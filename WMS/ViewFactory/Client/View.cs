using WMS.WinformsClient.Common;

using WMS.WinformsClient.ViewFactory.Abstract;

namespace WMS.WinformsClient.ViewFactory.Client
{
    class View
    {
        #region Fields

        private readonly Presenter _concretePresenter;


        private readonly IView _concreteView;

        #endregion


        #region Help Methods

        public View(Factory factory)
        {
            _concreteView = factory.CreateView();
            _concretePresenter = factory.CreatePresenter();
        }


        public void Run()
        {
            _concreteView.OwnPresenter = _concretePresenter;
            _concretePresenter.Run( _concreteView );
        }

        #endregion
    }
}
