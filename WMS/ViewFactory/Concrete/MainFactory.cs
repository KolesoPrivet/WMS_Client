using Presentation.Common;
using Presentation.Presenters;

using UI.ViewFactory.Abstract;
using UI.Views;

namespace UI.ViewFactory.Concrete
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
