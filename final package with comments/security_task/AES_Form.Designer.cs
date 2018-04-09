namespace security_task
{
    partial class AES_Form
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
            this.BoxTextCrypt = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.btnTextEncrypt = new System.Windows.Forms.Button();
            this.btnTextDecrypt = new System.Windows.Forms.Button();
            this.BoxTextCrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxTextCrypt
            // 
            this.BoxTextCrypt.Controls.Add(this.label6);
            this.BoxTextCrypt.Controls.Add(this.label10);
            this.BoxTextCrypt.Controls.Add(this.txtKey);
            this.BoxTextCrypt.Controls.Add(this.label4);
            this.BoxTextCrypt.Controls.Add(this.label5);
            this.BoxTextCrypt.Controls.Add(this.label2);
            this.BoxTextCrypt.Controls.Add(this.txtPlainText);
            this.BoxTextCrypt.Controls.Add(this.txtEncrypted);
            this.BoxTextCrypt.Controls.Add(this.btnTextEncrypt);
            this.BoxTextCrypt.Controls.Add(this.btnTextDecrypt);
            this.BoxTextCrypt.Location = new System.Drawing.Point(11, 10);
            this.BoxTextCrypt.Name = "BoxTextCrypt";
            this.BoxTextCrypt.Size = new System.Drawing.Size(400, 332);
            this.BoxTextCrypt.TabIndex = 16;
            this.BoxTextCrypt.TabStop = false;
            this.BoxTextCrypt.Text = "Encryption and Decryption for texts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "The key is only allowed for Hex-Decimal( ex : 0123456789ABCDEF )";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Only for alphabet and number.";
            // 
            // txtKey
            // 
            this.txtKey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKey.Location = new System.Drawing.Point(45, 119);
            this.txtKey.MaxLength = 32;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(340, 20);
            this.txtKey.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "The Result text for Encryption and Decryption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Key : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Text : ";
            // 
            // txtPlainText
            // 
            this.txtPlainText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPlainText.Location = new System.Drawing.Point(45, 25);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlainText.Size = new System.Drawing.Size(340, 78);
            this.txtPlainText.TabIndex = 4;
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEncrypted.Location = new System.Drawing.Point(45, 196);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.ReadOnly = true;
            this.txtEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncrypted.Size = new System.Drawing.Size(340, 87);
            this.txtEncrypted.TabIndex = 3;
            // 
            // btnTextEncrypt
            // 
            this.btnTextEncrypt.Location = new System.Drawing.Point(5, 296);
            this.btnTextEncrypt.Name = "btnTextEncrypt";
            this.btnTextEncrypt.Size = new System.Drawing.Size(89, 25);
            this.btnTextEncrypt.TabIndex = 10;
            this.btnTextEncrypt.Text = "Text-Encryption";
            this.btnTextEncrypt.UseVisualStyleBackColor = true;
            this.btnTextEncrypt.Click += new System.EventHandler(this.btnTextEncrypt_Click);
            // 
            // btnTextDecrypt
            // 
            this.btnTextDecrypt.Location = new System.Drawing.Point(101, 296);
            this.btnTextDecrypt.Name = "btnTextDecrypt";
            this.btnTextDecrypt.Size = new System.Drawing.Size(89, 25);
            this.btnTextDecrypt.TabIndex = 13;
            this.btnTextDecrypt.Text = "Text-Decryption";
            this.btnTextDecrypt.UseVisualStyleBackColor = true;
            this.btnTextDecrypt.Click += new System.EventHandler(this.btnTextDecrypt_Click);
            // 
            // AES_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 353);
            this.Controls.Add(this.BoxTextCrypt);
            this.Name = "AES_Form";
            this.Text = "AES_Form";
            this.BoxTextCrypt.ResumeLayout(false);
            this.BoxTextCrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxTextCrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Button btnTextEncrypt;
        private System.Windows.Forms.Button btnTextDecrypt;
    }
}