using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Common;
using UI.ViewFactory.Abstract;
using UI.Views;
using Presentation.Presenters;

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
