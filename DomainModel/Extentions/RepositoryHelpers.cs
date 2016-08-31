using DomainModel.Abstract;
using DomainModel.Entity;
using System.Collections.Generic;
using System.Linq;

namespace DomainModel.Extentions
{
    public static class RepositoryHelpers
    {
        public static List<Sensor> GetAllSensors(this ISensorRepository repositoryParam)
        {
            return repositoryParam.Sensors.ToList();
        }
    }
}
