namespace MALTweet
{
    partial class FormTwitter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTwitter));
            this.groupBoxTwitter = new System.Windows.Forms.GroupBox();
            this.buttonValidatePin = new System.Windows.Forms.Button();
            this.buttonGetPin = new System.Windows.Forms.Button();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.labelPin = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxTwitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTwitter
            // 
            this.groupBoxTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTwitter.Controls.Add(this.buttonValidatePin);
            this.groupBoxTwitter.Controls.Add(this.buttonGetPin);
            this.groupBoxTwitter.Controls.Add(this.textBoxPin);
            this.groupBoxTwitter.Controls.Add(this.labelPin);
            this.groupBoxTwitter.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTwitter.Name = "groupBoxTwitter";
            this.groupBoxTwitter.Size = new System.Drawing.Size(280, 90);
            this.groupBoxTwitter.TabIndex = 0;
            this.groupBoxTwitter.TabStop = false;
            this.groupBoxTwitter.Text = "Configurações do Twitter";
            // 
            // buttonValidatePin
            // 
            this.buttonValidatePin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValidatePin.Location = new System.Drawing.Point(199, 61);
            this.buttonValidatePin.Name = "buttonValidatePin";
            this.buttonValidatePin.Size = new System.Drawing.Size(75, 23);
            this.buttonValidatePin.TabIndex = 4;
            this.buttonValidatePin.Text = "Validar Pin";
            this.buttonValidatePin.UseVisualStyleBackColor = true;
            this.buttonValidatePin.Click += new System.EventHandler(this.buttonValidatePin_Click);
            // 
            // buttonGetPin
            // 
            this.buttonGetPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetPin.Location = new System.Drawing.Point(199, 32);
            this.buttonGetPin.Name = "buttonGetPin";
            this.buttonGetPin.Size = new System.Drawing.Size(75, 23);
            this.buttonGetPin.TabIndex = 2;
            this.buttonGetPin.Text = "Obter Pin";
            this.buttonGetPin.UseVisualStyleBackColor = true;
            this.buttonGetPin.Click += new System.EventHandler(this.buttonGetPin_Click);
            // 
            // textBoxPin
            // 
            this.textBoxPin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPin.Location = new System.Drawing.Point(6, 32);
            this.textBoxPin.MaxLength = 7;
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(187, 20);
            this.textBoxPin.TabIndex = 1;
            // 
            // labelPin
            // 
            this.labelPin.AutoSize = true;
            this.labelPin.Location = new System.Drawing.Point(6, 16);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(25, 13);
            this.labelPin.TabIndex = 0;
            this.labelPin.Text = "Pin:";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(217, 108);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Fechar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(136, 108);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Limpar";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // FormTwitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 138);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxTwitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTwitter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurar Twitter";
            this.Load += new System.EventHandler(this.FormTwitter_Load);
            this.groupBoxTwitter.ResumeLayout(false);
            this.groupBoxTwitter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTwitter;
        private System.Windows.Forms.Label labelPin;
        private System.Windows.Forms.Button buttonGetPin;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonValidatePin;
    }
}