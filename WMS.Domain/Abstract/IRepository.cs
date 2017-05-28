using System.Linq;

using WMS.Common;

namespace WMS.Domain
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        IQueryable<TEntity> GetAll();

        void AddAsync(TEntity entity);
    }
}
