using System;
using System.Windows.Forms;
using DomainModel.Abstract;
using DomainModel.Entity;
using Presentation.Common;

namespace UI.Views
{
    public partial class AboutForm : Form, IView
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        public Presenter OwnPresenter
        {
            get
            {
                return OwnPresenter;
            }

            set
            {
                if (value != null)
                {
                    OwnPresenter = value;
                }
            }
        }
    }
}
