using System.Collections.Generic;

using DomainModel.Abstract;
using DomainModel.Entity;

namespace DomainModel.Concrete
{
    public class EFDataRepository : IRepository<Data>
    {
        private static readonly EFDatabaseContext context = new EFDatabaseContext();

        public IEnumerable<Data> Get
        {
            get
            {
                return context.DataSet;
            }
        }
    }
}
