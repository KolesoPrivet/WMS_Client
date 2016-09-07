using Presentation.Views;
using System;
using System.Windows.Forms;
using DomainModel.Abstract;
using DomainModel.Entity;
using Presentation.Common;

namespace WMS.View
{
    public partial class SaveReportForm : Form, IViewSelection
    {
        public SaveReportForm()
        {
            InitializeComponent();
        }
    }
}
