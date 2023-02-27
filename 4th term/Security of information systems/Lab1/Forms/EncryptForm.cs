using System;
using System.IO;
using System.Windows.Forms;
using Security_of_information_systems.MainCode;

namespace Security_of_information_systems.Forms
{
    public partial class EncryptForm : Form
    {
        public static string targetString;

        public EncryptForm()
        {
            InitializeComponent();
            if (EncryptTextField.Text == "")
            {
                Encrypt_button.Enabled = false;
                EncryptSaveFileButton.Enabled = false;
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                EncryptTextField.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void Encrypt_Back_button_Click(object sender, EventArgs e)
        {
            Close();
            var mainForm = new MainForm();
            mainForm.Show();
        }

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            Close();
            var keyForm = new KeyForm();
            keyForm.Show();
        }

        public void Encrypt(string encryptingKey)
        {
            var caesarCipher = new CaesarCipher();
            caesarCipher.DoAction(targetString, encryptingKey, true);
            EncryptTextField.Text = caesarCipher.FinalString;
        }

        private void EncryptFIleTextField_TextChanged(object sender, EventArgs e)
        {
            if (Text.Length == 0)
            {
                Encrypt_button.Enabled = false;
                EncryptSaveFileButton.Enabled = false;
            }
            else
            {
                Encrypt_button.Enabled = true;
                EncryptSaveFileButton.Enabled = true;
            }

            targetString = EncryptTextField.Text;
        }

        private void EncryptSaveFileButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var filename = saveFileDialog.FileName;
            File.WriteAllText(filename, EncryptTextField.Text);
        }
    }
}