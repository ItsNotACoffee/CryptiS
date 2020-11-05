using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptiS
{
    public partial class formDecryptSymmetric : Form
    {
        public formDecryptSymmetric()
        {
            InitializeComponent();
        }

        private void btnSymmetricDecrypt_Click(object sender, EventArgs e)
        {
            richTextDecryptedFile.Text = "";
            if (encryptedFile != null && keyFile != null)
            {
                byte[] fileContent = Convert.FromBase64String(File.ReadAllText(encryptedFile));
                byte[] key = Convert.FromBase64String(File.ReadAllText(keyFile));

                try
                {
                    string decryptedContent = Cryptography.Symmetric.Decrypt(fileContent, key);
                    WorkingDir.save(decryptedContent, "dekriptirani_tekst_simetricni.txt");
                    richTextDecryptedFile.Text = decryptedContent;
                    textDecryptedPath.Text = WorkingDir.directory + "\\" + "dekriptirani_tekst_simetricni.txt";
                }
                catch (CryptographicException)
                {
                    string message = "Ključ ili datoteka nisu valjani!";
                    string caption = "Decrypt Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
            }
            else
            {
                string message = "Niste učitali sve potrebne podatke za dekriptiranje!";
                string caption = "Input Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        public string encryptedFile;
        public string keyFile;

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                encryptedFile = ofdFile.FileName;
                string splt = ofdFile.FileName.Split('\\').Last();
                textEncryptedFile.Text = splt;
            }
        }

        private void btnOpenKey_Click(object sender, EventArgs e)
        {
            if (ofdKey.ShowDialog() == DialogResult.OK)
            {
                keyFile = ofdKey.FileName;
                string fileContent = File.ReadAllText(keyFile);
                textSymmetricKey.Text = fileContent;
            }
        }
    }
}
