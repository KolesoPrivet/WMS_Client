using System.Collections.Generic;
using DomainModel.Entity;

namespace DomainModel.Abstract
{
    public interface ISensorRepository
    {
        IEnumerable<Sensor> Sensors { get; }
    }
}
