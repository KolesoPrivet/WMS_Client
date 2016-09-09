using Presentation.Common;
using Presentation.Presenters;

using UI.ViewFactory.Abstract;
using UI.Views;

namespace UI.ViewFactory.Concrete
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
