using Presentation.LogsBuilder.Abstract;
using Presentation.ViewModels;
using System.Collections.Generic;

namespace Presentation.LogsBuilder.Common
{
    public class Logger
    {
        private LogBuilder builder;

        public Logger(LogBuilder builderParam)
        {
            builder = builderParam;
        }

        public Log WriteLog(List<Log> logsListParam, string additionalDescription = "")
        {
            builder.SetDateTime();
            builder.SetDescription(additionalDescription);
            builder.SetLevelType();

            Log result = builder.GetResult();
            logsListParam.Add( result );

            return result;
        }
    }
}
