using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TweetSharp;
using System.Diagnostics;
using MALTweet.Properties;

namespace MALTweet
{
    public partial class FormTwitter : Form
    {
        public TwitterService _Twitter;
        public TwitterUser _TwitterUser;
        private OAuthRequestToken _RequestToken;
        private OAuthAccessToken _AccessToken;

        public FormTwitter(TwitterService service, TwitterUser user)
        {
            _Twitter = service;
            _TwitterUser = user;

            InitializeComponent();
        }

        private void gbxPin_Enter(object sender, EventArgs e)
        {

        }

        private void TwitterForm_Load(object sender, EventArgs e)
        {
            if (_TwitterUser.Id == 0)
            {
                groupBoxTwitter.Enabled = buttonObterPin.Enabled = true;
                textBoxPin.Enabled = buttonValidarPin.Enabled = false;
            }
            else
            {
                textBoxPin.Text = Settings.Default.PIN;
                buttonLimpar.Enabled = true;
                textBoxPin.Enabled = buttonValidarPin.Enabled = buttonObterPin.Enabled = groupBoxTwitter.Enabled = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnObterPin_Click(object sender, EventArgs e)
        {
            _RequestToken = _Twitter.GetRequestToken();
            Process.Start(_Twitter.GetAuthenticationUrl(_RequestToken).ToString());

            textBoxPin.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Limpar as configurações do Twitter?", "Confirmação", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                Settings.Default.AccessToken = "";
                Settings.Default.AccessTokenSecret = "";
                Settings.Default.PIN = "";
                Settings.Default.Save();

                textBoxPin.Clear();

                textBoxPin.Enabled = buttonValidarPin.Enabled = buttonLimpar.Enabled = false;
                buttonObterPin.Enabled = groupBoxTwitter.Enabled = true;
            }
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            TextBox _sender = sender as TextBox;
            buttonValidarPin.Enabled = (_sender.Text.Length == 7) ? true : false;

        }

        private void btnValidarPin_Click(object sender, EventArgs e)
        {
            _AccessToken = _Twitter.GetAccessToken(_RequestToken, textBoxPin.Text);

            if (_AccessToken.UserId == 0)
            {
                MessageBox.Show("O PIN digitado não é válido ou não pode ser autenticado.\r\nConfira se o PIN digitado tem sete caracteres numéricos ou tente solicitar um PIN novo.");
                textBoxPin.Clear();
                textBoxPin.Focus();
            }
            else
            {
                MessageBox.Show("O PIN digitado é válido!\r\nO Twitter foi configurado corretamente.");
                buttonLimpar.Enabled = true;
                textBoxPin.Enabled = buttonObterPin.Enabled = buttonValidarPin.Enabled = groupBoxTwitter.Enabled = false;

                Settings.Default.AccessToken = _AccessToken.Token;
                Settings.Default.AccessTokenSecret = _AccessToken.TokenSecret;
                Settings.Default.PIN = textBoxPin.Text;
                Settings.Default.Save();
            }
        }
    }
}
