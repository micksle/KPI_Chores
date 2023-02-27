using System;
using System.IO;
using System.Windows.Forms;

namespace Security_of_information_systems.Forms
{
    public partial class CreateFileForm : Form
    {
        private MainForm mainForm = new MainForm();

        public CreateFileForm()
        {
            InitializeComponent();
        }

        private void Create_file_button_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var filename = saveFileDialog.FileName;
            File.WriteAllText(filename, SaveFIleTextField.Text);
        }

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }
    }
}