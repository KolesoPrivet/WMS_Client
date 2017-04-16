using WMS.WinformsClient.Common;
using WMS.WinformsClient.Presenters;

using WMS.WinformsClient.ViewFactory.Abstract;
using WMS.WinformsClient.Views;

namespace WMS.WinformsClient.ViewFactory.Concrete
{
    class MainFactory : Factory
    {
        public override IView CreateView()
        {
            return new MainForm();
        }

        public override Presenter CreatePresenter()
        {
            return new MainPresenter();
        }
    }
}
