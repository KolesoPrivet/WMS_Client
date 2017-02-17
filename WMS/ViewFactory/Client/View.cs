using Presentation.Common;

using UI.ViewFactory.Abstract;

namespace UI.ViewFactory.Client
{
    class View
    {
        private readonly Presenter _concretePresenter;

        private readonly IView _concreteView;

        public View(Factory factory)
        {
            _concreteView = factory.CreateView();
            _concretePresenter = factory.CreatePresenter();
        }   

        public void Run()
        {
            _concreteView.OwnPresenter = _concretePresenter;
            _concretePresenter.Run( _concreteView);
        }

        public void Run(int sensorIdParam)
        {
            _concretePresenter.SensorId = sensorIdParam;
            Run();
        }
    }
}
