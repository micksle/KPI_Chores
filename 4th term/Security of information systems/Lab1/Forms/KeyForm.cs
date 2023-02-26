using System;
using System.Windows.Forms;

namespace Security_of_information_systems.Forms
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
            Accept.Enabled = false;
        }

        private void keyBox_TextChanged(object sender, EventArgs e)
        {
            if (keyBox.Text.Length == 0 || !byte.TryParse(keyBox.Text, out _))
                Accept.Enabled = false;
            else
                Accept.Enabled = true;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var encryptForm = new EncryptForm();
            var decryptForm = new DecryptForm();
            EncryptingKey = keyBox.Text;

            if (Encrypt)
            {
                encryptForm.Show();
                encryptForm.Encrypt(EncryptingKey);
                Close();
            }
            else
            {
                decryptForm.Show();
                decryptForm.Decrypt(EncryptingKey);
                Close();
            }
        }
    }
}
