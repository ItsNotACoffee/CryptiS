namespace DigitalniPotpis
{
    partial class formGenerateKeys
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
            this.btnSymmetricGenerate = new System.Windows.Forms.Button();
            this.groupBoxSymmetric = new System.Windows.Forms.GroupBox();
            this.labelSymmetricFile = new System.Windows.Forms.Label();
            this.labelSymmetricKey = new System.Windows.Forms.Label();
            this.textSymmetricFile = new System.Windows.Forms.TextBox();
            this.textSymmetricKey = new System.Windows.Forms.TextBox();
            this.groupBoxAsymmetric = new System.Windows.Forms.GroupBox();
            this.richTextAsymmetricPrivateKey = new System.Windows.Forms.RichTextBox();
            this.richTextAsymmetricPublicKey = new System.Windows.Forms.RichTextBox();
            this.labelAsymmetricPrivateFile = new System.Windows.Forms.Label();
            this.labelAsymmetricPrivateKey = new System.Windows.Forms.Label();
            this.textAsymmetricPrivateFile = new System.Windows.Forms.TextBox();
            this.labelAsymmetricPublicFile = new System.Windows.Forms.Label();
            this.labelAsymmetricPublicKey = new System.Windows.Forms.Label();
            this.textAsymmetricPublicFile = new System.Windows.Forms.TextBox();
            this.btnAsymmetricGenerate = new System.Windows.Forms.Button();
            this.groupBoxSymmetric.SuspendLayout();
            this.groupBoxAsymmetric.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSymmetricGenerate
            // 
            this.btnSymmetricGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnSymmetricGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSymmetricGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSymmetricGenerate.FlatAppearance.BorderSize = 0;
            this.btnSymmetricGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnSymmetricGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSymmetricGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSymmetricGenerate.ForeColor = System.Drawing.Color.White;
            this.btnSymmetricGenerate.Location = new System.Drawing.Point(226, 42);
            this.btnSymmetricGenerate.Name = "btnSymmetricGenerate";
            this.btnSymmetricGenerate.Size = new System.Drawing.Size(159, 43);
            this.btnSymmetricGenerate.TabIndex = 0;
            this.btnSymmetricGenerate.Text = "Generiraj";
            this.btnSymmetricGenerate.UseVisualStyleBackColor = false;
            this.btnSymmetricGenerate.Click += new System.EventHandler(this.btnSymmetricGenerate_Click);
            // 
            // groupBoxSymmetric
            // 
            this.groupBoxSymmetric.Controls.Add(this.labelSymmetricFile);
            this.groupBoxSymmetric.Controls.Add(this.labelSymmetricKey);
            this.groupBoxSymmetric.Controls.Add(this.textSymmetricFile);
            this.groupBoxSymmetric.Controls.Add(this.textSymmetricKey);
            this.groupBoxSymmetric.Controls.Add(this.btnSymmetricGenerate);
            this.groupBoxSymmetric.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSymmetric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSymmetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSymmetric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.groupBoxSymmetric.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSymmetric.Name = "groupBoxSymmetric";
            this.groupBoxSymmetric.Size = new System.Drawing.Size(632, 198);
            this.groupBoxSymmetric.TabIndex = 1;
            this.groupBoxSymmetric.TabStop = false;
            this.groupBoxSymmetric.Text = "Simetrični ključevi";
            // 
            // labelSymmetricFile
            // 
            this.labelSymmetricFile.AutoSize = true;
            this.labelSymmetricFile.Location = new System.Drawing.Point(67, 140);
            this.labelSymmetricFile.Name = "labelSymmetricFile";
            this.labelSymmetricFile.Size = new System.Drawing.Size(69, 18);
            this.labelSymmetricFile.TabIndex = 5;
            this.labelSymmetricFile.Text = "Putanja:";
            // 
            // labelSymmetricKey
            // 
            this.labelSymmetricKey.AutoSize = true;
            this.labelSymmetricKey.Location = new System.Drawing.Point(44, 111);
            this.labelSymmetricKey.Name = "labelSymmetricKey";
            this.labelSymmetricKey.Size = new System.Drawing.Size(92, 18);
            this.labelSymmetricKey.TabIndex = 4;
            this.labelSymmetricKey.Text = "Javni ključ:";
            // 
            // textSymmetricFile
            // 
            this.textSymmetricFile.BackColor = System.Drawing.Color.White;
            this.textSymmetricFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSymmetricFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSymmetricFile.Location = new System.Drawing.Point(142, 143);
            this.textSymmetricFile.Name = "textSymmetricFile";
            this.textSymmetricFile.ReadOnly = true;
            this.textSymmetricFile.Size = new System.Drawing.Size(442, 17);
            this.textSymmetricFile.TabIndex = 3;
            // 
            // textSymmetricKey
            // 
            this.textSymmetricKey.BackColor = System.Drawing.Color.White;
            this.textSymmetricKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSymmetricKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSymmetricKey.Location = new System.Drawing.Point(142, 114);
            this.textSymmetricKey.Name = "textSymmetricKey";
            this.textSymmetricKey.ReadOnly = true;
            this.textSymmetricKey.Size = new System.Drawing.Size(442, 17);
            this.textSymmetricKey.TabIndex = 2;
            // 
            // groupBoxAsymmetric
            // 
            this.groupBoxAsymmetric.Controls.Add(this.richTextAsymmetricPrivateKey);
            this.groupBoxAsymmetric.Controls.Add(this.richTextAsymmetricPublicKey);
            this.groupBoxAsymmetric.Controls.Add(this.labelAsymmetricPrivateFile);
            this.groupBoxAsymmetric.Controls.Add(this.labelAsymmetricPrivateKey);
            this.groupBoxAsymmetric.Controls.Add(this.textAsymmetricPrivateFile);
            this.groupBoxAsymmetric.Controls.Add(this.labelAsymmetricPublicFile);
            this.groupBoxAsymmetric.Controls.Add(this.labelAsymmetricPublicKey);
            this.groupBoxAsymmetric.Controls.Add(this.textAsymmetricPublicFile);
            this.groupBoxAsymmetric.Controls.Add(this.btnAsymmetricGenerate);
            this.groupBoxAsymmetric.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAsymmetric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAsymmetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAsymmetric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.groupBoxAsymmetric.Location = new System.Drawing.Point(0, 198);
            this.groupBoxAsymmetric.Name = "groupBoxAsymmetric";
            this.groupBoxAsymmetric.Size = new System.Drawing.Size(632, 436);
            this.groupBoxAsymmetric.TabIndex = 2;
            this.groupBoxAsymmetric.TabStop = false;
            this.groupBoxAsymmetric.Text = "Asimetrični ključevi";
            // 
            // richTextAsymmetricPrivateKey
            // 
            this.richTextAsymmetricPrivateKey.BackColor = System.Drawing.Color.White;
            this.richTextAsymmetricPrivateKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextAsymmetricPrivateKey.Location = new System.Drawing.Point(142, 278);
            this.richTextAsymmetricPrivateKey.Name = "richTextAsymmetricPrivateKey";
            this.richTextAsymmetricPrivateKey.ReadOnly = true;
            this.richTextAsymmetricPrivateKey.Size = new System.Drawing.Size(442, 81);
            this.richTextAsymmetricPrivateKey.TabIndex = 10;
            this.richTextAsymmetricPrivateKey.Text = "";
            // 
            // richTextAsymmetricPublicKey
            // 
            this.richTextAsymmetricPublicKey.BackColor = System.Drawing.Color.White;
            this.richTextAsymmetricPublicKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextAsymmetricPublicKey.Location = new System.Drawing.Point(142, 129);
            this.richTextAsymmetricPublicKey.Name = "richTextAsymmetricPublicKey";
            this.richTextAsymmetricPublicKey.ReadOnly = true;
            this.richTextAsymmetricPublicKey.Size = new System.Drawing.Size(442, 81);
            this.richTextAsymmetricPublicKey.TabIndex = 9;
            this.richTextAsymmetricPublicKey.Text = "";
            // 
            // labelAsymmetricPrivateFile
            // 
            this.labelAsymmetricPrivateFile.AutoSize = true;
            this.labelAsymmetricPrivateFile.Location = new System.Drawing.Point(67, 373);
            this.labelAsymmetricPrivateFile.Name = "labelAsymmetricPrivateFile";
            this.labelAsymmetricPrivateFile.Size = new System.Drawing.Size(69, 18);
            this.labelAsymmetricPrivateFile.TabIndex = 8;
            this.labelAsymmetricPrivateFile.Text = "Putanja:";
            // 
            // labelAsymmetricPrivateKey
            // 
            this.labelAsymmetricPrivateKey.AutoSize = true;
            this.labelAsymmetricPrivateKey.Location = new System.Drawing.Point(27, 278);
            this.labelAsymmetricPrivateKey.Name = "labelAsymmetricPrivateKey";
            this.labelAsymmetricPrivateKey.Size = new System.Drawing.Size(109, 18);
            this.labelAsymmetricPrivateKey.TabIndex = 7;
            this.labelAsymmetricPrivateKey.Text = "Privatni ključ:";
            // 
            // textAsymmetricPrivateFile
            // 
            this.textAsymmetricPrivateFile.BackColor = System.Drawing.Color.White;
            this.textAsymmetricPrivateFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAsymmetricPrivateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAsymmetricPrivateFile.Location = new System.Drawing.Point(142, 374);
            this.textAsymmetricPrivateFile.Name = "textAsymmetricPrivateFile";
            this.textAsymmetricPrivateFile.ReadOnly = true;
            this.textAsymmetricPrivateFile.Size = new System.Drawing.Size(442, 17);
            this.textAsymmetricPrivateFile.TabIndex = 6;
            // 
            // labelAsymmetricPublicFile
            // 
            this.labelAsymmetricPublicFile.AutoSize = true;
            this.labelAsymmetricPublicFile.Location = new System.Drawing.Point(67, 224);
            this.labelAsymmetricPublicFile.Name = "labelAsymmetricPublicFile";
            this.labelAsymmetricPublicFile.Size = new System.Drawing.Size(69, 18);
            this.labelAsymmetricPublicFile.TabIndex = 4;
            this.labelAsymmetricPublicFile.Text = "Putanja:";
            // 
            // labelAsymmetricPublicKey
            // 
            this.labelAsymmetricPublicKey.AutoSize = true;
            this.labelAsymmetricPublicKey.Location = new System.Drawing.Point(44, 129);
            this.labelAsymmetricPublicKey.Name = "labelAsymmetricPublicKey";
            this.labelAsymmetricPublicKey.Size = new System.Drawing.Size(92, 18);
            this.labelAsymmetricPublicKey.TabIndex = 3;
            this.labelAsymmetricPublicKey.Text = "Javni ključ:";
            // 
            // textAsymmetricPublicFile
            // 
            this.textAsymmetricPublicFile.BackColor = System.Drawing.Color.White;
            this.textAsymmetricPublicFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAsymmetricPublicFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAsymmetricPublicFile.Location = new System.Drawing.Point(142, 225);
            this.textAsymmetricPublicFile.Name = "textAsymmetricPublicFile";
            this.textAsymmetricPublicFile.ReadOnly = true;
            this.textAsymmetricPublicFile.Size = new System.Drawing.Size(442, 17);
            this.textAsymmetricPublicFile.TabIndex = 2;
            // 
            // btnAsymmetricGenerate
            // 
            this.btnAsymmetricGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnAsymmetricGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsymmetricGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAsymmetricGenerate.FlatAppearance.BorderSize = 0;
            this.btnAsymmetricGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnAsymmetricGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsymmetricGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsymmetricGenerate.ForeColor = System.Drawing.Color.White;
            this.btnAsymmetricGenerate.Location = new System.Drawing.Point(226, 41);
            this.btnAsymmetricGenerate.Name = "btnAsymmetricGenerate";
            this.btnAsymmetricGenerate.Size = new System.Drawing.Size(159, 43);
            this.btnAsymmetricGenerate.TabIndex = 0;
            this.btnAsymmetricGenerate.Text = "Generiraj";
            this.btnAsymmetricGenerate.UseVisualStyleBackColor = false;
            this.btnAsymmetricGenerate.Click += new System.EventHandler(this.btnAsymmetricGenerate_Click);
            // 
            // formGenerateKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 636);
            this.Controls.Add(this.groupBoxAsymmetric);
            this.Controls.Add(this.groupBoxSymmetric);
            this.Name = "formGenerateKeys";
            this.Text = "generateKeysForm";
            this.groupBoxSymmetric.ResumeLayout(false);
            this.groupBoxSymmetric.PerformLayout();
            this.groupBoxAsymmetric.ResumeLayout(false);
            this.groupBoxAsymmetric.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSymmetricGenerate;
        private System.Windows.Forms.GroupBox groupBoxSymmetric;
        private System.Windows.Forms.GroupBox groupBoxAsymmetric;
        private System.Windows.Forms.Button btnAsymmetricGenerate;
        private System.Windows.Forms.TextBox textAsymmetricPublicFile;
        private System.Windows.Forms.Label labelAsymmetricPublicKey;
        private System.Windows.Forms.Label labelAsymmetricPublicFile;
        private System.Windows.Forms.Label labelAsymmetricPrivateFile;
        private System.Windows.Forms.Label labelAsymmetricPrivateKey;
        private System.Windows.Forms.TextBox textAsymmetricPrivateFile;
        private System.Windows.Forms.Label labelSymmetricFile;
        private System.Windows.Forms.Label labelSymmetricKey;
        private System.Windows.Forms.TextBox textSymmetricFile;
        private System.Windows.Forms.TextBox textSymmetricKey;
        private System.Windows.Forms.RichTextBox richTextAsymmetricPrivateKey;
        private System.Windows.Forms.RichTextBox richTextAsymmetricPublicKey;
    }
}