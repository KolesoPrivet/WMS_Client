using System;
using System.Collections.Generic;
using System.ServiceModel;

using WMS.Common;
using WMS.Domain;

namespace WMS.Server
{
    [ServiceContract]
    public interface IWMSService
    {
        [OperationContract]
        List<SensorDto> GetAllSensors(Func<Sensor, bool> predicate);

        [OperationContract]
        List<DataDto> GetAllData(Func<Data, bool> predicate);

        [OperationContract]
        List<DataDto> GetDataBySensorId(int id);

        [OperationContract]
        List<Response> RequestToWSN(Request request);
    }
}