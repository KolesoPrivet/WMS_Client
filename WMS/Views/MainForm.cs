//-------------------------------------------------------------------
// Client application for wireless monitoring system. 
// Created by Alexander Kolesnikov.
//-------------------------------------------------------------------

#region Namespaces

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
using UI.ViewFactory.Abstract;


using Presentation.LogsBuilder.Common;
using Presentation.LogsBuilder.Concrete;

using DomainModel.WMSDatabaseService;

using WMS.QuizService;

using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

#endregion

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


        public ResultSettings QuizResult { get; private set; } = ResultSettings.showOnly;

        #endregion


        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            SettingComboboxes();
        }


        private void SettingMaps(object sender, EventArgs e)
        {
            GMapControl currentMap = ((GMapControl)sender);
            //Настройки для компонента GMap.
            currentMap.Bearing = 0;

            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту
            //с помощью правой кнопки мыши.
            currentMap.CanDragMap = true;

            //Указываем, что перетаскивание карты осуществляется
            //с использованием левой клавишей мыши.
            //По умолчанию - правая.
            currentMap.DragButton = MouseButtons.Left;

            currentMap.GrayScaleMode = true;

            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
            currentMap.MarkersEnabled = true;

            //Указываем значение максимального приближения.
            currentMap.MaxZoom = 18;

            //Указываем значение минимального приближения.
            currentMap.MinZoom = 2;

            //Устанавливаем центр приближения/удаления
            //курсор мыши.
            currentMap.MouseWheelZoomType =
                GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            //Отказываемся от негативного режима.
            currentMap.NegativeMode = false;

            //Разрешаем полигоны.
            currentMap.PolygonsEnabled = true;

            //Разрешаем маршруты
            currentMap.RoutesEnabled = true;

            //Скрываем внешнюю сетку карты
            //с заголовками.
            currentMap.ShowTileGridLines = false;

            //Указываем, что при загрузке карты будет использоваться
            //18ти кратное приближение.
            currentMap.Zoom = 5;

            //Указываем что будем использовать карты Google.
            currentMap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            currentMap.Position = new PointLatLng( 55.75393, 37.620795 );
        }
        #endregion


        #region Supporting methods

        void IView.Show()
        {
            Application.Run( this );
        }


        private async Task SetMarkersOnMaps()
        {
            //Set markers
            await Task.Factory.StartNew( () =>
            {
                GMapOverlay markersOverlaySensorMap = new GMapOverlay( "markersForSensorMap" );

                sensorMap.Overlays.Add( markersOverlaySensorMap );



                GMapOverlay markersOverlaySensorMinoringMap = new GMapOverlay( "markersForMonitoringMap" );

                sensorMonitoringMap.Overlays.Add( markersOverlaySensorMinoringMap );



                foreach (Sensor s in AllSensors)
                {
                    GMarkerGoogle marker = new GMarkerGoogle( new PointLatLng( s.Lat, s.Lng ), GMarkerGoogleType.blue );

                    markersOverlaySensorMap.Markers.Add( marker );

                    markersOverlaySensorMinoringMap.Markers.Add( marker );

                    marker.ToolTipText = s.Name;
                }
            } );
        }


        private async Task LoadDataFromDatabase()
        {
            dgvData.DataSource = await Task.Factory.StartNew( () =>
            {
                AllData = ((MainPresenter)OwnPresenter).GetData().ToList();

                return AllData.Where( x => x.SensorId == AllSensors.First().Id ).ToList();
            } );
        }


        private async Task LoadSensorsFromDatabase()
        {
            //Load all sensors from database
            dgvSens.DataSource = await Task.Factory.StartNew( () =>
            {
                AllSensors = ((MainPresenter)OwnPresenter).GetSensors().ToList();

                foreach (var i in AllSensors)
                    comboBoxSNMap.Items.Add( i.Name );

                return AllSensors;
            } );
        }


        private void WriteLogException(Exception ex)
        {
            Logger logger = new Logger( new CriticalLogBuilder() );

            logger.WriteLog( LogsList, ex.ToString() );

            Log result = logger.WriteLog( ErrorLogsList, ex.ToString() );

            rtbLogs.AppendText( string.Format( "{0} {1}\n{2}:\n", result.EventLogTime, result.LevelType, result.Description ) );
            rtbLogs.AppendText( Environment.NewLine );
            rtbLogs.AppendText( new string( '-', 350 ) );
        }


        private async Task<bool> CheckInternetConnection()
        {
            return await Task.Factory.StartNew( () =>
            {
                IPStatus status = IPStatus.Unknown;

                try
                {
                    status = new Ping().Send( "yandex.ru" ).Status;
                }

                catch (Exception ex)
                {
                    WriteLogException( ex );
                }

                if (status == IPStatus.Success)
                    return true;

                else
                    return false;
            } );
        }


        private async Task SendRequestToSensors()
        {
            await Task.Factory.StartNew( () =>
            {
                RequestEntity request = new RequestEntity()
                {
                    SensorIds = SelectSensorsForm.FinalList.Select( x => x.Id ).ToArray(),
                    SensorNames = SelectSensorsForm.FinalList.Select( x => x.Name ).ToArray(),
                    Frequence = int.Parse( comboBoxSelectQuizInterval.Text ),
                    QuizNumber = int.Parse( rtbQuizNumber.Text ),
                    ResultSettings = QuizResult
                };

                QuizServiceClient serviceClient = new QuizServiceClient();

                dgvQuizResult.DataSource = serviceClient.RequestToWSN( request ).ToList();



                serviceClient.Close();
            } );
        }


        /// <summary>
        /// Run new form through creating appropriate factory
        /// </summary>
        /// <param name="factoryParam"></param>
        private static void RunNewForm(Factory factoryParam)
        {
            ViewPresenter view = new ViewPresenter( factoryParam );

            view.Run();
        }


        /// <summary>
        /// Setting values into comboboxes
        /// </summary>
        private void SettingComboboxes()
        {
            comboBoxMonitoringType.Items.Add( "Единичный опрос" );
            comboBoxMonitoringType.Items.Add( "С заданным интервалом" );

            comboBoxSelectQuizInterval.Items.Add( "30" );
            comboBoxSelectQuizInterval.Items.Add( "60" );
            comboBoxSelectQuizInterval.Items.Add( "300" );
            comboBoxSelectQuizInterval.Items.Add( "1500" );
            comboBoxSelectQuizInterval.Items.Add( "3600" );
        }


        /// <summary>
        /// Settings for columns
        /// </summary>
        private void SettingDataGridViewColumns()
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
        }


        /// <summary>
        /// Set sensor info into appropriate textboxes
        /// </summary>
        /// <param name="currentSensor"></param>
        /// <param name="lastDataOfCurrentSensor"></param>
        private void ShowSensorInfo(Sensor currentSensor, Data lastDataOfCurrentSensor)
        {
            if (lastDataOfCurrentSensor != null)
            {

                txtBoxMapSType.Text = currentSensor.SensorType;
                txtBoxMapSStatus.Text = "Рабочее"; //TODO: реализуй алгоритм проверки состояния датчика
                txtBoxMapLastDate.Text = lastDataOfCurrentSensor.Date.ToString().Remove( 10, 8 );
                txtBoxMapLastTime.Text = lastDataOfCurrentSensor.Time.ToString();
                txtBoxMapLastValue.Text = lastDataOfCurrentSensor.Value.ToString();

                sensorMap.Position = new PointLatLng( currentSensor.Lat, currentSensor.Lng );
            }
            else
            {
                txtBoxMapSType.Text = currentSensor.SensorType;
                txtBoxMapSStatus.Text = "Рабочее";
                txtBoxMapLastDate.Text = "Empty";
                txtBoxMapLastTime.Text = "Empty";
                txtBoxMapLastValue.Text = "Empty";

                sensorMap.Position = new PointLatLng( currentSensor.Lat, currentSensor.Lng );
            }
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
        /// Count sensors and data number and set it into rtbAmountSensors and rtbSensorsValue
        /// </summary>
        private void CountSensorAndDataNumber()
        {
            rtbAmountSensors.Text = "Количество датчиков: " + dgvSens.Rows.Count.ToString();
            rtbSensorsValue.Text = "Показаний датчика: " + dgvData.Rows.Count.ToString();
        }


        /// <summary>
        /// Count number of required quiz
        /// </summary>
        /// <returns></returns>
        private int CountQuizNumber()
        {
            if (comboBoxSelectQuizInterval.Text == null) return 0;

            return 1 + (int)(dtpTo.Value.TimeOfDay.TotalSeconds - dtpFrom.Value.TimeOfDay.TotalSeconds) / (int)(TimeSpan.Parse( "0:00:" + comboBoxSelectQuizInterval.Text ).TotalSeconds);
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


            comboBoxSNMap.Items.Clear();
            sensorMap.Overlays.Clear();
            sensorMonitoringMap.Overlays.Clear();
            sensorMap.Overlays.Clear();

            try
            {
                progressBarLoadDataFromDB.Minimum = 1;
                progressBarLoadDataFromDB.Maximum = 10;
                progressBarLoadDataFromDB.Style = ProgressBarStyle.Marquee;
                progressBarLoadDataFromDB.MarqueeAnimationSpeed = 30;

                await LoadSensorsFromDatabase();

                await LoadDataFromDatabase();

                await SetMarkersOnMaps();

                if (!_isDataLoadedFromDB)
                {
                    EnableControsl();

                    btnRefreshDB.Text = "Обновить данные";
                }

                SettingDataGridViewColumns();

                CountSensorAndDataNumber();

                BindChart();

                _isDataLoadedFromDB = true;

                progressBarLoadDataFromDB.Style = ProgressBarStyle.Continuous;
                progressBarLoadDataFromDB.MarqueeAnimationSpeed = 0;
            }
            catch (Exception ex)
            {
                WriteLogException( ex );
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
            sensorMonitoringMap.Visible = true;

            bool result = await CheckInternetConnection();

            if (result)
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
        }


        /// <summary>
        /// Button is opened a window with sensor selection for request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectSensorsForRequest_Click(object sender, EventArgs e)
        {
            RunNewForm( new SelectSensorsFactory() );

            if (SelectSensorsForm.FinalList.Count > 0)
                rtbSelectedSensorsCount.Text = "Датчиков выбрано: " + SelectSensorsForm.FinalList.Count.ToString();
        }


        /// <summary>
        /// Button is dispatched request for wireless sensor network
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnRequestNetwork_Click(object sender, EventArgs e)
        {
            string warning = "Выбранных вами датчиков: " + SelectSensorsForm.FinalList.Count() + "\nНачать опрос?";


            //TODO: Request to sensors
            if (MessageBox.Show( warning, "Предупреждение", MessageBoxButtons.OKCancel ) == DialogResult.OK)
            {
                dgvQuizResult.DataSource = null;


                progressBarMonitoring.Minimum = 1;
                progressBarMonitoring.Maximum = 10;
                progressBarMonitoring.Style = ProgressBarStyle.Marquee;
                progressBarMonitoring.MarqueeAnimationSpeed = 30;


                rtbQuizNumber.Text = CountQuizNumber().ToString();



                await SendRequestToSensors();



                dgvQuizResult.RowHeadersVisible = false;
                dgvQuizResult.Columns["Id"].Visible = false;



                rtbDataCountQuiz.Text = "Показаний датчика: " + ((List<ResponseEntity>)dgvQuizResult.DataSource).Count().ToString();

                rtbSensorsCountQuiz.Text = "Количество датчиков: " + ((List<ResponseEntity>)dgvQuizResult.DataSource).Select( x => x.SensorId ).Distinct().Count().ToString();



                progressBarMonitoring.Style = ProgressBarStyle.Continuous;
                progressBarMonitoring.MarqueeAnimationSpeed = 0;
            }
        }




        /// <summary>
        /// Button is opened a window with sensor selection for data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rButtonChooseSensors_MouseClick(object sender, MouseEventArgs e)
        {
            RunNewForm( new SelectSensorsFactory() );

            if (SelectSensorsForm.FinalList.Count > 0)
            {
                dgvSens.DataSource = SelectSensorsForm.FinalList.ToList();

                rtbAmountSensors.Text = "Количество датчиков: " + dgvSens.RowCount.ToString();
            }
        }


        /// <summary>
        /// Button is chosen all sensors for data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rButtonAllSensors_MouseClick(object sender, MouseEventArgs e)
        {
            dgvSens.DataSource = ((MainPresenter)OwnPresenter).GetSensors().ToList();

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

                if (SelectDateForm.FinalList.Count() > 0)
                {
                    dgvData.DataSource = SelectDateForm.FinalList.OrderBy( d => d.Date ).ToList();

                    rtbSensorsValue.Text = "Количество датчиков: " + dgvData.Rows.Count.ToString();
                }
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


        private void radioBtnOnlyShow_Click(object sender, EventArgs e)
        {
            QuizResult = ResultSettings.showOnly;
        }


        private void radioBtnOnlySave_Click(object sender, EventArgs e)
        {
            QuizResult = ResultSettings.saveOnly;
        }


        private void radioBtnSaveAndShow_Click(object sender, EventArgs e)
        {
            QuizResult = ResultSettings.showAndSave;
        }

        #endregion


        #region Menu

        private void AboutProgramMenu_Click(object sender, EventArgs e)
        {
            RunNewForm( new AboutFactory() );
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
            RunNewForm( new SaveAsFactory() );

            //TODO: доделай логику обработки события закрытия формы сохранения
        }

        #endregion


        #region Filters

        private void comboBoxSNMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sensor currentSensor = OwnPresenter.GetSensorByName( comboBoxSNMap.Text );

            Data lastDataOfCurrentSensor = ((MainPresenter)OwnPresenter).GetLastData( currentSensor );

            ShowSensorInfo( currentSensor, lastDataOfCurrentSensor );
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

                    CountSensorAndDataNumber();

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
    }
}