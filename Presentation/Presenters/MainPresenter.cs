using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

using DomainModel.Abstract;
using DomainModel.Entity;
using DomainModel.Extentions;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using Presentation.Common;
using Presentation.ViewModels;

namespace Presentation.Presenters
{
    public class MainPresenter : Presenter
    {
        public static List<Sensor> RequestList { get; private set; }
        public static List<Log> LogsList { get; private set; }

        public MainPresenter()
        {
            RequestList = new List<Sensor>();
            LogsList = new List<Log>();
        }

        public List<Sensor> GetSensorsList()
        {
            return SensorRepository.Get.ToList();
        }

        public List<Data> GetDataList()
        {
            return (from c in DataRepository.Get
                    where c.SensorId == SensorRepository.Get.FirstOrDefault().Id
                    orderby c.Date
                    select c).ToList();
        }

        public Data GetLastData(Sensor currentSensorParam)
        {
            return DataRepository.SingleFilter( d => d.SensorId == currentSensorParam.Id );
        }

        public GMapOverlay GetMarkersOfSensors()
        {
            var markersOverlay = new GMapOverlay( "markers" );
            markersOverlay.Markers.Clear();

            foreach (Sensor s in SensorRepository.Get)
            {
                GMarkerGoogle marker = new GMarkerGoogle( new PointLatLng( s.Lat, s.Lng ), GMarkerGoogleType.red );

                markersOverlay.Markers.Add( marker );
                marker.ToolTipText = s.Name;
            }
            return markersOverlay;
        }

        public override void Run(IView viewParam, IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            View = viewParam;
            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            View.Show();
        }
    }
}