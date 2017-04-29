using System.Linq;

namespace WMS.Domain
{
    public class SensorRepository : IRepository<Sensor>
    {
        public IQueryable<Sensor> GetAll()
        {
            using (WmsContext context = new WmsContext())
            {
                return context.Sensors.AsQueryable();
            }
        }
    }
}
