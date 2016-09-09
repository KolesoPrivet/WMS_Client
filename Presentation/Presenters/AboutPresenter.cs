using System;
using DomainModel.Abstract;
using DomainModel.Entity;
using Presentation.Common;

namespace Presentation.Presenters
{
    public class AboutPresenter : Presenter
    {
        public override void Run(IView viewParam, IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            View = viewParam;

            View.ShowDialog();
        }
    }
}
