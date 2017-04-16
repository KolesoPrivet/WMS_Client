using WMS.WinformsClient.Common;

namespace WMS.WinformsClient.Presenters
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
