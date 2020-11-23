using System;
using System.Windows.Forms;

namespace MVC_IP_CW
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SpiderWeb SW = new SpiderWeb();
            Favourites FV = new Favourites();

            var f1 = new firstPage();
            f1.SpiderWeb = SW;
            f1.Favourites = FV;
            f1.ShowDialog();
        }
    }
}
