using System;
using System.Windows.Forms;

namespace Cryptographic_system.Lab1.Forms
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

            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                {if (e.KeyValue == (char)Keys.Enter) Accept_Button_Click(Accept_Button, null);}
            };
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

        private void Accept_Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char) Keys.Enter)
            {
                Accept_Button.PerformClick();
                //Accept_Button_Click(Accept_Button, null);
            }
        }
    }
}