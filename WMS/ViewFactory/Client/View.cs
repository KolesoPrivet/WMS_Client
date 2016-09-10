using DomainModel.Abstract;
using DomainModel.Entity;

using Presentation.Common;

using UI.ViewFactory.Abstract;

namespace UI.ViewFactory.Client
{
    class View
    {
        private readonly Presenter concretePresenter;
        private readonly IView concreteView;

        private readonly IRepository<Sensor> sensorRepository;
        private readonly IRepository<Data> dataRepository;

        public View(Factory factory)
        {
            concreteView = factory.CreateView();
            concretePresenter = factory.CreatePresenter();
        }

        public View(Factory factory, IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepoitoryParam) : this( factory )
        {
            sensorRepository = sensorRepositoryParam;
            dataRepository = dataRepoitoryParam;
        }

        public void Run()
        {
            concreteView.OwnPresenter = concretePresenter;
            concretePresenter.Run( concreteView, sensorRepository, dataRepository );
        }

        public void Run(int sensorIdParam)
        {
            concretePresenter.SensorId = sensorIdParam;
            Run();
        }
    }
}
