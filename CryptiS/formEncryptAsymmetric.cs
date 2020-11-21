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
    public partial class formEncryptAsymmetric : Form
    {
        public formEncryptAsymmetric()
        {
            InitializeComponent();
        }

        public string originalFile;
        private string publicKey;

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                originalFile = ofdFile.FileName;
                string splt = ofdFile.FileName.Split('\\').Last();
                textOriginalFile.Text = splt;
            }
        }

        private void btnOpenKey_Click(object sender, EventArgs e)
        {
            if (ofdKey.ShowDialog() == DialogResult.OK)
            {
                publicKey = ofdKey.FileName;
                string fileContent = File.ReadAllText(publicKey);
                textPublicKey.Text = fileContent;
            }
        }

        private void btnAsymmetricEncrypt_Click(object sender, EventArgs e)
        {
            if (originalFile != null && publicKey != null)
            {
                string fileContent = File.ReadAllText(originalFile);
                string pKey = File.ReadAllText(publicKey);
                try
                {
                byte[] encryptedContent = Cryptography.Asymmetric.Encrypt(fileContent, pKey);
                WorkingDir.save(Convert.ToBase64String(encryptedContent), "kriptirani_tekst_asimetricni.txt");
                richTextEncryptedFile.Text = Convert.ToBase64String(encryptedContent);
                textEncryptedPath.Text = WorkingDir.directory + "\\" + "kriptirani_tekst_asimetricni.txt";
                }
                catch (Exception ex)
                {
                    if (ex is CryptographicException || ex is System.FormatException)
                    {
                        string message = "Ključ ili datoteka nisu valjani!";
                        string caption = "Encrypt Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        string message = "Dogodila se greška, pokušajte ponovo!";
                        string caption = "Unknown Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                    }
                }
            } else
            {
                string message = "Niste učitali sve potrebne podatke za kriptiranje!";
                string caption = "Input Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
