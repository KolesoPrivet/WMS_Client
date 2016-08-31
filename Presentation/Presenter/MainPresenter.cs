using DomainModel.Abstract;
using DomainModel.Entity;
using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Presenter
{
    public class MainPresenter : IPresenter
    {
        private readonly IView view;
        private static ISensorRepository sensorRepository;

        public MainPresenter(IView viewParam)
        {
            view = viewParam;
        }

        public void Run()
        {
            view.Show();
        }

        public static List<Sensor> GetSensorsListAsync(ISensorRepository sensorRepositoryParam)
        {
            sensorRepository = sensorRepositoryParam;

            return sensorRepositoryParam.Sensors.ToList();
        }

        public static List<Data> GetDataListAsync(IDataRepository dataRepositoryParam)
        {
            return (from c in dataRepositoryParam.Data
                    where c.SensorId == sensorRepository.Sensors.FirstOrDefault().SensorId
                    orderby c.Date
                    select c).ToList();
        }
    }
}
