namespace CryptiS
{
    partial class formGenerateHash
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
            this.textFile = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnCalculateHash = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textHash = new System.Windows.Forms.TextBox();
            this.labelHash = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textFile
            // 
            this.textFile.BackColor = System.Drawing.Color.White;
            this.textFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFile.Location = new System.Drawing.Point(133, 77);
            this.textFile.Multiline = true;
            this.textFile.Name = "textFile";
            this.textFile.ReadOnly = true;
            this.textFile.Size = new System.Drawing.Size(464, 32);
            this.textFile.TabIndex = 20;
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
            this.btnOpenFile.Location = new System.Drawing.Point(39, 77);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(88, 32);
            this.btnOpenFile.TabIndex = 19;
            this.btnOpenFile.Text = "Datoteka";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnCalculateHash
            // 
            this.btnCalculateHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnCalculateHash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateHash.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCalculateHash.FlatAppearance.BorderSize = 0;
            this.btnCalculateHash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnCalculateHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateHash.ForeColor = System.Drawing.Color.White;
            this.btnCalculateHash.Location = new System.Drawing.Point(226, 143);
            this.btnCalculateHash.Name = "btnCalculateHash";
            this.btnCalculateHash.Size = new System.Drawing.Size(159, 43);
            this.btnCalculateHash.TabIndex = 18;
            this.btnCalculateHash.Text = "Izračunaj";
            this.btnCalculateHash.UseVisualStyleBackColor = false;
            this.btnCalculateHash.Click += new System.EventHandler(this.btnCalculateHash_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelTitle.Location = new System.Drawing.Point(148, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(317, 25);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Izračunavanje sažetka datoteke";
            // 
            // textHash
            // 
            this.textHash.BackColor = System.Drawing.Color.White;
            this.textHash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHash.Location = new System.Drawing.Point(133, 224);
            this.textHash.Multiline = true;
            this.textHash.Name = "textHash";
            this.textHash.ReadOnly = true;
            this.textHash.Size = new System.Drawing.Size(464, 32);
            this.textHash.TabIndex = 22;
            // 
            // labelHash
            // 
            this.labelHash.AutoSize = true;
            this.labelHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelHash.Location = new System.Drawing.Point(53, 224);
            this.labelHash.Name = "labelHash";
            this.labelHash.Size = new System.Drawing.Size(74, 18);
            this.labelHash.TabIndex = 23;
            this.labelHash.Text = "Sažetak:";
            // 
            // ofdFile
            // 
            this.ofdFile.Title = "Izaberite simetrični ključ";
            // 
            // formGenerateHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 636);
            this.Controls.Add(this.labelHash);
            this.Controls.Add(this.textHash);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnCalculateHash);
            this.Name = "formGenerateHash";
            this.Text = "formGenerateHash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnCalculateHash;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textHash;
        private System.Windows.Forms.Label labelHash;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}