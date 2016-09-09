using Presentation.Common;

namespace UI.ViewFactory.Abstract
{
    abstract class Factory
    {
        public abstract IView CreateView();
        public abstract Presenter CreatePresenter();
    }
}
