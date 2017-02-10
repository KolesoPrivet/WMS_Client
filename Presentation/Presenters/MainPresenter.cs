using System.Collections.Generic;
using System.Linq;
using System;
using System.ServiceModel;

using DomainModel.Abstract;
using DomainModel.Entity;
using DomainModel.Extentions;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using Presentation.Common;
using Presentation.ViewModels;

using ServiceContracts;

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
            return SensorRepository.GetAll.ToList();
        }

        public List<Data> GetDataList()
        {
            return (from c in DataRepository.GetAll
                    where c.SensorId == SensorRepository.GetAll.FirstOrDefault().Id
                    orderby c.Date
                    select c).ToList();
        }

        public Data GetLastData(Sensor currentSensorParam)
        {
            return DataRepository.SingleFilter( d => d.SensorId == currentSensorParam.Id );
        }

        public GMapOverlay GetMarkersOfSensors()
        {
            GMapOverlay markersOverlay = new GMapOverlay( "markers" );
            markersOverlay.Markers.Clear();

            foreach (Sensor s in SensorRepository.GetAll)
            {
                GMarkerGoogle marker = new GMarkerGoogle( new PointLatLng( s.Lat, s.Lng ), GMarkerGoogleType.red );

                markersOverlay.Markers.Add( marker );
                marker.ToolTipText = s.Name;
            }
            return markersOverlay;
        }

        public string RequestSensors()
        {

            // Создание экземпляра ChannelFactory<T>, где Т - Контракт.
            ChannelFactory<IQuizService> factory = new ChannelFactory<IQuizService>( new BasicHttpBinding(), 
                                                                                     new EndpointAddress( new Uri( "http://localhost:4000/QuizService" ) ) );

            // Использование factory для создания канала (прокси).
            IQuizService channel = factory.CreateChannel();

            // Использование channel (прокси) для отправки сообщения получателю.
            return channel.GetSensorsValue();
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