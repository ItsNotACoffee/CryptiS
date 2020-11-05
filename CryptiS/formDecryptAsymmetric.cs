using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptiS
{
    public partial class formDecryptAsymmetric : Form
    {
        public formDecryptAsymmetric()
        {
            InitializeComponent();
        }

        public string encryptedFile;
        public string privateKey;

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
                privateKey = ofdKey.FileName;
                string fileContent = File.ReadAllText(privateKey);
                textPrivateKey.Text = fileContent;
            }
        }

        private void btnAsymmetricDecrypt_Click(object sender, EventArgs e)
        {
            richTextDecryptedFile.Text = "";
            if (encryptedFile != null && privateKey != null)
            {
                byte[] encFile = Convert.FromBase64String(File.ReadAllText(encryptedFile));
                string pKey = File.ReadAllText(privateKey);

                string decodedText = Cryptography.Asymmetric.Decrypt(encFile, pKey);
                WorkingDir.save(decodedText, "dekriptirani_tekst_asimetricni.txt");
                richTextDecryptedFile.Text = decodedText;
                textDecryptedPath.Text = WorkingDir.directory + "\\" + "dekriptirani_tekst_asimetricni.txt";
            }
            else
            {
                string message = "Niste učitali sve potrebne podatke za dekriptiranje!";
                string caption = "Input Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
