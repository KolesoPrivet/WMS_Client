using System;
using System.Collections.Generic;

using DomainModel.Abstract;
using DomainModel.Entity;
using DomainModel.Extentions;

using Presentation.Common;
using Presentation.Views;

namespace Presentation.Presenter
{
    public class SelectSensorsPresenter : IPresenter
    {
        private IViewSelection view;
        public IViewSelection View
        {
            get { return view; }
            set
            {
                if (view != null)
                    return;

                view = value;
            }
        }

        public static IRepository<Sensor> SensorRepository { get; private set; }
        public static IRepository<Data> DataRepository { get; private set; }
        public static List<Sensor> FinalList { get; set; }

        public event Action StartClosing;

        public SelectSensorsPresenter()
        {
            FinalList = new List<Sensor>();
        }

        public void Run(IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            view.ShowDialog();
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
            foreach (var name in SensorRepository.Filter( s => s.SensorType == sensorTypeParam ))
            {
                yield return name.Name;
            }
        }

        public static IEnumerable<string> GetSensorsTypes()
        {
            foreach (var s in SensorRepository.Get)
            {
                yield return s.SensorType;
            }
        }

        public void Invoke()
        {
            if (StartClosing != null)
            {
                StartClosing();
            }
        }
    }
}
