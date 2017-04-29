namespace WMS.WinFormsClient
{
    class SelectDateFactory : Factory
    {
        public override Presenter CreatePresenter()
        {
            return new SelectDatePresenter();
        }

        public override IView CreateView()
        {
            return new SelectDateForm();
        }
    }
}
