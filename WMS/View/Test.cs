using System;
using System.Windows.Forms;
using Presentation.Presenter;

namespace Presentation.Common
{   //TODO: приведи в божеский вид эту форму.
    public partial class Test : Form
    {
        

        public Test()
        {
            InitializeComponent();
        }

        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #region Buttons
        private void button3_Click(object sender, EventArgs e)
        {
            //monitoringService.OnOffLed(LedColors.RedLedOne);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //monitoringService.OnOffLed(LedColors.RedLedTwo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //monitoringService.OnOffLed(LedColors.GreenLedOne);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // monitoringService.OnOffLed(LedColors.GreenLedTwo);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //monitoringService.OnOffLed(LedColors.YellowLedOne);
        }
        #endregion
    }
}
