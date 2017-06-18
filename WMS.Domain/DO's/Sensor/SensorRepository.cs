using System.Collections.Generic;
using System.Linq;

namespace WMS.Domain
{
    public class SensorRepository : IRepository<Sensor>
    {
        public List<Sensor> GetAll()
        {
            WmsContext context = new WmsContext();

            return context.Sensors.ToList();
        }

        public async void AddAsync(Sensor sensor)
        {
            using (WmsContext context = new WmsContext())
            {
                context.Sensors.Add( sensor );
                await context.SaveChangesAsync();
            }
        }
    }
}
