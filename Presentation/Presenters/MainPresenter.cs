using System.Collections.Generic;
using System.Linq;
using System;
using System.ServiceModel;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using Presentation.Common;
using Presentation.ViewModels;

using ServiceContracts;
using Presentation.DbService;

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


        public Data GetLastData(Sensor currentSensorParam)
        {
            return SelectSingleEntity(Data, d => d.SensorId == currentSensorParam.Id );
        }

        public GMapOverlay GetMarkersOfSensors()
        {
            GMapOverlay markersOverlay = new GMapOverlay( "markers" );
            markersOverlay.Markers.Clear();

            foreach (Sensor s in Sensors)
            {
                GMarkerGoogle marker = new GMarkerGoogle( new PointLatLng( s.Lat, s.Lng ), GMarkerGoogleType.red );

                markersOverlay.Markers.Add( marker );
                marker.ToolTipText = s.Name;
            }
            return markersOverlay;
        }



        public override void Run(IView viewParam)
        {
            View = viewParam;

            View.Show();
        }
    }
}