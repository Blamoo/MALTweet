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
        private MALTweet App;

        public FormMAL(MALTweet app)
        {
            App = app;
            InitializeComponent();
        }

        private void UpdateStatus()
        {
            if (App.MALIsReady)
            {
                textBoxMALUser.Text = App.MALUser;
                textBoxMALUser.Enabled = false;
                buttonValidateMAL.Enabled = false;
                buttonReset.Enabled = true;
            }
            else
            {
                textBoxMALUser.Text = String.Empty;
                textBoxMALUser.Enabled = true;
                buttonValidateMAL.Enabled = true;
                buttonReset.Enabled = false;
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            App.SaveMALConfig();
            Close();
        }

        private void FormMAL_Load(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            App.ResetMAL();
            UpdateStatus();
        }

        private void buttonValidateMAL_Click(object sender, EventArgs e)
        {
            App.SetTestMALUser(textBoxMALUser.Text);
            App.ValidateMAL();

            if (!App.MALIsReady)
                MessageBox.Show(App.LastMALError);
            else
                MessageBox.Show("Sucesso!");

            UpdateStatus();
        }
    }
}
