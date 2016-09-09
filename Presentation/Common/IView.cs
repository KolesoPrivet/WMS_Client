using DomainModel.Abstract;
using DomainModel.Entity;
using System.Windows.Forms;
using Presentation.Common;

namespace Presentation.Common
{
    public interface IView
    {
        void Show();
        void Close();
        DialogResult ShowDialog();
    }
}
