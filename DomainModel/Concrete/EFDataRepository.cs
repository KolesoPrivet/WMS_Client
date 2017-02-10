using System.Collections.Generic;
using System.Linq;

using DomainModel.Abstract;
using DomainModel.Entity;

namespace DomainModel.Concrete
{
    public class EFDataRepository : IRepository<Data>
    {
        private static readonly EFDatabaseContext _context = new EFDatabaseContext();

        public IEnumerable<Data> GetAll
        {
            get
            {
                return _context.DataSet.ToList();
            }
        }
    }
}
