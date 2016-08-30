using System.Collections.Generic;
using DomainModel.Abstract;
using DomainModel.Entity;

namespace DomainModel.Concrete
{
    public class EFSensorRepository : ISensorRepository
    {
        private static readonly EFDatabaseContext context = new EFDatabaseContext();

        public IEnumerable<Sensor> Sensors
        {
            get
            {
                return context.Sensors;
            }
        }
    }
}
