using System;
using System.IO;
using System.Windows.Forms;
using Cryptographic_system.Lab2.MainCode;

namespace Cryptographic_system.Lab2.Forms
{
    public partial class MainForm : Form
    {
        private static CaesarCipher caesarCipher;
        private static TrithemiusCipher trithemiusCipher;
        private static string targetString;
        private static string key1;
        private static string key2;
        private static string key3;

        public MainForm()
        {
            InitializeComponent();

            if (TextBox.Text == "")
            {
                encryptToolStripMenuItem.Enabled = false;
                decryptToolStripMenuItem.Enabled = false;
            }

            Key1.AutoSize = false;
            Key2.AutoSize = false;
            Key3.AutoSize = false;
            Key1.Height = 30;
            Key2.Height = 30;
            Key3.Height = 30;
        }

        private void designerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"
         Personal info:

        Name: Yaroslav
        Surname: Kalinin
        Group: TP-12");
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var filename = saveFileDialog.FileName;
            File.WriteAllText(filename, TextBox.Text);
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
            Key1.Text = "";
            Key2.Text = "";
            Key3.Text = "";
            targetString = null;
            key1 = null;
            key2 = null;
            key3 = null;
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trithemiusCipher.DoAction(targetString, key1, key2, key3, 2, true);
            TextBox.Text = trithemiusCipher.FinalString;
            trithemiusCipher.FinalString = "";
        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trithemiusCipher.DoAction(targetString, key1, key2, key3, 2, false);
            TextBox.Text = trithemiusCipher.FinalString;
            trithemiusCipher.FinalString = "";
        }

        private void Key1_TextChanged(object sender, EventArgs e)
        {
            if (Key1.Text.Length == 0 || !int.TryParse(Key1.Text, out _))
            {
                encryptToolStripMenuItem.Enabled = false;
                decryptToolStripMenuItem.Enabled = false;
            }
            else
            {
                key1 = Key1.Text;
                encryptToolStripMenuItem.Enabled = true;
                decryptToolStripMenuItem.Enabled = true;
            }
        }

        private void Key2_TextChanged(object sender, EventArgs e)
        {
            if (Key2.Text.Length == 0 || !int.TryParse(Key2.Text, out _))
            {
                encryptToolStripMenuItem.Enabled = false;
                decryptToolStripMenuItem.Enabled = false;
            }
            else
            {
                key2 = Key2.Text;
                encryptToolStripMenuItem.Enabled = true;
                decryptToolStripMenuItem.Enabled = true;
            }
        }

        private void Key3_TextChanged(object sender, EventArgs e)
        {
            if (Key3.Text.Length == 0 || !int.TryParse(Key3.Text, out _))
            {
                encryptToolStripMenuItem.Enabled = false;
                decryptToolStripMenuItem.Enabled = false;
            }
            else
            {
                key3 = Key3.Text;
                encryptToolStripMenuItem.Enabled = true;
                decryptToolStripMenuItem.Enabled = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            targetString = TextBox.Text;
        }
    }
}