namespace MALTweet
{
    partial class FormMAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMAL));
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.groupBoxMAL = new System.Windows.Forms.GroupBox();
            this.buttonValidarMAL = new System.Windows.Forms.Button();
            this.textBoxMALUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuarioMAL = new System.Windows.Forms.Label();
            this.groupBoxMAL.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.Location = new System.Drawing.Point(114, 105);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 7;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFechar.Location = new System.Drawing.Point(195, 105);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 5;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBoxMAL
            // 
            this.groupBoxMAL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMAL.Controls.Add(this.buttonValidarMAL);
            this.groupBoxMAL.Controls.Add(this.textBoxMALUsuario);
            this.groupBoxMAL.Controls.Add(this.labelUsuarioMAL);
            this.groupBoxMAL.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMAL.Name = "groupBoxMAL";
            this.groupBoxMAL.Size = new System.Drawing.Size(258, 87);
            this.groupBoxMAL.TabIndex = 4;
            this.groupBoxMAL.TabStop = false;
            this.groupBoxMAL.Text = "Configurações do MyAnimeList";
            // 
            // buttonValidarMAL
            // 
            this.buttonValidarMAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValidarMAL.Location = new System.Drawing.Point(177, 58);
            this.buttonValidarMAL.Name = "buttonValidarMAL";
            this.buttonValidarMAL.Size = new System.Drawing.Size(75, 23);
            this.buttonValidarMAL.TabIndex = 4;
            this.buttonValidarMAL.Text = "Validar usuário";
            this.buttonValidarMAL.UseVisualStyleBackColor = true;
            this.buttonValidarMAL.Click += new System.EventHandler(this.btnValidarMALUser_Click);
            // 
            // textBoxMALUsuario
            // 
            this.textBoxMALUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMALUsuario.Location = new System.Drawing.Point(6, 32);
            this.textBoxMALUsuario.MaxLength = 16;
            this.textBoxMALUsuario.Name = "textBoxMALUsuario";
            this.textBoxMALUsuario.Size = new System.Drawing.Size(246, 20);
            this.textBoxMALUsuario.TabIndex = 1;
            // 
            // labelUsuarioMAL
            // 
            this.labelUsuarioMAL.AutoSize = true;
            this.labelUsuarioMAL.Location = new System.Drawing.Point(6, 16);
            this.labelUsuarioMAL.Name = "labelUsuarioMAL";
            this.labelUsuarioMAL.Size = new System.Drawing.Size(187, 13);
            this.labelUsuarioMAL.TabIndex = 0;
            this.labelUsuarioMAL.Text = "Seu nome de usuário no MyAnimeList:";
            // 
            // FormMAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 139);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBoxMAL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurar MyAnimeList";
            this.Load += new System.EventHandler(this.MALForm_Load);
            this.groupBoxMAL.ResumeLayout(false);
            this.groupBoxMAL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.GroupBox groupBoxMAL;
        private System.Windows.Forms.Button buttonValidarMAL;
        private System.Windows.Forms.TextBox textBoxMALUsuario;
        private System.Windows.Forms.Label labelUsuarioMAL;

    }
}