using System.Linq;
using WMS.Common;

namespace WMS.Domain
{
    public interface IRepository<T> where T : IEntity
    {
        IQueryable<T> GetAll();
    }
}
