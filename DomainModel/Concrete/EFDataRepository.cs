using System.Collections.Generic;
using DomainModel.Abstract;
using DomainModel.Entity;

namespace DomainModel.Concrete
{
    public class EFDataRepository : IDataRepository
    {
        private static readonly EFDatabaseContext context = new EFDatabaseContext();

        public IEnumerable<Data> Data
        {
            get
            {
                return context.DataSet;
            }
        }
    }
}
