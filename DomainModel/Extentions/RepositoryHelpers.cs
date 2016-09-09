using System;
using System.Collections.Generic;

using DomainModel.Abstract;

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
    }
}
