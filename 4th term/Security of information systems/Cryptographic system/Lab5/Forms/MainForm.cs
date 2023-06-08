using System;
using System.IO;
using System.Windows.Forms;
using Cryptographic_system.Lab5.MainCode;
using Cryptographic_system.Main;
using CipherMode = System.Security.Cryptography.CipherMode;

namespace Cryptographic_system.Lab5.Forms
{
    public partial class MainForm : Form
    {
        private static string targetString; // string to cipher
        private static string keyValue; // variable for storing - motto (key) 
        private static bool[] counter = new bool[3]; // Indicator whether Encrypt/Decrypt should be enabled
        private static CipherMode mode = CipherMode.CBC;
        private static InitializeVector state = InitializeVector.NULL; // Enum - which cipher method to use

        public MainForm()
        {
            InitializeComponent();

            encryptToolStripMenuItem.Enabled = false;
            encryptToolStripMenuItem1.Enabled = false;
            decryptToolStripMenuItem.Enabled = false;
            decryptToolStripMenuItem1.Enabled = false;

            KeyPanel.AutoSize = false;
            KeyPanel.Height = 30;
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

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Text = null;
            KeyPanel.Text = null;
            targetString = null;
            radioButtonDes.Checked = false;
            trippleDESRadio.Checked = false;
            AesRadio.Checked = false;
            CBCRadio.Checked = false;
            ECBRadio.Checked = false;
            CFBRadio.Checked = false;
            encryptToolStripMenuItem1.Visible = false;
            decryptToolStripMenuItem1.Visible = false;

            for (var i = 0; i < counter.Length; i++)
            {
                counter[i] = false;
            }
        }

        private void MainMenuStripMenuItem_Click(object sender, EventArgs e)
        {
            var systemForm = new SystemForm();
            systemForm.Show();
            Hide();
        }

        private void designerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"
         Personal info:

        Name: Yaroslav
        Surname: Kalinin
        Group: TP-12");
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var symmetricCipher = new SymmetricCipher();

            switch (state)
            {
                case InitializeVector.DES:
                    symmetricCipher.DoAction(targetString, keyValue, InitializeVector.DES, mode, true);
                    break;
                case InitializeVector.TripleDES:
                    symmetricCipher.DoAction(targetString, keyValue, InitializeVector.TripleDES, mode, true);
                    break;
                case InitializeVector.AES:
                    symmetricCipher.DoAction(targetString, keyValue, InitializeVector.AES, mode, true);
                    break;
            }

            TextBox.Text = symmetricCipher.FinalString;
            symmetricCipher.FinalString = "";
        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var symmetricCipher = new SymmetricCipher();

            switch (state)
            {
                case InitializeVector.DES:
                    symmetricCipher.DoAction(targetString, keyValue, InitializeVector.DES, mode, false);
                    break;
                case InitializeVector.TripleDES:
                    symmetricCipher.DoAction(targetString, keyValue, InitializeVector.TripleDES, mode, false);
                    break;
                case InitializeVector.AES:
                    symmetricCipher.DoAction(targetString, keyValue, InitializeVector.AES, mode, false);
                    break;
            }

            TextBox.Text = symmetricCipher.FinalString;
            symmetricCipher.FinalString = "";
        }

        private void ExpandControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encryptToolStripMenuItem1.Visible = true;
            decryptToolStripMenuItem1.Visible = true;
        }

        private void hideControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encryptToolStripMenuItem1.Visible = false;
            decryptToolStripMenuItem1.Visible = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            if (counter[0] && counter[1] && counter[2])
            {
                return true;
            }

            return false;
        }

        private void radioButtonDes_CheckedChanged(object sender, EventArgs e)
        {
            state = InitializeVector.DES;
            counter[1] = true;
            TryToEnable();
        }

        private void trippleDESRadio_CheckedChanged(object sender, EventArgs e)
        {
            state = InitializeVector.TripleDES;
            counter[1] = true;
            TryToEnable();
        }

        private void AesRadio_CheckedChanged(object sender, EventArgs e)
        {
            state = InitializeVector.AES;
            counter[1] = true;
            TryToEnable();
        }

        private void CBCRadio_CheckedChanged(object sender, EventArgs e)
        {
            mode = CipherMode.CBC;
            counter[2] = true;
            TryToEnable();
        }

        private void ECBRadio_CheckedChanged(object sender, EventArgs e)
        {
            mode = CipherMode.ECB;
            counter[2] = true;
            TryToEnable();
        }

        private void CFBRadio_CheckedChanged(object sender, EventArgs e)
        {
            mode = CipherMode.CFB;
            counter[2] = true;
            TryToEnable();
        }
    }
}