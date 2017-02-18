using System;
using System.Linq;

using DomainModel.WMSDatabaseService;

namespace DomainModel.Repositories
{
    public class EFSensorRepository
    {
        public static IQueryable<Sensor> GetAll()
        {
            WMSEntities context = new WMSEntities( new Uri( "http://localhost:58833/DatabaseService.svc/" ) );

            return context.Sensors.AsQueryable();
        }
    }
}
