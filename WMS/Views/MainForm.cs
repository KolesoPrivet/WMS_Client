using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using GMap.NET;

using Presentation.Presenters;
using Presentation.Common;
using Presentation.ViewModels;

using ViewPresenter = UI.ViewFactory.Client.View;
using UI.ViewFactory.Concrete;

using Presentation.LogsBuilder.Common;
using Presentation.LogsBuilder.Concrete;

using DomainModel.WMSDatabaseService;

namespace UI.Views
{
    public partial class MainForm : Form, IView
    {
        #region Fields

        private bool _isDataLoadedFromDB;


        public List<Log> LogsList { get; } = new List<Log>();

        public List<Log> ErrorLogsList { get; } = new List<Log>();


        public List<Sensor> AllSensors { get; private set; }

        public List<Data> AllData { get; set; }


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

        #endregion


        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
        }


        private void MainMap_Load(object sender, EventArgs e)
        {

            //Настройки для компонента GMap.
            sensorMap.Bearing = 0;

            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту
            //с помощью правой кнопки мыши.
            sensorMap.CanDragMap = true;

            //Указываем, что перетаскивание карты осуществляется
            //с использованием левой клавишей мыши.
            //По умолчанию - правая.
            sensorMap.DragButton = MouseButtons.Left;

            sensorMap.GrayScaleMode = true;

            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
            sensorMap.MarkersEnabled = true;

            //Указываем значение максимального приближения.
            sensorMap.MaxZoom = 18;

            //Указываем значение минимального приближения.
            sensorMap.MinZoom = 2;

            //Устанавливаем центр приближения/удаления
            //курсор мыши.
            sensorMap.MouseWheelZoomType =
                GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            //Отказываемся от негативного режима.
            sensorMap.NegativeMode = false;

            //Разрешаем полигоны.
            sensorMap.PolygonsEnabled = true;

            //Разрешаем маршруты
            sensorMap.RoutesEnabled = true;

            //Скрываем внешнюю сетку карты
            //с заголовками.
            sensorMap.ShowTileGridLines = false;

            //Указываем, что при загрузке карты будет использоваться
            //18ти кратное приближение.
            sensorMap.Zoom = 5;

            //Указываем что будем использовать карты Google.
            sensorMap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            sensorMap.Position = new PointLatLng( 55.75393, 37.620795 );
        }

        #endregion


        #region Supporting methods

        void IView.Show()
        {
            Application.Run( this );
        }


        /// <summary>
        /// Set enable controls
        /// </summary>
        private void EnableControsl()
        {
            rButtonAllDates.Enabled = true;
            rButtonChooseDate.Enabled = true;
            rButtonAllSensors.Enabled = true;
            rButtonChooseSensors.Enabled = true;

            btnShwMap.Enabled = true;
            btnRequestNetwork.Enabled = true;
            btnSelectSensorsForRequest.Enabled = true;

            SaveAsMenu.Enabled = true;

            comboBoxSNMap.Enabled = true;
        }


        /// <summary>
        /// Settings for columns
        /// </summary>
        private void SettingColumns()
        {
            dgvSens.RowHeadersVisible = false;

            dgvSens.Columns["Id"].Visible = false;
            dgvSens.Columns["Name"].Width = 100;
            dgvSens.Columns["SensorType"].Width = 150;
            dgvSens.Columns["SensorType"].Name = "Sensor type";

            dgvData.RowHeadersVisible = false;

            dgvData.Columns["Id"].Visible = false;
            dgvData.Columns["Sensors"].Visible = false;
            dgvData.Columns["SensorId"].Visible = false;
        }


        /// <summary>
        /// Bind chart to data from datagridviews
        /// </summary>
        private void BindChart()
        {
            unionChart.DataSource = dgvData.DataSource;
            unionChart.Series["Датчик"].XValueMember = "Date";
            unionChart.Series["Датчик"].YValueMembers = "Value";
            unionChart.DataBind();
        }


        /// <summary>
        /// Check sensors and data count
        /// </summary>
        private void CheckSensorDataCount()
        {
            rtbAmountSensors.Text = "Количество датчиков: " + dgvSens.Rows.Count.ToString();
            rtbSensorsValue.Text = "Показаний датчика: " + dgvData.Rows.Count.ToString();
        }

        #endregion


        #region Buttons

        /// <summary>
        /// Button is downloaded actual data from DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnRefreshDB_Click(object sender, EventArgs e)
        {
            dgvSens.DataSource = null;
            dgvData.DataSource = null;

            try
            {
                progressBarLoadDataFromDB.Minimum = 1;
                progressBarLoadDataFromDB.Maximum = 10;
                progressBarLoadDataFromDB.Style = ProgressBarStyle.Marquee;
                progressBarLoadDataFromDB.MarqueeAnimationSpeed = 30;


                //Load all sensors from database
                dgvSens.DataSource = await Task.Factory.StartNew( () =>
                {
                    AllSensors = ((MainPresenter)OwnPresenter).GetSensors().ToList();

                    foreach (var i in AllSensors)
                        comboBoxSNMap.Items.Add( i.Name );

                    return AllSensors;
                } );


                //Load whole data from sensors
                dgvData.DataSource = await Task.Factory.StartNew( () =>
                {
                    AllData = ((MainPresenter)OwnPresenter).GetData().ToList();

                    return AllData.Where( x => x.SensorId == AllSensors.First().Id ).ToList();
                } );


                
                //Set markers
                await Task.Factory.StartNew( () =>
                {
                    sensorMap.Overlays.Add( ((MainPresenter)OwnPresenter).GetMarkersOfSensors(AllSensors) );
                } );




                if (!_isDataLoadedFromDB)
                {
                    EnableControsl();

                    btnRefreshDB.Text = "Обновить данные";
                }

                SettingColumns();

                _isDataLoadedFromDB = true;

                progressBarLoadDataFromDB.Style = ProgressBarStyle.Continuous;
                progressBarLoadDataFromDB.MarqueeAnimationSpeed = 0;

                CheckSensorDataCount();

                BindChart();
            }
            catch (Exception ex)
            {
                Logger logger = new Logger( new CriticalLogBuilder() );
                logger.WriteLog( LogsList, ex.ToString() );
                Log result = logger.WriteLog( ErrorLogsList, ex.ToString() );

                rtbLogs.AppendText( string.Format( "{0} {1}\n{2}:\n", result.EventLogTime, result.LevelType, result.Description ) );
                rtbLogs.AppendText( Environment.NewLine );
                rtbLogs.AppendText( new string( '-', 350 ) );
            }
        }


        /// <summary>
        /// Button is downloaded a map with actual markers(sensors)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnShwMap_Click(object sender, EventArgs e)
        {
            sensorMap.Visible = true;

            await Task.Factory.StartNew( () =>
            {
                IPStatus status = IPStatus.Unknown;
                try
                {
                    status = new Ping().Send( "yandex.ru" ).Status;
                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.ToString() );
                }

                if (status == IPStatus.Success)
                {
                    comboBoxSNMap.Enabled = true;
                    txtBoxCheckInternet.ForeColor = Color.FromArgb( 0, 192, 0 );
                    txtBoxCheckInternet.Text = "Доступно";
                    btnShwMap.Enabled = false;
                }
                else
                {
                    txtBoxCheckInternet.ForeColor = Color.FromArgb( 192, 0, 0 );
                    txtBoxCheckInternet.Text = "Отсутствует";
                }
            } );
        }


        /// <summary>
        /// Button is opened a window with sensor selection for request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectSensorsForRequest_Click(object sender, EventArgs e)
        {
            //TODO: realize dependency injection
            ViewPresenter view = new ViewPresenter( new SelectSensorsFactory() );

            view.Run();

            rtbSelectedSensorsCount.Text = SelectSensorsForm.FinalList.Count.ToString();
        }


        /// <summary>
        /// Button is dispatched a request for wireless sensor network
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnRequestNetwork_Click(object sender, EventArgs e)
        {
            //TODO: Request to sensors

        }


        /// <summary>
        /// Button is opened a window with sensor selection for data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rButtonChooseSensors_MouseClick(object sender, MouseEventArgs e)
        {
            ViewPresenter view = new ViewPresenter( new SelectSensorsFactory() );

            view.Run();

            if (SelectSensorsForm.FinalList.Count > 0)
                dgvSens.DataSource = SelectSensorsForm.FinalList.ToList();

            rtbAmountSensors.Text = "Количество датчиков: " + dgvSens.RowCount.ToString();
        }


        /// <summary>
        /// Button is chosen all sensors for data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rButtonAllSensors_MouseClick(object sender, MouseEventArgs e)
        {
            dgvSens.DataSource = ((MainPresenter)OwnPresenter).GetSensors();

            rtbAmountSensors.Text = "Количество датчиков: " + dgvSens.Rows.Count.ToString();
        }


        /// <summary>
        /// Button is opened a window with date selection for data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rButtonChooseDate_MouseClick(object sender, EventArgs e)
        {
            var currentRow = dgvSens.CurrentRow;

            if (currentRow != null)
            {
                var currentSensor = currentRow.DataBoundItem as Sensor;

                ViewPresenter view = new ViewPresenter( new SelectDateFactory() );

                view.Run( currentSensor.Id );

                dgvData.DataSource = SelectDateForm.FinalList.OrderBy( d => d.Date ).ToList();

                rtbSensorsValue.Text = "Количество датчиков: " + dgvData.Rows.Count.ToString();
            }
            else
            {
                MessageBox.Show( "Необходимо выбрать датчик в таблице датчиков" );
            }
        }


        /// <summary>
        /// Button is chosen all dates for data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rButtonAllDates_MouseClick(object sender, EventArgs e)
        {
            var currentRow = dgvSens.CurrentRow;

            if (currentRow != null)
            {
                var currentSensor = currentRow.DataBoundItem as Sensor;

                dgvData.DataSource = OwnPresenter.GetData().Where( x => x.SensorId == currentSensor.Id ).OrderBy( v => v.Date ).ToList();

                rtbSensorsValue.Text = "Показаний датчика: " + dgvData.Rows.Count.ToString();
            }
            else
            {
                MessageBox.Show( "Необходимо выбрать датчик в таблице датчиков" );
            }
        }
        
        #endregion


        #region Menu

        private void AboutProgramMenu_Click(object sender, EventArgs e)
        {
            ViewPresenter view = new ViewPresenter( new AboutFactory() );

            view.Run();
        }


        private void RestartMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void SaveAsMenu_Click(object sender, EventArgs e)
        {
            ViewPresenter view = new ViewPresenter( new SaveAsFactory() );

            view.Run();

            //TODO: доделай логику обработки события закрытия формы сохранения
        }
       
        #endregion


        #region Filters

        private void comboBoxSNMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sensor currentSensor = OwnPresenter.GetSensorByName( comboBoxSNMap.Text );
            Data lastDataOfCurrentSensor = ((MainPresenter)OwnPresenter).GetLastData( currentSensor );

            if (lastDataOfCurrentSensor != null)
            {

                txtBoxMapSType.Text = currentSensor.SensorType;
                txtBoxMapSStatus.Text = "Рабочее"; //TODO: реализуй алгоритм проверки состояния датчика
                txtBoxMapLastDate.Text = lastDataOfCurrentSensor.Date.ToString().Remove( 10, 8 );
                txtBoxMapLastTime.Text = lastDataOfCurrentSensor.Time.ToString();
                txtBoxMapLastValue.Text = lastDataOfCurrentSensor.Value.ToString();

                sensorMap.Position = new PointLatLng( currentSensor.Lat, currentSensor.Lng );
            }
            else MessageBox.Show( "Выбранный датчик еще не получал данных" );
        }

        #endregion


        #region DataGridView

        private void dgvSens_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_isDataLoadedFromDB)
            {
                Sensor currentSensor = dgvSens.CurrentRow.DataBoundItem as Sensor;

                if (currentSensor != null)
                {
                    txtBoxCurrentSensor.Text = currentSensor.Name;


                    dgvData.DataSource = OwnPresenter.GetData().Where( d => d.SensorId == currentSensor.Id ).ToList();

                    CheckSensorDataCount();

                    BindChart();
                }
            }
        }
       
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show( "Вы действительно желаете закрыть приложение?", "Закрыть", MessageBoxButtons.OKCancel ) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}