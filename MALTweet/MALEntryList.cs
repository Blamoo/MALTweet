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

        public static XmlDocument GetXmlDocument(string user)
        {
            string url = String.Format(MAL_REQUEST_URL, user);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (Stream stream = request.GetResponse().GetResponseStream())
            using (StreamReader r = new StreamReader(stream))
            {
                XmlDocument ret = new XmlDocument();
                ret.Load(r);

                return ret;
            }
        }

        public static MALEntryList CreateFromUser(string user)
        {
            return CreateFromXmlDocument(GetXmlDocument(user));
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

        public static MALEntryList CreateDiff(MALEntryList previous, MALEntryList current)
        {
            MALEntryList ret = MALEntryList.CreateEmpty();

            foreach (MALEntry entry in current)
            {
                ret.Add(entry);
                if (entry.MyLastUpdated > previous.LastUpdate)
                    entry.Changed = true;
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
