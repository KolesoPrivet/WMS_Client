using WMS.Common;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WMS.WinFormsClient
{
    public interface IView
    {
        void Show();

        void Close();

        DialogResult ShowDialog();

        Presenter OwnPresenter { get; set; }
    }
}
