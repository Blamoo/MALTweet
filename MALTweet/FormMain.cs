using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TweetSharp;
using System.Net;
using System.Xml;
using System.Text.RegularExpressions;
using MALTweet.Properties;

namespace MALTweet
{
    public partial class FormMain : Form
    {
        private MALTweet App;

        const string TOTAL_EPISODES_LABEL = "/  {0}";
        const string TWEET_COUNTER_LABEL = "Caracteres restantes: {0}";
        const int TWEET_COUNTER_LIMIT = 140;

        public FormMain()
        {
            InitializeComponent();
        }

        private void UpdateStatus()
        {
            pictureBoxStatusMAL.Image = App.MALIsReady ? Properties.Resources.YesIcon : Properties.Resources.NoIcon;
            pictureBoxStatusTwitter.Image = App.TwitterIsReady ? Properties.Resources.YesIcon : Properties.Resources.NoIcon;

            if (App.Ready)
            {
                listViewMALUpdates.Enabled = true;
                buttonReloadMALUpdates.Enabled = true;
                labelTweet.Enabled = true;
                labelTotalEpisodes.Enabled = true;
                labelTweetCounter.Enabled = true;
                textBoxTweet.Enabled = true;
                buttonSendTweet.Enabled = true;
                numericUpDownCurrentEpisodes.Enabled = true;
                textBoxTweet.BackColor = SystemColors.Window;

                listViewMALUpdates.Items.Clear();

                foreach (MALEntry entry in App.MALCurrentList)
                {
                    listViewMALUpdates.Items.Add(new ListViewItem(new string[] { entry.SeriesTitle, String.Format("{0}/{1}", entry.MyWatchedEpisodes, entry.SeriesEpisodes) }) { Tag = entry });
                }

                listViewMALUpdates_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else
            {
                listViewMALUpdates.Enabled = false;
                listViewMALUpdates.Items.Clear();
                buttonReloadMALUpdates.Enabled = false;
                labelTweet.Enabled = false;
                labelTotalEpisodes.Enabled = false;
                labelTweetCounter.Enabled = false;
                textBoxTweet.Enabled = false;
                textBoxTweet.Text = String.Empty;
                buttonSendTweet.Enabled = false;
                numericUpDownCurrentEpisodes.Enabled = false;
                numericUpDownCurrentEpisodes.Value = 0;
                textBoxTweet.BackColor = SystemColors.Control;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            App = new MALTweet();

            UpdateStatus();
        }

        private void buttonbuttonResetConfig_Click(object sender, EventArgs e)
        {
            App.ResetTwitter();
            App.ResetMAL();

            UpdateStatus();
        }

        private void buttonConfigTwitter_Click(object sender, EventArgs e)
        {
            FormTwitter f = new FormTwitter(App);

            if (f.ShowDialog(this) == DialogResult.OK)
                UpdateStatus();
        }

        private void buttonConfigMAL_Click(object sender, EventArgs e)
        {
            FormMAL f = new FormMAL(App);

            if (f.ShowDialog(this) == DialogResult.OK)
                UpdateStatus();
        }

        private void buttonReloadMALUpdates_Click(object sender, EventArgs e)
        {
            MALEntryList m = App.MALGetUpdates();
        }

        private void listViewMALUpdates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMALUpdates.SelectedItems.Count == 0)
            {
                numericUpDownCurrentEpisodes.Maximum = 0;
                numericUpDownCurrentEpisodes.Value = 0;
                numericUpDownCurrentEpisodes.Enabled = false;

                labelTotalEpisodes.Text = String.Empty;

                textBoxTweet.Text = String.Empty;
                textBoxTweet.Enabled = false;
                textBoxTweet.BackColor = SystemColors.Control;

                buttonSendTweet.Enabled = false;
            }
            else
            {
                MALEntry entry = (MALEntry) listViewMALUpdates.SelectedItems[0].Tag;

                numericUpDownCurrentEpisodes.Maximum = entry.SeriesEpisodes;
                numericUpDownCurrentEpisodes.Value = entry.MyWatchedEpisodes;
                numericUpDownCurrentEpisodes.Enabled = true;

                labelTotalEpisodes.Text = String.Format(TOTAL_EPISODES_LABEL, entry.SeriesEpisodes);

                textBoxTweet.Text = ComposeTweet(entry, entry.MyWatchedEpisodes);
                textBoxTweet.Enabled = true;
                textBoxTweet.BackColor = SystemColors.Window;

                buttonSendTweet.Enabled = true;
            }
        }

        private void buttonSendTweet_Click(object sender, EventArgs e)
        {
            if (App.SendTweet(textBoxTweet.Text))
                MessageBox.Show("Sucesso!");
            else
                MessageBox.Show("zica monstro, o tweet voltou.");
        }

        private void textBoxTweet_TextChanged(object sender, EventArgs e)
        {
            labelTweetCounter.Text = String.Format(TWEET_COUNTER_LABEL, TWEET_COUNTER_LIMIT - textBoxTweet.TextLength);
        }

        private void numericUpDownCurrentEpisodes_ValueChanged(object sender, EventArgs e)
        {
            if (listViewMALUpdates.SelectedItems.Count != 0)
            {
                MALEntry entry = (MALEntry) listViewMALUpdates.SelectedItems[0].Tag;
                textBoxTweet.Text = ComposeTweet(entry, (int) numericUpDownCurrentEpisodes.Value);
            }
        }

        private string ComposeTweet(MALEntry entry, int watched)
        {
            if (watched == 0)
                return String.Format("Comecei a assistir a {0} ({1} episódios) - http://myanimelist.net/anime/{2} #MALTweet", entry.SeriesTitle, entry.SeriesEpisodes, entry.SeriesAnimedbId);

            if (watched == 1)
            {
                if (entry.SeriesEpisodes == 1)
                    return String.Format("Assisti a {0} - http://myanimelist.net/anime/{1} #MALTweet", entry.SeriesTitle, entry.SeriesAnimedbId);

                return String.Format("Comecei a assistir a {0} ({1} episódios) - http://myanimelist.net/anime/{2} #MALTweet", entry.SeriesTitle, entry.SeriesEpisodes, entry.SeriesAnimedbId);
            }

            if (watched >= entry.SeriesEpisodes)
                return String.Format("Terminei de assistir a {0} ({1} episódios) - http://myanimelist.net/anime/{2} #MALTweet", entry.SeriesTitle, entry.SeriesEpisodes, entry.SeriesAnimedbId);

            return String.Format("Assisti a {0} ({1} de {2} episódios) - http://myanimelist.net/anime/{3} #MALTweet", entry.SeriesTitle, watched, entry.SeriesEpisodes, entry.SeriesAnimedbId);
        }
    }
}
