using System.Collections.Generic;
using DomainModel.Entity;
using DomainModel.Extentions;

namespace DomainModel.Abstract
{
    public interface ISensorRepository
    {
        IEnumerable<Sensor> Sensors { get; }
    }
}
