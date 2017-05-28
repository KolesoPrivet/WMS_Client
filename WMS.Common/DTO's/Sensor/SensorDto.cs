namespace WMS.Common
{
    public class SensorDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SensorType { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int Radius { get; set; }
    }
}
