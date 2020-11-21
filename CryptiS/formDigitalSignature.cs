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
    public partial class formDigitalSignature : Form
    {
        public formDigitalSignature()
        {
            InitializeComponent();
            toggleComponents(false);
        }

        private void toggleComponents(Boolean visibility)
        {
            labelSignatureStatus.Visible = visibility;
            labelFilePath.Visible = visibility;
            textFilePath.Visible = visibility;
        }

        public string originalFile;
        private string publicKey;
        private string privateKey;
        private string signature;

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                originalFile = ofdFile.FileName;
                string splt = ofdFile.FileName.Split('\\').Last();
                textOriginalFile.Text = splt;
            }
        }

        private void btnOpenSignature_Click(object sender, EventArgs e)
        {
            if (ofdSignature.ShowDialog() == DialogResult.OK)
            {
                signature = ofdSignature.FileName;
                string splt = ofdSignature.FileName.Split('\\').Last();
                textDigitalSignature.Text = splt;
            }
        }

        private void btnOpenPrivateKey_Click(object sender, EventArgs e)
        {
            if (ofdPrivateKey.ShowDialog() == DialogResult.OK)
            {
                privateKey = ofdPrivateKey.FileName;
                string fileContent = File.ReadAllText(privateKey);
                textPrivateKey.Text = fileContent;
            }
        }

        private void btnOpenPublicKey_Click(object sender, EventArgs e)
        {
            if (ofdPublicKey.ShowDialog() == DialogResult.OK)
            {
                publicKey = ofdPublicKey.FileName;
                string fileContent = File.ReadAllText(publicKey);
                textPublicKey.Text = fileContent;
            }
        }

        private void btnSignDigitally_Click(object sender, EventArgs e)
        {
            toggleComponents(false);
            if (originalFile != null && privateKey != null)
            {
                string fileContent = File.ReadAllText(originalFile);
                string pKey = File.ReadAllText(privateKey);
                try
                {
                    string digitalSignature = Convert.ToBase64String(Cryptography.DigitalSignature.Sign(fileContent, pKey));
                    WorkingDir.save(digitalSignature, "digitalni_potpis.txt");
                    labelSignatureStatus.Text = "Datoteka uspješno potpisana!";
                    labelSignatureStatus.ForeColor = Color.Green;
                    textFilePath.Text = WorkingDir.directory + "\\" + "digitalni_potpis.txt";
                    toggleComponents(true);
                }
                catch (Exception ex)
                {
                    if (ex is CryptographicException || ex is System.FormatException)
                    {
                        string message = "Ključ ili datoteka nisu valjani!";
                        string caption = "Signature Error";
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
                string message = "Niste učitali sve potrebne podatke za potpisivanje!";
                string caption = "Input Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void btnCheckSignature_Click(object sender, EventArgs e)
        {
            toggleComponents(false);
            if (originalFile != null && publicKey != null && signature != null)
            {
                string fileContent = File.ReadAllText(originalFile);
                string pKey = File.ReadAllText(publicKey);
                string digitalSignature = File.ReadAllText(signature);
                try
                {
                    Boolean signatureStatus = Cryptography.DigitalSignature.Verify(fileContent, digitalSignature, pKey);
                    if (signatureStatus)
                    {
                        labelSignatureStatus.Text = "Potpis je valjan!";
                        labelSignatureStatus.ForeColor = Color.Green;
                        labelSignatureStatus.Visible = true;
                    }
                    else
                    {
                        labelSignatureStatus.Text = "Potpis nije valjan!";
                        labelSignatureStatus.ForeColor = Color.Red;
                        labelSignatureStatus.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    if (ex is CryptographicException || ex is System.FormatException)
                    {
                        string message = "Učitane datoteke nisu valjane!";
                        string caption = "Signature Error";
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
            }
            else
            {
                string message = "Niste učitali sve potrebne podatke za provjeru potpisa!";
                string caption = "Input Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
