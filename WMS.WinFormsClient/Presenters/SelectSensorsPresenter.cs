namespace WMS.WinFormsClient
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
