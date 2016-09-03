using System.Data.Entity;
using DomainModel.Entity;

namespace DomainModel.Concrete
{
    public class EFDatabaseContext : DbContext
    {
        private static EFDatabaseContext instance;
        private static readonly object obj = new object();

        protected EFDatabaseContext() : base("name = EFDatabaseContext" )
        {
        }

        public static EFDatabaseContext GetInstance()
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new EFDatabaseContext();
                    }
                }
            }
            return instance;
        }

        public virtual DbSet<Sensor> Sensors { get; set; }
        public virtual DbSet<Data> DataSet { get; set; }
    }
}
