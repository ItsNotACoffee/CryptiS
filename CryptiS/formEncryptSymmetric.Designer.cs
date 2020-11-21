namespace CryptiS
{
    partial class formEncryptSymmetric
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
            this.btnSymmetricEncrypt = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.richTextEncryptedFile = new System.Windows.Forms.RichTextBox();
            this.btnOpenKey = new System.Windows.Forms.Button();
            this.textSymmetricKey = new System.Windows.Forms.TextBox();
            this.labelEncryptedFile = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.ofdKey = new System.Windows.Forms.OpenFileDialog();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textOriginalFile = new System.Windows.Forms.TextBox();
            this.labelEncryptedPath = new System.Windows.Forms.Label();
            this.textEncryptedPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSymmetricEncrypt
            // 
            this.btnSymmetricEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnSymmetricEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSymmetricEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSymmetricEncrypt.FlatAppearance.BorderSize = 0;
            this.btnSymmetricEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnSymmetricEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSymmetricEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSymmetricEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnSymmetricEncrypt.Location = new System.Drawing.Point(230, 212);
            this.btnSymmetricEncrypt.Name = "btnSymmetricEncrypt";
            this.btnSymmetricEncrypt.Size = new System.Drawing.Size(159, 43);
            this.btnSymmetricEncrypt.TabIndex = 1;
            this.btnSymmetricEncrypt.Text = "Kriptiraj";
            this.btnSymmetricEncrypt.UseVisualStyleBackColor = false;
            this.btnSymmetricEncrypt.Click += new System.EventHandler(this.btnSymmetricEncrypt_Click);
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
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Datoteka";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
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
            this.richTextEncryptedFile.TabIndex = 4;
            this.richTextEncryptedFile.Text = "";
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
            this.btnOpenKey.TabIndex = 5;
            this.btnOpenKey.Text = "Ključ";
            this.btnOpenKey.UseVisualStyleBackColor = false;
            this.btnOpenKey.Click += new System.EventHandler(this.btnOpenKey_Click);
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
            this.textSymmetricKey.TabIndex = 6;
            // 
            // labelEncryptedFile
            // 
            this.labelEncryptedFile.AutoSize = true;
            this.labelEncryptedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncryptedFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelEncryptedFile.Location = new System.Drawing.Point(7, 296);
            this.labelEncryptedFile.Name = "labelEncryptedFile";
            this.labelEncryptedFile.Size = new System.Drawing.Size(118, 18);
            this.labelEncryptedFile.TabIndex = 7;
            this.labelEncryptedFile.Text = "Kriptiran tekst:";
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "txt files (*.txt)|*.txt";
            this.ofdFile.Title = "Izaberite datoteku koju želite kriptirati";
            // 
            // ofdKey
            // 
            this.ofdKey.Filter = "txt files (*.txt)|*.txt";
            this.ofdKey.Title = "Izaberite simetrični ključ";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelTitle.Location = new System.Drawing.Point(202, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(214, 25);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "Simetrično kriptiranje";
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
            this.textOriginalFile.TabIndex = 17;
            // 
            // labelEncryptedPath
            // 
            this.labelEncryptedPath.AutoSize = true;
            this.labelEncryptedPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncryptedPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelEncryptedPath.Location = new System.Drawing.Point(56, 463);
            this.labelEncryptedPath.Name = "labelEncryptedPath";
            this.labelEncryptedPath.Size = new System.Drawing.Size(69, 18);
            this.labelEncryptedPath.TabIndex = 20;
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
            this.textEncryptedPath.TabIndex = 19;
            // 
            // formEncryptSymmetric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 636);
            this.Controls.Add(this.labelEncryptedPath);
            this.Controls.Add(this.textEncryptedPath);
            this.Controls.Add(this.textOriginalFile);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelEncryptedFile);
            this.Controls.Add(this.textSymmetricKey);
            this.Controls.Add(this.btnOpenKey);
            this.Controls.Add(this.richTextEncryptedFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnSymmetricEncrypt);
            this.Name = "formEncryptSymmetric";
            this.Text = "encryptSymmetricForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSymmetricEncrypt;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RichTextBox richTextEncryptedFile;
        private System.Windows.Forms.Button btnOpenKey;
        private System.Windows.Forms.TextBox textSymmetricKey;
        private System.Windows.Forms.Label labelEncryptedFile;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.OpenFileDialog ofdKey;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textOriginalFile;
        private System.Windows.Forms.Label labelEncryptedPath;
        private System.Windows.Forms.TextBox textEncryptedPath;
    }
}