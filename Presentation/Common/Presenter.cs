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
        protected IRepository<Sensor> SensorRepository { get; set; }
        protected IRepository<Data> DataRepository { get; set; }

        public virtual Sensor GetSensorByName(string sensorNameParam)
        {
            return SensorRepository.SingleFilter( s => s.Name == sensorNameParam );
        }

        public virtual IEnumerable<Data> GetData(IEnumerable<DateTime> dates) { throw new NotImplementedException(); }

        public virtual IEnumerable<Data> GetData(IEnumerable<DateTime> dates, TimeSpan firstTime, TimeSpan secondTime) { throw new NotImplementedException(); }

        public abstract void Run(IView view, IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam);
    }
}
