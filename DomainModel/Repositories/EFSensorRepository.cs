using System;
using System.Linq;

using DomainModel.WMSDatabaseService;
using DomainModel.Cache;
using System.Collections.Generic;

namespace DomainModel.Repositories
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
