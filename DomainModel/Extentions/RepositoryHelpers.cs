using System;
using System.Linq;
using System.Collections.Generic;

using DomainModel.Abstract;
using DomainModel.Entity;

namespace DomainModel.Extentions
{
    public static class RepositoryHelpers
    {
        public static IEnumerable<Sensor> SensorFilter(this IRepository<Sensor> repositoryParam, Func<Sensor, bool> selectorParam)
        {
            foreach (Sensor s in repositoryParam.Get)
            {
                if (selectorParam( s ))
                    yield return s;
            }
        }

        public static IEnumerable<Data> DataFilter(this IRepository<Data> repositoryParam, Func<Data, bool> selectoParam)
        {
            foreach (Data d in repositoryParam.Get)
            {
                if (selectoParam( d ))
                    yield return d;
            }
        }

        public static Data SingleDataFilter(this IRepository<Data> repositoryParam, Func<Data, bool> selectoParam)
        {
            Data result = null;

            foreach (Data d in repositoryParam.Get)
            {
                if (selectoParam( d ))
                {
                    result = d;
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
