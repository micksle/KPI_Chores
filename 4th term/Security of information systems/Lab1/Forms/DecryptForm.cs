using System;
using System.IO;
using System.Windows.Forms;
using Security_of_information_systems.MainCode;

namespace Security_of_information_systems.Forms
{
    public partial class DecryptForm : Form
    {
        public static string targetString;
        public DecryptForm()
        {
            InitializeComponent();
            if (DecryptTextField.Text == "")
            {
                DecryptButton.Enabled = false;
                SaveFileButton.Enabled = false;
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            Close();
            var keyForm = new KeyForm();
            keyForm.Encrypt = false;
            keyForm.Show();
        }
        
        public void Decrypt(string encryptingKey)
        {
            var caesarsCipher = new CaesarsCipher();
            caesarsCipher.DoAction(targetString, encryptingKey, false);
            DecryptTextField.Text = caesarsCipher.finalString;
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Test files|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
                using (var sw = new StreamWriter(saveFileDialog.FileName, true))
                {
                    sw.WriteLine(DecryptTextField.Text);
                    sw.Close();
                }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            var mainForm = new MainForm();
            mainForm.Show();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DecryptTextField.Text = File.ReadAllText(openFileDialog.FileName);
                targetString = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void DecryptTextField_TextChanged(object sender, EventArgs e)
        {if (Text.Length == 0)
            {
                DecryptButton.Enabled = false;
                SaveFileButton.Enabled = false;
            }
            else
            {
                DecryptButton.Enabled = true;
                SaveFileButton.Enabled = true;
            }

            targetString = DecryptTextField.Text;
        }
    }
}