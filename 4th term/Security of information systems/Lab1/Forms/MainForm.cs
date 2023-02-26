using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Security_of_information_systems
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Decrypt_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            // DecryptionForm decryptForm = new DecryptionForm();
           // decryptForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
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
            this.Hide();
            CreateFileForm createFileForm = new CreateFileForm();
            createFileForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EncryptForm encryptForm = new EncryptForm();
            encryptForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
