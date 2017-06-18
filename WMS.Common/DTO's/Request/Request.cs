using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WMS.Common
{
    [DataContract]
    public class Request
    {
        public int QuizNumber { get; set; }

        public int Frequence { get; set; }

        public ResultSettings ResultSettings { get; set; }

        public HashSet<int> SensorIds { get; set; }

        public HashSet<string> SensorNames { get; set; }
    }
}
