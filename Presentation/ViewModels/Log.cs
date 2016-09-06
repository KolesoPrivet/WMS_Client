using System;

namespace Presentation.ViewModels
{
    public class Log
    {
        public DateTime EventLogTime { get; private set; }
        public Level LevelType { get; private set; }
        public string Description { get; private set; }

        public Log(DateTime EventLogTimeParam, Level LevelTypeParam, string DescriptionParam)
        {
            EventLogTime = EventLogTimeParam;
            LevelType = LevelTypeParam;
            Description = DescriptionParam;
        }
    }

    public enum Level
    {
        Critical,
        Error,
        Attention,
        Success,
        Info
    }
}
