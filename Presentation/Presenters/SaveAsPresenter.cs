using Presentation.Common;
using DomainModel.Abstract;
using DomainModel.Entity;
using System.Collections.Generic;
using System;
using DomainModel.Extentions;

namespace Presentation.Presenters
{
    public class SaveAsPresenter : Presenter
    {
        public static List<Data> FinalList { get; private set; }

        public SaveAsPresenter()
        {
            FinalList = new List<Data>();
        }

        //TODO: GetSensorsNames in 3 presenters!
        public static IEnumerable<string> GetSensorsNames()
        {
            foreach (var s in SensorRepository.Get)
            {
                yield return s.Name;
            }
        }

        //TODO: GetSensorsTypes in 2 presenters!
        public static IEnumerable<string> GetSensorsNames(string sensorTypeParam)
        {
            foreach (var sensor in SensorRepository.Filter( s => s.SensorType == sensorTypeParam ))
            {
                yield return sensor.Name;
            }
        }

        //TODO: GetSensorsTypes in 2 presenters!
        public static IEnumerable<string> GetSensorsTypes()
        {
            foreach (var s in SensorRepository.Get)
            {
                yield return s.SensorType;
            }
        }

        //TODO: GetDates in 2 presenters!
        public static IEnumerable<DateTime> GetDates(int selectedSensorIdParam)
        {
            foreach (var data in DataRepository.Filter( d => d.SensorId == selectedSensorIdParam ))
            {
                yield return data.Date;
            }
        }

        //TODO: GetData in 2 presenters!
        public static IEnumerable<Data> GetData(IEnumerable<DateTime> dates)
        {
            foreach (var date in dates)
            {
                foreach (var data in DataRepository.Filter( d => d.Date == date ))
                {
                    yield return data;
                }
            }
        }

        //TODO: GetData in 2 presenters!
        public static IEnumerable<Data> GetData(IEnumerable<DateTime> dates, TimeSpan firstTime, TimeSpan secondTime)
        {
            foreach (var date in dates)
            {
                foreach (var data in DataRepository.Filter( d => d.Date == date
                                                                && d.Time >= firstTime
                                                                && d.Time <= secondTime ))
                {
                    yield return data;
                }
            }
        }

        public static IRepository<Sensor> SensorRepository { get; private set; }
        public static IRepository<Data> DataRepository { get; private set; }

        public override void Run(IView viewParam,IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            View = viewParam;

            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            View.ShowDialog();
        }
    }
}
