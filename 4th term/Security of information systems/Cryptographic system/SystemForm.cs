using System;
using System.Windows.Forms;
using Cryptographic_system.Lab1.Forms;
using Cryptographic_system.Lab2.Forms;

namespace Cryptographic_system
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

        private void SystemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}