namespace WMS.WinFormsClient
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
