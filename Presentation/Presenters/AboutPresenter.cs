using Presentation.Common;

namespace Presentation.Presenters
{
    public class AboutPresenter : Presenter
    {
        public override void Run(IView viewParam)
        {
            View = viewParam;

            View.ShowDialog();
        }
    }
}
