using WMS.WinformsClient.Common;
using WMS.WinformsClient.Presenters;
using WMS.WinformsClient.ViewFactory.Abstract;
using WMS.WinformsClient.Views;

namespace WMS.WinformsClient.ViewFactory.Concrete
{
    class SelectDateFactory : Factory
    {
        public override Presenter CreatePresenter()
        {
            return new SelectDatePresenter();
        }

        public override IView CreateView()
        {
            return new SelectDateForm();
        }
    }
}
