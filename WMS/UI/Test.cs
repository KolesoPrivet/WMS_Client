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
            button2.Enabled = false;
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

        /// <summary>
        /// Начинает асинхронный опрос датчика и запись ответа в TextBox.
        /// </summary>
        /// <param name="cts"></param>
        public async void Start(CancellationTokenSource cts)
        {
            do
            {
                TB_Data.Text = await Task.Run(() =>
                {
                    if (!cts.IsCancellationRequested)
                    {
                        if (sp.IsOpen)
                        {
                            sp.WriteLine("G");
                            string stroke = sp.ReadLine();

                            return stroke;
                        }
                    }
                    return " ";
                });
            } while (!cts.IsCancellationRequested);

            sp.Close();
        }

        /// <summary>
        /// Отправка отменяющего токена.
        /// </summary>
        private void Stop()
        {
            if (sp.IsOpen)
            {
                if (cts != null)
                {
                    cts.Cancel();

                    button2.Enabled = false;
                    button1.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }
      
    }
}
