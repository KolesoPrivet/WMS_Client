using System;
using System.Linq;
using System.Collections.Generic;

using DomainModel.WMSDatabaseService;
using DomainModel.Repositories;
using DomainModel.Cache;

namespace Presentation.Common
{
    /// <summary>
    /// Abstract class for all presenters
    /// </summary>
    public abstract class Presenter
    {
        #region Fields and properties

        protected IView View { get; set; }

        #endregion


        #region Data manipulation methods

        /// <summary>
        /// Sends request to WCF-Service named DbService
        /// </summary>
        /// <returns>IQueryable collection of sensors</returns>
        public IQueryable<Sensor> GetSensors()
        {
            return EFSensorRepository.GetAll();
        }


        /// <summary>
        /// Sends request to WCF-Service named DbService
        /// </summary>
        /// <returns>IQueryable collection of data</returns>
        public IQueryable<Data> GetData()
        {
            return EFDataRepository.GetAll();
        }



        /// <summary>
        /// Returns sensor that name as parameter
        /// </summary>
        /// <param name="sensorNameParam"></param>
        /// <returns>Sensor name</returns>
        public virtual Sensor GetSensorByName(string sensorNameParam)
        {
            return GetSensors().Where( s => s.Name == sensorNameParam ).AsEnumerable().FirstOrDefault();
        }


        /// <summary>
        /// Get current sensors from cache
        /// </summary>
        /// <returns>Collection of all sensors names</returns>
        public virtual IEnumerable<string> GetSensorsNames()
        {

            foreach (var s in CacheEntity.CurrentSensors.Select( x => x.Name ))
            {
                yield return s;
            }
        }


        /// <summary>
        /// Get current sensors names from database
        /// </summary>
        /// <param name="sensorTypeParam">Sensor type</param>
        /// <returns>Collection of sensors names</returns>
        public virtual IEnumerable<string> GetSensorsNames(string sensorTypeParam)
        {
            foreach (var sensor in GetSensors().Where( s => s.SensorType == sensorTypeParam ))
            {
                yield return sensor.Name;
            }
        }


        /// <summary>
        /// Get current sensors types from cache
        /// </summary>
        /// <returns>Collection of sensors types</returns>
        public virtual IEnumerable<string> GetSensorsTypes()
        {
            foreach (var s in CacheEntity.CurrentSensors.Select( x => x.SensorType ))
            {
                yield return s;
            }
        }


        /// <summary>
        /// Get all dates from database
        /// </summary>
        /// <returns>All dates from database</returns>
        public virtual IEnumerable<DateTime> GetDates()
        {
            foreach (var data in GetData())
            {
                yield return data.Date;
            }
        }


        /// <summary>
        /// Return all dates by sensor id
        /// </summary>
        /// <param name="sensorIdParam">Sensor id</param>
        /// <returns></returns>
        public virtual IEnumerable<DateTime> GetDates(int sensorIdParam)
        {
            foreach (var data in GetData().Where( x => x.SensorId == sensorIdParam ))
            {
                yield return data.Date;
            }
        }


        /// <summary>
        /// Get dates from database by sensor name
        /// </summary>
        /// <param name="sensorNameParam">Sensor name</param>
        /// <returns></returns>
        public virtual IEnumerable<DateTime> GetDates(string sensorNameParam)
        {
            Sensor currentSensor = GetSensors().Where( s => s.Name == sensorNameParam ).AsEnumerable().First();

            foreach (var data in GetData().Where( d => d.SensorId == currentSensor.Id ))
            {
                yield return data.Date;
            }
        }


        /// <summary>
        /// Get data by dates collection
        /// </summary>
        /// <param name="dates"></param>
        /// <returns>Collection of data</returns>
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
        /// Get data by dates, and time interval
        /// </summary>
        /// <param name="dates">Date collection</param>
        /// <param name="firstTime">First time</param>
        /// <param name="secondTime">Second time</param>
        /// <returns>Collection of data</returns>
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

        #endregion


        public abstract void Run(IView view);       
    }
}
