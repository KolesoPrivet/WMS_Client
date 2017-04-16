using System.Linq;
using System;

using WMS.Domain.Cache;
using WMS.Domain.WMSDatabaseService;

namespace WNS.Domain.Repositories
{
    public class EFDataRepository
    {
        public static IQueryable<Data> GetAll()
        {
            WMSEntities context = new WMSEntities(new Uri( "http://localhost:58833/DatabaseService.svc/" ) );

            CacheEntity.CurrentData = context.Data.ToList();

            return context.Data.AsQueryable();
        }
    }
}
