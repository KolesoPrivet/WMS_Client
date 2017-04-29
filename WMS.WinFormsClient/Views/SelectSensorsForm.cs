using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

using WMS.Common;

namespace WMS.WinFormsClient
{
    public partial class SelectSensorsForm : Form, IView
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
                    _ownPresenter = value;

            }
        }


        public static List<SensorDto> FinalList { get; } = new List<SensorDto>();

        #endregion


        #region Constructors

        public SelectSensorsForm()
        {
            InitializeComponent();
        }


        private void SelectSensorsForm_Load(object sender, EventArgs e)
        {
            SetComboboxes();
        }

        private void SetComboboxes()
        {
            foreach (var s in OwnPresenter.GetSensorsTypes().Distinct())
                comboBoxSensorType.Items.Add( s );

            foreach (var s in OwnPresenter.GetSensorsNames())
                chBoxSensorsNames.Items.Add( s );
        }

        #endregion


        #region Controls

        private void comboBoxSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chBoxSensorsNames.Items.Clear();

            foreach (var s in OwnPresenter.GetSensorsNames( comboBoxSensorType.Text ))
            {
                chBoxSensorsNames.Items.Add( s );
            }
        }


        private void btnAcceptSelection_Click(object sender, EventArgs e)
        {
            FinalList.Clear();

            foreach (var l in chBoxSensorsNames.CheckedItems.OfType<string>())
                FinalList.Add( OwnPresenter.GetSensorByName( l ) );

            Close();
        }

        #endregion
    }
}
