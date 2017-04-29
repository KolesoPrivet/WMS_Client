using WMS.WinFormsClient;
using System;

namespace WMS.WinFormsClient
{
    public abstract class LogBuilder
    {
        protected Log buildingLog { get; } = new Log();

        public abstract void SetLevelType();
        public abstract void SetDescription(string additionalDescriptionParam);

        public void SetDateTime()
        {
            buildingLog.EventLogTime = DateTime.Now;
        }

        public Log GetResult()
        {
            return buildingLog;
        }
    }
}
