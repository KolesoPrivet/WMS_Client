using DomainModel.Abstract;
using DomainModel.Entity;

using Presentation.Common;

using UI.ViewFactory.Abstract;

namespace UI.ViewFactory.Client
{
    class View
    {
        private readonly Presenter _concretePresenter;

        private readonly IView _concreteView;

        private readonly IRepository<Sensor> _sensorRepository;
        private readonly IRepository<Data> _dataRepository;

        public View(Factory factory)
        {
            _concreteView = factory.CreateView();
            _concretePresenter = factory.CreatePresenter();
        }

        public View(Factory factory, IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepoitoryParam) : this( factory )
        {
            _sensorRepository = sensorRepositoryParam;
            _dataRepository = dataRepoitoryParam;
        }

        public void Run()
        {
            _concreteView.OwnPresenter = _concretePresenter;
            _concretePresenter.Run( _concreteView, _sensorRepository, _dataRepository );
        }

        public void Run(int sensorIdParam)
        {
            _concretePresenter.SensorId = sensorIdParam;
            Run();
        }
    }
}
