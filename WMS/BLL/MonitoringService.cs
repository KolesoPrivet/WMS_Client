using System.IO.Ports;

namespace WMS.BLL
{
    enum LedColors : int
    {
        RedLedOne = 1,
        RedLedTwo = 2,
        YellowLedOne = 3,
        YellowLedTwo = 4,
        GreenLedOne = 5,
        GreenLedTwo = 6,
        TripleLedRed = 7,
        TripleLedGreen = 8,
        TripleLedBlue = 9
    }

    class MonitoringService
    {
        private readonly SerialPort sp;

        public MonitoringService()
        {
            sp = new SerialPort();
            sp.BaudRate = 9600;
            sp.PortName = "COM3";
        }

        public void OnOffLed(LedColors lc)
        {
            if (sp.IsOpen)
            {
                sp.WriteLine(lc.ToString("D"));
            }
            else
            {
                sp.Open();
                sp.WriteLine(lc.ToString("D"));
            }
        }

    }
}
