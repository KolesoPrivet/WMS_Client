using System.Collections.Generic;

using DomainModel.Abstract;
using DomainModel.Entity;

using Presentation.Common;

namespace Presentation.Presenters
{
    public class SelectSensorsPresenter : Presenter
    {
        public override void Run(IView viewParam, IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            View = viewParam;

            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            View.ShowDialog();
        }
    }
}
