using System;
using System.Linq;
using System.Windows.Forms;
using Presentation.Presenter;
using Presentation.Common;
using System.Collections.Generic;
using Presentation.Views;

namespace UI.View
{
    public partial class SelectSensorsForm : Form, IViewSelectSensors
    {
        #region Constructors
        public SelectSensorsForm()
        {
            InitializeComponent();
        }

        private void SelectSensorsForm_Load(object sender, EventArgs e)
        {
            foreach (var s in SelectSensorsPresenter.GetSensorsNames())
                chBoxSensorsNames.Items.Add(s);

            foreach (var s in SelectSensorsPresenter.GetSensorsTypes())
                comboBoxSensorType.Items.Add(s);
        }
        #endregion

        #region Controls
        private void comboBoxSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chBoxSensorsNames.Items.Clear();

            foreach (var s in SelectSensorsPresenter.GetSensorsByType(comboBoxSensorType.Text))
            {
                chBoxSensorsNames.Items.Add(s);
            }
        }

        private void btnAcceptSelection_Click(object sender, EventArgs e)
        {

            foreach (var l in SelectSensorsPresenter.GetSensorsByName(chBoxSensorsNames.CheckedItems.OfType<string>()))
            {
                SelectSensorsPresenter.FinalList.Add(l);
            }

            Close();
        }
        #endregion

        private void SelectSensorsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectSensorsPresenter.Invoke();
        }
    }
}
