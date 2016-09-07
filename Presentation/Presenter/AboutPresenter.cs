using DomainModel.Abstract;
using DomainModel.Entity;
using Presentation.Common;

namespace Presentation.Presenter
{
    public class AboutPresenter
    {
        private readonly IView view;

        public AboutPresenter(IView viewParam)
        {
            view = viewParam;
        }

        public void Run(IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            view.Show( sensorRepositoryParam, dataRepositoryParam );
        }
    }
}
