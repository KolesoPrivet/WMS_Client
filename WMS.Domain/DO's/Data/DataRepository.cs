using System.Linq;

namespace WMS.Domain
{
    public class DataRepository : IRepository<Data>
    {
        public IQueryable<Data> GetAll()
        {
            using (WmsContext context = new WmsContext())
            {
                return context.Data.AsQueryable();
            }
        }

        public async void AddAsync(Data data)
        {
            using (WmsContext context = new WmsContext())
            {
                context.Data.Add( data );
                await context.SaveChangesAsync();
            }
        }
    }
}
