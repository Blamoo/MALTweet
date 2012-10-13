using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using MALTweet.Properties;

namespace MALTweet
{
    public partial class FormTwitter : Form
    {
        private MALTweet App;

        public FormTwitter(MALTweet app)
        {
            App = app;
            InitializeComponent();
        }
        public void UpdateStatus()
        {
            if (App.TwitterIsReady)
            {
                textBoxPin.Text = App.TwitterPin;
                textBoxPin.Enabled = false;
                buttonGetPin.Enabled = false;
                buttonValidatePin.Enabled = false;
                buttonReset.Enabled = true;

            }
            else
            {
                textBoxPin.Text = String.Empty;
                textBoxPin.Enabled = false;
                buttonGetPin.Enabled = true;
                buttonValidatePin.Enabled = false;
                buttonReset.Enabled = false;
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            App.SaveTwitterConfig();
            Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            App.ResetTwitter();
            UpdateStatus();
        }

        private void buttonValidatePin_Click(object sender, EventArgs e)
        {
            if (App.SetTwitterPin(textBoxPin.Text))
            {
                App.ValidateTwitter();
                if (App.TwitterIsReady)
                    MessageBox.Show("Sucesso!");
                else
                    MessageBox.Show(App.LastTwitterError);
            }
            else
                MessageBox.Show(App.LastTwitterError);

            UpdateStatus();
        }

        private void FormTwitter_Load(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void buttonGetPin_Click(object sender, EventArgs e)
        {
            Uri uri = App.GetTwitterAuthorizationUrl();

            Process.Start(uri.ToString());

            textBoxPin.Enabled = true;
            textBoxPin.Clear();

            buttonValidatePin.Enabled = true;
        }
    }
}
