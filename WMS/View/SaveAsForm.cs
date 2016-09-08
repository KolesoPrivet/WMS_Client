using Presentation.Presenter;
using Presentation.Views;

using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace UI.View
{
    public partial class SaveAsForm : Form, IViewSelection
    {
        public SaveAsForm()
        {
            InitializeComponent();
        }

        private string _filePath;
        private readonly Regex regexPatternForTime = new Regex( "^(([0,1][0-9])|(2[0-3])):[0-5][0-9]$" );

        private void SaveAsForm_Load(object sender, EventArgs e)
        {
            foreach (var s in SaveAsPresenter.GetSensorsNames())
            {
                comboBoxSensorName.Items.Add( s );
            }

            foreach (var s in SaveAsPresenter.GetSensorsTypes())
            {
                if(!comboBoxSensorType.Items.Contains(s))
                    comboBoxSensorType.Items.Add( s );
            }
        }

        private void btnPathExplorer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                _filePath = folderBrowser.SelectedPath;
        }

        private async void btnSaveFile_Click(object sender, EventArgs e)
        {
            await Task.Factory.StartNew( () =>
             {
                 Excel.Application excelAppl = new Excel.Application();
                 Excel._Worksheet workSheet = excelAppl.ActiveSheet;

                 workSheet.Cells[1, "A"] = "Name";
                 workSheet.Cells[1, "B"] = "Type";
                 workSheet.Cells[1, "C"] = "Date";
             } );
        }

        private void checkBoxEnableTimeInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxFirstTimeValue.Enabled)
            {
                txtBoxFirstTimeValue.Enabled = false;
                txtBoxSecondTimeValue.Enabled = false;
            }
            else
            {
                txtBoxFirstTimeValue.Enabled = true;
                txtBoxSecondTimeValue.Enabled = true;
            }
        }
    }
}
