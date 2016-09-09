using Presentation.Common;
using Presentation.Presenters;

using UI.ViewFactory.Abstract;
using UI.Views;

namespace UI.ViewFactory.Concrete
{
    class SelectSensorsFactory : Factory
    {
        public override Presenter CreatePresenter()
        {
            return new SelectSensorsPresenter();
        }

        public override IView CreateView()
        {
            return new SelectSensorsForm();
        }
    }
}
