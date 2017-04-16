using System;
using System.Linq;

using WMS.Domain.WMSDatabaseService;
using WMS.Domain.Cache;
using System.Collections.Generic;

namespace WMS.Domain.Repositories
{
    public class EFSensorRepository
    {
        public static IQueryable<Sensor> GetAll()
        {
            WMSEntities context = new WMSEntities( new Uri( "http://localhost:58833/DatabaseService.svc/" ) );

            CacheEntity.CurrentSensors = context.Sensors.AsQueryable().ToList();

            return context.Sensors.Expand(x => x.Data).AsQueryable();
        }
    }
}
