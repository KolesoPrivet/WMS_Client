using System;
using System.Linq;
using System.Windows.Forms;
using Presentation.Common;
using DomainModel.Entity;
using System.Collections.Generic;

namespace UI.Views
{
    public partial class SelectSensorsForm : Form, IView
    {
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

        public static List<Sensor> FinalList { get; } = new List<Sensor>();

        #region Constructors
        public SelectSensorsForm()
        {
            InitializeComponent();
        }

        private void SelectSensorsForm_Load(object sender, EventArgs e)
        {
            foreach (var s in OwnPresenter.GetSensorsNames())
                chBoxSensorsNames.Items.Add( s );

            foreach (var s in OwnPresenter.GetSensorsTypes())
            {
                if (!comboBoxSensorType.Items.Contains( s ))
                    comboBoxSensorType.Items.Add( s );
            }
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
