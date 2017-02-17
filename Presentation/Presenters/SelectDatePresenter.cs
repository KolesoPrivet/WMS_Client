using Presentation.Common;

namespace Presentation.Presenters
{
    public class SelectDatePresenter : Presenter
    {
        public override void Run(IView viewParam)
        {
            View = viewParam;

            View.ShowDialog();
        }
    }
}
