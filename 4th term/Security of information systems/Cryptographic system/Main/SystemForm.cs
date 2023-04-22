using System;
using System.Windows.Forms;

namespace Cryptographic_system.Main
{
    public partial class SystemForm : Form
    {
        public SystemForm()
        {
            InitializeComponent();
        }

        private void CaesarButton_Click(object sender, EventArgs e)
        {
            var mainForm = new Lab1.Forms.MainForm();
            mainForm.Show();
            Hide();
        }

        private void TrithemiusButton_Click(object sender, EventArgs e)
        {
            var mainForm = new Lab2.Forms.MainForm();
            mainForm.Show();
            Hide();
        }

        private void GammaCipher_Click(object sender, EventArgs e)
        {
            var mainForm = new Lab3.Forms.MainForm();
            mainForm.Show();
            Hide();
        }
        
        private void SystemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}