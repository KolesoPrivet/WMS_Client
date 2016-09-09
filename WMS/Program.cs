using System;
using System.Windows.Forms;
using ViewPresenter = UI.ViewFactory.Client.View;
using DomainModel.Entity;
using DomainModel.Abstract;
using Ninject;
using DomainModel.Concrete;
using UI.ViewFactory.Concrete;

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
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IRepository<Sensor>>().To<EFSensorRepository>();
            ninjectKernel.Bind<IRepository<Data>>().To<EFDataRepository>();
            
            IRepository<Sensor> sensorRepository = ninjectKernel.Get<IRepository<Sensor>>();
            IRepository<Data> dataRepository = ninjectKernel.Get<IRepository<Data>>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ViewPresenter view = new ViewPresenter( new MainFactory(), sensorRepository, dataRepository );
            view.Run();
        }
    }
}
