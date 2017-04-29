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
        private SensorService _sensorService;

        private DataService _dataService;

        public IList<DataDto> GetDataList()
        {
            return _dataService.GetAll();
        }

        public IList<SensorDto> GetSensorList()
        {
            return _sensorService.GetAll();
        }

        public IList<Response> RequestService(Request requestEnityParam)
        {
            // Get dispatcher, which will do work with gotten sensors request:
            //
            // * only save in database (return null);
            // * save and return to client (return IList<ResponseEntity);
            // * only return (return IList<ResponseEntity).
            //
            return ResponseDispatcher.GetDispatcher( requestEnityParam.ResultSettings ).ResultWork( RequestToSensors( requestEnityParam ) );
        }

        public IList<Response> RequestToSensors(Request requestEntityParam)
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
