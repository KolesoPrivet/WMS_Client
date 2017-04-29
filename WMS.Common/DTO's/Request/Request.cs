using System.Collections.Generic;

namespace WMS.Common
{
    public class Request
    {
        public int QuizNumber { get; set; }

        public int Frequence { get; set; }

        public ResultSettings ResultSettings { get; set; }

        public HashSet<int> SensorIds { get; set; }

        public HashSet<string> SensorNames { get; set; }
    }
}
