﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Security_of_information_systems
{
    public partial class CreateFileForm : Form
    {
        MainForm mainForm = new MainForm();
        public CreateFileForm()
        {
            InitializeComponent();
        }

        private void Create_file_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog= new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Test files|*.txt";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog.FileName.Length > 0)
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, true))
                {
                    sw.WriteLine(SaveFIleTextField.Text);
                    sw.Close();
                    MessageBox.Show("File saved successfully");
                }
            this.Close();
            mainForm.Show();
        }

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void CreateFileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
