using Presentation.Common;

namespace Presentation.Presenter
{
    public class AboutPresenter
    {
        private readonly IView view;

        public AboutPresenter(IView viewParam)
        {
            view = viewParam;
        }
        public void Run()
        {
            view.Show();
        }
    }
}
