using System.Collections.Generic;
using DomainModel.Entity;

namespace DomainModel.Abstract
{
    public interface IDataRepository
    {
        IEnumerable<Data> Data { get; }
    }
}
