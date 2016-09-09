using Presentation.Common;
using System;
using DomainModel.Abstract;
using DomainModel.Entity;
using System.Collections.Generic;
using DomainModel.Extentions;

namespace Presentation.Presenters
{
    public class SelectDatePresenter : Presenter
    {
        public static List<Data> FinalList { get; private set; }

        public SelectDatePresenter()
        {
            FinalList = new List<Data>();
        }

        public IEnumerable<TimeSpan> GetTime(TimeSpan firstTime, TimeSpan secondTime)
        {
            foreach (var data in DataRepository.Filter( d => d.Time >= firstTime && d.Time <= secondTime ))
            {
                yield return data.Time;
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
