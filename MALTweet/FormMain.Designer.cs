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
            this.buttonLimparConfig = new System.Windows.Forms.Button();
            this.buttonConfigurarMAL = new System.Windows.Forms.Button();
            this.buttonConfigurarTwitter = new System.Windows.Forms.Button();
            this.buttonRecarregarLista = new System.Windows.Forms.Button();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.textBoxTweet = new System.Windows.Forms.TextBox();
            this.listViewAtualizacoes = new System.Windows.Forms.ListView();
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxStaticMAL = new System.Windows.Forms.PictureBox();
            this.pictureBoxStatusTwitter = new System.Windows.Forms.PictureBox();
            this.labelContador = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxContagem = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStaticMAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusTwitter)).BeginInit();
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
            // buttonLimparConfig
            // 
            this.buttonLimparConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimparConfig.Location = new System.Drawing.Point(503, 392);
            this.buttonLimparConfig.Name = "buttonLimparConfig";
            this.buttonLimparConfig.Size = new System.Drawing.Size(116, 23);
            this.buttonLimparConfig.TabIndex = 21;
            this.buttonLimparConfig.Text = "Limpar configurações";
            this.buttonLimparConfig.UseVisualStyleBackColor = true;
            this.buttonLimparConfig.Click += new System.EventHandler(this.LimparConfig_Click);
            // 
            // buttonConfigurarMAL
            // 
            this.buttonConfigurarMAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigurarMAL.Location = new System.Drawing.Point(346, 392);
            this.buttonConfigurarMAL.Name = "buttonConfigurarMAL";
            this.buttonConfigurarMAL.Size = new System.Drawing.Size(129, 23);
            this.buttonConfigurarMAL.TabIndex = 18;
            this.buttonConfigurarMAL.Text = "Configurar MyAnimeList";
            this.buttonConfigurarMAL.UseVisualStyleBackColor = true;
            this.buttonConfigurarMAL.Click += new System.EventHandler(this.configurarMAL_Click);
            // 
            // buttonConfigurarTwitter
            // 
            this.buttonConfigurarTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigurarTwitter.Location = new System.Drawing.Point(346, 363);
            this.buttonConfigurarTwitter.Name = "buttonConfigurarTwitter";
            this.buttonConfigurarTwitter.Size = new System.Drawing.Size(129, 23);
            this.buttonConfigurarTwitter.TabIndex = 17;
            this.buttonConfigurarTwitter.Text = "Configurar Twitter";
            this.buttonConfigurarTwitter.UseVisualStyleBackColor = true;
            this.buttonConfigurarTwitter.Click += new System.EventHandler(this.configurarTwitter_Click);
            // 
            // buttonRecarregarLista
            // 
            this.buttonRecarregarLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecarregarLista.Enabled = false;
            this.buttonRecarregarLista.Location = new System.Drawing.Point(12, 392);
            this.buttonRecarregarLista.Name = "buttonRecarregarLista";
            this.buttonRecarregarLista.Size = new System.Drawing.Size(328, 23);
            this.buttonRecarregarLista.TabIndex = 16;
            this.buttonRecarregarLista.Text = "Recarregar Lista";
            this.buttonRecarregarLista.UseVisualStyleBackColor = true;
            this.buttonRecarregarLista.Click += new System.EventHandler(this.carregar_Click);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnviar.Enabled = false;
            this.buttonEnviar.Location = new System.Drawing.Point(572, 102);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(47, 23);
            this.buttonEnviar.TabIndex = 15;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // textBoxTweet
            // 
            this.textBoxTweet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTweet.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTweet.Enabled = false;
            this.textBoxTweet.Location = new System.Drawing.Point(346, 27);
            this.textBoxTweet.MaxLength = 140;
            this.textBoxTweet.Multiline = true;
            this.textBoxTweet.Name = "textBoxTweet";
            this.textBoxTweet.Size = new System.Drawing.Size(273, 69);
            this.textBoxTweet.TabIndex = 14;
            this.textBoxTweet.TextChanged += new System.EventHandler(this.txtTweet_TextChanged);
            // 
            // listViewAtualizacoes
            // 
            this.listViewAtualizacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAtualizacoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderStatus});
            this.listViewAtualizacoes.Enabled = false;
            this.listViewAtualizacoes.FullRowSelect = true;
            this.listViewAtualizacoes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAtualizacoes.HideSelection = false;
            this.listViewAtualizacoes.Location = new System.Drawing.Point(12, 11);
            this.listViewAtualizacoes.MultiSelect = false;
            this.listViewAtualizacoes.Name = "listViewAtualizacoes";
            this.listViewAtualizacoes.Size = new System.Drawing.Size(328, 372);
            this.listViewAtualizacoes.TabIndex = 13;
            this.listViewAtualizacoes.UseCompatibleStateImageBehavior = false;
            this.listViewAtualizacoes.View = System.Windows.Forms.View.Details;
            this.listViewAtualizacoes.SelectedIndexChanged += new System.EventHandler(this.lstUpdates_SelectedIndexChanged);
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
            // pictureBoxStaticMAL
            // 
            this.pictureBoxStaticMAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxStaticMAL.Image = global::MALTweet.Properties.Resources.NoIcon;
            this.pictureBoxStaticMAL.InitialImage = null;
            this.pictureBoxStaticMAL.Location = new System.Drawing.Point(481, 397);
            this.pictureBoxStaticMAL.Name = "pictureBoxStaticMAL";
            this.pictureBoxStaticMAL.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxStaticMAL.TabIndex = 20;
            this.pictureBoxStaticMAL.TabStop = false;
            // 
            // pictureBoxStatusTwitter
            // 
            this.pictureBoxStatusTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxStatusTwitter.Image = global::MALTweet.Properties.Resources.NoIcon;
            this.pictureBoxStatusTwitter.InitialImage = null;
            this.pictureBoxStatusTwitter.Location = new System.Drawing.Point(481, 367);
            this.pictureBoxStatusTwitter.Name = "pictureBoxStatusTwitter";
            this.pictureBoxStatusTwitter.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxStatusTwitter.TabIndex = 19;
            this.pictureBoxStatusTwitter.TabStop = false;
            // 
            // labelContador
            // 
            this.labelContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContador.AutoSize = true;
            this.labelContador.Location = new System.Drawing.Point(491, 9);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(128, 13);
            this.labelContador.TabIndex = 23;
            this.labelContador.Text = "Caracteres restantes: 140";
            this.labelContador.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBoxContagem
            // 
            this.checkBoxContagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxContagem.AutoSize = true;
            this.checkBoxContagem.Enabled = false;
            this.checkBoxContagem.Location = new System.Drawing.Point(346, 102);
            this.checkBoxContagem.Name = "checkBoxContagem";
            this.checkBoxContagem.Size = new System.Drawing.Size(146, 17);
            this.checkBoxContagem.TabIndex = 24;
            this.checkBoxContagem.Text = "Adicionar um à contagem";
            this.checkBoxContagem.UseVisualStyleBackColor = true;
            this.checkBoxContagem.CheckedChanged += new System.EventHandler(this.cbxIncCount_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 425);
            this.Controls.Add(this.checkBoxContagem);
            this.Controls.Add(this.labelContador);
            this.Controls.Add(this.labelTweet);
            this.Controls.Add(this.buttonLimparConfig);
            this.Controls.Add(this.pictureBoxStaticMAL);
            this.Controls.Add(this.pictureBoxStatusTwitter);
            this.Controls.Add(this.buttonConfigurarMAL);
            this.Controls.Add(this.buttonConfigurarTwitter);
            this.Controls.Add(this.buttonRecarregarLista);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxTweet);
            this.Controls.Add(this.listViewAtualizacoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(470, 220);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MALTweet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStaticMAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusTwitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTweet;
        private System.Windows.Forms.Button buttonLimparConfig;
        private System.Windows.Forms.PictureBox pictureBoxStaticMAL;
        private System.Windows.Forms.PictureBox pictureBoxStatusTwitter;
        private System.Windows.Forms.Button buttonConfigurarMAL;
        private System.Windows.Forms.Button buttonConfigurarTwitter;
        private System.Windows.Forms.Button buttonRecarregarLista;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.TextBox textBoxTweet;
        private System.Windows.Forms.ListView listViewAtualizacoes;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.Label labelContador;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.CheckBox checkBoxContagem;

    }
}

