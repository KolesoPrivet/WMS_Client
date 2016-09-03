using System;
using System.Collections.Generic;

using DomainModel.Abstract;
using DomainModel.Entity;

namespace DomainModel.Extentions
{
    /// <summary>
    /// Class, that contains extension methods for repositories
    /// </summary>
    public static class RepositoryHelpers
    {
        /// <summary>
        /// Common filter for Sensors
        /// </summary>
        /// <param name="repositoryParam"></param>
        /// <param name="selectorParam"></param>
        /// <returns></returns>
        public static IEnumerable<Sensor> Filter(this IRepository<Sensor> repositoryParam, Func<Sensor, bool> selectorParam)
        {
            foreach(Sensor s in repositoryParam.Get)
            {
                if (selectorParam(s))
                {
                    yield return s;
                }
            }
        }
    }
}
