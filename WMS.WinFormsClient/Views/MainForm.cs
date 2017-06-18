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
using WMS.WinFormsClient.WMSService;

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
        /// Установить асинхронно макеры на карту.
        /// </summary>
        private async Task SetMarkersOnMapsAsync()
        {
            await Task.Factory.StartNew( () =>
            {
                GMapOverlay markersOverlaySensorMap = new GMapOverlay( "markersForSensorMap" );
                SensorMap.Overlays.Add( markersOverlaySensorMap );

                GMapOverlay markersOverlaySensorMinoringMap = new GMapOverlay( "markersForMonitoringMap" );
                SensorMonitoringMap.Overlays.Add( markersOverlaySensorMinoringMap );

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
        /// Загрузить асинхронно данные из БД.
        /// </summary>
        private async Task LoadDataFromDatabaseAsync()
        {
            DgvData.DataSource = await Task.Factory.StartNew( () =>
            {
                return OwnPresenter.GetData().Where( x => x.SensorId == CachedEntity.CurrentSensors.First().Id )
                                             .OrderBy(x => x.Date)
                                             .ThenBy(x => x.Time)
                                             .ToList();
            } );
        }

        /// <summary>
        /// Загрузить асинхронно сенсоры из БД.
        /// </summary>
        private async Task LoadSensorsFromDatabaseAsync()
        {
            DgvSens.DataSource = await Task.Factory.StartNew( () =>
            {
                return OwnPresenter.GetSensors().ToList();
            } );

            foreach (var s in OwnPresenter.GetSensorsNames())
                ComboBoxSNMap.Items.Add( s );
        }

        /// <summary>
        /// Проверить асинхронно подключение к интернету.
        /// </summary>
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
        /// Отправить асинхронно запрос к сенсорной сети.
        /// </summary>
        private async Task SendRequestToSensorsAsync(int intervalParam, int quizNumberParam)
        {
            DgvQuizResult.DataSource = await Task.Factory.StartNew( () =>
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
                 return new WMSServiceClient().RequestToWSN( requestSettings ).ToList();
            } );
        }
         
        /// <summary>
        /// Установить значения данных в datagridview на основе ячейки сенсоровской datagridview.
        /// </summary>
        private void GetDataSensorCell()
        {
            if (_isDataLoadedFromDB)
            {
                if (DgvSens.CurrentRow.DataBoundItem is SensorDto currentSensor)
                {
                    TxtBoxCurrentSensor.Text = currentSensor.Name;


                    DgvData.DataSource = OwnPresenter.GetData().Where( d => d.SensorId == currentSensor.Id ).OrderBy( d => d.Date ).ToList();

                    CountSensorAndDataNumber();

                    BindChart();
                }
            }
        }

        /// <summary>
        /// Логировать ошибку.
        /// </summary>
        private void WriteLogException(Exception ex)
        {
            Logger logger = new Logger( new CriticalLogBuilder() );

            logger.WriteLog( LogsList, ex.ToString() );

            Log result = logger.WriteLog( ErrorLogsList, ex.ToString() );

            RtbLogs.AppendText( string.Format( "{0} {1}\n{2}:\n", result.EventLogTime, result.LevelType, result.Description ) );
            RtbLogs.AppendText( Environment.NewLine );
            RtbLogs.AppendText( new string( '-', 350 ) );
        }

        /// <summary>
        /// Запустить новую форму.
        /// </summary>
        private static void RunNewForm(Factory factoryParam)
        {
            View view = new View( factoryParam );

            view.Run();
        }

        /// <summary>
        /// Настройки для комбобоксов.
        /// </summary>
        private void SettingComboboxes()
        {
            comboBoxMonitoringType.Items.Add( "Единичный опрос" );
            comboBoxMonitoringType.Items.Add( "С заданным интервалом" );

            ComboBoxSelectQuizInterval.Items.Add( "30" );
            ComboBoxSelectQuizInterval.Items.Add( "60" );
            ComboBoxSelectQuizInterval.Items.Add( "300" );
            ComboBoxSelectQuizInterval.Items.Add( "1500" );
            ComboBoxSelectQuizInterval.Items.Add( "3600" );
        }

        /// <summary>
        /// Настройки для столбцов
        /// </summary>
        private void SettingDataGridViewColumns()
        {
            DgvSens.Columns["Id"].Visible = false;
            DgvSens.Columns["Name"].Width = 100;
            DgvSens.Columns["SensorType"].Width = 150;
            DgvSens.Columns["SensorType"].Name = "Sensor type";

            DgvData.Columns["Id"].Visible = false;
            DgvData.Columns["SensorId"].Visible = false;
        }

        /// <summary>
        /// Включить контролы.
        /// </summary>
        private void EnableControsl()
        {
            RButtonAllDates.Enabled = true;
            RButtonChooseDate.Enabled = true;
            RButtonAllSensors.Enabled = true;
            RButtonChooseSensors.Enabled = true;

            ButtonShowMap.Enabled = true;
            ButtonRequestNetwork.Enabled = true;
            ButtonSelectSensorsForRequest.Enabled = true;

            SaveAsMenu.Enabled = true;
        }

        /// <summary>
        /// Установить информацию о сенсоре в соответствующие текстбоксы
        /// </summary>
        private void ShowSensorInfo(SensorDto currentSensor, DataDto lastDataOfCurrentSensor)
        {
            if (lastDataOfCurrentSensor != null)
            {

                TxtBoxMapSType.Text = currentSensor.SensorType;
                TxtBoxMapSStatus.Text = "Рабочее"; //TODO: реализуй алгоритм проверки состояния датчика
                TxtBoxMapLastDate.Text = lastDataOfCurrentSensor.Date.ToString().Remove( 10, 8 );
                TxtBoxMapLastTime.Text = lastDataOfCurrentSensor.Time.ToString();
                TxtBoxMapLastValue.Text = lastDataOfCurrentSensor.Value.ToString();

                SensorMap.Position = new PointLatLng( currentSensor.Lat, currentSensor.Lng );
            }
            else
            {
                TxtBoxMapSType.Text = currentSensor.SensorType;
                TxtBoxMapSStatus.Text = "Рабочее";
                TxtBoxMapLastDate.Text = "Empty";
                TxtBoxMapLastTime.Text = "Empty";
                TxtBoxMapLastValue.Text = "Empty";

                SensorMap.Position = new PointLatLng( currentSensor.Lat, currentSensor.Lng );
            }
        }

        /// <summary>
        /// Связать график с гридвьюшкой данных.
        /// </summary>
        private void BindChart()
        {
            UnionChart.DataSource = DgvData.DataSource;
            UnionChart.Series["Датчик"].XValueMember = "Date";
            UnionChart.Series["Датчик"].YValueMembers = "Value";
            UnionChart.DataBind();
        }

        /// <summary>
        /// Посчитать количество данных и количество сенсоров отображаемых в данный момент.
        /// </summary>
        private void CountSensorAndDataNumber()
        {
            RtbAmountSensors.Text = "Количество датчиков: " + DgvSens.Rows.Count.ToString();
            RtbSensorsValue.Text = "Показаний датчика: " + DgvData.Rows.Count.ToString();
        }

        /// <summary>
        /// Посчитать количество ожидаемых опросов.
        /// </summary>
        private int CountQuizNumber()
        {
            return ComboBoxSelectQuizInterval.Text == null ? 0 : GetTimespan() / GetQuizFrequency();
        }

        /// <summary>
        /// Получить временной интервал для опроса.
        /// </summary>
        private int GetTimespan()
        {
            // 1 + [First time] - [Second time]
            return 1 + (int)(DtpTo.Value.TimeOfDay.TotalSeconds - DtpFrom.Value.TimeOfDay.TotalSeconds);
        }

        /// <summary>
        /// Получить частоту опроса.
        /// </summary>
        private int GetQuizFrequency()
        {
            return (int)(TimeSpan.Parse( "0:00:" + ComboBoxSelectQuizInterval.Text ).TotalSeconds);
        }

        #endregion

        #region Buttons

        /// <summary>
        /// Кнопка загружает данные из БД.
        /// </summary>
        private async void ButtonRefreshDB_Click(object sender, EventArgs e)
        {
            DgvSens.DataSource = null;
            DgvData.DataSource = null;


            ComboBoxSNMap.Items.Clear();
            SensorMap.Overlays.Clear();
            SensorMonitoringMap.Overlays.Clear();
            SensorMap.Overlays.Clear();

            try
            {
                ProgressBarLoadDataFromDB.Minimum = 1;
                ProgressBarLoadDataFromDB.Maximum = 10;
                ProgressBarLoadDataFromDB.Style = ProgressBarStyle.Marquee;
                ProgressBarLoadDataFromDB.MarqueeAnimationSpeed = 30;

                await LoadSensorsFromDatabaseAsync();

                await LoadDataFromDatabaseAsync();

                await SetMarkersOnMapsAsync();

                BindChart();

                SettingDataGridViewColumns();

                CountSensorAndDataNumber();

                if (!_isDataLoadedFromDB)
                {
                    EnableControsl();

                    ButtonRefreshDB.Text = "Обновить данные";
                }

                _isDataLoadedFromDB = true;

                ProgressBarLoadDataFromDB.Style = ProgressBarStyle.Continuous;
                ProgressBarLoadDataFromDB.MarqueeAnimationSpeed = 0;
            }
            catch (Exception ex)
            {
                WriteLogException( ex );
            }
        }

        /// <summary>
        /// Кнопка загружает карту с маркерами.
        /// </summary>
        private async void ButtonShowMap_Click(object sender, EventArgs e)
        {
            SensorMap.Visible = true;
            SensorMonitoringMap.Visible = true;

            bool result = await CheckInternetConnectionAsync();
            if (result)
            {
                ComboBoxSNMap.Enabled = true;
                TxtBoxCheckInternet.ForeColor = Color.FromArgb( 0, 192, 0 );
                TxtBoxCheckInternet.Text = "Доступно";
                ButtonShowMap.Enabled = false;
            }
            else
            {
                TxtBoxCheckInternet.ForeColor = Color.FromArgb( 192, 0, 0 );
                TxtBoxCheckInternet.Text = "Отсутствует";
            }
        }

        /// <summary>
        /// Кнопка открывает окно выбора сенсоров для опроса.
        /// </summary>
        private void ButtonSelectSensorsForRequest_Click(object sender, EventArgs e)
        {
            RunNewForm( new SelectSensorsFactory() );

            if (SelectSensorsForm.FinalList.Count > 0)
                ButtonRequestNetwork.Enabled = true;

            RtbSelectedSensorsCount.Text = "Датчиков выбрано: " + SelectSensorsForm.FinalList.Count.ToString();
        }

        /// <summary>
        /// Кнопка инициирует опрос сенсорной сети.
        /// </summary>
        private async void ButtonRequestNetwork_Click(object sender, EventArgs e)
        {
            string warning = "Выбранных вами датчиков: " + SelectSensorsForm.FinalList.Count() + "\nЕсли вами не был выбран интервал опроса, то опрос датчиков проведется единожды.\nНачать опрос?";

            //TODO: Request to sensors
            if (MessageBox.Show( warning, "Предупреждение", MessageBoxButtons.OKCancel ) == DialogResult.OK)
            {
                DgvQuizResult.DataSource = null;

                //Start progress bar
                ProgressBarMonitoring.Minimum = 1;
                ProgressBarMonitoring.Maximum = 10;
                ProgressBarMonitoring.Style = ProgressBarStyle.Marquee;
                ProgressBarMonitoring.MarqueeAnimationSpeed = 30;

                int quizNumber = CountQuizNumber();

                RtbQuizNumber.Text = "Количество опросов сети: " + quizNumber.ToString();

                await SendRequestToSensorsAsync( int.Parse( ComboBoxSelectQuizInterval.Text ), quizNumber );

                DgvQuizResult.Columns["Id"].Visible = false;

                rtbDataCountQuiz.Text = "Показаний датчика: " + ((List<Response>)DgvQuizResult.DataSource).Count().ToString();

                //Take selected sensors count and set them to the rtbSensorsCountQuiz
                rtbSensorsCountQuiz.Text = "Количество датчиков: " + RtbSelectedSensorsCount.Text.Substring(17);

                //Stop progress bar
                ProgressBarMonitoring.Style = ProgressBarStyle.Continuous;
                ProgressBarMonitoring.MarqueeAnimationSpeed = 0;
            }
        }

        /// <summary>
        /// Кнопка открывает окно с выбором сенсоров для фильтрации в datagridview.
        /// </summary>
        private void RButtonChooseSensors_MouseClick(object sender, MouseEventArgs e)
        {
            RunNewForm( new SelectSensorsFactory() );

            if (SelectSensorsForm.FinalList.Count > 0)
            {
                DgvSens.DataSource = SelectSensorsForm.FinalList.ToList();

                RtbAmountSensors.Text = "Количество датчиков: " + DgvSens.RowCount.ToString();
            }
        }

        /// <summary>
        /// Кнопка выбирает все сенсоры для фильтрации в datagridview.
        /// </summary>
        private void RButtonAllSensors_MouseClick(object sender, MouseEventArgs e)
        {
            DgvSens.DataSource = CachedEntity.CurrentSensors;

            RtbAmountSensors.Text = "Количество датчиков: " + DgvSens.Rows.Count.ToString();
        }

        /// <summary>
        /// Кнопка открывает окно с выбором даты для фильтрации в datagridview
        /// </summary>
        private void RButtonChooseDate_MouseClick(object sender, EventArgs e)
        {
            View view = new View( new SelectDateFactory() );

            view.Run();

            if (SelectDateForm.FinalList.Count() > 0)
            {
                DgvData.DataSource = SelectDateForm.FinalList.OrderBy( d => d.Date ).ToList();

                RtbSensorsValue.Text = "Количество датчиков: " + DgvData.Rows.Count.ToString();

                //Draw chart with picked dates
                BindChart();

            }
        }

        /// <summary>
        /// Кнопка выбирает все даты для фильтрации в datagridview.
        /// </summary>
        private void RButtonAllDates_MouseClick(object sender, EventArgs e)
        {
            var currentRow = DgvSens.CurrentRow;

            if (currentRow != null)
            {
                var currentSensor = currentRow.DataBoundItem as SensorDto;

                DgvData.DataSource = OwnPresenter.GetData().Where( x => x.SensorId == currentSensor.Id ).OrderBy( v => v.Date ).ToList();

                RtbSensorsValue.Text = "Показаний датчика: " + DgvData.Rows.Count.ToString();
            }
            else
            {
                MessageBox.Show( "Необходимо выбрать датчик в таблице датчиков" );
            }
        }

        private void RadioButtonOnlyShow_Click(object sender, EventArgs e)
        {
            QuizResult = ResultSettings.showOnly;
        }

        private void RadioButtonOnlySave_Click(object sender, EventArgs e)
        {
            QuizResult = ResultSettings.saveOnly;
        }

        private void RadioButtonSaveAndShow_Click(object sender, EventArgs e)
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

        private void ComboBoxSNMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            SensorDto currentSensor = OwnPresenter.GetSensorByName( ComboBoxSNMap.Text );

            DataDto lastDataOfCurrentSensor = ((MainPresenter)OwnPresenter).GetLastData( currentSensor );

            ShowSensorInfo( currentSensor, lastDataOfCurrentSensor );
        }

        #endregion

        #region DataGridView

        private void DgvSens_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            GetDataSensorCell();

            RButtonAllDates.Checked = true;
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