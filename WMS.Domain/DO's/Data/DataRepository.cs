using System.Linq;
using System;

using WMS.Domain;

namespace WNS.Domain
{
    public class DataRepository : IRepository<Data>
    {
        public IQueryable<Data> GetAll()
        {
            using(WmsContext context = new WmsContext())
            {
                return context.Data.AsQueryable();
            }
        }
    }
}
