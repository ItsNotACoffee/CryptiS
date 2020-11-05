namespace CryptiS
{
    partial class formDecryptSymmetric
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
            this.labelDecryptedFile = new System.Windows.Forms.Label();
            this.textSymmetricKey = new System.Windows.Forms.TextBox();
            this.btnOpenKey = new System.Windows.Forms.Button();
            this.richTextDecryptedFile = new System.Windows.Forms.RichTextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSymmetricDecrypt = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.ofdKey = new System.Windows.Forms.OpenFileDialog();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textEncryptedFile = new System.Windows.Forms.TextBox();
            this.textDecryptedPath = new System.Windows.Forms.TextBox();
            this.labelDecryptedPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDecryptedFile
            // 
            this.labelDecryptedFile.AutoSize = true;
            this.labelDecryptedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecryptedFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelDecryptedFile.Location = new System.Drawing.Point(20, 296);
            this.labelDecryptedFile.Name = "labelDecryptedFile";
            this.labelDecryptedFile.Size = new System.Drawing.Size(105, 18);
            this.labelDecryptedFile.TabIndex = 14;
            this.labelDecryptedFile.Text = "Izvorni tekst:";
            // 
            // textSymmetricKey
            // 
            this.textSymmetricKey.BackColor = System.Drawing.Color.White;
            this.textSymmetricKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSymmetricKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSymmetricKey.Location = new System.Drawing.Point(131, 132);
            this.textSymmetricKey.Multiline = true;
            this.textSymmetricKey.Name = "textSymmetricKey";
            this.textSymmetricKey.ReadOnly = true;
            this.textSymmetricKey.Size = new System.Drawing.Size(464, 32);
            this.textSymmetricKey.TabIndex = 13;
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
            this.btnOpenKey.Location = new System.Drawing.Point(37, 132);
            this.btnOpenKey.Name = "btnOpenKey";
            this.btnOpenKey.Size = new System.Drawing.Size(88, 32);
            this.btnOpenKey.TabIndex = 12;
            this.btnOpenKey.Text = "Ključ";
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
            this.richTextDecryptedFile.TabIndex = 11;
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
            this.btnOpenFile.Location = new System.Drawing.Point(37, 68);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(88, 32);
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.Text = "Datoteka";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSymmetricDecrypt
            // 
            this.btnSymmetricDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnSymmetricDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSymmetricDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSymmetricDecrypt.FlatAppearance.BorderSize = 0;
            this.btnSymmetricDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnSymmetricDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSymmetricDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSymmetricDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnSymmetricDecrypt.Location = new System.Drawing.Point(230, 212);
            this.btnSymmetricDecrypt.Name = "btnSymmetricDecrypt";
            this.btnSymmetricDecrypt.Size = new System.Drawing.Size(159, 43);
            this.btnSymmetricDecrypt.TabIndex = 8;
            this.btnSymmetricDecrypt.Text = "Dekriptiraj";
            this.btnSymmetricDecrypt.UseVisualStyleBackColor = false;
            this.btnSymmetricDecrypt.Click += new System.EventHandler(this.btnSymmetricDecrypt_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.Title = "Izaberite datoteku koju želite dekriptirati";
            // 
            // ofdKey
            // 
            this.ofdKey.Title = "Izaberite simetrični ključ";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelTitle.Location = new System.Drawing.Point(190, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(238, 25);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Simetrično dekriptiranje";
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
            this.textEncryptedFile.TabIndex = 16;
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
            this.textDecryptedPath.TabIndex = 17;
            // 
            // labelDecryptedPath
            // 
            this.labelDecryptedPath.AutoSize = true;
            this.labelDecryptedPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecryptedPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelDecryptedPath.Location = new System.Drawing.Point(56, 463);
            this.labelDecryptedPath.Name = "labelDecryptedPath";
            this.labelDecryptedPath.Size = new System.Drawing.Size(69, 18);
            this.labelDecryptedPath.TabIndex = 18;
            this.labelDecryptedPath.Text = "Putanja:";
            // 
            // formDecryptSymmetric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 636);
            this.Controls.Add(this.labelDecryptedPath);
            this.Controls.Add(this.textDecryptedPath);
            this.Controls.Add(this.textEncryptedFile);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelDecryptedFile);
            this.Controls.Add(this.textSymmetricKey);
            this.Controls.Add(this.btnOpenKey);
            this.Controls.Add(this.richTextDecryptedFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnSymmetricDecrypt);
            this.Name = "formDecryptSymmetric";
            this.Text = "decryptSymmetricForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDecryptedFile;
        private System.Windows.Forms.TextBox textSymmetricKey;
        private System.Windows.Forms.Button btnOpenKey;
        private System.Windows.Forms.RichTextBox richTextDecryptedFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSymmetricDecrypt;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.OpenFileDialog ofdKey;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textEncryptedFile;
        private System.Windows.Forms.TextBox textDecryptedPath;
        private System.Windows.Forms.Label labelDecryptedPath;
    }
}