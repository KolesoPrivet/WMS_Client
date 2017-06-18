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
        /// <summary>
        /// Получить все данные
        /// </summary>
        public DataDto[] GetAllData()
        {
            DataService dataService = new DataService();

            return dataService.GetAll().ToArray();
        }

        /// <summary>
        /// Получить данные по идентификатору сенсора
        /// </summary>
        public DataDto[] GetDataBySensorId(int id)
        {
            DataService dataService = new DataService();

            return dataService.Get(x => x.SensorId == id).ToArray();
        }

        /// <summary>
        /// Получить все сенсоры
        /// </summary>
        public SensorDto[] GetAllSensors()
        {
            SensorService sensorService = new SensorService();

            return sensorService.GetAll().ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        public Response[] RequestToWSN(Request requestEnityParam)
        {
            // Get dispatcher, which will do work with gotten sensors request:
            //
            // * only save in database (return null);
            // * save and return to client (return IList<ResponseEntity);
            // * only return (return IList<ResponseEntity).
            //
            return ResponseDispatcher.GetDispatcher( requestEnityParam.ResultSettings ).ResultWork( RequestToSensors( requestEnityParam ) ).ToArray();
        }

        /// <summary>
        /// Отправить запрос на опрос сенсорной сети
        /// </summary>
        public Response[] RequestToSensors(Request requestEntityParam)
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
                                                         Value = 53 }}.ToArray();
        }
    }
}
