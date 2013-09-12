using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Diagnostics;
using System.Windows.Forms;

namespace MALTweet
{
    [DebuggerDisplay("{SeriesTitle}")]
    public class MALEntry
    {
        public class Comparer : IComparer<MALEntry>
        {
            public int Compare(MALEntry x, MALEntry y)
            {
                return -x.MyLastUpdated.CompareTo(y.MyLastUpdated);
            }
        }

        public bool Changed = false;

        public int SeriesAnimedbId;
        public string SeriesTitle;
        public string SeriesSynonyms;
        public int SeriesType;
        public int SeriesEpisodes;
        public int SeriesStatus;
        public string SeriesStart;
        public string SeriesEnd;
        public string SeriesImage;
        public int MyId;
        public int MyWatchedEpisodes;
        public string MyStartDate;
        public string MyFinishDate;
        public int MyScore;
        public int MyStatus;
        public int MyRewatching;
        public int MyRewatchingEp;
        public int MyLastUpdated;
        public string MyTags;

        public MALEntry(XmlNode entry)
        {
            SeriesTitle = entry["series_title"].InnerText;
            SeriesSynonyms = entry["series_synonyms"].InnerText;
            SeriesStart = entry["series_start"].InnerText;
            SeriesEnd = entry["series_end"].InnerText;
            SeriesImage = entry["series_image"].InnerText;
            MyStartDate = entry["my_start_date"].InnerText;
            MyFinishDate = entry["my_finish_date"].InnerText;
            MyTags = entry["my_tags"].InnerText;

            int.TryParse(entry["series_animedb_id"].InnerText, out SeriesAnimedbId);
            int.TryParse(entry["series_type"].InnerText, out SeriesType);
            int.TryParse(entry["series_episodes"].InnerText, out SeriesEpisodes);
            int.TryParse(entry["series_status"].InnerText, out SeriesStatus);
            int.TryParse(entry["my_id"].InnerText, out MyId);
            int.TryParse(entry["my_watched_episodes"].InnerText, out MyWatchedEpisodes);
            int.TryParse(entry["my_score"].InnerText, out MyScore);
            int.TryParse(entry["my_status"].InnerText, out MyStatus);
            int.TryParse(entry["my_rewatching"].InnerText, out MyRewatching);
            int.TryParse(entry["my_rewatching_ep"].InnerText, out MyRewatchingEp);
            int.TryParse(entry["my_last_updated"].InnerText, out MyLastUpdated);
        }
    }
}
