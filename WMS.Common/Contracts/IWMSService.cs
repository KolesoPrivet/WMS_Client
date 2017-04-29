using System.Collections.Generic;
using System.ServiceModel;

namespace WMS.Common
{
    [ServiceContract]
    public interface IWMSService
    {
        [OperationContract]
        IList<SensorDto> GetSensorList();

        [OperationContract]
        IList<DataDto> GetDataList();

        [OperationContract]
        IList<Response> RequestService(Request requestEntityParam);
    }
}