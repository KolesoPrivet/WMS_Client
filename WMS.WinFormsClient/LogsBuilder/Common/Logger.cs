using WMS.WinFormsClient;
using System.Collections.Generic;

namespace WMS.WinFormsClient
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
