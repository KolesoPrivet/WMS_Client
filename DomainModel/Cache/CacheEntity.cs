using System.Collections.Generic;

using WMS.Domain.WMSDatabaseService;

namespace WMS.Domain.Cache
{
    public static class CacheEntity
    {
        public static List<Sensor> CurrentSensors { get; set; }
       

        public static List<Data> CurrentData { get; set; }        
    }
}
