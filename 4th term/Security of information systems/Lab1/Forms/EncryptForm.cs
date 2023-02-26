using Security_of_information_systems.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace Security_of_information_systems
{
    public partial class EncryptForm : Form
    {
        public static string targetString;
        public EncryptForm()
        {
            InitializeComponent();
            if (EncryptTextField.Text == "" || EncryptTextField == null)
            {
                Encrypt_button.Enabled = false;
                EncryptSaveFileButton.Enabled = false;
            }
        }

        private void Save_file_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                EncryptTextField.Text = File.ReadAllText(openFileDialog.FileName);
                targetString = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void Encrypt_Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        public static string encryptingKey;

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            KeyForm keyForm = new KeyForm(); 
            keyForm.Show();
            this.Hide();
        }

        public void Encrypt(string encryptingKey)
        {
            CaesarsCipher caesarsCipher = new CaesarsCipher();
            caesarsCipher.DoAction(targetString, encryptingKey, true);
            EncryptTextField.Text = caesarsCipher.finalString;
        }

        private void EncryptFIleTextField_TextChanged(object sender, EventArgs e)
        {
             if (this.Text.Length == 0)
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Test files|*.txt";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog.FileName.Length > 0)
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, true))
                {
                    sw.WriteLine(EncryptTextField.Text);
                    sw.Close();
                    // MessageBox.Show("File saved successfully");
                }
        }
    }
}
