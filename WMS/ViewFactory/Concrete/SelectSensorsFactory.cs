using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Common;
using UI.ViewFactory.Abstract;
using Presentation.Presenters;
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
