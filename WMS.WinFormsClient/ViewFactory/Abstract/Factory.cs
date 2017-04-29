namespace WMS.WinFormsClient
{
    abstract class Factory
    {
        public abstract IView CreateView();

        public abstract Presenter CreatePresenter();
    }
}
