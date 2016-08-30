using System;
using System.Windows.Forms;
using UI.View;
using Presentation.Presenter;

namespace Presentation
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

            var presenter = new MainPresenter(new MainForm());
            presenter.Run();
        }
    }
}
