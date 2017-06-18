using System.Runtime.Serialization;

namespace WMS.Common
{
    [DataContract]
    public class SensorDto : IDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string SensorType { get; set; }

        [DataMember]
        public double Lat { get; set; }

        [DataMember]
        public double Lng { get; set; }

        [DataMember]
        public int Radius { get; set; }
    }
}
