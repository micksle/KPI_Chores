using System;
using System.IO;
using System.Windows.Forms;

namespace Security_of_information_systems.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Decrypt_button_Click(object sender, EventArgs e)
        {
            Hide();
            var decryptForm = new DecryptForm();
            decryptForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private string userName = "Yaroslav";
        private string userSurname = "Kalinin";
        private string userGroup = "12";
        private void Info_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"   Personal info:\n\nName: {userName}\nSurname: {userSurname}\nGroup: TP-{userGroup}");
        }
        private void Create_file_button_Click(object sender, EventArgs e)
        {
            Hide();
            var createFileForm = new CreateFileForm();
            createFileForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            var encryptForm = new EncryptForm();
            encryptForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
            //e.Cancel = true;
        }
    }
}
