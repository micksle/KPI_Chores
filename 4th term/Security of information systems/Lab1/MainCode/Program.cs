using System;
using System.Windows.Forms;
using Security_of_information_systems.Forms;

namespace Security_of_information_systems.MainCode
{
    internal class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}