using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using Presentation.Common;

using DomainModel.Entity;

namespace UI.Views
{
    public partial class SelectDateForm : Form, IView
    {
        private readonly Regex regexPatternForTime = new Regex( "^(([0,1][0-9])|(2[0-3])):[0-5][0-9]$" );

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

        public static List<Data> FinalList { get; } = new List<Data>();

        public SelectDateForm()
        {
            InitializeComponent();
        }

        private void WarningTime()
        {
            toolTipForSelectDateForm.ToolTipTitle = "Внимание!";
            toolTipForSelectDateForm.SetToolTip( txtBoxFirstTimeValue, "Введите время в 24-часовом формате. 00:00" );
            toolTipForSelectDateForm.SetToolTip( txtBoxSecondTimeValue, "Введите время в 24-часовом формате. 00:00" );
        }

        private void SelectDateForm_Load(object sender, EventArgs e)
        {
            foreach (var s in OwnPresenter.GetDates().OrderBy( d => d.Date ).ToList())
            {
                if (!chBoxDates.Items.Contains( s ))
                    chBoxDates.Items.Add( s.Date );
            }
        }

        private void btnAcceptSelection_Click(object sender, EventArgs e)
        {
            FinalList.Clear();

            if (!txtBoxFirstTimeValue.Enabled)
            {
                foreach (var d in OwnPresenter.GetData( chBoxDates.CheckedItems.OfType<DateTime>() ))
                {
                    if (!FinalList.Contains( d ))
                        FinalList.Add( d );
                }


                Close();
            }
            else
            {
                if (regexPatternForTime.IsMatch( txtBoxFirstTimeValue.Text )
                    && regexPatternForTime.IsMatch( txtBoxSecondTimeValue.Text ))
                {
                    FinalList.AddRange( OwnPresenter.GetData( chBoxDates.CheckedItems.OfType<DateTime>(),
                                        TimeSpan.Parse( txtBoxFirstTimeValue.Text ),
                                        TimeSpan.Parse( txtBoxSecondTimeValue.Text ) ) );

                    Close();
                }
                else
                {
                    MessageBox.Show( "Неккоректный ввод времени!" );
                }
            }
        }

        private void txtBoxFirstTimeValue_MouseEnter(object sender, EventArgs e)
        {
            WarningTime();
        }

        private void txtBoxSecondTimeValue_MouseEnter(object sender, EventArgs e)
        {
            WarningTime();
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
