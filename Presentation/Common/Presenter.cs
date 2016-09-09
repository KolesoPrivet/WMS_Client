using DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Abstract;
using DomainModel.Extentions;

namespace Presentation.Common
{
    public abstract class Presenter
    {
        protected virtual IView View { get; set; }
        public IRepository<Sensor> SensorRepository { get; set; }
        public IRepository<Data> DataRepository { get; set; }

        public virtual Sensor GetSensorByName(string sensorNameParam)
        {
            return SensorRepository.SingleFilter( s => s.Name == sensorNameParam );
        }

        public IEnumerable<DateTime> GetDates(int selectedSensorIdParam)
        {
            foreach (var data in DataRepository.Filter( d => d.SensorId == selectedSensorIdParam ))
            {
                yield return data.Date;
            }
        }

        //TODO: GetSensorsNames in 3 presenters!
        public IEnumerable<string> GetSensorsNames()
        {
            foreach (var s in SensorRepository.Get)
            {
                yield return s.Name;
            }
        }

        //TODO: GetSensorsTypes in 2 presenters!
        public IEnumerable<string> GetSensorsNames(string sensorTypeParam)
        {
            foreach (var sensor in SensorRepository.Filter( s => s.SensorType == sensorTypeParam ))
            {
                yield return sensor.Name;
            }
        }

        //TODO: GetSensorsTypes in 2 presenters!
        public IEnumerable<string> GetSensorsTypes()
        {
            foreach (var s in SensorRepository.Get)
            {
                yield return s.SensorType;
            }
        }

        public virtual IEnumerable<Data> GetData(IEnumerable<DateTime> dates) { throw new NotImplementedException(); }

        public virtual IEnumerable<Data> GetData(IEnumerable<DateTime> dates, TimeSpan firstTime, TimeSpan secondTime) { throw new NotImplementedException(); }

        public abstract void Run(IView view, IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam);
    }
}
