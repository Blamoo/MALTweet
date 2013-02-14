using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Net;
using System.IO;

namespace MALTweet
{
    public class MALEntryList : List<MALEntry>
    {
        public const string MAL_REQUEST_URL = "http://myanimelist.net/malappinfo.php?u={0}&status=all&type=anime";
        public int LastUpdate { get; private set; }

        private MALEntryList()
        {
            LastUpdate = 0;
        }

        public static MALEntryList CreateEmpty()
        {
            return new MALEntryList();
        }

        public static MALEntryList CreateFromUserName(string user)
        {
            string url = String.Format(MAL_REQUEST_URL, user);

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            return CreateFromStream(response.GetResponseStream());
        }

        public static MALEntryList CreateFromTextFile(string listData)
        {
            XmlDocument document = new XmlDocument();
            document.LoadXml(listData);

            return CreateFromXmlDocument(document);
        }

        public static MALEntryList CreateFromStream(Stream stream)
        {
            XmlDocument document = new XmlDocument();
            document.Load(stream);

            return CreateFromXmlDocument(document);
        }

        public static MALEntryList CreateFromXmlDocument(XmlDocument document)
        {
            MALEntryList ret = MALEntryList.CreateEmpty();

            XmlNodeList entries = document["myanimelist"].GetElementsByTagName("anime");

            foreach (XmlNode entry in entries)
            {
                MALEntry m = new MALEntry(entry);

                ret.AddEntry(m);
            }

            ret.Sort();

            return ret;
        }

        public static MALEntryList CreateFromDifference(MALEntryList previous, MALEntryList current)
        {
            MALEntryList ret = MALEntryList.CreateEmpty();

            foreach (MALEntry entry in current)
            {
                if (entry.MyLastUpdated >= previous.LastUpdate)
                    ret.AddEntry(entry);
            }

            return ret;
        }

        public void AddEntry(MALEntry entry)
        {
            Add(entry);
            LastUpdate = Math.Max(LastUpdate, entry.MyLastUpdated);
        }

        public new void Sort()
        {
            Sort(new MALEntry.Comparer());
        }
    }
}
