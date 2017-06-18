using System.Collections.Generic;
using System.Linq;

namespace WMS.Domain
{
    public class DataRepository : IRepository<Data>
    {
        public List<Data> GetAll()
        {
            WmsContext context = new WmsContext();
            
            return context.Data.ToList();
        }

        public async void AddAsync(Data data)
        {
            //TODO: null reference
            using (WmsContext context = new WmsContext())
            {
                context.Data.Add( data );
                await context.SaveChangesAsync();
            }
        }
    }
}
