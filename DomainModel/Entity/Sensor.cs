using System.Collections.Generic;

namespace DomainModel.Entity
{
    public class Sensor
    {
        public int SensorId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public string Radius { get; set; }

        public virtual ICollection<Data> DataCollection { get; set; }
    }
}
