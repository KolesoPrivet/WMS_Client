using System.Collections.Generic;
using DomainModel.Abstract;
using DomainModel.Entity;
using System.Linq;

namespace DomainModel.Concrete
{
    public class EFDataRepository : IDataRepository
    {
        private readonly EFDatabaseContext context = EFDatabaseContext.GetInstance();

        public IEnumerable<Data> Data
        {
            get
            {
                return context.DataSet.ToList();
            }
        }
    }
}
