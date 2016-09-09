using Presentation.Common;
using Presentation.Presenters;

using UI.ViewFactory.Abstract;
using UI.Views;

namespace UI.ViewFactory.Concrete
{
    class SaveAsFactory : Factory
    {
        public override Presenter CreatePresenter()
        {
            return new SaveAsPresenter();
        }

        public override IView CreateView()
        {
            return new SaveAsForm();
        }
    }
}
