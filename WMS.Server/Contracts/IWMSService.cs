using System.Collections.Generic;
using System.ServiceModel;

using WMS.Common;

namespace WMS.Server
{
    [ServiceContract]
    public interface IWMSService
    {
        [OperationContract]
        SensorDto[] GetAllSensors();

        [OperationContract]
        DataDto[] GetAllData();

        [OperationContract]
        DataDto[] GetDataBySensorId(int id);

        [OperationContract]
        Response[] RequestToWSN(Request request);
    }
}