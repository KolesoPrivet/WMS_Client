using System;
using System.Linq;
using System.Windows.Forms;
using Presentation.Presenters;
using Presentation.Common;
using DomainModel.Entity;
using System.Collections.Generic;

namespace UI.Views
{
    public partial class SelectSensorsForm : Form, IView
    {
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

        public static List<Sensor> FinalList { get; private set; } = new List<Sensor>();

        #region Constructors
        public SelectSensorsForm()
        {
            InitializeComponent();
        }

        private void SelectSensorsForm_Load(object sender, EventArgs e)
        {
            foreach (var s in SelectSensorsPresenter.GetSensorsNames())
                chBoxSensorsNames.Items.Add( s );

            foreach (var s in SelectSensorsPresenter.GetSensorsTypes())
                comboBoxSensorType.Items.Add( s );
        }
        #endregion

        #region Controls
        private void comboBoxSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chBoxSensorsNames.Items.Clear();

            foreach (var s in SelectSensorsPresenter.GetSensorsNames( comboBoxSensorType.Text ))
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
