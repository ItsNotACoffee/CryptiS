using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptiS
{
    public partial class formGenerateKeys : Form
    {
        public formGenerateKeys()
        {
            InitializeComponent();
            setAsymmetricComponentVisibility(false);
            setSymmetricComponentVisibility(false);
        }

        private void setAsymmetricComponentVisibility(Boolean visibility)
        {
            labelAsymmetricPublicFile.Visible = visibility;
            labelAsymmetricPublicKey.Visible = visibility;
            textAsymmetricPublicFile.Visible = visibility;
            richTextAsymmetricPublicKey.Visible = visibility;

            labelAsymmetricPrivateFile.Visible = visibility;
            labelAsymmetricPrivateKey.Visible = visibility;
            textAsymmetricPrivateFile.Visible = visibility;
            richTextAsymmetricPrivateKey.Visible = visibility;
        }

        private void setSymmetricComponentVisibility(Boolean visibility)
        {
            labelSymmetricFile.Visible = visibility;
            labelSymmetricKey.Visible = visibility;
            textSymmetricFile.Visible = visibility;
            textSymmetricKey.Visible = visibility;
        }

        private void btnAsymmetricGenerate_Click(object sender, EventArgs e)
        {
            //generate keys
            Cursor.Current = Cursors.WaitCursor;
            Cryptography.Asymmetric.CreateKeys(out var publicKey, out var privateKey);
            richTextAsymmetricPrivateKey.Text = privateKey;
            richTextAsymmetricPublicKey.Text = publicKey;
            Cursor.Current = Cursors.Default;

            //write to file
            WorkingDir.save(privateKey, "privatni_kljuc.txt");
            WorkingDir.save(publicKey, "javni_kljuc.txt");
            textAsymmetricPrivateFile.Text = WorkingDir.directory + "\\" + "privatni_kljuc.txt";
            textAsymmetricPublicFile.Text = WorkingDir.directory + "\\" + "javni_kljuc.txt";

            setAsymmetricComponentVisibility(true);
        }

        private void btnSymmetricGenerate_Click(object sender, EventArgs e)
        {
            string key = Cryptography.Symmetric.CreateKey();
            WorkingDir.save(key, "tajni_kljuc.txt");
            textSymmetricKey.Text = key;
            textSymmetricFile.Text = WorkingDir.directory + "\\" + "tajni_kljuc.txt";

            setSymmetricComponentVisibility(true);
        }
    }
}
