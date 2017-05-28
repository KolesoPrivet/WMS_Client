using System.Collections.Generic;

using WMS.Common;

namespace WMS.WinFormsClient
{
    public static class CachedEntity
    {
        public static List<SensorDto> CurrentSensors { get; set; }

        public static List<DataDto> CurrentData { get; set; }
    }
}
