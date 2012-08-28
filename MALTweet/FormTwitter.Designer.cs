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
            this.buttonValidarPin = new System.Windows.Forms.Button();
            this.buttonObterPin = new System.Windows.Forms.Button();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.labelPin = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.groupBoxTwitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTwitter
            // 
            this.groupBoxTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTwitter.Controls.Add(this.buttonValidarPin);
            this.groupBoxTwitter.Controls.Add(this.buttonObterPin);
            this.groupBoxTwitter.Controls.Add(this.textBoxPin);
            this.groupBoxTwitter.Controls.Add(this.labelPin);
            this.groupBoxTwitter.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTwitter.Name = "groupBoxTwitter";
            this.groupBoxTwitter.Size = new System.Drawing.Size(280, 90);
            this.groupBoxTwitter.TabIndex = 0;
            this.groupBoxTwitter.TabStop = false;
            this.groupBoxTwitter.Text = "Configurações do Twitter";
            // 
            // buttonValidarPin
            // 
            this.buttonValidarPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValidarPin.Enabled = false;
            this.buttonValidarPin.Location = new System.Drawing.Point(199, 61);
            this.buttonValidarPin.Name = "buttonValidarPin";
            this.buttonValidarPin.Size = new System.Drawing.Size(75, 23);
            this.buttonValidarPin.TabIndex = 4;
            this.buttonValidarPin.Text = "Validar Pin";
            this.buttonValidarPin.UseVisualStyleBackColor = true;
            this.buttonValidarPin.Click += new System.EventHandler(this.btnValidarPin_Click);
            // 
            // buttonObterPin
            // 
            this.buttonObterPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonObterPin.Location = new System.Drawing.Point(199, 32);
            this.buttonObterPin.Name = "buttonObterPin";
            this.buttonObterPin.Size = new System.Drawing.Size(75, 23);
            this.buttonObterPin.TabIndex = 2;
            this.buttonObterPin.Text = "Obter Pin";
            this.buttonObterPin.UseVisualStyleBackColor = true;
            this.buttonObterPin.Click += new System.EventHandler(this.btnObterPin_Click);
            // 
            // textBoxPin
            // 
            this.textBoxPin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPin.Enabled = false;
            this.textBoxPin.Location = new System.Drawing.Point(6, 32);
            this.textBoxPin.MaxLength = 7;
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(187, 20);
            this.textBoxPin.TabIndex = 1;
            this.textBoxPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
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
            // buttonFechar
            // 
            this.buttonFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFechar.Location = new System.Drawing.Point(217, 108);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 1;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.Enabled = false;
            this.buttonLimpar.Location = new System.Drawing.Point(136, 108);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 3;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormTwitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 138);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBoxTwitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTwitter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurar Twitter";
            this.Load += new System.EventHandler(this.TwitterForm_Load);
            this.groupBoxTwitter.ResumeLayout(false);
            this.groupBoxTwitter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTwitter;
        private System.Windows.Forms.Label labelPin;
        private System.Windows.Forms.Button buttonObterPin;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonValidarPin;
    }
}