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
        public TwitterService _Twitter;
        public TwitterUser _TwitterUser;


        public bool IsTwitterReady;
        public bool IsMALReady;

        public int ListHash = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void UpdateMainWindow()
        {
            pictureBoxStatusTwitter.Image = IsTwitterReady ? Properties.Resources.YesIcon : Properties.Resources.NoIcon;
            pictureBoxStaticMAL.Image = IsMALReady ? Properties.Resources.YesIcon : Properties.Resources.NoIcon;

            if (IsMALReady && IsTwitterReady)
            {
                listViewAtualizacoes.Enabled = buttonRecarregarLista.Enabled = true;
            }
            else
            {
                listViewAtualizacoes.Enabled = buttonRecarregarLista.Enabled = false;

                Settings.Default.Save();
            }
            UpdateList();
        }
        private void UpdateList()
        {
            WebRequest request = WebRequest.Create("http://myanimelist.net/rss.php?type=rwe&u=" + Settings.Default.MALUser);

            listViewAtualizacoes.Items.Clear();

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(response.GetResponseStream());

                    XmlNodeList animes = xml.GetElementsByTagName("item");

                    foreach (XmlNode i in animes)
                    {
                        ListViewItem info = new ListViewItem();

                        foreach (XmlNode j in i.ChildNodes)
                        {
                            if (j.Name == "title")
                            {
                                info.Text = j.InnerText.Trim();
                                continue;
                            }

                            if (j.Name == "description")
                            {
                                info.SubItems.Add(j.InnerText.Trim());
                                continue;
                            }
                        }

                        listViewAtualizacoes.Items.Add(info);
                    }
                    listViewAtualizacoes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar a lista de atualizações.\r\nVerifique se há conexão com a internet e\r\nse o MyAimeList não está passando por problemas tecnicos ou atualizações. Detalhes: {0}", ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _Twitter = new TwitterService(Settings.Default.consumerKey, Settings.Default.consumerSecret, Settings.Default.AccessToken, Settings.Default.AccessTokenSecret);

            _TwitterUser = _Twitter.VerifyCredentials();
            IsTwitterReady = (_TwitterUser.Id != 0);
            IsMALReady = !String.IsNullOrWhiteSpace(Settings.Default.MALUser);

            toolTipMain.SetToolTip(checkBoxContagem, "Adiciona um ao número de episódios assistidos\r\npara resolver o problema do atraso nas atualizações\r\ndo RSS do MyAnimeList");

            UpdateMainWindow();
        }

        private void configurarTwitter_Click(object sender, EventArgs e)
        {
            FormTwitter t = new FormTwitter(_Twitter, _TwitterUser);

            t.ShowDialog(this);

            _Twitter.AuthenticateWith(Settings.Default.consumerKey, Settings.Default.consumerSecret, Settings.Default.AccessToken, Settings.Default.AccessTokenSecret);
            _TwitterUser = _Twitter.VerifyCredentials();

            IsTwitterReady = (_TwitterUser.Id != 0);
            this.UpdateMainWindow();
        }

        private void configurarMAL_Click(object sender, EventArgs e)
        {
            FormMAL m = new FormMAL();

            DialogResult d = m.ShowDialog(this);

            IsMALReady = !String.IsNullOrWhiteSpace(Settings.Default.MALUser);

            this.UpdateMainWindow();
        }

        private void LimparConfig_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Tem ceteza de que deseja limpar todas as configurações?", "Confirmação", MessageBoxButtons.OKCancel);

            if (m == DialogResult.OK)
            {
                Settings.Default.MALUser = "";
                Settings.Default.PIN = "";
                Settings.Default.AccessToken = "";
                Settings.Default.AccessTokenSecret = "";

                _Twitter.AuthenticateWith(Settings.Default.consumerKey, Settings.Default.consumerSecret);
                _TwitterUser = _Twitter.VerifyCredentials();

                IsMALReady = false;
                IsTwitterReady = (_TwitterUser.Id != 0);
                this.UpdateMainWindow();
            }
        }

        private void carregar_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void lstUpdates_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewAtualizacoes.SelectedItems.Count == 0)
            {
                textBoxTweet.Text = "";
                checkBoxContagem.Enabled = false;
                buttonEnviar.Enabled = false;
                textBoxTweet.Enabled = false;
                textBoxTweet.Clear();
                return;
            }

            Regex r = new Regex("(Watching|Rewatching|Dropped|On-Hold|Completed|Plan to Watch) - ([0-9]+?) of ([0-9]+?) episodes", RegexOptions.IgnoreCase);

            GroupCollection t = r.Match(listViewAtualizacoes.SelectedItems[0].SubItems[1].Text).Groups;

            try
            {
                string status = t[1].Value;
                int current = Convert.ToInt32(t[2].Value);
                int total = Convert.ToInt32(t[3].Value);

                if (checkBoxContagem.Checked && (current < total))
                    current++;

                if (status == "Dropped")
                    textBoxTweet.Text = String.Format("Desisti de assistir a {0}", listViewAtualizacoes.SelectedItems[0].Text);
                else if (current == 1 && total == 1)
                    textBoxTweet.Text = String.Format("Assisti a {0}", listViewAtualizacoes.SelectedItems[0].Text);
                else if (current == 1)
                    textBoxTweet.Text = String.Format("Comecei a assistir a {0} (episódio 1 de {1})", listViewAtualizacoes.SelectedItems[0].Text, total);
                else if (current == total)
                    textBoxTweet.Text = String.Format("Terminei de assistir a {0} ({1} episódios)", listViewAtualizacoes.SelectedItems[0].Text, current);
                else
                    textBoxTweet.Text = String.Format("Assisti a {0} (episódio {1} de {2})", listViewAtualizacoes.SelectedItems[0].Text, current, total);

                textBoxTweet.Enabled = buttonEnviar.Enabled = checkBoxContagem.Enabled = true;
            }
            catch (FormatException Exception)
            {
                MessageBox.Show(Exception.Message);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            TwitterStatus t = _Twitter.SendTweet(textBoxTweet.Text);

            if (t.Id != 0)
            {
                MessageBox.Show("O tweet foi enviado com sucesso!");
                textBoxTweet.Clear();
            }
            else
                MessageBox.Show("O ocorreu um erro ao enviar o tweet.");

            //System.Diagnostics.Process.Start("http://twitter.com/{0}",t.Author);
        }

        private void txtTweet_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            labelContador.Text = String.Format("Caracteres restantes: {0}", t.MaxLength - t.Text.Length);
        }

        private void cbxIncCount_CheckedChanged(object sender, EventArgs e)
        {
            lstUpdates_SelectedIndexChanged(sender, e);
        }
    }
}
