namespace CryptiS
{
    partial class formDecryptAsymmetric
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
            this.labelDecryptedPath = new System.Windows.Forms.Label();
            this.textDecryptedPath = new System.Windows.Forms.TextBox();
            this.textEncryptedFile = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDecryptedFile = new System.Windows.Forms.Label();
            this.textPrivateKey = new System.Windows.Forms.TextBox();
            this.btnOpenKey = new System.Windows.Forms.Button();
            this.richTextDecryptedFile = new System.Windows.Forms.RichTextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnAsymmetricDecrypt = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.ofdKey = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelDecryptedPath
            // 
            this.labelDecryptedPath.AutoSize = true;
            this.labelDecryptedPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecryptedPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelDecryptedPath.Location = new System.Drawing.Point(56, 463);
            this.labelDecryptedPath.Name = "labelDecryptedPath";
            this.labelDecryptedPath.Size = new System.Drawing.Size(69, 18);
            this.labelDecryptedPath.TabIndex = 28;
            this.labelDecryptedPath.Text = "Putanja:";
            // 
            // textDecryptedPath
            // 
            this.textDecryptedPath.BackColor = System.Drawing.Color.White;
            this.textDecryptedPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDecryptedPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDecryptedPath.Location = new System.Drawing.Point(131, 463);
            this.textDecryptedPath.Multiline = true;
            this.textDecryptedPath.Name = "textDecryptedPath";
            this.textDecryptedPath.ReadOnly = true;
            this.textDecryptedPath.Size = new System.Drawing.Size(464, 32);
            this.textDecryptedPath.TabIndex = 27;
            // 
            // textEncryptedFile
            // 
            this.textEncryptedFile.BackColor = System.Drawing.Color.White;
            this.textEncryptedFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEncryptedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEncryptedFile.Location = new System.Drawing.Point(131, 68);
            this.textEncryptedFile.Multiline = true;
            this.textEncryptedFile.Name = "textEncryptedFile";
            this.textEncryptedFile.ReadOnly = true;
            this.textEncryptedFile.Size = new System.Drawing.Size(464, 32);
            this.textEncryptedFile.TabIndex = 26;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelTitle.Location = new System.Drawing.Point(190, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(249, 25);
            this.labelTitle.TabIndex = 25;
            this.labelTitle.Text = "Asimetrično dekriptiranje";
            // 
            // labelDecryptedFile
            // 
            this.labelDecryptedFile.AutoSize = true;
            this.labelDecryptedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecryptedFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelDecryptedFile.Location = new System.Drawing.Point(20, 296);
            this.labelDecryptedFile.Name = "labelDecryptedFile";
            this.labelDecryptedFile.Size = new System.Drawing.Size(105, 18);
            this.labelDecryptedFile.TabIndex = 24;
            this.labelDecryptedFile.Text = "Izvorni tekst:";
            // 
            // textPrivateKey
            // 
            this.textPrivateKey.BackColor = System.Drawing.Color.White;
            this.textPrivateKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrivateKey.Location = new System.Drawing.Point(131, 132);
            this.textPrivateKey.Multiline = true;
            this.textPrivateKey.Name = "textPrivateKey";
            this.textPrivateKey.ReadOnly = true;
            this.textPrivateKey.Size = new System.Drawing.Size(464, 32);
            this.textPrivateKey.TabIndex = 23;
            // 
            // btnOpenKey
            // 
            this.btnOpenKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnOpenKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenKey.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOpenKey.FlatAppearance.BorderSize = 0;
            this.btnOpenKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnOpenKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenKey.ForeColor = System.Drawing.Color.White;
            this.btnOpenKey.Location = new System.Drawing.Point(12, 132);
            this.btnOpenKey.Name = "btnOpenKey";
            this.btnOpenKey.Size = new System.Drawing.Size(113, 32);
            this.btnOpenKey.TabIndex = 22;
            this.btnOpenKey.Text = "Privatni ključ";
            this.btnOpenKey.UseVisualStyleBackColor = false;
            this.btnOpenKey.Click += new System.EventHandler(this.btnOpenKey_Click);
            // 
            // richTextDecryptedFile
            // 
            this.richTextDecryptedFile.BackColor = System.Drawing.Color.White;
            this.richTextDecryptedFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextDecryptedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextDecryptedFile.Location = new System.Drawing.Point(131, 296);
            this.richTextDecryptedFile.Name = "richTextDecryptedFile";
            this.richTextDecryptedFile.ReadOnly = true;
            this.richTextDecryptedFile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextDecryptedFile.Size = new System.Drawing.Size(464, 135);
            this.richTextDecryptedFile.TabIndex = 21;
            this.richTextDecryptedFile.Text = "";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Location = new System.Drawing.Point(12, 68);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(113, 32);
            this.btnOpenFile.TabIndex = 20;
            this.btnOpenFile.Text = "Datoteka";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnAsymmetricDecrypt
            // 
            this.btnAsymmetricDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnAsymmetricDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsymmetricDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAsymmetricDecrypt.FlatAppearance.BorderSize = 0;
            this.btnAsymmetricDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnAsymmetricDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsymmetricDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsymmetricDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnAsymmetricDecrypt.Location = new System.Drawing.Point(230, 212);
            this.btnAsymmetricDecrypt.Name = "btnAsymmetricDecrypt";
            this.btnAsymmetricDecrypt.Size = new System.Drawing.Size(159, 43);
            this.btnAsymmetricDecrypt.TabIndex = 19;
            this.btnAsymmetricDecrypt.Text = "Dekriptiraj";
            this.btnAsymmetricDecrypt.UseVisualStyleBackColor = false;
            this.btnAsymmetricDecrypt.Click += new System.EventHandler(this.btnAsymmetricDecrypt_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.Title = "Izaberite datoteku koju želite dekriptirati";
            // 
            // ofdKey
            // 
            this.ofdKey.Title = "Izaberite privatni ključ";
            // 
            // formDecryptAsymmetric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 636);
            this.Controls.Add(this.labelDecryptedPath);
            this.Controls.Add(this.textDecryptedPath);
            this.Controls.Add(this.textEncryptedFile);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelDecryptedFile);
            this.Controls.Add(this.textPrivateKey);
            this.Controls.Add(this.btnOpenKey);
            this.Controls.Add(this.richTextDecryptedFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnAsymmetricDecrypt);
            this.Name = "formDecryptAsymmetric";
            this.Text = "formDecryptAsymmetric";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDecryptedPath;
        private System.Windows.Forms.TextBox textDecryptedPath;
        private System.Windows.Forms.TextBox textEncryptedFile;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDecryptedFile;
        private System.Windows.Forms.TextBox textPrivateKey;
        private System.Windows.Forms.Button btnOpenKey;
        private System.Windows.Forms.RichTextBox richTextDecryptedFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnAsymmetricDecrypt;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.OpenFileDialog ofdKey;
    }
}