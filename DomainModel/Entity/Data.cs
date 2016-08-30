using System;


namespace DomainModel.Entity
{
    public class Data
    {
        public int DataId { get; set; }
        public int SensorId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public double Value { get; set; }

        public virtual Sensor SingleSensor { get; set; }
    }
}
