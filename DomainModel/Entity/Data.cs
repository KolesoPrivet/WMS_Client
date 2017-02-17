using System;
using System.Runtime.Serialization;

using DomainModel.Abstract;

namespace DomainModel.Entity
{
    [DataContract( IsReference = true )]
    public class Data : IEntity
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
