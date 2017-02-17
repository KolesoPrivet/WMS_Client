using System.Collections.Generic;
using System.Runtime.Serialization;

using DomainModel.Abstract;

namespace DomainModel.Entity
{
    [DataContract( IsReference = true )]
    public class Sensor : IEntity
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


        [DataMember]
        public virtual IList<Data> DataCollection { get; set; }
    }
}
