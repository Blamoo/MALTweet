namespace MALTweet
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelTweet = new System.Windows.Forms.Label();
            this.buttonResetConfig = new System.Windows.Forms.Button();
            this.buttonConfigMAL = new System.Windows.Forms.Button();
            this.buttonConfigTwitter = new System.Windows.Forms.Button();
            this.buttonReloadMALUpdates = new System.Windows.Forms.Button();
            this.buttonSendTweet = new System.Windows.Forms.Button();
            this.textBoxTweet = new System.Windows.Forms.TextBox();
            this.pictureBoxStatusMAL = new System.Windows.Forms.PictureBox();
            this.pictureBoxStatusTwitter = new System.Windows.Forms.PictureBox();
            this.labelTweetCounter = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDownCurrentEpisodes = new System.Windows.Forms.NumericUpDown();
            this.labelTotalEpisodes = new System.Windows.Forms.Label();
            this.listViewMALUpdates = new System.Windows.Forms.ListView();
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusMAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentEpisodes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTweet
            // 
            this.labelTweet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTweet.AutoSize = true;
            this.labelTweet.Location = new System.Drawing.Point(346, 11);
            this.labelTweet.Name = "labelTweet";
            this.labelTweet.Size = new System.Drawing.Size(40, 13);
            this.labelTweet.TabIndex = 22;
            this.labelTweet.Text = "Tweet:";
            // 
            // buttonResetConfig
            // 
            this.buttonResetConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetConfig.Location = new System.Drawing.Point(490, 332);
            this.buttonResetConfig.Name = "buttonResetConfig";
            this.buttonResetConfig.Size = new System.Drawing.Size(129, 23);
            this.buttonResetConfig.TabIndex = 21;
            this.buttonResetConfig.Text = "Limpar configurações";
            this.buttonResetConfig.UseVisualStyleBackColor = true;
            this.buttonResetConfig.Click += new System.EventHandler(this.buttonbuttonResetConfig_Click);
            // 
            // buttonConfigMAL
            // 
            this.buttonConfigMAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigMAL.Location = new System.Drawing.Point(490, 390);
            this.buttonConfigMAL.Name = "buttonConfigMAL";
            this.buttonConfigMAL.Size = new System.Drawing.Size(129, 23);
            this.buttonConfigMAL.TabIndex = 18;
            this.buttonConfigMAL.Text = "Configurar MyAnimeList";
            this.buttonConfigMAL.UseVisualStyleBackColor = true;
            this.buttonConfigMAL.Click += new System.EventHandler(this.buttonConfigMAL_Click);
            // 
            // buttonConfigTwitter
            // 
            this.buttonConfigTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigTwitter.Location = new System.Drawing.Point(490, 361);
            this.buttonConfigTwitter.Name = "buttonConfigTwitter";
            this.buttonConfigTwitter.Size = new System.Drawing.Size(129, 23);
            this.buttonConfigTwitter.TabIndex = 17;
            this.buttonConfigTwitter.Text = "Configurar Twitter";
            this.buttonConfigTwitter.UseVisualStyleBackColor = true;
            this.buttonConfigTwitter.Click += new System.EventHandler(this.buttonConfigTwitter_Click);
            // 
            // buttonReloadMALUpdates
            // 
            this.buttonReloadMALUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReloadMALUpdates.Location = new System.Drawing.Point(12, 390);
            this.buttonReloadMALUpdates.Name = "buttonReloadMALUpdates";
            this.buttonReloadMALUpdates.Size = new System.Drawing.Size(328, 23);
            this.buttonReloadMALUpdates.TabIndex = 16;
            this.buttonReloadMALUpdates.Text = "Recarregar Lista";
            this.buttonReloadMALUpdates.UseVisualStyleBackColor = true;
            this.buttonReloadMALUpdates.Click += new System.EventHandler(this.buttonReloadMALUpdates_Click);
            // 
            // buttonSendTweet
            // 
            this.buttonSendTweet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendTweet.Location = new System.Drawing.Point(572, 102);
            this.buttonSendTweet.Name = "buttonSendTweet";
            this.buttonSendTweet.Size = new System.Drawing.Size(47, 23);
            this.buttonSendTweet.TabIndex = 15;
            this.buttonSendTweet.Text = "Enviar";
            this.buttonSendTweet.UseVisualStyleBackColor = true;
            this.buttonSendTweet.Click += new System.EventHandler(this.buttonSendTweet_Click);
            // 
            // textBoxTweet
            // 
            this.textBoxTweet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTweet.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTweet.Location = new System.Drawing.Point(346, 27);
            this.textBoxTweet.MaxLength = 140;
            this.textBoxTweet.Multiline = true;
            this.textBoxTweet.Name = "textBoxTweet";
            this.textBoxTweet.Size = new System.Drawing.Size(273, 69);
            this.textBoxTweet.TabIndex = 14;
            this.textBoxTweet.TextChanged += new System.EventHandler(this.textBoxTweet_TextChanged);
            // 
            // pictureBoxStatusMAL
            // 
            this.pictureBoxStatusMAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxStatusMAL.Image = global::MALTweet.Properties.Resources.NoIcon;
            this.pictureBoxStatusMAL.InitialImage = null;
            this.pictureBoxStatusMAL.Location = new System.Drawing.Point(468, 390);
            this.pictureBoxStatusMAL.Name = "pictureBoxStatusMAL";
            this.pictureBoxStatusMAL.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxStatusMAL.TabIndex = 20;
            this.pictureBoxStatusMAL.TabStop = false;
            // 
            // pictureBoxStatusTwitter
            // 
            this.pictureBoxStatusTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxStatusTwitter.Image = global::MALTweet.Properties.Resources.NoIcon;
            this.pictureBoxStatusTwitter.InitialImage = null;
            this.pictureBoxStatusTwitter.Location = new System.Drawing.Point(468, 361);
            this.pictureBoxStatusTwitter.Name = "pictureBoxStatusTwitter";
            this.pictureBoxStatusTwitter.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxStatusTwitter.TabIndex = 19;
            this.pictureBoxStatusTwitter.TabStop = false;
            // 
            // labelTweetCounter
            // 
            this.labelTweetCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTweetCounter.AutoSize = true;
            this.labelTweetCounter.Location = new System.Drawing.Point(491, 9);
            this.labelTweetCounter.Name = "labelTweetCounter";
            this.labelTweetCounter.Size = new System.Drawing.Size(128, 13);
            this.labelTweetCounter.TabIndex = 23;
            this.labelTweetCounter.Text = "Caracteres restantes: 140";
            this.labelTweetCounter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericUpDownCurrentEpisodes
            // 
            this.numericUpDownCurrentEpisodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCurrentEpisodes.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDownCurrentEpisodes.Location = new System.Drawing.Point(346, 102);
            this.numericUpDownCurrentEpisodes.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownCurrentEpisodes.Name = "numericUpDownCurrentEpisodes";
            this.numericUpDownCurrentEpisodes.ReadOnly = true;
            this.numericUpDownCurrentEpisodes.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownCurrentEpisodes.TabIndex = 24;
            this.numericUpDownCurrentEpisodes.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownCurrentEpisodes.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownCurrentEpisodes.ValueChanged += new System.EventHandler(this.numericUpDownCurrentEpisodes_ValueChanged);
            // 
            // labelTotalEpisodes
            // 
            this.labelTotalEpisodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalEpisodes.AutoSize = true;
            this.labelTotalEpisodes.Location = new System.Drawing.Point(388, 104);
            this.labelTotalEpisodes.Name = "labelTotalEpisodes";
            this.labelTotalEpisodes.Size = new System.Drawing.Size(36, 13);
            this.labelTotalEpisodes.TabIndex = 25;
            this.labelTotalEpisodes.Text = "/  999";
            // 
            // listViewMALUpdates
            // 
            this.listViewMALUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMALUpdates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderStatus});
            this.listViewMALUpdates.FullRowSelect = true;
            this.listViewMALUpdates.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMALUpdates.HideSelection = false;
            this.listViewMALUpdates.Location = new System.Drawing.Point(12, 11);
            this.listViewMALUpdates.MultiSelect = false;
            this.listViewMALUpdates.Name = "listViewMALUpdates";
            this.listViewMALUpdates.Size = new System.Drawing.Size(328, 373);
            this.listViewMALUpdates.TabIndex = 13;
            this.listViewMALUpdates.UseCompatibleStateImageBehavior = false;
            this.listViewMALUpdates.View = System.Windows.Forms.View.Details;
            this.listViewMALUpdates.SelectedIndexChanged += new System.EventHandler(this.listViewMALUpdates_SelectedIndexChanged);
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 178;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 425);
            this.Controls.Add(this.labelTotalEpisodes);
            this.Controls.Add(this.numericUpDownCurrentEpisodes);
            this.Controls.Add(this.labelTweetCounter);
            this.Controls.Add(this.labelTweet);
            this.Controls.Add(this.buttonResetConfig);
            this.Controls.Add(this.pictureBoxStatusMAL);
            this.Controls.Add(this.pictureBoxStatusTwitter);
            this.Controls.Add(this.buttonConfigMAL);
            this.Controls.Add(this.buttonConfigTwitter);
            this.Controls.Add(this.buttonReloadMALUpdates);
            this.Controls.Add(this.buttonSendTweet);
            this.Controls.Add(this.textBoxTweet);
            this.Controls.Add(this.listViewMALUpdates);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(470, 220);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MALTweet";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusMAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentEpisodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTweet;
        private System.Windows.Forms.Button buttonResetConfig;
        private System.Windows.Forms.PictureBox pictureBoxStatusMAL;
        private System.Windows.Forms.PictureBox pictureBoxStatusTwitter;
        private System.Windows.Forms.Button buttonConfigMAL;
        private System.Windows.Forms.Button buttonConfigTwitter;
        private System.Windows.Forms.Button buttonReloadMALUpdates;
        private System.Windows.Forms.Button buttonSendTweet;
        private System.Windows.Forms.TextBox textBoxTweet;
        private System.Windows.Forms.ListView listViewMALUpdates;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.Label labelTweetCounter;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.NumericUpDown numericUpDownCurrentEpisodes;
        private System.Windows.Forms.Label labelTotalEpisodes;

    }
}

