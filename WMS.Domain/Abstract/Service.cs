using System;
using System.Collections.Generic;
using System.Linq;

using WMS.Common;

namespace WMS.Domain
{
    /// <summary>
    /// Базовый класс для всех сервисов доменных объектов
    /// </summary>
    public abstract class Service<TEntity, VDto> where TEntity : IEntity
                                        where VDto : IDto
    {
        protected IRepository<TEntity> _repository;

        /// <summary>
        /// DO -> DTO
        /// </summary>
        public abstract VDto Map(TEntity source);

        /// <summary>
        /// DO -> DTO
        /// </summary>
        public abstract List<VDto> Map(IEnumerable<TEntity> source);

        /// <summary>
        /// Получить список ДТО из репозитория.
        /// </summary>
        public VDto GetById(int id)
        {
            TEntity domainObject = _repository.GetAll().Where( x => x.Id == id ).First();

            return Map( domainObject );
        }

        /// <summary>
        /// Получить список ДТО из репозитория.
        /// </summary>
        public List<VDto> Get(Func<TEntity, bool> predicate)
        {
            if (predicate == null)
                return null;

            List<TEntity> domainObjects = _repository.GetAll().Where( predicate ).ToList();

            return Map( domainObjects );
        }
    }
}
