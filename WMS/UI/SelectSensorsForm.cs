using System;
using System.Data;
using System.Linq;
using WMS.DAL;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WMS.UI
{
    public partial class SelectSensorsForm : Form
    {
        private readonly DBEntitiesContext context;
        private List<Sensors> sensors;

        #region Constructors
        public SelectSensorsForm()
        {
            InitializeComponent();
        }

        public SelectSensorsForm(DBEntitiesContext context, List<Sensors> sensors) : this()
        {
            this.context = context;
            this.sensors = sensors;
        }

        private void SelectSensorsForm_Load(object sender, EventArgs e)
        {
            var typeAndNames = (from c in context.Sensors
                                select new { c.Name, c.Type }).ToList();

            foreach (var typeAndName in typeAndNames)
            {
                chBoxSensorsNames.Items.Add(typeAndName.Name);
                comboBoxSensorType.Items.Add(typeAndName.Type);
            }

        }
        #endregion

        #region Controls
        private void comboBoxSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chBoxSensorsNames.Items.Clear();
            var names = (from c in context.Sensors
                         where c.Type == comboBoxSensorType.Text
                         select new { c.Name }).ToList();

            foreach (var name in names)
            {
                chBoxSensorsNames.Items.Add(name.Name);
            }

        }

        private void btnAcceptSelection_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chBoxSensorsNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            sensors.Add((from c in context.Sensors
                       where c.Name == chBoxSensorsNames.Text
                       select c).First());
        }
        #endregion
    }
}
