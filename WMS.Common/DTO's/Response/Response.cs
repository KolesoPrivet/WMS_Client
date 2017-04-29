using System;

namespace WMS.Common
{
    public class Response
    {
        public int SensorId { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public int Value { get; set; }
    }
}
