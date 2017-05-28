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

using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using WMS.Common;
using WMS.WinFormsClient;

#endregion

namespace WMS.WinFormsClient
{
    public partial class MainForm : Form, IView
    {
        #region Fields

        private bool _isDataLoadedFromDB;


        public List<Log> LogsList { get; } = new List<Log>();

        public List<Log> ErrorLogsList { get; } = new List<Log>();


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

        /// <summary>
        /// Asynchronous set map markers on sensor map
        /// </summary>
        /// <returns></returns>
        private async Task SetMarkersOnMapsAsync()
        {
            //Set markers
            await Task.Factory.StartNew( () =>
            {
                GMapOverlay markersOverlaySensorMap = new GMapOverlay( "markersForSensorMap" );

                sensorMap.Overlays.Add( markersOverlaySensorMap );



                GMapOverlay markersOverlaySensorMinoringMap = new GMapOverlay( "markersForMonitoringMap" );

                sensorMonitoringMap.Overlays.Add( markersOverlaySensorMinoringMap );



                foreach (SensorDto s in CachedEntity.CurrentSensors)
                {
                    GMarkerGoogle marker = new GMarkerGoogle( new PointLatLng( s.Lat, s.Lng ), GMarkerGoogleType.blue );

                    markersOverlaySensorMap.Markers.Add( marker );

                    markersOverlaySensorMinoringMap.Markers.Add( marker );

                    marker.ToolTipText = s.Name;
                }
            } );
        }

        /// <summary>
        /// Asynchronous load data from database
        /// </summary>
        /// <returns></returns>
        private async Task LoadDataFromDatabaseAsync()
        {
            dgvData.DataSource = await Task.Factory.StartNew( () =>
            {
                return OwnPresenter.GetData().Where( x => x.SensorId == CachedEntity.CurrentSensors.First().Id )
                                             .OrderBy(x => x.Date)
                                             .ThenBy(x => x.Time)
                                             .ToList();
            } );
        }

        /// <summary>
        /// Asynchronous load sensors from database
        /// </summary>
        /// <returns></returns>
        private async Task LoadSensorsFromDatabaseAsync()
        {
            //Load all sensors from database
            dgvSens.DataSource = await Task.Factory.StartNew( () =>
            {
                return OwnPresenter.GetSensors().ToList();
            } );

            foreach (var s in OwnPresenter.GetSensorsNames())
                comboBoxSNMap.Items.Add( s );
        }

        /// <summary>
        /// Asynchronous checking an internet connection
        /// </summary>
        /// <returns></returns>
        private async Task<bool> CheckInternetConnectionAsync()
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

                return status == IPStatus.Success ? true : false;
            } );
        }

        /// <summary>
        /// Asynchronous dispatch request to sensors
        /// </summary>
        /// <returns></returns>
        private async Task SendRequestToSensorsAsync(int intervalParam, int quizNumberParam)
        {
            dgvQuizResult.DataSource = await Task.Factory.StartNew( () =>
            {
                Request requestSettings = new Request()
                {
                    SensorIds = new HashSet<int>( SelectSensorsForm.FinalList.Select( x => x.Id )),
                    SensorNames = new HashSet<string>( SelectSensorsForm.FinalList.Select( x => x.Name )),
                    Frequence = intervalParam,
                    QuizNumber = quizNumberParam,
                    ResultSettings = QuizResult
                };

                // Request may return null if "SaveOnly" option was chosen.
                 return new WMSServiceClient().RequestService( requestSettings ).ToList();
            } );
        }
         
        /// <summary>
        /// Get current row from datagridview for Sensors and set appropriate data to datagridview for Data
        /// </summary>
        private void GetDataSensorCell()
        {
            if (_isDataLoadedFromDB)
            {
                SensorDto currentSensor = dgvSens.CurrentRow.DataBoundItem as SensorDto;

                if (currentSensor != null)
                {
                    txtBoxCurrentSensor.Text = currentSensor.Name;


                    dgvData.DataSource = OwnPresenter.GetData().Where( d => d.SensorId == currentSensor.Id ).OrderBy( d => d.Date ).ToList();

                    CountSensorAndDataNumber();

                    BindChart();
                }
            }
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

        /// <summary>
        /// Run new form through creating appropriate factory
        /// </summary>
        /// <param name="factoryParam">Factory for concrete form</param>
        private static void RunNewForm(Factory factoryParam)
        {
            View view = new View( factoryParam );

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
            dgvSens.Columns["Id"].Visible = false;
            dgvSens.Columns["Name"].Width = 100;
            dgvSens.Columns["SensorType"].Width = 150;
            dgvSens.Columns["SensorType"].Name = "Sensor type";

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
        /// <param name="currentSensor">Current sensor</param>
        /// <param name="lastDataOfCurrentSensor">Last data of current sensor</param>
        private void ShowSensorInfo(SensorDto currentSensor, DataDto lastDataOfCurrentSensor)
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
        /// <returns>Number of quiz</returns>
        private int CountQuizNumber()
        {
            return comboBoxSelectQuizInterval.Text == null ? 0 : GetTimespan() / GetQuizFrequency();
        }

        /// <summary>
        /// Get time interval for request
        /// </summary>
        /// <returns>Time interval</returns>
        private int GetTimespan()
        {
            // 1 + [First time] - [Second time]
            return 1 + (int)(dtpTo.Value.TimeOfDay.TotalSeconds - dtpFrom.Value.TimeOfDay.TotalSeconds);
        }

        /// <summary>
        /// Get quiz frequency from combobox
        /// </summary>
        /// <returns>Quiz frequency/returns>
        private int GetQuizFrequency()
        {
            return (int)(TimeSpan.Parse( "0:00:" + comboBoxSelectQuizInterval.Text ).TotalSeconds);
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

                await LoadSensorsFromDatabaseAsync();

                await LoadDataFromDatabaseAsync();

                await SetMarkersOnMapsAsync();

                BindChart();

                SettingDataGridViewColumns();

                CountSensorAndDataNumber();

                if (!_isDataLoadedFromDB)
                {
                    EnableControsl();

                    btnRefreshDB.Text = "Обновить данные";
                }

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

            bool result = await CheckInternetConnectionAsync();

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


            if (SelectSensorsForm.FinalList.Count > 0) btnRequestNetwork.Enabled = true;

            rtbSelectedSensorsCount.Text = "Датчиков выбрано: " + SelectSensorsForm.FinalList.Count.ToString();
        }

        /// <summary>
        /// Button is dispatched request for wireless sensor network
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnRequestNetwork_Click(object sender, EventArgs e)
        {
            string warning = "Выбранных вами датчиков: " + SelectSensorsForm.FinalList.Count() + "\nЕсли вами не был выбран интервал опроса, то опрос датчиков проведется единожды.\nНачать опрос?";

            //TODO: Request to sensors
            if (MessageBox.Show( warning, "Предупреждение", MessageBoxButtons.OKCancel ) == DialogResult.OK)
            {
                dgvQuizResult.DataSource = null;

                //Start progress bar
                progressBarMonitoring.Minimum = 1;
                progressBarMonitoring.Maximum = 10;
                progressBarMonitoring.Style = ProgressBarStyle.Marquee;
                progressBarMonitoring.MarqueeAnimationSpeed = 30;

                int quizNumber = CountQuizNumber();

                rtbQuizNumber.Text = "Количество опросов сети: " + quizNumber.ToString();

                await SendRequestToSensorsAsync( int.Parse( comboBoxSelectQuizInterval.Text ), quizNumber );

                dgvQuizResult.Columns["Id"].Visible = false;

                rtbDataCountQuiz.Text = "Показаний датчика: " + ((List<Response>)dgvQuizResult.DataSource).Count().ToString();

                //Take selected sensors count and set them to the rtbSensorsCountQuiz
                rtbSensorsCountQuiz.Text = "Количество датчиков: " + rtbSelectedSensorsCount.Text.Substring(17);


                //Stop progress bar
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
            dgvSens.DataSource = CachedEntity.CurrentSensors;

            rtbAmountSensors.Text = "Количество датчиков: " + dgvSens.Rows.Count.ToString();
        }

        /// <summary>
        /// Button is opened a window with date selection for data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rButtonChooseDate_MouseClick(object sender, EventArgs e)
        {
            View view = new View( new SelectDateFactory() );

            view.Run();

            if (SelectDateForm.FinalList.Count() > 0)
            {
                dgvData.DataSource = SelectDateForm.FinalList.OrderBy( d => d.Date ).ToList();

                rtbSensorsValue.Text = "Количество датчиков: " + dgvData.Rows.Count.ToString();

                //Draw chart with picked dates
                BindChart();

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
                var currentSensor = currentRow.DataBoundItem as SensorDto;

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
            SensorDto currentSensor = OwnPresenter.GetSensorByName( comboBoxSNMap.Text );

            DataDto lastDataOfCurrentSensor = ((MainPresenter)OwnPresenter).GetLastData( currentSensor );

            ShowSensorInfo( currentSensor, lastDataOfCurrentSensor );
        }

        #endregion

        #region DataGridView

        private void dgvSens_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            GetDataSensorCell();

            rButtonAllDates.Checked = true;
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