using System.Windows.Forms;

namespace Presentation.Common
{
    public interface IView
    {
        void Show();
        void Close();
        DialogResult ShowDialog();
        Presenter OwnPresenter { get; set; }
    }
}
