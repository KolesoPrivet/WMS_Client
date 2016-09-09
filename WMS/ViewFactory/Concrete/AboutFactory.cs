using Presentation.Common;
using Presentation.Presenters;

using UI.ViewFactory.Abstract;
using UI.Views;

namespace UI.ViewFactory.Concrete
{
    class AboutFactory : Factory
    {
        public override Presenter CreatePresenter()
        {
            return new AboutPresenter();
        }

        public override IView CreateView()
        {
            return new AboutForm();
        }
    }
}
