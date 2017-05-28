using System.ServiceModel;
using System.ServiceProcess;

using WMS.Server;

namespace WMS.WindowsServiceHost
{
    public partial class WMSServiceHost : ServiceBase
    {
        private ServiceHost _host;

        public WMSServiceHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _host = new ServiceHost(typeof(WMSService));
            _host.Open();
        }

        protected override void OnStop()
        {
            if(_host != null)
                _host.Abort();
        }
    }
}
