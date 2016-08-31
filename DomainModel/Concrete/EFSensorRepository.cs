using System.Collections.Generic;
using DomainModel.Abstract;
using DomainModel.Entity;
using System.Linq;

namespace DomainModel.Concrete
{
    public class EFSensorRepository : ISensorRepository
    {
        private readonly EFDatabaseContext context = EFDatabaseContext.GetInstance();

        public IEnumerable<Sensor> Sensors
        {
            get
            {
                return context.Sensors.ToList();
            }
        }
    }
}
