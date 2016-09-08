using System.Collections.Generic;
using System.Linq;

using DomainModel.Abstract;
using DomainModel.Entity;

namespace DomainModel.Concrete
{
    public class EFSensorRepository : IRepository<Sensor>
    {
        private static readonly EFDatabaseContext context = new EFDatabaseContext();

        public IEnumerable<Sensor> Get
        {
            get
            {
                return context.Sensors.ToList();
            }
        }
    }
}
