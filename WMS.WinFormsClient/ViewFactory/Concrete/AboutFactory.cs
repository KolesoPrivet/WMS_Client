namespace WMS.WinFormsClient
{
    class AboutFactory : Factory
    {
        public override Presenter CreatePresenter()
        {
            return new AboutPresenter();
        }

        public override IView CreateView()
        {
            return new AboutForm();
        }
    }
}
