using Presentation.Common;
using DomainModel.Abstract;
using DomainModel.Entity;
using Presentation.Views;

namespace Presentation.Presenter
{
    class SaveRepoortPresenter : IPresenter
    {
        private IViewSelection view;
        public IViewSelection View
        {
            get { return view; }
            set
            {
                if (view != null)
                    return;

                view = value;
            }
        }

        public static IRepository<Sensor> SensorRepository { get; private set; }
        public static IRepository<Data> DataRepository { get; private set; }

        public void Run(IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            view.ShowDialog();
        }
    }
}
