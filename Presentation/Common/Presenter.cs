using System;
using System.Linq;
using System.Collections.Generic;

using DomainModel.Abstract;
using DomainModel.Extentions;
using DomainModel.Entity;

namespace Presentation.Common
{
    /// <summary>
    /// Abstract class for all presenters
    /// </summary>
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

        /// <summary>
        /// Return collection of all sensor names
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetSensorsNames()
        {
            foreach (var s in SensorRepository.GetAll)
            {
                yield return s.Name;
            }
        }

        /// <summary>
        /// Return collection of sensors, that type is param
        /// </summary>
        /// <param name="sensorTypeParam"></param>
        /// <returns></returns>
        public virtual IEnumerable<string> GetSensorsNames(string sensorTypeParam)
        {
            foreach (var sensor in SensorRepository.Filter( s => s.SensorType == sensorTypeParam ))
            {
                yield return sensor.Name;
            }
        }

        public virtual IEnumerable<string> GetSensorsTypes()
        {
            foreach (var s in SensorRepository.GetAll)
            {
                yield return s.SensorType;
            }
        }
        #endregion

        /// <summary>
        /// Return all dates of current sensor
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DateTime> GetDates()
        {
            foreach (var data in DataRepository.Filter( d => d.SensorId == SensorId ))
            {
                yield return data.Date;
            }
        }

        /// <summary>
        /// Return all dates of sensor name param
        /// </summary>
        /// <param name="sensorNameParam"></param>
        /// <returns></returns>
        public IEnumerable<DateTime> GetDates(string sensorNameParam)
        {
            Sensor currentSensor = SensorRepository.GetAll.Where(s => s.Name == sensorNameParam).First();

            foreach (var data in DataRepository.Filter( d => d.SensorId == currentSensor.Id ))
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
