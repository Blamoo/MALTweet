using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using TweetSharp;
using System.Xml;
using System.IO;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MALTweet
{
    public class MALTweet
    {
        public bool MALIsReady { get; private set; }
        public bool TwitterIsReady { get; private set; }

        public bool Ready
        {
            get
            {
                return MALIsReady && TwitterIsReady;
            }
        }

        public string LastMALError { get; private set; }
        public string LastTwitterError { get; private set; }

        public string MALUser { get; private set; }

        public string TwitterConsumerKey { get; private set; }
        public string TwitterConsumerSecret { get; private set; }

        public string TwitterPin { get; private set; }
        public string TwitterAccessTokenSecret { get; private set; }
        public string TwitterAccessToken { get; private set; }

        private TwitterService TwitterService;
        private OAuthRequestToken TempTwitterRequestToken;

        const string INVALID_TWITTER_TOKEN = "?";

        public MALEntryList MALCurrentList;

        public MALTweet(FormProgress fp)
        {
            fp.ReportProgress(18, "Carregando Configurações do MAL");
            LoadMALConfig();

            fp.ReportProgress(18, "Validando configurações do MAL");
            ValidateMAL();

            fp.ReportProgress(18, "Carregando Configurações do Twitter");
            LoadTwitterConfig();

            fp.ReportProgress(18, "Validando configurações do Twitter");
            ValidateTwitter();

            fp.ReportProgress(18, "Obtendo atualizações do MAL");
            if (Ready)
                MALGetUpdates();

            fp.ReportProgress(10, "Concluído");
        }

        public void ValidateMAL()
        {
            string urlMAL = String.Format("http://myanimelist.net/malappinfo.php?u={0}&status=all&type=anime", MALUser);

            WebRequest request = WebRequest.Create(urlMAL);
            WebResponse response = request.GetResponse();
            XmlDocument document = new XmlDocument();
            document.Load(response.GetResponseStream());

            XmlElement errorNode = document["myanimelist"]["error"];

            if (document["myanimelist"].ChildNodes.Count == 0)
            {
                MALIsReady = false;
                LastMALError = "Nome de usuário em branco";
            }
            else if (errorNode != null)
            {
                MALIsReady = false;
                LastMALError = errorNode.InnerText;
            }
            else
            {
                MALIsReady = true;
                MALUser = document["myanimelist"]["myinfo"]["user_name"].InnerText;
            }
            response.Close();
        }

        public void SetTestMALUser(string malUser)
        {
            ResetMAL();
            MALUser = malUser;
        }

        public void ValidateTwitter()
        {
            TwitterService.AuthenticateWith(TwitterAccessToken, TwitterAccessTokenSecret);

            TwitterUser user = TwitterService.GetUserProfile();

            if (user == null)
            {
                TwitterIsReady = false;
                LastTwitterError = TwitterService.Response.StatusDescription;
            }
            else
            {
                TwitterIsReady = true;
            }
        }

        public Uri GetTwitterAuthorizationUrl()
        {
            TempTwitterRequestToken = TwitterService.GetRequestToken();

            if (TempTwitterRequestToken.Token == INVALID_TWITTER_TOKEN)
                throw new Exception("Tem zica monstro nesse Request Token aí, mano.");

            return TwitterService.GetAuthorizationUri(TempTwitterRequestToken);
        }

        public bool SetTwitterPin(string pin)
        {
            OAuthAccessToken access = TwitterService.GetAccessToken(TempTwitterRequestToken, pin);

            if (access.Token == INVALID_TWITTER_TOKEN)
            {
                LastTwitterError = "Pin inválido";
                return false;
            }

            TwitterPin = pin;
            TwitterAccessToken = access.Token;
            TwitterAccessTokenSecret = access.TokenSecret;

            return true;
        }

        internal bool SendTweet(string tweet)
        {
            TwitterStatus s = TwitterService.SendTweet(tweet);

            if (s.Id == 0)
                return false;

            return true;
        }

        public void ResetMAL()
        {
            MALUser = String.Empty;
            MALIsReady = false;
        }

        public void ResetTwitter()
        {
            TwitterPin = String.Empty;
            TwitterAccessToken = String.Empty;
            TwitterAccessTokenSecret = String.Empty;
            TwitterIsReady = false;
        }

        public void LoadMALConfig()
        {
            MALUser = Properties.Settings.Default.MALUser;
        }

        public void LoadTwitterConfig()
        {
            TwitterPin = Properties.Settings.Default.PIN;
            TwitterConsumerKey = Properties.Settings.Default.ConsumerKey;
            TwitterConsumerSecret = Properties.Settings.Default.ConsumerSecret;
            TwitterAccessToken = Properties.Settings.Default.AccessToken;
            TwitterAccessTokenSecret = Properties.Settings.Default.AccessTokenSecret;

            TwitterService = new TwitterService(TwitterConsumerKey, TwitterConsumerSecret);
        }

        public void SaveMALConfig()
        {
            Properties.Settings.Default.MALUser = MALUser;
            Properties.Settings.Default.Save();
        }

        public void SaveTwitterConfig()
        {
            Properties.Settings.Default.PIN = TwitterPin;
            Properties.Settings.Default.AccessToken = TwitterAccessToken;
            Properties.Settings.Default.AccessTokenSecret = TwitterAccessTokenSecret;
            Properties.Settings.Default.Save();
        }

        public MALEntryList MALGetUpdates()
        {
            if (MALCurrentList == null)
            {
                MALCurrentList = GetCurrentMALList();
                return MALEntryList.CreateEmpty();
            }
            MALEntryList previousList = MALCurrentList;
            MALEntryList currentList = GetCurrentMALList();

            return MALEntryList.CreateFromDifference(previousList, currentList);
        }

        private MALEntryList GetCurrentMALList()
        {
            return MALEntryList.CreateFromUserName(MALUser);
        }
    }
}
