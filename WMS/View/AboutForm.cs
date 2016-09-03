using System;
using System.Windows.Forms;
using DomainModel.Abstract;
using DomainModel.Entity;
using Presentation.Common;

namespace Presentation.Common
{
    public partial class AboutForm : Form, IView
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        public void Show(IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            throw new NotImplementedException();
        }
    }
}
