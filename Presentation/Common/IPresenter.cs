using DomainModel.Abstract;
using DomainModel.Entity;

namespace Presentation.Common
{
    interface IPresenter
    {
        void Run(IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam);
    }
}
