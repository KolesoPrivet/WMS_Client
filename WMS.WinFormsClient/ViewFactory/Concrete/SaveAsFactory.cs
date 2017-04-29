namespace WMS.WinFormsClient
{
    class SaveAsFactory : Factory
    {
        public override Presenter CreatePresenter()
        {
            return new SaveAsPresenter();
        }

        public override IView CreateView()
        {
            return new SaveAsForm();
        }
    }
}
