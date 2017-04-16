using WMS.WinformsClient.Common;

namespace WMS.WinformsClient.ViewFactory.Abstract
{
    abstract class Factory
    {
        public abstract IView CreateView();

        public abstract Presenter CreatePresenter();
    }
}
