using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Common;

namespace UI.ViewFactory.Abstract
{
    abstract class Factory
    {
        public abstract IView CreateView();
        public abstract Presenter CreatePresenter();
    }
}
