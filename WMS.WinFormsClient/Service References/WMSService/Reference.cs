﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMS.WinFormsClient.WMSService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WMSService.IWMSService")]
    public interface IWMSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWMSService/GetAllSensors", ReplyAction="http://tempuri.org/IWMSService/GetAllSensorsResponse")]
        WMS.Common.SensorDto[] GetAllSensors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWMSService/GetAllSensors", ReplyAction="http://tempuri.org/IWMSService/GetAllSensorsResponse")]
        System.Threading.Tasks.Task<WMS.Common.SensorDto[]> GetAllSensorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWMSService/GetAllData", ReplyAction="http://tempuri.org/IWMSService/GetAllDataResponse")]
        WMS.Common.DataDto[] GetAllData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWMSService/GetAllData", ReplyAction="http://tempuri.org/IWMSService/GetAllDataResponse")]
        System.Threading.Tasks.Task<WMS.Common.DataDto[]> GetAllDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWMSService/GetDataBySensorId", ReplyAction="http://tempuri.org/IWMSService/GetDataBySensorIdResponse")]
        WMS.Common.DataDto[] GetDataBySensorId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWMSService/GetDataBySensorId", ReplyAction="http://tempuri.org/IWMSService/GetDataBySensorIdResponse")]
        System.Threading.Tasks.Task<WMS.Common.DataDto[]> GetDataBySensorIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWMSService/RequestToWSN", ReplyAction="http://tempuri.org/IWMSService/RequestToWSNResponse")]
        WMS.Common.Response[] RequestToWSN(WMS.Common.Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWMSService/RequestToWSN", ReplyAction="http://tempuri.org/IWMSService/RequestToWSNResponse")]
        System.Threading.Tasks.Task<WMS.Common.Response[]> RequestToWSNAsync(WMS.Common.Request request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWMSServiceChannel : WMS.WinFormsClient.WMSService.IWMSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WMSServiceClient : System.ServiceModel.ClientBase<WMS.WinFormsClient.WMSService.IWMSService>, WMS.WinFormsClient.WMSService.IWMSService {
        
        public WMSServiceClient() {
        }
        
        public WMSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WMSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WMSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WMSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WMS.Common.SensorDto[] GetAllSensors() {
            return base.Channel.GetAllSensors();
        }
        
        public System.Threading.Tasks.Task<WMS.Common.SensorDto[]> GetAllSensorsAsync() {
            return base.Channel.GetAllSensorsAsync();
        }
        
        public WMS.Common.DataDto[] GetAllData() {
            return base.Channel.GetAllData();
        }
        
        public System.Threading.Tasks.Task<WMS.Common.DataDto[]> GetAllDataAsync() {
            return base.Channel.GetAllDataAsync();
        }
        
        public WMS.Common.DataDto[] GetDataBySensorId(int id) {
            return base.Channel.GetDataBySensorId(id);
        }
        
        public System.Threading.Tasks.Task<WMS.Common.DataDto[]> GetDataBySensorIdAsync(int id) {
            return base.Channel.GetDataBySensorIdAsync(id);
        }
        
        public WMS.Common.Response[] RequestToWSN(WMS.Common.Request request) {
            return base.Channel.RequestToWSN(request);
        }
        
        public System.Threading.Tasks.Task<WMS.Common.Response[]> RequestToWSNAsync(WMS.Common.Request request) {
            return base.Channel.RequestToWSNAsync(request);
        }
    }
}
