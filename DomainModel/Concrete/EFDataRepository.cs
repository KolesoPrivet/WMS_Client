using System.Collections.Generic;
using System.Linq;

using DomainModel.Abstract;
using DomainModel.Entity;

namespace DomainModel.Concrete
{
    public class EFDataRepository : IRepository<Data>
    {
        public List<Data> GetAll()
        {
            using (EFDatabaseContext ctx = new EFDatabaseContext())
            {
                List<Data> data = (from s in ctx.DataSet.Include( "SingleSensor" )
                                        select s).ToList();


                return null;
            }
        }
    }
}
