using System.Collections.Generic;

using Presentation.Common;

using DomainModel.Abstract;
using DomainModel.Entity;

namespace Presentation.Presenters
{
    public class SaveAsPresenter : Presenter
    {
        public static List<Data> FinalList { get; private set; }

        public SaveAsPresenter()
        {
            FinalList = new List<Data>();
        }

        

        public override void Run(IView viewParam,IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            View = viewParam;

            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            View.ShowDialog();
        }
    }
}
