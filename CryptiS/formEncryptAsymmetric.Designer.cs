namespace CryptiS
{
    partial class formEncryptAsymmetric
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
            this.labelEncryptedPath = new System.Windows.Forms.Label();
            this.textEncryptedPath = new System.Windows.Forms.TextBox();
            this.textOriginalFile = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelEncryptedFile = new System.Windows.Forms.Label();
            this.textPublicKey = new System.Windows.Forms.TextBox();
            this.btnOpenKey = new System.Windows.Forms.Button();
            this.richTextEncryptedFile = new System.Windows.Forms.RichTextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnAsymmetricEncrypt = new System.Windows.Forms.Button();
            this.ofdKey = new System.Windows.Forms.OpenFileDialog();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelEncryptedPath
            // 
            this.labelEncryptedPath.AutoSize = true;
            this.labelEncryptedPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncryptedPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelEncryptedPath.Location = new System.Drawing.Point(56, 463);
            this.labelEncryptedPath.Name = "labelEncryptedPath";
            this.labelEncryptedPath.Size = new System.Drawing.Size(69, 18);
            this.labelEncryptedPath.TabIndex = 30;
            this.labelEncryptedPath.Text = "Putanja:";
            // 
            // textEncryptedPath
            // 
            this.textEncryptedPath.BackColor = System.Drawing.Color.White;
            this.textEncryptedPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEncryptedPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEncryptedPath.Location = new System.Drawing.Point(131, 463);
            this.textEncryptedPath.Multiline = true;
            this.textEncryptedPath.Name = "textEncryptedPath";
            this.textEncryptedPath.ReadOnly = true;
            this.textEncryptedPath.Size = new System.Drawing.Size(464, 32);
            this.textEncryptedPath.TabIndex = 29;
            // 
            // textOriginalFile
            // 
            this.textOriginalFile.BackColor = System.Drawing.Color.White;
            this.textOriginalFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOriginalFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOriginalFile.Location = new System.Drawing.Point(131, 68);
            this.textOriginalFile.Multiline = true;
            this.textOriginalFile.Name = "textOriginalFile";
            this.textOriginalFile.ReadOnly = true;
            this.textOriginalFile.Size = new System.Drawing.Size(464, 32);
            this.textOriginalFile.TabIndex = 28;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelTitle.Location = new System.Drawing.Point(202, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(225, 25);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Asimetrično kriptiranje";
            // 
            // labelEncryptedFile
            // 
            this.labelEncryptedFile.AutoSize = true;
            this.labelEncryptedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncryptedFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelEncryptedFile.Location = new System.Drawing.Point(7, 296);
            this.labelEncryptedFile.Name = "labelEncryptedFile";
            this.labelEncryptedFile.Size = new System.Drawing.Size(118, 18);
            this.labelEncryptedFile.TabIndex = 26;
            this.labelEncryptedFile.Text = "Kriptiran tekst:";
            // 
            // textPublicKey
            // 
            this.textPublicKey.BackColor = System.Drawing.Color.White;
            this.textPublicKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPublicKey.Location = new System.Drawing.Point(131, 132);
            this.textPublicKey.Multiline = true;
            this.textPublicKey.Name = "textPublicKey";
            this.textPublicKey.ReadOnly = true;
            this.textPublicKey.Size = new System.Drawing.Size(464, 32);
            this.textPublicKey.TabIndex = 25;
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
            this.btnOpenKey.Location = new System.Drawing.Point(24, 132);
            this.btnOpenKey.Name = "btnOpenKey";
            this.btnOpenKey.Size = new System.Drawing.Size(101, 32);
            this.btnOpenKey.TabIndex = 24;
            this.btnOpenKey.Text = "Javni ključ";
            this.btnOpenKey.UseVisualStyleBackColor = false;
            this.btnOpenKey.Click += new System.EventHandler(this.btnOpenKey_Click);
            // 
            // richTextEncryptedFile
            // 
            this.richTextEncryptedFile.BackColor = System.Drawing.Color.White;
            this.richTextEncryptedFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextEncryptedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextEncryptedFile.Location = new System.Drawing.Point(131, 296);
            this.richTextEncryptedFile.Name = "richTextEncryptedFile";
            this.richTextEncryptedFile.ReadOnly = true;
            this.richTextEncryptedFile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextEncryptedFile.Size = new System.Drawing.Size(464, 135);
            this.richTextEncryptedFile.TabIndex = 23;
            this.richTextEncryptedFile.Text = "";
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
            this.btnOpenFile.Location = new System.Drawing.Point(24, 68);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(101, 32);
            this.btnOpenFile.TabIndex = 22;
            this.btnOpenFile.Text = "Datoteka";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnAsymmetricEncrypt
            // 
            this.btnAsymmetricEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnAsymmetricEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsymmetricEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAsymmetricEncrypt.FlatAppearance.BorderSize = 0;
            this.btnAsymmetricEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnAsymmetricEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsymmetricEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsymmetricEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnAsymmetricEncrypt.Location = new System.Drawing.Point(230, 212);
            this.btnAsymmetricEncrypt.Name = "btnAsymmetricEncrypt";
            this.btnAsymmetricEncrypt.Size = new System.Drawing.Size(159, 43);
            this.btnAsymmetricEncrypt.TabIndex = 21;
            this.btnAsymmetricEncrypt.Text = "Kriptiraj";
            this.btnAsymmetricEncrypt.UseVisualStyleBackColor = false;
            this.btnAsymmetricEncrypt.Click += new System.EventHandler(this.btnAsymmetricEncrypt_Click);
            // 
            // ofdKey
            // 
            this.ofdKey.Filter = "txt files (*.txt)|*.txt";
            this.ofdKey.Title = "Izaberite javni ključ";
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "txt files (*.txt)|*.txt";
            this.ofdFile.Title = "Izaberite datoteku koju želite kriptirati";
            // 
            // formEncryptAsymmetric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 636);
            this.Controls.Add(this.labelEncryptedPath);
            this.Controls.Add(this.textEncryptedPath);
            this.Controls.Add(this.textOriginalFile);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelEncryptedFile);
            this.Controls.Add(this.textPublicKey);
            this.Controls.Add(this.btnOpenKey);
            this.Controls.Add(this.richTextEncryptedFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnAsymmetricEncrypt);
            this.Name = "formEncryptAsymmetric";
            this.Text = "formEncryptAsymmetric";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEncryptedPath;
        private System.Windows.Forms.TextBox textEncryptedPath;
        private System.Windows.Forms.TextBox textOriginalFile;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelEncryptedFile;
        private System.Windows.Forms.TextBox textPublicKey;
        private System.Windows.Forms.Button btnOpenKey;
        private System.Windows.Forms.RichTextBox richTextEncryptedFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnAsymmetricEncrypt;
        private System.Windows.Forms.OpenFileDialog ofdKey;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}