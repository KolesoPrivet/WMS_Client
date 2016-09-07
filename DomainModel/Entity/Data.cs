using DomainModel.Abstract;
using System;


namespace DomainModel.Entity
{
    public class Data : IEntity
    {
        public int Id { get; set; }
        public int SensorId { get; set; }     
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int Value { get; set; }

        public virtual Sensor SingleSensor { get; set; }
    }
}
