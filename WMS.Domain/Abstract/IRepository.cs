using System.Collections.Generic;
using System.Linq;

using WMS.Common;

namespace WMS.Domain
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        List<TEntity> GetAll();

        void AddAsync(TEntity entity);
    }
}
