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
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxMALUser = new System.Windows.Forms.GroupBox();
            this.buttonValidateMAL = new System.Windows.Forms.Button();
            this.textBoxMALUser = new System.Windows.Forms.TextBox();
            this.labelMALUser = new System.Windows.Forms.Label();
            this.groupBoxMALUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(114, 105);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Limpar";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(195, 105);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Fechar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // groupBoxMALUser
            // 
            this.groupBoxMALUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMALUser.Controls.Add(this.buttonValidateMAL);
            this.groupBoxMALUser.Controls.Add(this.textBoxMALUser);
            this.groupBoxMALUser.Controls.Add(this.labelMALUser);
            this.groupBoxMALUser.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMALUser.Name = "groupBoxMALUser";
            this.groupBoxMALUser.Size = new System.Drawing.Size(258, 87);
            this.groupBoxMALUser.TabIndex = 4;
            this.groupBoxMALUser.TabStop = false;
            this.groupBoxMALUser.Text = "Configurações do MyAnimeList";
            // 
            // buttonValidateMAL
            // 
            this.buttonValidateMAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValidateMAL.Location = new System.Drawing.Point(177, 58);
            this.buttonValidateMAL.Name = "buttonValidateMAL";
            this.buttonValidateMAL.Size = new System.Drawing.Size(75, 23);
            this.buttonValidateMAL.TabIndex = 4;
            this.buttonValidateMAL.Text = "Validar usuário";
            this.buttonValidateMAL.UseVisualStyleBackColor = true;
            this.buttonValidateMAL.Click += new System.EventHandler(this.buttonValidateMAL_Click);
            // 
            // textBoxMALUser
            // 
            this.textBoxMALUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMALUser.Location = new System.Drawing.Point(6, 32);
            this.textBoxMALUser.MaxLength = 16;
            this.textBoxMALUser.Name = "textBoxMALUser";
            this.textBoxMALUser.Size = new System.Drawing.Size(246, 20);
            this.textBoxMALUser.TabIndex = 1;
            // 
            // labelMALUser
            // 
            this.labelMALUser.AutoSize = true;
            this.labelMALUser.Location = new System.Drawing.Point(6, 16);
            this.labelMALUser.Name = "labelMALUser";
            this.labelMALUser.Size = new System.Drawing.Size(187, 13);
            this.labelMALUser.TabIndex = 0;
            this.labelMALUser.Text = "Seu nome de usuário no MyAnimeList:";
            // 
            // FormMAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 139);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxMALUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurar MyAnimeList";
            this.Load += new System.EventHandler(this.FormMAL_Load);
            this.groupBoxMALUser.ResumeLayout(false);
            this.groupBoxMALUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxMALUser;
        private System.Windows.Forms.Button buttonValidateMAL;
        private System.Windows.Forms.TextBox textBoxMALUser;
        private System.Windows.Forms.Label labelMALUser;

    }
}