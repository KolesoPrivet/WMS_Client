using System;
using System.Windows.Forms;
using UI.View;
using Presentation.Presenter;
using DomainModel.Entity;
using DomainModel.Abstract;
using Ninject;
using DomainModel.Concrete;

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

            var presenter = new MainPresenter(new MainForm());
            presenter.Run(sensorRepository, dataRepository);
        }
    }
}
