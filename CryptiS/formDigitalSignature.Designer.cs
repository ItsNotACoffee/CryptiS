namespace CryptiS
{
    partial class formDigitalSignature
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textOriginalFile = new System.Windows.Forms.TextBox();
            this.textPrivateKey = new System.Windows.Forms.TextBox();
            this.btnOpenPrivateKey = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnCheckSignature = new System.Windows.Forms.Button();
            this.textPublicKey = new System.Windows.Forms.TextBox();
            this.btnOpenPublicKey = new System.Windows.Forms.Button();
            this.textDigitalSignature = new System.Windows.Forms.TextBox();
            this.btnOpenSignature = new System.Windows.Forms.Button();
            this.btnSignDigitally = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.labelSignatureStatus = new System.Windows.Forms.Label();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.ofdSignature = new System.Windows.Forms.OpenFileDialog();
            this.ofdPrivateKey = new System.Windows.Forms.OpenFileDialog();
            this.ofdPublicKey = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelTitle.Location = new System.Drawing.Point(201, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(217, 25);
            this.labelTitle.TabIndex = 22;
            this.labelTitle.Text = "Digitalno potpisivanje";
            // 
            // textOriginalFile
            // 
            this.textOriginalFile.BackColor = System.Drawing.Color.White;
            this.textOriginalFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOriginalFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOriginalFile.Location = new System.Drawing.Point(144, 68);
            this.textOriginalFile.Multiline = true;
            this.textOriginalFile.Name = "textOriginalFile";
            this.textOriginalFile.ReadOnly = true;
            this.textOriginalFile.Size = new System.Drawing.Size(464, 32);
            this.textOriginalFile.TabIndex = 32;
            // 
            // textPrivateKey
            // 
            this.textPrivateKey.BackColor = System.Drawing.Color.White;
            this.textPrivateKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrivateKey.Location = new System.Drawing.Point(144, 172);
            this.textPrivateKey.Multiline = true;
            this.textPrivateKey.Name = "textPrivateKey";
            this.textPrivateKey.ReadOnly = true;
            this.textPrivateKey.Size = new System.Drawing.Size(464, 32);
            this.textPrivateKey.TabIndex = 31;
            // 
            // btnOpenPrivateKey
            // 
            this.btnOpenPrivateKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnOpenPrivateKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPrivateKey.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOpenPrivateKey.FlatAppearance.BorderSize = 0;
            this.btnOpenPrivateKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnOpenPrivateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPrivateKey.ForeColor = System.Drawing.Color.White;
            this.btnOpenPrivateKey.Location = new System.Drawing.Point(25, 172);
            this.btnOpenPrivateKey.Name = "btnOpenPrivateKey";
            this.btnOpenPrivateKey.Size = new System.Drawing.Size(113, 32);
            this.btnOpenPrivateKey.TabIndex = 30;
            this.btnOpenPrivateKey.Text = "Privatni ključ";
            this.btnOpenPrivateKey.UseVisualStyleBackColor = false;
            this.btnOpenPrivateKey.Click += new System.EventHandler(this.btnOpenPrivateKey_Click);
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
            this.btnOpenFile.Location = new System.Drawing.Point(25, 68);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(113, 32);
            this.btnOpenFile.TabIndex = 29;
            this.btnOpenFile.Text = "Datoteka";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnCheckSignature
            // 
            this.btnCheckSignature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnCheckSignature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckSignature.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCheckSignature.FlatAppearance.BorderSize = 0;
            this.btnCheckSignature.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnCheckSignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSignature.ForeColor = System.Drawing.Color.White;
            this.btnCheckSignature.Location = new System.Drawing.Point(348, 384);
            this.btnCheckSignature.Name = "btnCheckSignature";
            this.btnCheckSignature.Size = new System.Drawing.Size(159, 43);
            this.btnCheckSignature.TabIndex = 33;
            this.btnCheckSignature.Text = "Provjeri potpis";
            this.btnCheckSignature.UseVisualStyleBackColor = false;
            this.btnCheckSignature.Click += new System.EventHandler(this.btnCheckSignature_Click);
            // 
            // textPublicKey
            // 
            this.textPublicKey.BackColor = System.Drawing.Color.White;
            this.textPublicKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPublicKey.Location = new System.Drawing.Point(144, 225);
            this.textPublicKey.Multiline = true;
            this.textPublicKey.Name = "textPublicKey";
            this.textPublicKey.ReadOnly = true;
            this.textPublicKey.Size = new System.Drawing.Size(464, 32);
            this.textPublicKey.TabIndex = 35;
            // 
            // btnOpenPublicKey
            // 
            this.btnOpenPublicKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnOpenPublicKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPublicKey.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOpenPublicKey.FlatAppearance.BorderSize = 0;
            this.btnOpenPublicKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnOpenPublicKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPublicKey.ForeColor = System.Drawing.Color.White;
            this.btnOpenPublicKey.Location = new System.Drawing.Point(25, 225);
            this.btnOpenPublicKey.Name = "btnOpenPublicKey";
            this.btnOpenPublicKey.Size = new System.Drawing.Size(113, 32);
            this.btnOpenPublicKey.TabIndex = 34;
            this.btnOpenPublicKey.Text = "Javni ključ";
            this.btnOpenPublicKey.UseVisualStyleBackColor = false;
            this.btnOpenPublicKey.Click += new System.EventHandler(this.btnOpenPublicKey_Click);
            // 
            // textDigitalSignature
            // 
            this.textDigitalSignature.BackColor = System.Drawing.Color.White;
            this.textDigitalSignature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDigitalSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDigitalSignature.Location = new System.Drawing.Point(144, 119);
            this.textDigitalSignature.Multiline = true;
            this.textDigitalSignature.Name = "textDigitalSignature";
            this.textDigitalSignature.ReadOnly = true;
            this.textDigitalSignature.Size = new System.Drawing.Size(464, 32);
            this.textDigitalSignature.TabIndex = 37;
            // 
            // btnOpenSignature
            // 
            this.btnOpenSignature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnOpenSignature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenSignature.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOpenSignature.FlatAppearance.BorderSize = 0;
            this.btnOpenSignature.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnOpenSignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSignature.ForeColor = System.Drawing.Color.White;
            this.btnOpenSignature.Location = new System.Drawing.Point(25, 119);
            this.btnOpenSignature.Name = "btnOpenSignature";
            this.btnOpenSignature.Size = new System.Drawing.Size(113, 32);
            this.btnOpenSignature.TabIndex = 36;
            this.btnOpenSignature.Text = "Potpis";
            this.btnOpenSignature.UseVisualStyleBackColor = false;
            this.btnOpenSignature.Click += new System.EventHandler(this.btnOpenSignature_Click);
            // 
            // btnSignDigitally
            // 
            this.btnSignDigitally.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnSignDigitally.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignDigitally.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSignDigitally.FlatAppearance.BorderSize = 0;
            this.btnSignDigitally.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnSignDigitally.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignDigitally.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignDigitally.ForeColor = System.Drawing.Color.White;
            this.btnSignDigitally.Location = new System.Drawing.Point(126, 384);
            this.btnSignDigitally.Name = "btnSignDigitally";
            this.btnSignDigitally.Size = new System.Drawing.Size(159, 43);
            this.btnSignDigitally.TabIndex = 38;
            this.btnSignDigitally.Text = "Potpiši";
            this.btnSignDigitally.UseVisualStyleBackColor = false;
            this.btnSignDigitally.Click += new System.EventHandler(this.btnSignDigitally_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.richTextBox1.Location = new System.Drawing.Point(25, 276);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(260, 84);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "Za potpisivanje je potrebno učitati:\n - Datoteku\n - Privatni ključ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.richTextBox2.Location = new System.Drawing.Point(348, 276);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(260, 84);
            this.richTextBox2.TabIndex = 40;
            this.richTextBox2.Text = "Za provjeru potpisa je potrebno učitati:\n - Datoteku\n - Javni ključ\n - Potpis";
            // 
            // labelSignatureStatus
            // 
            this.labelSignatureStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelSignatureStatus.AutoSize = true;
            this.labelSignatureStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignatureStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelSignatureStatus.Location = new System.Drawing.Point(214, 455);
            this.labelSignatureStatus.Name = "labelSignatureStatus";
            this.labelSignatureStatus.Size = new System.Drawing.Size(201, 31);
            this.labelSignatureStatus.TabIndex = 41;
            this.labelSignatureStatus.Text = "Status potpisa";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelFilePath.Location = new System.Drawing.Point(51, 504);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(69, 18);
            this.labelFilePath.TabIndex = 43;
            this.labelFilePath.Text = "Putanja:";
            // 
            // textFilePath
            // 
            this.textFilePath.BackColor = System.Drawing.Color.White;
            this.textFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFilePath.Location = new System.Drawing.Point(126, 504);
            this.textFilePath.Multiline = true;
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.ReadOnly = true;
            this.textFilePath.Size = new System.Drawing.Size(464, 32);
            this.textFilePath.TabIndex = 42;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "ofdFile";
            this.ofdFile.Filter = "txt files (*.txt)|*.txt";
            this.ofdFile.Title = "Izaberite originalnu datoteku";
            // 
            // ofdSignature
            // 
            this.ofdSignature.FileName = "ofdSignature";
            this.ofdSignature.Filter = "txt files (*.txt)|*.txt";
            this.ofdSignature.Title = "Izaberite digitalni potpis";
            // 
            // ofdPrivateKey
            // 
            this.ofdPrivateKey.FileName = "ofdPrivateKey";
            this.ofdPrivateKey.Filter = "txt files (*.txt)|*.txt";
            this.ofdPrivateKey.Title = "Izaberite privatni ključ";
            // 
            // ofdPublicKey
            // 
            this.ofdPublicKey.FileName = "ofdPublicKey";
            this.ofdPublicKey.Filter = "txt files (*.txt)|*.txt";
            this.ofdPublicKey.Title = "Izaberite javni ključ";
            // 
            // formDigitalSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 636);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.textFilePath);
            this.Controls.Add(this.labelSignatureStatus);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSignDigitally);
            this.Controls.Add(this.textDigitalSignature);
            this.Controls.Add(this.btnOpenSignature);
            this.Controls.Add(this.textPublicKey);
            this.Controls.Add(this.btnOpenPublicKey);
            this.Controls.Add(this.btnCheckSignature);
            this.Controls.Add(this.textOriginalFile);
            this.Controls.Add(this.textPrivateKey);
            this.Controls.Add(this.btnOpenPrivateKey);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.labelTitle);
            this.Name = "formDigitalSignature";
            this.Text = "formDigitalSignature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textOriginalFile;
        private System.Windows.Forms.TextBox textPrivateKey;
        private System.Windows.Forms.Button btnOpenPrivateKey;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnCheckSignature;
        private System.Windows.Forms.TextBox textPublicKey;
        private System.Windows.Forms.Button btnOpenPublicKey;
        private System.Windows.Forms.TextBox textDigitalSignature;
        private System.Windows.Forms.Button btnOpenSignature;
        private System.Windows.Forms.Button btnSignDigitally;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label labelSignatureStatus;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.TextBox textFilePath;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.OpenFileDialog ofdSignature;
        private System.Windows.Forms.OpenFileDialog ofdPrivateKey;
        private System.Windows.Forms.OpenFileDialog ofdPublicKey;
    }
}