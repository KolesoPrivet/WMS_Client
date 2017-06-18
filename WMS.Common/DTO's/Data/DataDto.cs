using System;
using System.Runtime.Serialization;

namespace WMS.Common
{
    [DataContract]
    public class DataDto : IDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int SensorId { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public TimeSpan Time { get; set; }

        [DataMember]
        public int Value { get; set; }
    }
}
