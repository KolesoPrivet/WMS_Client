using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Common
{
    public class DataDto
    {
        public int Id { get; set; }
        public int SensorId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
    }
}
