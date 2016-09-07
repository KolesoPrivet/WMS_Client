using Presentation.Views;
using System.Windows.Forms;
using System;
using Presentation.Presenter;
using System.Linq;
using System.Text.RegularExpressions;

namespace UI.View
{
    public partial class SelectDateForm : Form, IViewSelection
    {
        private readonly int selectedSensorId;
        private readonly Regex regexPatternForTime = new Regex( "^(([0,1][0-9])|(2[0-3])):[0-5][0-9]$" );

        public SelectDateForm(int selectedSensorIdParam)
        {
            selectedSensorId = selectedSensorIdParam;
            InitializeComponent();
        }

        private void SelectDateForm_Load(object sender, EventArgs e)
        {
            foreach (var s in SelectDatePresenter.GetDates( selectedSensorId ))
            {
                if (!chBoxDates.Items.Contains( s ))
                    chBoxDates.Items.Add( s.Date );
            }

            var items = chBoxDates.Items.Cast<DateTime>().OrderBy( d => d.Date ).ToList();

            chBoxDates.Items.Clear();

            foreach (var i in items)
            {
                chBoxDates.Items.Add( i );
            }
        }

        private void btnAcceptSelection_Click(object sender, EventArgs e)
        {
            if (regexPatternForTime.IsMatch( txtBoxFirstTimeValue.Text )
                && regexPatternForTime.IsMatch( txtBoxSecondTimeValue.Text ))
            {
                SelectDatePresenter.FinalList.AddRange(
                    SelectDatePresenter.GetData( chBoxDates.CheckedItems.OfType<DateTime>(),
                                                 TimeSpan.Parse( txtBoxFirstTimeValue.Text ),
                                                 TimeSpan.Parse( txtBoxSecondTimeValue.Text ) ) );

                Close();
            }
            else
            {
                MessageBox.Show( "Неккоректный ввод времени!" );
            }
        }

        private void txtBoxFirstTimeValue_MouseEnter(object sender, EventArgs e)
        {
            toolTipForSelectDateForm.ToolTipTitle = "Внимание!";
            toolTipForSelectDateForm.SetToolTip( txtBoxFirstTimeValue, "Введите время в 24-часовом формате. 00:00" );
            toolTipForSelectDateForm.SetToolTip( txtBoxSecondTimeValue, "Введите время в 24-часовом формате. 00:00" );
        }

        private void txtBoxSecondTimeValue_MouseEnter(object sender, EventArgs e)
        {
            toolTipForSelectDateForm.ToolTipTitle = "Внимание!";
            toolTipForSelectDateForm.SetToolTip( txtBoxFirstTimeValue, "Введите время в 24-часовом формате. 00:00" );
            toolTipForSelectDateForm.SetToolTip( txtBoxSecondTimeValue, "Введите время в 24-часовом формате. 00:00" );
        }
    }
}
