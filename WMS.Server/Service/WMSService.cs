using System;
using System.Collections.Generic;
using System.ServiceModel;

using WMS.Common;
using WMS.Domain;

namespace WMS.Server
{
    [ServiceBehavior( InstanceContextMode = InstanceContextMode.PerCall,
                      ConcurrencyMode = ConcurrencyMode.Multiple )]
    public class WMSService : IWMSService
    {
        private readonly DataService _dataService = new DataService();

        private readonly SensorService _sensorService = new SensorService();

        /// <summary>
        /// Получить все данные
        /// </summary>
        public List<DataDto> GetAllData(Func<Data, bool> predicate)
        {
            return _dataService.Get( predicate );
        }

        /// <summary>
        /// Получить данные по идентификатору сенсора
        /// </summary>
        public List<DataDto> GetDataBySensorId(int id)
        {
            return _dataService.Get(x => x.SensorId == id);
        }

        /// <summary>
        /// Получить все сенсоры
        /// </summary>
        public List<SensorDto> GetAllSensors(Func<Sensor, bool> predicate)
        {
            return _sensorService.Get( predicate );
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Response> RequestToWSN(Request requestEnityParam)
        {
            // Get dispatcher, which will do work with gotten sensors request:
            //
            // * only save in database (return null);
            // * save and return to client (return IList<ResponseEntity);
            // * only return (return IList<ResponseEntity).
            //
            return ResponseDispatcher.GetDispatcher( requestEnityParam.ResultSettings ).ResultWork( RequestToSensors( requestEnityParam ) );
        }

        /// <summary>
        /// Отправить запрос на опрос сенсорной сети
        /// </summary>
        public List<Response> RequestToSensors(Request requestEntityParam)
        {
            //TODO: Request to sensor network
            return new List<Response>() { new Response { Name = "111-111",
                                                         Date = DateTime.Now,
                                                         SensorId = 1,
                                                         Time = DateTime.Now.TimeOfDay,
                                                         Value = 50 },
                                
                                          new Response { Name = "111-111",
                                                         Date = DateTime.Now,
                                                         SensorId = 1,
                                                         Time = DateTime.Now.TimeOfDay,
                                                         Value = 51 },
                                      
                                          new Response { Name = "111-111",
                                                         Date = DateTime.Now,
                                                         SensorId = 1,
                                                         Time = DateTime.Now.TimeOfDay,
                                                         Value = 53 }};
        }
    }
}
