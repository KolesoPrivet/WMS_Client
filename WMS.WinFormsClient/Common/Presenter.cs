using System;
using System.Linq;
using System.Collections.Generic;

using WMS.Common;
using WMS.WinFormsClient.WMSService;
using WMS.WinFormsClient;

namespace WMS.WinFormsClient
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
        /// Получить список дто
        /// </summary>
        public List<SensorDto> GetSensors()
        {
            WMSServiceClient client = new WMSServiceClient();

            CachedEntity.CurrentSensors = client.GetAllSensors( null ).ToList();

            return CachedEntity.CurrentSensors;
        }

        /// <summary>
        /// Получить список дто
        /// /// </summary>
        public List<DataDto> GetData()
        {
            WMSServiceClient client = new WMSServiceClient();

            CachedEntity.CurrentData = client.GetDataBySensorId( null ).ToList();

            return CachedEntity.CurrentData;
        }

        /// <summary>
        /// Returns sensor that name as parameter
        /// </summary>
        public virtual SensorDto GetSensorByName(string sensorNameParam) => 
            GetSensors()
            .Where( s => s.Name == sensorNameParam )
            .AsEnumerable()
            .FirstOrDefault();

        /// <summary>
        /// Получить названия закэшированных сенсоров
        /// </summary>
        public virtual List<string> GetSensorsNames() => 
            CachedEntity.CurrentSensors
            .Select( x => x.Name )
            .ToList();


        /// <summary>
        /// Get current sensors names from database
        /// </summary>
        public virtual List<string> GetSensorsNames(string sensorTypeParam) => 
            CachedEntity.CurrentSensors
            .Where( x => x.SensorType == sensorTypeParam )
            .Select( x => x.Name )
            .ToList();

        /// <summary>
        /// Get current sensors types from cache
        /// </summary>
        public virtual List<string> GetSensorsTypes() => 
            CachedEntity.CurrentSensors
            .Select( x => x.SensorType )
            .ToList();

        /// <summary>
        /// Получить все даты данных
        /// </summary>
        public virtual List<DateTime> GetDates() => 
            CachedEntity.CurrentData
            .Select( x => x.Date )
            .ToList();

        /// <summary>
        /// Получить даты данных по идентификатору сенсора
        /// </summary>
        public virtual List<DateTime> GetDates(int sensorIdParam) => 
            CachedEntity.CurrentData
            .Where( x => x.SensorId == sensorIdParam )
            .Select( x => x.Date )
            .ToList();


        /// <summary>
        /// Get dates from database by sensor name
        /// </summary>
        public virtual IEnumerable<DateTime> GetDates(string sensorNameParam)
        {
            SensorDto currentSensor = GetSensors().Where( s => s.Name == sensorNameParam ).AsEnumerable().First();

            foreach (var data in GetData().Where( d => d.SensorId == currentSensor.Id ))
            {
                yield return data.Date;
            }
        }

        /// <summary>
        /// Get data by dates collection
        /// </summary>
        public virtual IEnumerable<DataDto> GetDataByDates(IEnumerable<DateTime> dates)
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
        public virtual IEnumerable<DataDto> GetDataByDates(IEnumerable<DateTime> dates, TimeSpan firstTime, TimeSpan secondTime)
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
