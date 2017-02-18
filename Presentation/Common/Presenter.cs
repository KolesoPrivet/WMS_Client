using System;
using System.Linq;
using System.Collections.Generic;

using DomainModel.WMSDatabaseService;
using DomainModel.Repositories;

namespace Presentation.Common
{
    /// <summary>
    /// Abstract class for all presenters
    /// </summary>
    public abstract class Presenter
    {
        #region Fileds

        protected IView View { get; set; }


        public int SensorId { get; set; }

        #endregion


        #region Help methods

        /// <summary>
        /// Sends request to WCF-Service named DbService and returns collection of sensors
        /// </summary>
        /// <returns></returns>
        public IQueryable<Sensor> GetSensors()
        {
            return EFSensorRepository.GetAll();
        }


        /// <summary>
        /// Sends request to WCF-Service named DbService and returns collection of data
        /// </summary>
        /// <returns></returns>
        public IQueryable<Data> GetData()
        {
            return EFDataRepository.GetAll();
        }


        /// <summary>
        /// Returns sensor that name as parameter
        /// </summary>
        /// <param name="sensorNameParam"></param>
        /// <returns></returns>
        public virtual Sensor GetSensorByName(string sensorNameParam)
        {
            return GetSensors().First( s => s.Name == sensorNameParam );
        }


        /// <summary>
        /// Returns collection of all sensors names
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetSensorsNames()
        {
            foreach (var s in GetSensors())
            {
                yield return s.Name;
            }
        }


        /// <summary>
        /// Returns collection of sensors names, that type as parameter
        /// </summary>
        /// <param name="sensorTypeParam"></param>
        /// <returns></returns>
        public virtual IEnumerable<string> GetSensorsNames(string sensorTypeParam)
        {
            foreach (var sensor in GetSensors().Where( s => s.SensorType == sensorTypeParam ))
            {
                yield return sensor.Name;
            }
        }


        /// <summary>
        /// Returns collection of sensors types
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetSensorsTypes()
        {
            foreach (var s in GetSensors())
            {
                yield return s.SensorType;
            }
        }


        /// <summary>
        /// Return all dates of current sensor
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DateTime> GetDates()
        {
            foreach (var data in GetData().Where( d => d.SensorId == SensorId ))
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
            Sensor currentSensor = GetSensors().First( s => s.Name == sensorNameParam );

            foreach (var data in GetData().Where( d => d.SensorId == currentSensor.Id ))
            {
                yield return data.Date;
            }
        }


        /// <summary>
        /// Returns collection of data, which dates are in parameter
        /// </summary>
        /// <param name="dates"></param>
        /// <returns></returns>
        public virtual IEnumerable<Data> GetDataByDates(IEnumerable<DateTime> dates)
        {
            foreach (var date in dates)
            {
                foreach (var data in GetData().Where( d => d.Date == date ))
                {
                    yield return data;
                }
            }
        }


        /// <summary>
        /// Returns collection of data, which dates and time are in parameters
        /// </summary>
        /// <param name="dates"></param>
        /// <param name="firstTime"></param>
        /// <param name="secondTime"></param>
        /// <returns></returns>
        public virtual IEnumerable<Data> GetDataByDates(IEnumerable<DateTime> dates, TimeSpan firstTime, TimeSpan secondTime)
        {
            foreach (var date in dates)
            {
                foreach (var data in GetData().Where( d => d.Date == date
                                                                 && d.Time >= firstTime
                                                                 && d.Time <= secondTime ))
                {
                    yield return data;
                }
            }
        }


        public abstract void Run(IView view);
       
        #endregion
    }
}
