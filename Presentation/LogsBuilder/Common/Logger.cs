using Presentation.LogsBuilder.Abstract;
using Presentation.ViewModels;
using System.Collections.Generic;

namespace Presentation.LogsBuilder.Common
{
    public class Logger
    {
        private LogBuilder _builder;

        public Logger(LogBuilder builderParam)
        {
            _builder = builderParam;
        }

        public Log WriteLog(List<Log> logsListParam, string additionalDescription = "")
        {
            _builder.SetDateTime();
            _builder.SetDescription(additionalDescription);
            _builder.SetLevelType();

            Log result = _builder.GetResult();
            logsListParam.Add( result );

            return result;
        }
    }
}
