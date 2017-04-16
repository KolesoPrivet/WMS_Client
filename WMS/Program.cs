using System;
using System.Windows.Forms;

using ViewPresenter = WMS.WinformsClient.ViewFactory.Client.View;

using WMS.WinformsClient.ViewFactory.Concrete;

namespace WMS.WinformsClient
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

            ViewPresenter view = new ViewPresenter( new MainFactory()); // class name View
            view.Run();
        }
    }
}
