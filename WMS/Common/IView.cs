using WMS.Domain.WMSDatabaseService;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WMS.WinformsClient.Common
{
    public interface IView
    {
        void Show();

        void Close();

        DialogResult ShowDialog();

        Presenter OwnPresenter { get; set; }
    }
}
