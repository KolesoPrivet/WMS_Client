namespace WMS.WinFormsClient
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
