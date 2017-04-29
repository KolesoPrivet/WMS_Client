namespace WMS.WinFormsClient
{
    class SelectSensorsFactory : Factory
    {
        public override Presenter CreatePresenter()
        {
            return new SelectSensorsPresenter();
        }

        public override IView CreateView()
        {
            return new SelectSensorsForm();
        }
    }
}
