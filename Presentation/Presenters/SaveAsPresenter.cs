using Presentation.Common;
using DomainModel.Abstract;
using DomainModel.Entity;
using System.Collections.Generic;
using System;
using DomainModel.Extentions;

namespace Presentation.Presenters
{
    public class SaveAsPresenter : IPresenter
    {
        private IView view;
        public IView View
        {
            get { return view; }
            set
            {
                if (view != null)
                    return;

                view = value;
            }
        }

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

        public void Run(IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            view.ShowDialog();
        }
    }
}
