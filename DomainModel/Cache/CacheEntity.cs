using System.Collections.Generic;

using DomainModel.WMSDatabaseService;

namespace DomainModel.Cache
{
    public static class CacheEntity
    {
        public static List<Sensor> CurrentSensors { get; set; }
       

        public static List<Data> CurrentData { get; set; }        
    }
}
