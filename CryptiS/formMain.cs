using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptiS
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            hideSubmenus();
            toggleButtons(false);
        }

        #region helper functions
        private void hideSubmenus()
        {
            panelSubDecrypt.Visible = false;
            panelSubEncrypt.Visible = false;
        }

        private void toggleButtons(Boolean visibility)
        {
            btnDigitalSignature.Visible = visibility;
            btnCalculateHash.Visible = visibility;
            panelSubDecrypt.Visible = visibility;
            btnDecrypt.Visible = visibility;
            panelSubEncrypt.Visible = visibility;
            btnEncrypt.Visible = visibility;
            btnGenerateKeys.Visible = visibility;

            //fix subpanels showing
            panelSubDecrypt.Visible = false;
            panelSubEncrypt.Visible = false;
        }

        private void showHideSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                //hide all menus first
                panelSubDecrypt.Visible = false;
                panelSubEncrypt.Visible = false;

                submenu.Visible = true;
            } else
            {
                submenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelHolderPanel.Controls.Add(form);
            panelHolderPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        #endregion

        #region sidebar button controls
        private void generateKeys_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            openForm(new formGenerateKeys());
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            showHideSubmenu(panelSubEncrypt);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            showHideSubmenu(panelSubDecrypt);
        }

        private void btnEncryptSymmetric_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            openForm(new formEncryptSymmetric());
        }

        private void btnEncryptAsymmetric_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            openForm(new formEncryptAsymmetric());
        }

        private void btnDecryptSymmetric_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            openForm(new formDecryptSymmetric());
        }

        private void btnDecryptAsymmetric_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            openForm(new formDecryptAsymmetric());
        }

        private void btnCalculateHash_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            openForm(new formGenerateHash());
        }

        private void btnDigitalSignature_Click(object sender, EventArgs e)
        {
            hideSubmenus();
        }
        #endregion

        #region events for dragging the window
        Point lastPoint; //used for dragging the window
        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void btnChooseDir_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdMainDir.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbdMainDir.SelectedPath))
            {
                WorkingDir.directory = fbdMainDir.SelectedPath;
                toggleButtons(true);
                btnChooseDir.Visible = false;
                labelChooseDir.Visible = false;
            }
        }
    }
}
