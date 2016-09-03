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
        public static IEnumerable<Sensor> SensorFilter(this IRepository<Sensor> repositoryParam, Func<Sensor, bool> selectorParam)
        {
            foreach (Sensor s in repositoryParam.Get)
            {
                if (selectorParam( s ))
                {
                    yield return s;
                }
            }
        }

        public static IEnumerable<Data> DataFilter(this IRepository<Data> repositoryParam, Func<Data, bool> selectoParam)
        {
            foreach (Data d in repositoryParam.Get)
            {
                if (selectoParam( d ))
                {
                    yield return d;
                }
            }
        }
    }
}
