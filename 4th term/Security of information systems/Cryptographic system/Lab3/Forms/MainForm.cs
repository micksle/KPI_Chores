using System;
using System.IO;
using System.Windows.Forms;
using Cryptographic_system.Lab3.MainCode;
using Cryptographic_system.Main;

namespace Cryptographic_system.Lab3.Forms
{
    public partial class MainForm : Form
    {
        private static string targetString; // string to cipher
        private static string seed; // variable for storing A value
        private static bool[] counter = new bool[2]; // Indicator whether Encrypt/Decrypt should be enabled

        public MainForm()
        {
            InitializeComponent();
            
            encryptToolStripMenuItem.Enabled = false;
            encryptToolStripMenuItem1.Enabled = false;
            decryptToolStripMenuItem.Enabled = false;
            decryptToolStripMenuItem1.Enabled = false;
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
            saveFileDialog.Filter = @"Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var filename = saveFileDialog.FileName;
            File.WriteAllText(filename, TextBox.Text);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Text = null;
            SeedField.Text = null;
            targetString = null;
            encryptToolStripMenuItem.Visible = false;
            decryptToolStripMenuItem.Visible = false;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var systemForm = new SystemForm();
            systemForm.Show();
            Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void designerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"
         Personal info:

        Name: Yaroslav
        Surname: Kalinin
        Group: TP-12");
        }

        private void encryptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var gammaCipher = new GammaCipher();
            gammaCipher.DoAction(targetString, seed, true);

            TextBox.Text = gammaCipher.FinalString;
            gammaCipher.FinalString = "";
        }

        private void decryptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var gammaCipher = new GammaCipher();
            gammaCipher.DoAction(targetString, seed, false);

            TextBox.Text = gammaCipher.FinalString;
            gammaCipher.FinalString = "";
        }

        private void expandControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encryptToolStripMenuItem.Visible = true;
            decryptToolStripMenuItem.Visible = true;
        }

        private void hideControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encryptToolStripMenuItem.Visible = false;
            decryptToolStripMenuItem.Visible = false;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox.Text))
                counter[0] = false;
            else
                counter[0] = true;

            TryToEnable();
            targetString = TextBox.Text;
        }

        private void Seed_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SeedField.Text) || !int.TryParse(SeedField.Text, out _))
            {
                counter[1] = false;
            }
            else
            {
                seed = SeedField.Text;
                counter[1] = true;
            }

            TryToEnable();
        }
        
        private void TryToEnable() // method to enable Encrypt/Decrypt buttons
        {
            if (IsActive())
            {
                encryptToolStripMenuItem.Enabled = true;
                decryptToolStripMenuItem.Enabled = true;
                encryptToolStripMenuItem1.Enabled = true;
                decryptToolStripMenuItem1.Enabled = true;
            }
            else
            {
                encryptToolStripMenuItem.Enabled = false;
                decryptToolStripMenuItem.Enabled = false;
                encryptToolStripMenuItem1.Enabled = false;
                decryptToolStripMenuItem1.Enabled = false;
            }
        }

        private static bool IsActive() // method to count whether the Encrypt/Decrypt buttons should be enabled
        {
            return counter[0] && counter[1];
        }
    }
}