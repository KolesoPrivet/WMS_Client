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
        private bool pin1, pin2, pin3, pin4, pin5, pin6, pin7, pin8, pin9;
        SerialPort sp = new SerialPort();

        public Test()
        {
            InitializeComponent();
            button2.Enabled = false;
            sp.BaudRate = 9600;
            sp.PortName = "COM3";
            sp.Open();
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
            Random rnd = new Random();
            do
            {
                TB_Data.Text = await Task.Run(() =>
                {
                    if (!cts.IsCancellationRequested)
                    {
                        if (sp.IsOpen)
                        {
                            sp.WriteLine(rnd.Next(2, 9).ToString());

                            return " ";
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
            sp.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.WriteLine("1");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.WriteLine("2");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.WriteLine("3");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.WriteLine("4");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                if (!pin5)
                {
                    sp.WriteLine("");
                    pin5 = true;
                }
                else
                {
                    sp.WriteLine("");
                    pin5 = false;
                }
            }
        }
    }
}
