using System.Collections.Generic;

using DomainModel.Abstract;
using DomainModel.Entity;
using DomainModel.Extentions;

using Presentation.Common;

namespace Presentation.Presenters
{
    public class SelectSensorsPresenter : Presenter
    {

        public static List<Sensor> FinalList { get; set; }

        public SelectSensorsPresenter()
        {
            FinalList = new List<Sensor>();
        }

        public IEnumerable<Sensor> GetSensorsByName(string sensorNameParam)
        {
            foreach (var s in SensorRepository.Filter( s => s.Name == sensorNameParam ))
            {
                yield return s;
            }
        }

        public override void Run(IView viewParam, IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            View = viewParam;

            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            View.ShowDialog();
        }
    }
}
