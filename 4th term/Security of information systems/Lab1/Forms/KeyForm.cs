using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Security_of_information_systems.Forms
{
    public partial class KeyForm : Form
    {
        public KeyForm()
        {
            InitializeComponent();
            this.CodePanel.AutoSize = false;
            this.TextPanel.AutoSize = false;
            Accept.Enabled = false;
        }

        private void keyBox_TextChanged(object sender, EventArgs e)
        {
            if (keyBox.Text.Length == 0 || !byte.TryParse(keyBox.Text, out _))
                Accept.Enabled = false;
            else
                Accept.Enabled = true;
        }

        public static string encryptingKey = null;

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            EncryptForm encryptForm = new EncryptForm();

            string targetString = EncryptForm.targetString;
            encryptingKey = keyBox.Text;

            encryptForm.Show();
            encryptForm.Encrypt(encryptingKey);
            this.Hide();
        }
    }
}
