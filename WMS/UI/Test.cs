using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS.UI
{   //TODO: приведи в божеский вид эту форму.
    public partial class Test : Form
    {
        private CancellationTokenSource cts;
        SerialPort sp = new SerialPort();

        public Test()
        {
            InitializeComponent();
            textBox1.Text = "Датчик температуры";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            
            cts = new CancellationTokenSource();

            sp.BaudRate = 9600;
            sp.PortName = "COM3";
            sp.Open();

            Start(cts);
        }

        public async Task<string> Monitoring(CancellationTokenSource cts)
        {
            return await Task.Run(() => GetMonitor());
        }

        public string GetMonitor()
        {
            if (!cts.IsCancellationRequested)
            {
                sp.WriteLine("G");
                string stroke = sp.ReadLine();

                return stroke;
            }
            return " ";
        }

        public async void Start(CancellationTokenSource cts)
        {
            while ( !cts.IsCancellationRequested )
            {
                TB_Data.Text = await Monitoring(cts);
            }
            sp.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();

                button2.Enabled = false;
                button1.Enabled = true;
            }
        }

        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts.Cancel();
            sp.Close();
        }
    }
}
