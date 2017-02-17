using System;
using System.Linq;
using System.Collections.Generic;

using Presentation.DbService;

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

        public List<Sensor> Sensors { get; protected set; }


        public List<Data> Data { get; protected set; }
        #endregion



        #region Get entities from database

        /// <summary>
        /// Sends request to WCF-Service named DbService and returns collection of sensors
        /// </summary>
        /// <returns></returns>
        public List<Sensor> GetSensorsList()
        {
            Sensors = new DbServiceClient().GetSensorList().ToList();

            return Sensors;
        }


        /// <summary>
        /// Sends request to WCF-Service named DbService and returns collection of data
        /// </summary>
        /// <returns></returns>
        public List<Data> GetDataList()
        {
            Data = new DbServiceClient().GetDataList().ToList();

            return Data.Where( s => s.SensorId == Sensors.FirstOrDefault().Id ).ToList();
        }

        #endregion



        #region Generic methods for entities

        /// <summary>
        /// Returns single entity by predicate parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arrayParam"></param>
        /// <param name="predicateParam"></param>
        /// <returns></returns>
        public T SelectSingleEntity<T>(IEnumerable<T> arrayParam, Func<T, bool> predicateParam) where T : class
        {
            foreach (T entity in arrayParam)
            {
                if (predicateParam( entity ))
                {
                    return entity;
                }
            }
            return null;
        }



        /// <summary>
        /// Returns collection of entities by predicate param
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arrayParam"></param>
        /// <param name="predicateParam"></param>
        /// <returns></returns>
        public IEnumerable<T> SelectManyEntities<T>(IEnumerable<T> arrayParam, Func<T, bool> predicateParam)
        {
            foreach (T t in arrayParam)
            {
                if (predicateParam( t ))
                    yield return t;
            }
        }

        #endregion



        #region Get sensor, sensors names and types

        /// <summary>
        /// Returns sensor that name as parameter
        /// </summary>
        /// <param name="sensorNameParam"></param>
        /// <returns></returns>
        public virtual Sensor GetSensorByName(string sensorNameParam)
        {
            return SelectSingleEntity(Sensors, s => s.Name == sensorNameParam );
        }


        /// <summary>
        /// Returns collection of all sensors names
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetSensorsNames()
        {
            foreach (var s in Sensors)
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
            foreach (var sensor in SelectManyEntities(Sensors, s => s.SensorType == sensorTypeParam ))
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
            foreach (var s in Sensors)
            {
                yield return s.SensorType;
            }
        }

        #endregion



        #region Get dates

        /// <summary>
        /// Return all dates of current sensor
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DateTime> GetDates()
        {
            foreach (var data in SelectManyEntities( Data, d => d.SensorId == SensorId ))
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
            Sensor currentSensor = Sensors.Where( s => s.Name == sensorNameParam ).First();

            foreach (var data in SelectManyEntities( Data, d => d.SensorId == currentSensor.Id ))
            {
                yield return data.Date;
            }
        }

        #endregion



        #region Get data by date
        
        /// <summary>
        /// Returns collection of data, which dates are in parameter
        /// </summary>
        /// <param name="dates"></param>
        /// <returns></returns>
        public virtual IEnumerable<Data> GetDataByDates(IEnumerable<DateTime> dates)
        {
            foreach (var date in dates)
            {
                foreach (var data in SelectManyEntities( Data, d => d.Date == date ))
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
                foreach (var data in SelectManyEntities( Data, d => d.Date == date
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
