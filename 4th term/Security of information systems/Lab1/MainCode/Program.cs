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
            // var cs = new CaesarNew();
            // cs.DoAction("З'їв аґрусу — та ягода цілюща б'є жах інфекцій шипучим „ь“.\nThe five boxing wizards jump quickly", "1", true);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}