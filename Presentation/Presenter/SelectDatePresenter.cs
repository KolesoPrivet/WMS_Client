using Presentation.Common;
using System;
using DomainModel.Abstract;
using DomainModel.Entity;
using Presentation.Views;
using System.Collections.Generic;
using DomainModel.Extentions;

namespace Presentation.Presenter
{
    public class SelectDatePresenter : IPresenter
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
        public static List<Data> FinalList { get; private set; }

        public SelectDatePresenter()
        {
            FinalList = new List<Data>();
        }

        public static IEnumerable<DateTime> GetDates(int selectedSensorIdParam)
        {
            foreach (var data in DataRepository.Filter( d => d.SensorId == selectedSensorIdParam ))
            {
                yield return data.Date;
            }
        }

        public static IEnumerable<TimeSpan> GetTime(TimeSpan firstTime, TimeSpan secondTime)
        {
            foreach (var data in DataRepository.Filter( d => d.Time >= firstTime && d.Time <= secondTime ))
            {
                yield return data.Time;
            }
        }

        public static IEnumerable<Data> GetData(IEnumerable<DateTime> dates)
        {
            foreach (var date in dates)
            {
                foreach (var data in DataRepository.Filter( d => d.Date == date))
                {
                    yield return data;
                }
            }
        }

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

        public void Run(IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            view.ShowDialog();
        }
    }
}
