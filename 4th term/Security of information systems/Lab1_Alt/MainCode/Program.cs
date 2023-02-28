using System;
using System.Windows.Forms;
using Lab1_Alt.Forms;

namespace Lab1_Alt.MainCode
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}