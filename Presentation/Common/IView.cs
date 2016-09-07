using DomainModel.Abstract;
using DomainModel.Entity;

namespace Presentation.Common
{
    public interface IView
    {
        void Show();
        void Close();
    }
}
