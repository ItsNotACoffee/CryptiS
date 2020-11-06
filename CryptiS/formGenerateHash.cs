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
    public partial class formGenerateHash : Form
    {
        public formGenerateHash()
        {
            InitializeComponent();
        }

        private void btnCalculateHash_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                string rawData = File.ReadAllText(fileName);
                string readableHash = Cryptography.Hash.calculate(rawData);
                textHash.Text = readableHash;
                WorkingDir.save(readableHash, "hash.txt");
            }
            else
            {
                string message = "Niste odabrali datoteku!";
                string caption = "Input Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        public string fileName;

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                fileName = ofdFile.FileName;
                string splt = ofdFile.FileName.Split('\\').Last();
                textFile.Text = splt;
            }
        }
    }
}
