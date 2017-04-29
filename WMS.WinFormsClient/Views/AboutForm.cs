using System.Windows.Forms;

namespace WMS.WinFormsClient
{
    public partial class AboutForm : Form, IView
    {
        #region Fields

        private Presenter _ownPresenter;
        public Presenter OwnPresenter
        {
            get
            {
                return _ownPresenter;
            }

            set
            {
                if (value != null)
                {
                    _ownPresenter = value;
                }
            }
        }

        #endregion


        #region Constructors

        public AboutForm()
        {
            InitializeComponent();
        }

        #endregion
        
    }
}
