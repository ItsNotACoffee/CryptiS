namespace CryptiS
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.titleBar = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.panelHolderPanel = new System.Windows.Forms.Panel();
            this.sidebar = new CryptiS.GradientPanel();
            this.btnDigitalSignature = new System.Windows.Forms.Button();
            this.btnCalculateHash = new System.Windows.Forms.Button();
            this.panelSubDecrypt = new System.Windows.Forms.Panel();
            this.btnDecryptAsymmetric = new System.Windows.Forms.Button();
            this.btnDecryptSymmetric = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.panelSubEncrypt = new System.Windows.Forms.Panel();
            this.btnEncryptAsymmetric = new System.Windows.Forms.Button();
            this.btnEncryptSymmetric = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebarLogo = new System.Windows.Forms.PictureBox();
            this.btnChooseDir = new System.Windows.Forms.Button();
            this.labelChooseDir = new System.Windows.Forms.Label();
            this.fbdMainDir = new System.Windows.Forms.FolderBrowserDialog();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panelHolderPanel.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panelSubDecrypt.SuspendLayout();
            this.panelSubEncrypt.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.titleBar.Controls.Add(this.exit);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(280, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(659, 33);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(632, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(23, 22);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panelHolderPanel
            // 
            this.panelHolderPanel.Controls.Add(this.labelChooseDir);
            this.panelHolderPanel.Controls.Add(this.btnChooseDir);
            this.panelHolderPanel.Location = new System.Drawing.Point(286, 39);
            this.panelHolderPanel.Name = "panelHolderPanel";
            this.panelHolderPanel.Size = new System.Drawing.Size(648, 675);
            this.panelHolderPanel.TabIndex = 2;
            // 
            // sidebar
            // 
            this.sidebar.AutoScroll = true;
            this.sidebar.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.sidebar.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.sidebar.Controls.Add(this.btnDigitalSignature);
            this.sidebar.Controls.Add(this.btnCalculateHash);
            this.sidebar.Controls.Add(this.panelSubDecrypt);
            this.sidebar.Controls.Add(this.btnDecrypt);
            this.sidebar.Controls.Add(this.panelSubEncrypt);
            this.sidebar.Controls.Add(this.btnEncrypt);
            this.sidebar.Controls.Add(this.btnGenerateKeys);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(280, 724);
            this.sidebar.TabIndex = 0;
            // 
            // btnDigitalSignature
            // 
            this.btnDigitalSignature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnDigitalSignature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDigitalSignature.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDigitalSignature.FlatAppearance.BorderSize = 0;
            this.btnDigitalSignature.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnDigitalSignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDigitalSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigitalSignature.ForeColor = System.Drawing.Color.White;
            this.btnDigitalSignature.Location = new System.Drawing.Point(0, 645);
            this.btnDigitalSignature.Name = "btnDigitalSignature";
            this.btnDigitalSignature.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDigitalSignature.Size = new System.Drawing.Size(280, 52);
            this.btnDigitalSignature.TabIndex = 10;
            this.btnDigitalSignature.Text = "Digitalno potpisivanje";
            this.btnDigitalSignature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDigitalSignature.UseVisualStyleBackColor = false;
            this.btnDigitalSignature.Click += new System.EventHandler(this.btnDigitalSignature_Click);
            // 
            // btnCalculateHash
            // 
            this.btnCalculateHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnCalculateHash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateHash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalculateHash.FlatAppearance.BorderSize = 0;
            this.btnCalculateHash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnCalculateHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateHash.ForeColor = System.Drawing.Color.White;
            this.btnCalculateHash.Location = new System.Drawing.Point(0, 593);
            this.btnCalculateHash.Name = "btnCalculateHash";
            this.btnCalculateHash.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCalculateHash.Size = new System.Drawing.Size(280, 52);
            this.btnCalculateHash.TabIndex = 9;
            this.btnCalculateHash.Text = "Izračunavanje sažetka";
            this.btnCalculateHash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculateHash.UseVisualStyleBackColor = false;
            this.btnCalculateHash.Click += new System.EventHandler(this.btnCalculateHash_Click);
            // 
            // panelSubDecrypt
            // 
            this.panelSubDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(100)))));
            this.panelSubDecrypt.Controls.Add(this.btnDecryptAsymmetric);
            this.panelSubDecrypt.Controls.Add(this.btnDecryptSymmetric);
            this.panelSubDecrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubDecrypt.Location = new System.Drawing.Point(0, 487);
            this.panelSubDecrypt.Name = "panelSubDecrypt";
            this.panelSubDecrypt.Size = new System.Drawing.Size(280, 106);
            this.panelSubDecrypt.TabIndex = 8;
            // 
            // btnDecryptAsymmetric
            // 
            this.btnDecryptAsymmetric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(100)))));
            this.btnDecryptAsymmetric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecryptAsymmetric.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDecryptAsymmetric.FlatAppearance.BorderSize = 0;
            this.btnDecryptAsymmetric.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnDecryptAsymmetric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecryptAsymmetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptAsymmetric.ForeColor = System.Drawing.Color.White;
            this.btnDecryptAsymmetric.Location = new System.Drawing.Point(0, 52);
            this.btnDecryptAsymmetric.Name = "btnDecryptAsymmetric";
            this.btnDecryptAsymmetric.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnDecryptAsymmetric.Size = new System.Drawing.Size(280, 54);
            this.btnDecryptAsymmetric.TabIndex = 4;
            this.btnDecryptAsymmetric.Text = "Asimetrično";
            this.btnDecryptAsymmetric.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecryptAsymmetric.UseVisualStyleBackColor = false;
            this.btnDecryptAsymmetric.Click += new System.EventHandler(this.btnDecryptAsymmetric_Click);
            // 
            // btnDecryptSymmetric
            // 
            this.btnDecryptSymmetric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(100)))));
            this.btnDecryptSymmetric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecryptSymmetric.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDecryptSymmetric.FlatAppearance.BorderSize = 0;
            this.btnDecryptSymmetric.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnDecryptSymmetric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecryptSymmetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptSymmetric.ForeColor = System.Drawing.Color.White;
            this.btnDecryptSymmetric.Location = new System.Drawing.Point(0, 0);
            this.btnDecryptSymmetric.Name = "btnDecryptSymmetric";
            this.btnDecryptSymmetric.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnDecryptSymmetric.Size = new System.Drawing.Size(280, 52);
            this.btnDecryptSymmetric.TabIndex = 3;
            this.btnDecryptSymmetric.Text = "Simetrično";
            this.btnDecryptSymmetric.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecryptSymmetric.UseVisualStyleBackColor = false;
            this.btnDecryptSymmetric.Click += new System.EventHandler(this.btnDecryptSymmetric_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(0, 435);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDecrypt.Size = new System.Drawing.Size(280, 52);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Dekriptiranje";
            this.btnDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // panelSubEncrypt
            // 
            this.panelSubEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(100)))));
            this.panelSubEncrypt.Controls.Add(this.btnEncryptAsymmetric);
            this.panelSubEncrypt.Controls.Add(this.btnEncryptSymmetric);
            this.panelSubEncrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubEncrypt.Location = new System.Drawing.Point(0, 329);
            this.panelSubEncrypt.Name = "panelSubEncrypt";
            this.panelSubEncrypt.Size = new System.Drawing.Size(280, 106);
            this.panelSubEncrypt.TabIndex = 6;
            // 
            // btnEncryptAsymmetric
            // 
            this.btnEncryptAsymmetric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(100)))));
            this.btnEncryptAsymmetric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryptAsymmetric.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEncryptAsymmetric.FlatAppearance.BorderSize = 0;
            this.btnEncryptAsymmetric.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnEncryptAsymmetric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptAsymmetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptAsymmetric.ForeColor = System.Drawing.Color.White;
            this.btnEncryptAsymmetric.Location = new System.Drawing.Point(0, 52);
            this.btnEncryptAsymmetric.Name = "btnEncryptAsymmetric";
            this.btnEncryptAsymmetric.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnEncryptAsymmetric.Size = new System.Drawing.Size(280, 54);
            this.btnEncryptAsymmetric.TabIndex = 4;
            this.btnEncryptAsymmetric.Text = "Asimetrično";
            this.btnEncryptAsymmetric.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncryptAsymmetric.UseVisualStyleBackColor = false;
            this.btnEncryptAsymmetric.Click += new System.EventHandler(this.btnEncryptAsymmetric_Click);
            // 
            // btnEncryptSymmetric
            // 
            this.btnEncryptSymmetric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(100)))));
            this.btnEncryptSymmetric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryptSymmetric.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEncryptSymmetric.FlatAppearance.BorderSize = 0;
            this.btnEncryptSymmetric.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnEncryptSymmetric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptSymmetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptSymmetric.ForeColor = System.Drawing.Color.White;
            this.btnEncryptSymmetric.Location = new System.Drawing.Point(0, 0);
            this.btnEncryptSymmetric.Name = "btnEncryptSymmetric";
            this.btnEncryptSymmetric.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnEncryptSymmetric.Size = new System.Drawing.Size(280, 52);
            this.btnEncryptSymmetric.TabIndex = 3;
            this.btnEncryptSymmetric.Text = "Simetrično";
            this.btnEncryptSymmetric.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncryptSymmetric.UseVisualStyleBackColor = false;
            this.btnEncryptSymmetric.Click += new System.EventHandler(this.btnEncryptSymmetric_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(0, 277);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEncrypt.Size = new System.Drawing.Size(280, 52);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Kriptiranje";
            this.btnEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnGenerateKeys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateKeys.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateKeys.FlatAppearance.BorderSize = 0;
            this.btnGenerateKeys.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnGenerateKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKeys.ForeColor = System.Drawing.Color.White;
            this.btnGenerateKeys.Location = new System.Drawing.Point(0, 225);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGenerateKeys.Size = new System.Drawing.Size(280, 52);
            this.btnGenerateKeys.TabIndex = 1;
            this.btnGenerateKeys.Text = "Generiranje ključeva";
            this.btnGenerateKeys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateKeys.UseVisualStyleBackColor = false;
            this.btnGenerateKeys.Click += new System.EventHandler(this.generateKeys_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.sidebarLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 225);
            this.panel1.TabIndex = 0;
            // 
            // sidebarLogo
            // 
            this.sidebarLogo.Image = ((System.Drawing.Image)(resources.GetObject("sidebarLogo.Image")));
            this.sidebarLogo.Location = new System.Drawing.Point(38, 29);
            this.sidebarLogo.Name = "sidebarLogo";
            this.sidebarLogo.Size = new System.Drawing.Size(199, 116);
            this.sidebarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sidebarLogo.TabIndex = 0;
            this.sidebarLogo.TabStop = false;
            // 
            // btnChooseDir
            // 
            this.btnChooseDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.btnChooseDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseDir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnChooseDir.FlatAppearance.BorderSize = 0;
            this.btnChooseDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(196)))));
            this.btnChooseDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseDir.ForeColor = System.Drawing.Color.White;
            this.btnChooseDir.Location = new System.Drawing.Point(240, 308);
            this.btnChooseDir.Name = "btnChooseDir";
            this.btnChooseDir.Size = new System.Drawing.Size(159, 43);
            this.btnChooseDir.TabIndex = 1;
            this.btnChooseDir.Text = "Odaberi direktorij";
            this.btnChooseDir.UseVisualStyleBackColor = false;
            this.btnChooseDir.Click += new System.EventHandler(this.btnChooseDir_Click);
            // 
            // labelChooseDir
            // 
            this.labelChooseDir.AutoSize = true;
            this.labelChooseDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.labelChooseDir.Location = new System.Drawing.Point(131, 238);
            this.labelChooseDir.Name = "labelChooseDir";
            this.labelChooseDir.Size = new System.Drawing.Size(395, 18);
            this.labelChooseDir.TabIndex = 15;
            this.labelChooseDir.Text = "Odaberite direktorij gdje će se pohranjivati datoteke";
            // 
            // formMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(939, 724);
            this.ControlBox = false;
            this.Controls.Add(this.panelHolderPanel);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.Text = "DigitalniPotpis";
            this.titleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panelHolderPanel.ResumeLayout(false);
            this.panelHolderPanel.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.panelSubDecrypt.ResumeLayout(false);
            this.panelSubEncrypt.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sidebarLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.PictureBox sidebarLogo;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel panelHolderPanel;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Panel panelSubEncrypt;
        private System.Windows.Forms.Button btnEncryptAsymmetric;
        private System.Windows.Forms.Button btnEncryptSymmetric;
        private System.Windows.Forms.Button btnDigitalSignature;
        private System.Windows.Forms.Button btnCalculateHash;
        private System.Windows.Forms.Panel panelSubDecrypt;
        private System.Windows.Forms.Button btnDecryptAsymmetric;
        private System.Windows.Forms.Button btnDecryptSymmetric;
        private System.Windows.Forms.Button btnChooseDir;
        private System.Windows.Forms.Label labelChooseDir;
        private System.Windows.Forms.FolderBrowserDialog fbdMainDir;
    }
}

