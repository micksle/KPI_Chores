using System;
using System.Windows.Forms;

namespace Lab1_Alt.Forms
{
    public partial class KeyForm : Form
    {
        private static string EncryptingKey { get; set; }
        public bool Encrypt { get; set; } = true;
        
        public KeyForm()
        {
            InitializeComponent();
            CodePanel.AutoSize = false;
            TextPanel.AutoSize = false;
            Accept_Button.Enabled = false;
        }

        private void keyBox_TextChanged(object sender, EventArgs e)
        {
            if (keyBox.Text.Length == 0 || !int.TryParse(keyBox.Text, out _))
                Accept_Button.Enabled = false;
            else
                Accept_Button.Enabled = true;
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            EncryptingKey = keyBox.Text;

            if (Encrypt)
            {
                mainForm.Show();
                mainForm.Encrypt(EncryptingKey);
                Close();
            }
            else
            {
                mainForm.Show();
                mainForm.Decrypt(EncryptingKey);
                Close();
            }
        }
    }
}