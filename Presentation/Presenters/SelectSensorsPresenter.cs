using Presentation.Common;

namespace Presentation.Presenters
{
    public class SelectSensorsPresenter : Presenter
    {
        public override void Run(IView viewParam)
        {
            View = viewParam;

            View.ShowDialog();
        }
    }
}
