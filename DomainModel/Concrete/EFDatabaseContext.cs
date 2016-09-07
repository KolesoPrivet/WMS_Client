using System.Data.Entity;
using DomainModel.Entity;

namespace DomainModel.Concrete
{
    public class EFDatabaseContext : DbContext
    {
        public EFDatabaseContext() : base("name = EFDatabaseContext" )
        {
        }

        public virtual DbSet<Sensor> Sensors { get; set; }
        public virtual DbSet<Data> DataSet { get; set; }
    }
}
