using System;
using System.Windows.Forms;

namespace WMS.WinFormsClient
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

            View view = new View( new MainFactory()); // class name View
            view.Run();
        }
    }
}
