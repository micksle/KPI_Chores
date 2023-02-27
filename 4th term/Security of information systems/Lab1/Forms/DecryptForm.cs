using System;
using System.IO;
using System.Windows.Forms;
using Security_of_information_systems.MainCode;

namespace Security_of_information_systems.Forms
{
    public partial class DecryptForm : Form
    {
        private static string TargetString;
        public DecryptForm()
        {
            InitializeComponent();
            if (DecryptTextField.Text == "")
            {
                DecryptButton.Enabled = false;
                SaveFileButton.Enabled = false;
                BruteDecrypt.Enabled = false;
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
            var caesarCipher = new CaesarCipher();
            caesarCipher.DoAction(TargetString, encryptingKey, false);
            DecryptTextField.Text = caesarCipher.FinalString;
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var filename = saveFileDialog.FileName;
            File.WriteAllText(filename, DecryptTextField.Text);
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
                TargetString = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void DecryptTextField_TextChanged(object sender, EventArgs e)
        {if (Text.Length == 0)
            {
                DecryptButton.Enabled = false;
                SaveFileButton.Enabled = false;
                BruteDecrypt.Enabled = false;
            }
            else
            {
                DecryptButton.Enabled = true;
                SaveFileButton.Enabled = true;
                BruteDecrypt.Enabled = true;
            }

            TargetString = DecryptTextField.Text;
        }

        private void BruteDecrypt_Click(object sender, EventArgs e)
        {
            string toFind = null;
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                toFind = File.ReadAllText(openFileDialog.FileName);
            }

            if (!string.IsNullOrEmpty(toFind))
            {
                var caesarCipher = new CaesarCipher();
                caesarCipher.BruteForce(TargetString, toFind);
                DecryptTextField.Text = caesarCipher.FinalString;   
            }
            else
            {
                MessageBox.Show("Error, can`t decrypt the null value");
            }
        }
    }
}