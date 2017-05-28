using System;

namespace WMS.Common
{
    public class DataDto : IDto
    {
        public int Id { get; set; }
        public int SensorId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
    }
}
