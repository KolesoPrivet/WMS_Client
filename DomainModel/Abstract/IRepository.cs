using System.Collections.Generic;
using DomainModel.Entity;
using DomainModel.Extentions;

namespace DomainModel.Abstract
{
    /// <summary>
    /// Common repository interface
    /// </summary>
    public interface IRepository<T> where T : IEntity
    {

        /// <summary>
        /// Returns an T collection
        /// </summary>
        IEnumerable<T> Get { get; }
    }
}
