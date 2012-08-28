using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using MALTweet.Properties;

namespace MALTweet
{
    public partial class FormMAL : Form
    {
        public FormMAL()
        {
            InitializeComponent();
        }

        private void btnValidarMALUser_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://myanimelist.net/malappinfo.php?u=" + textBoxMALUsuario.Text);
            WebResponse response = request.GetResponse();

            XmlDocument xml = new XmlDocument();

            try
            {
                xml.Load(response.GetResponseStream());

                foreach (XmlNode i in xml.ChildNodes[1])
                {
                    if (i.Name == "myinfo")
                    {
                        foreach (XmlNode j in i.ChildNodes)
                        {
                            if (j.Name == "user_name")
                            {
                                textBoxMALUsuario.Text = j.InnerText.Trim();
                                break;
                            }
                        }
                        break;
                    }
                }

                MessageBox.Show("O nome de usuário é válido. Sua conta no MyAnimeList foi configurada corretamente.");
                groupBoxMAL.Enabled = textBoxMALUsuario.Enabled = buttonValidarMAL.Enabled = false;
                buttonLimpar.Enabled = true;

                Settings.Default.MALUser = textBoxMALUsuario.Text;
                Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show("Nome de usuário inválido");
                textBoxMALUsuario.Clear();
                textBoxMALUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            groupBoxMAL.Enabled = textBoxMALUsuario.Enabled = buttonValidarMAL.Enabled = true;
            buttonLimpar.Enabled = false;
            Settings.Default.MALUser = "";
            Settings.Default.Save();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MALForm_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Settings.Default.MALUser))
            {
                groupBoxMAL.Enabled = textBoxMALUsuario.Enabled = buttonValidarMAL.Enabled = true;
                buttonLimpar.Enabled = false;
            }
            else
            {
                textBoxMALUsuario.Text = Settings.Default.MALUser;
                groupBoxMAL.Enabled = textBoxMALUsuario.Enabled = buttonValidarMAL.Enabled = false;
                buttonLimpar.Enabled = true;
            }
        }
    }
}
