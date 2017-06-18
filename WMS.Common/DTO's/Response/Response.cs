using System;
using System.Runtime.Serialization;

namespace WMS.Common
{
    [DataContract]
    public class Response
    {
        public int SensorId { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public int Value { get; set; }
    }
}
