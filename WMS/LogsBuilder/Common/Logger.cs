using WMS.WinformsClient.LogsBuilder.Abstract;
using WMS.WinformsClient.ViewModels;
using System.Collections.Generic;

namespace WMS.WinformsClient.LogsBuilder.Common
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
