using System.Collections.Generic;
using System.Linq;

using DomainModel.Abstract;
using DomainModel.Entity;

namespace DomainModel.Concrete
{
    public class EFSensorRepository : IRepository<Sensor>
    {
        public List<Sensor> GetAll()
        {
            using (EFDatabaseContext ctx = new EFDatabaseContext())
            {
                List<Sensor> sensors = (from s in ctx.Sensors.Include( "DataCollection" )
                               select s).ToList();

                foreach(var s in sensors)
                {
                    ctx.Entry( s ).Collection( m => m.DataCollection ).Load();
                }
                return sensors;
            }
        }
    }
}
