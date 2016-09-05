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
            T result = null;

            foreach (T t in repositoryParam.Get)
            {
                if (selectorParam( t ))
                {
                    result = t;
                }
            }
            return result;
        }

        public static Data LastDataFilter(this IRepository<Data> repositoryParam, Func<Data, bool> selectoParam)
        {
            Data result = null;

            foreach (Data d in repositoryParam.Get.OrderByDescending( d => d.Date ).ThenByDescending(d => d.Time))
            {
                if (selectoParam( d ))
                {
                    result = d;
                }
            }

            return result;
        }
    }
}
