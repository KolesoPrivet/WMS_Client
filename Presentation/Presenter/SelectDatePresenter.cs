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
        public static List<Sensor> FinalList { get; set; }

        public event Action StartClosing;

        public SelectDatePresenter()
        {
            FinalList = new List<Sensor>();
        }

        public static IEnumerable<DateTime> GetDates(int selectedSensorIdParam)
        {
            foreach(var date in DataRepository.DataFilter( d => d.Id == selectedSensorIdParam ))
            {
                yield return date.Date;
            }
        }

        public void Run(IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            view.ShowDialog();
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
