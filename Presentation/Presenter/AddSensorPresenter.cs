using Presentation.Common;

namespace Presentation.Presenter
{
    public class AddSensorPresenter
    {
        private readonly IView view;

        public AddSensorPresenter(IView viewParam)
        {
            view = viewParam;
        }
        public void Run()
        {
            view.Show();
        }
    }
}
