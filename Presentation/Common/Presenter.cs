using System;
using System.Collections.Generic;

using DomainModel.Abstract;
using DomainModel.Extentions;
using DomainModel.Entity;

namespace Presentation.Common
{
    public abstract class Presenter
    {
        protected IView View { get; set; }

        public int SensorId { get; set; }

        public IRepository<Sensor> SensorRepository { get; set; }
        public IRepository<Data> DataRepository { get; set; }

        #region Methods for Sensors
        public virtual Sensor GetSensorByName(string sensorNameParam)
        {
            return SensorRepository.SingleFilter( s => s.Name == sensorNameParam );
        }

        public virtual IEnumerable<string> GetSensorsNames()
        {
            foreach (var s in SensorRepository.Get)
            {
                yield return s.Name;
            }
        }

        public virtual IEnumerable<string> GetSensorsNames(string sensorTypeParam)
        {
            foreach (var sensor in SensorRepository.Filter( s => s.SensorType == sensorTypeParam ))
            {
                yield return sensor.Name;
            }
        }

        public virtual IEnumerable<string> GetSensorsTypes()
        {
            foreach (var s in SensorRepository.Get)
            {
                yield return s.SensorType;
            }
        }
        #endregion

        public IEnumerable<DateTime> GetDates()
        {
            foreach (var data in DataRepository.Filter( d => d.SensorId == SensorId ))
            {
                yield return data.Date;
            }
        }

        #region Methods for Data
        public virtual IEnumerable<Data> GetData(IEnumerable<DateTime> dates)
        {
            foreach (var date in dates)
            {
                foreach (var data in DataRepository.Filter( d => d.Date == date ))
                {
                    yield return data;
                }
            }
        }

        public virtual IEnumerable<Data> GetData(IEnumerable<DateTime> dates, TimeSpan firstTime, TimeSpan secondTime)
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
        #endregion

        public abstract void Run(IView view, IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam);
    }
}
