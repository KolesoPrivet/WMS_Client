using DomainModel.Abstract;
using DomainModel.Entity;

namespace Presentation.Common
{
    public interface IView
    {
        void Show(IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam);
        void Close();
    }
}
