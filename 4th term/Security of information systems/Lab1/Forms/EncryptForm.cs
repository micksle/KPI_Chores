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

        private void Save_file_button_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                EncryptTextField.Text = File.ReadAllText(openFileDialog.FileName);
                targetString = File.ReadAllText(openFileDialog.FileName);
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
            // var caesarsCipher = new CaesarsCipher();
            var caesarsCipher = new CaesarNew();
            caesarsCipher.DoAction(targetString, encryptingKey, true);
            EncryptTextField.Text = caesarsCipher.FinalString;
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
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Test files|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
                using (var sw = new StreamWriter(saveFileDialog.FileName, true))
                {
                    sw.WriteLine(EncryptTextField.Text);
                    sw.Close();
                }
        }
    }
}