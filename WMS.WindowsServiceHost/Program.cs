using System.ServiceProcess;

namespace WMS.WindowsServiceHost
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new WMSServiceHost()
            };
            ServiceBase.Run( ServicesToRun );
        }
    }
}
