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

        public static IEnumerable<Sensor> GetSensorsByName(string sensorNameParam)
        {
            foreach (var s in SensorRepository.Filter( s => s.Name == sensorNameParam ))
            {
                yield return s;
            }
        }

        public static IEnumerable<string> GetSensorsNames()
        {
            foreach (var s in SensorRepository.Get)
            {
                yield return s.Name;
            }
        }

        public static IEnumerable<string> GetSensorsNames(string sensorTypeParam)
        {
            foreach (var sensor in SensorRepository.Filter( s => s.SensorType == sensorTypeParam ))
            {
                yield return sensor.Name;
            }
        }

        public static IEnumerable<string> GetSensorsTypes()
        {
            foreach (var s in SensorRepository.Get)
            {
                yield return s.SensorType;
            }
        }

        public override void Run(IView viewParam, IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            View = viewParam;
            View.FormClosed += (s, ev) => 

            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            View.ShowDialog();
        }
    }
}
