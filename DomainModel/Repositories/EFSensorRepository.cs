using System;
using System.Linq;

using DomainModel.WMSDatabaseService;
using System.Data.Entity;

namespace DomainModel.Repositories
{
    public class EFSensorRepository
    {
        public static IQueryable<Sensor> GetAll()
        {
            WMSEntities context = new WMSEntities( new Uri( "http://localhost:58833/DatabaseService.svc/" ) );

            return context.Sensors.Expand(x => x.Data).AsQueryable();
        }
    }
}
