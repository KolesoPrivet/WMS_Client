using System.Collections.Generic;
using System.Linq;

using WMS.Common;

namespace WMS.WinFormsClient
{
    public class MainPresenter : Presenter
    {
        #region Fields

        public static List<SensorDto> RequestList { get; private set; }


        public static List<Log> LogsList { get; private set; }

        #endregion


        #region Constructors

        public MainPresenter()
        {
            RequestList = new List<SensorDto>();

            LogsList = new List<Log>();
        }

        #endregion


        #region Help methods

        public DataDto GetLastData(SensorDto currentSensorParam)
        {
            return GetData().Where( d => d.SensorId == currentSensorParam.Id ).OrderBy( s => s.Date ).AsEnumerable().LastOrDefault();
        }


        public override void Run(IView viewParam)
        {
            View = viewParam;

            View.Show();
        }

        #endregion
    }
}