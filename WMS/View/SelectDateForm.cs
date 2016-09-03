using Presentation.Views;
using System.Windows.Forms;
using DomainModel.Abstract;
using DomainModel.Entity;
using System;
using Presentation.Presenter;

namespace UI.View
{
    public partial class SelectDateForm : Form, IViewSelection
    {
        private readonly int selectedSensorId;
        public SelectDateForm(int selectedSensorIdParam )
        {
            selectedSensorId = selectedSensorIdParam;
            InitializeComponent();
        }

        private void SelectDateForm_Load(object sender, EventArgs e)
        {
            foreach (var s in SelectDatePresenter.GetDates(selectedSensorId))
                chBoxDates.Items.Add( s.Date );
        }

        private void btnAcceptSelection_Click(object sender, EventArgs e)
        {

        }

        public void Show(IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            throw new NotImplementedException();
        }
    }
}
