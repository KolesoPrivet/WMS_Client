using System;
using System.Windows.Forms;
using DomainModel.Abstract;
using DomainModel.Entity;

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
