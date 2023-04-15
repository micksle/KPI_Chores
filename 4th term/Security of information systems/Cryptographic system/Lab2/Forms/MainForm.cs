using System;
using System.IO;
using System.Windows.Forms;
using Cryptographic_system.Lab2.MainCode;
using Cryptographic_system.Main;

namespace Cryptographic_system.Lab2.Forms
{
    public partial class MainForm : Form
    {
        private static string targetString; // string to cipher
        private static string motto; // variable for storing - motto (key) 
        private static State state = State.NULL; // Enum - which cipher method to use
        private static string key1; // variable for storing A value
        private static string key2; // variable for storing B value
        private static string key3; // variable for storing C value 
        private static bool[] counter = new bool[6]; // Indicator whether Encrypt/Decrypt should be enabled

        public MainForm()
        {
            InitializeComponent();

            encryptToolStripMenuItem.Enabled = false;
            decryptToolStripMenuItem.Enabled = false;

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
            saveFileDialog.Filter = @"Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var filename = saveFileDialog.FileName;
            File.WriteAllText(filename, TextBox.Text);
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
            MottoBox.Text = "";
            Key1.Text = "";
            Key2.Text = "";
            Key3.Text = "";
            targetString = null;
            key1 = null;
            key2 = null;
            key3 = null;
            encryptToolStripMenuItem1.Visible = false;
            decryptToolStripMenuItem1.Visible = false;
            LinearRadio.Checked = false;
            NonLinear.Checked = false;
            Motto.Checked = false;

            for (var i = 0; i < counter.Length; i++)
            {
                counter[i] = false;
            }
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var trithemiusCipher = new TrithemiusCipher();
            trithemiusCipher.DoAction(targetString, key1, key2, key3, motto, state, true);
            TextBox.Text = trithemiusCipher.FinalString;
            trithemiusCipher.FinalString = "";
        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var trithemiusCipher = new TrithemiusCipher();
            trithemiusCipher.DoAction(targetString, key1, key2, key3, motto, state, false);
            TextBox.Text = trithemiusCipher.FinalString;
            trithemiusCipher.FinalString = "";
        }

        private void Key1_TextChanged(object sender, EventArgs e)
        {
            if (Key1.Text.Length == 0 || !int.TryParse(Key1.Text, out _))
            {
                counter[0] = false;
            }
            else
            {
                key1 = Key1.Text;
                counter[0] = true;
            }

            TryToEnable();
        }

        private void Key2_TextChanged(object sender, EventArgs e)
        {
            if (Key2.Text.Length == 0 || !int.TryParse(Key2.Text, out _))
            {
                counter[1] = false;
            }
            else
            {
                key2 = Key2.Text;
                counter[1] = true;
            }

            TryToEnable();
        }

        private void Key3_TextChanged(object sender, EventArgs e)
        {
            if (Key3.Text.Length == 0 || !int.TryParse(Key3.Text, out _))
            {
                counter[2] = false;
            }
            else
            {
                key3 = Key3.Text;
                counter[2] = true;
            }

            TryToEnable();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox.Text))
                counter[3] = false;
            else
                counter[3] = true;

            TryToEnable();
            targetString = TextBox.Text;
        }

        private void MottoBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MottoBox.Text))
                counter[5] = false;
            else
                counter[5] = true;

            TryToEnable();
            motto = MottoBox.Text;
        }

        private void LinearRadio_CheckedChanged(object sender, EventArgs e)
        {
            state = State.LINEAR;
            counter[4] = true;
            TryToEnable();
        }

        private void NonLinear_CheckedChanged(object sender, EventArgs e)
        {
            state = State.NONLINEAR;
            counter[4] = true;
            TryToEnable();
        }

        private void Motto_CheckedChanged(object sender, EventArgs e)
        {
            state = State.MOTTO;
            counter[4] = true;
            TryToEnable();
        }

        private void MainMenuStripMenuItem_Click(object sender, EventArgs e)
        {
            var systemForm = new SystemForm();
            systemForm.Show();
            Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private bool IsActive() // method to count whether the Encrypt/Decrypt buttons should be enabled
        {
            var count = 0;

            foreach (var b in counter)
            {
                if (b.Equals(true))
                {
                    count++;
                }
            }

            return count == 6;
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
    }
}