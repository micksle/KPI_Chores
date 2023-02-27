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
            var saveFileDialog= new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Test files|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
                using (var sw = new StreamWriter(saveFileDialog.FileName, true))
                {
                    sw.WriteLine(SaveFIleTextField.Text);
                    sw.Close();
                }
        }

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }
    }
}
