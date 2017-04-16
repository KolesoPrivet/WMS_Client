using System.Collections.Generic;
using System.Linq;

using WMS.WinformsClient.Common;
using WMS.WinformsClient.ViewModels;

using WMS.Domain.WMSDatabaseService;

namespace WMS.WinformsClient.Presenters
{
    public class MainPresenter : Presenter
    {
        #region Fields

        public static List<Sensor> RequestList { get; private set; }


        public static List<Log> LogsList { get; private set; }

        #endregion


        #region Constructors

        public MainPresenter()
        {
            RequestList = new List<Sensor>();

            LogsList = new List<Log>();
        }

        #endregion


        #region Help methods

        public Data GetLastData(Sensor currentSensorParam)
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