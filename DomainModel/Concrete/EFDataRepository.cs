using System.Collections.Generic;
using DomainModel.Abstract;
using DomainModel.Entity;
using System.Linq;

namespace DomainModel.Concrete
{
    public class EFDataRepository : IRepository<Data>
    {
        private static readonly EFDatabaseContext context = EFDatabaseContext.GetInstance();

        public IEnumerable<Data> Get
        {
            get
            {
                return context.DataSet.ToList();
            }
        }
    }
}
