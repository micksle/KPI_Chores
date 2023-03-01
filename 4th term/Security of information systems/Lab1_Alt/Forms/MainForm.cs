using System;
using System.IO;
using System.Windows.Forms;
using Lab1_Alt.MainCode;

namespace Lab1_Alt.Forms
{
    public partial class MainForm : Form
    {
        private CaesarCipher caesarCipher = new CaesarCipher();
        private static string targetString;
        private KeyForm keyForm = new KeyForm();

        private string userName = "Yaroslav";
        private string userSurname = "Kalinin";
        private string userGroup = "12";

        public MainForm()
        {
            InitializeComponent();
            if (TextBox.Text == "")
            {
                DecryptButton.Enabled = false;
                EncryptButton.Enabled = false;
                BruteButton.Enabled = false;
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"   Personal info:\n\nName: {userName}\nSurname: {userSurname}\nGroup: TP-{userGroup}");
        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var filename = saveFileDialog.FileName;
            File.WriteAllText(filename, TextBox.Text);
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            Hide();
            keyForm = new KeyForm();
            keyForm.Show();
        }

        public void Encrypt(string encryptingKey)
        {
            caesarCipher.DoAction(targetString, encryptingKey, true);
            TextBox.Text = caesarCipher.FinalString;
            caesarCipher.FinalString = "";
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            Hide();
            keyForm = new KeyForm();
            keyForm.Encrypt = false;
            keyForm.Show();
        }

        public void Decrypt(string encryptingKey)
        {
            caesarCipher.DoAction(targetString, encryptingKey, false);
            TextBox.Text = caesarCipher.FinalString;
            caesarCipher.FinalString = "";
        }

        private void BruteButton_Click(object sender, EventArgs e)
        {
            targetString = TextBox.Text;
            string toFind = null;
            
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                toFind = File.ReadAllText(openFileDialog.FileName);
            }

            if (!string.IsNullOrEmpty(toFind))
            {
                caesarCipher.BruteForce(targetString, toFind);
                TextBox.Text = caesarCipher.FinalString;
            }
            else
            {
                MessageBox.Show("Error, can`t decrypt the empty value");
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextBox.Text == "")
            {
                DecryptButton.Enabled = false;
                EncryptButton.Enabled = false;
                BruteButton.Enabled = false;
            }
            else
            {
                DecryptButton.Enabled = true;
                EncryptButton.Enabled = true;
                BruteButton.Enabled = true;
            }

            targetString = TextBox.Text;
        }
    }
}