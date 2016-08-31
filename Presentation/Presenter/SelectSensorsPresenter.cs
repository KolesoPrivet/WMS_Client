using DomainModel.Abstract;
using DomainModel.Entity;
using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using DomainModel.Extentions;
using Presentation.Views;

namespace Presentation.Presenter
{
    public class SelectSensorsPresenter : IPresenter
    {
        private readonly IViewSelectSensors view;
        public static ISensorRepository SensorRepository { get; private set; }
        public static IDataRepository DataRepository { get; private set; }
        public static List<Sensor> FinalList { get; set; }

        public static event Action StartClosing;

        public SelectSensorsPresenter(IViewSelectSensors viewParam)
        {
            view = viewParam;
            FinalList = new List<Sensor>();
        }

        static SelectSensorsPresenter() { }

        public void Run()
        {
            view.ShowDialog();
        }

        public void Run(ISensorRepository sensorRepositoryParam, IDataRepository dataRepositoryParam)
        {
            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            view.ShowDialog();
        }
        public static IEnumerable<string> GetSensorsByType(string sensorTypeParam)
        {
            var names = (from s in SensorRepository.GetAllSensors()
                         where s.SensorType == sensorTypeParam
                         select s).ToList();

            foreach (var name in names)
            {
                yield return name.Name;
            }
        }

        public static IEnumerable<Sensor> GetSensorsByName(IEnumerable<string> sensorNameParam)
        {
            var sensors = (from s in SensorRepository.Sensors
                           from t in sensorNameParam
                           where s.Name == t
                           select s);

            foreach (var s in sensors)
            {
                yield return s;
            }
        }

        //public static List<Sensor> GetSensorsByName1(List<string> sensorNameParam)
        //{
        //    foreach(var s in sensorNameParam)
        //    {

        //    }
        //    return (from s in SensorRepository.Sensors
        //            where s.Name == sensorNameParam.
        //            select s).ToList();
        //}

        public static IEnumerable<string> GetSensorsNames()
        {
            foreach (var s in SensorRepository.Sensors)
            {
                yield return s.Name;
            }
        }

        public static IEnumerable<string> GetSensorsTypes()
        {
            foreach (var s in SensorRepository.Sensors)
            {
                yield return s.SensorType;
            }
        }

        public static void Invoke()
        {
            if (StartClosing != null)
            {
                StartClosing();
            }
        }
    }
}
