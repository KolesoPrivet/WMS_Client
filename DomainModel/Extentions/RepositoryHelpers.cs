using System;
using System.Linq;
using System.Collections.Generic;

using DomainModel.Abstract;
using DomainModel.Entity;

namespace DomainModel.Extentions
{
    public static class RepositoryHelpers
    {
        public static IEnumerable<T> Filter<T>(this IRepository<T> repositoryParam, Func<T, bool> selectorParam) where T: class, IEntity
        {
            foreach (T t in repositoryParam.Get)
            {
                if (selectorParam( t ))
                    yield return t;
            }
        }

        public static T SingleFilter<T>(this IRepository<T> repositoryParam, Func<T, bool> selectorParam) where T : class, IEntity
        {
            foreach (T t in repositoryParam.Get)
            {
                if (selectorParam( t ))
                {
                    return t;
                }
            }
            return null;
        }

        public static Data LastDataFilter(this IRepository<Data> repositoryParam, Func<Data, bool> selectoParam)
        {
            foreach (Data d in repositoryParam.Get.OrderByDescending( d => d.Date ).ThenByDescending(d => d.Time))
            {
                if (selectoParam( d ))
                {
                    return d;
                }
            }

            return null;
        }
    }
}
