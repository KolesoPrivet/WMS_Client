using DomainModel.Abstract;
using System.Collections.Generic;

namespace DomainModel.Entity
{
    public class Sensor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SensorType { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int Radius { get; set; }

        public virtual ICollection<Data> DataCollection { get; set; }
    }
}
