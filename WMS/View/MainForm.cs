using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Linq;
using System.Threading.Tasks;

using GMap.NET;
using GMap.NET.WindowsForms;

using DomainModel.Abstract;
using DomainModel.Entity;

using Presentation.Presenter;
using Presentation.Common;
using UI.View;

namespace UI.View
{
    public partial class MainForm : Form, IView
    {
        #region Fields
        public IRepository<Sensor> SensorRepository { get; private set; }
        public IRepository<Data> DataRepository { get; private set; }
        private bool isDataLoadedFromDB = false;
        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisEnableControsl();
        }

        private void MainMap_Load(object sender, EventArgs e)
        {
            
            //Настройки для компонента GMap.
            MainMap.Bearing = 0;

            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту
            //с помощью правой кнопки мыши.
            MainMap.CanDragMap = true;

            //Указываем, что перетаскивание карты осуществляется
            //с использованием левой клавишей мыши.
            //По умолчанию - правая.
            MainMap.DragButton = MouseButtons.Left;

            MainMap.GrayScaleMode = true;

            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
            MainMap.MarkersEnabled = true;

            //Указываем значение максимального приближения.
            MainMap.MaxZoom = 18;

            //Указываем значение минимального приближения.
            MainMap.MinZoom = 2;

            //Устанавливаем центр приближения/удаления
            //курсор мыши.
            MainMap.MouseWheelZoomType =
                GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            //Отказываемся от негативного режима.
            MainMap.NegativeMode = false;

            //Разрешаем полигоны.
            MainMap.PolygonsEnabled = true;

            //Разрешаем маршруты
            MainMap.RoutesEnabled = true;

            //Скрываем внешнюю сетку карты
            //с заголовками.
            MainMap.ShowTileGridLines = false;

            //Указываем, что при загрузке карты будет использоваться
            //18ти кратное приближение.
            MainMap.Zoom = 5;

            //Указываем что будем использовать карты Google.
            MainMap.MapProvider =
                GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode =
                GMap.NET.AccessMode.ServerOnly;

            MainMap.Position = new PointLatLng( 55.75393, 37.620795 );
        }
        #endregion

        #region Supporting methods
        public void Show(IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            Application.Run( this );
        }

        private void EnableControls()
        {
            //Включаем контролы
            btnShwMap.Enabled = true;
            AddSensMenu.Enabled = true;
            rButtonAllSensors.Enabled = true;
            rButtonChooseSensors.Enabled = true;
        }

        private void DisEnableControsl()
        {
            //Выключаем контролы
            rButtonAllSensors.Enabled = false;
            rButtonChooseSensors.Enabled = false;
            btnShwMap.Enabled = false;
            comboBoxSNMap.Enabled = false;
            AddSensMenu.Enabled = false;
        }

        private void ReturnSelectedSensors()
        {
            if (SelectSensorsPresenter.FinalList.Count > 0)
            {
                dgvSens.DataSource = SelectSensorsPresenter.FinalList;
            }
        }

        private void ReturnSelectedDates()
        {
            if(SelectDatePresenter.FinalList.Count > 0)
            {
                dgvData.DataSource = SelectDatePresenter.FinalList;
            }
        }

        #endregion

        #region Buttons
        private async void btnRefreshDB_Click(object sender, EventArgs e)
        {
            try
            {
                progressBarLoadDataFromDB.Minimum = 1;
                progressBarLoadDataFromDB.Maximum = 10;
                progressBarLoadDataFromDB.Style = ProgressBarStyle.Marquee;
                progressBarLoadDataFromDB.MarqueeAnimationSpeed = 30;

                dgvSens.DataSource = await Task.Factory.StartNew( () =>
                 {
                     return MainPresenter.GetSensorsList();
                 } );

                dgvData.DataSource = await Task.Factory.StartNew( () =>
                 {
                     return MainPresenter.GetDataList();
                 } );

                await Task.Factory.StartNew( () =>
                 {
                     MainMap.Overlays.Add( MainPresenter.GetMarkersOfSensors() );

                 } );

                btnRefreshDB.Enabled = false;

                btnShwMap.Enabled = true;
                AddSensMenu.Enabled = true;
                rButtonAllSensors.Enabled = true;
                rButtonChooseSensors.Enabled = true;

                dgvSens.RowHeadersVisible = false;

                dgvSens.Columns["Id"].Visible = false;
                dgvSens.Columns["DataCollection"].Visible = false;
                dgvSens.Columns["Name"].Width = 50;
                dgvSens.Columns["SensorType"].Width = 200;

                dgvData.RowHeadersVisible = false;

                dgvData.Columns["Id"].Visible = false;
                dgvData.Columns["SingleSensor"].Visible = false;
                dgvData.Columns["SensorId"].Visible = false;

                isDataLoadedFromDB = true;
                progressBarLoadDataFromDB.Style = ProgressBarStyle.Continuous;
                progressBarLoadDataFromDB.MarqueeAnimationSpeed = 0;

                rtbAmountSensors.Text = "Количество датчиков: " + dgvSens.Rows.Count.ToString();
                rtbSensorsValue.Text = "Показаний датчиков: " + dgvData.Rows.Count.ToString();

                unionChart.DataSource = dgvData.DataSource;
                unionChart.Series["Датчик"].XValueMember = "Date";
                unionChart.Series["Датчик"].YValueMembers = "Value";
                unionChart.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }
        }

        private async void btnShwMap_Click(object sender, EventArgs e)
        {
            MainMap.Visible = true;
            comboBoxSNMap.Enabled = true;
            comboBoxCheckForQuery.Enabled = true;

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
                    txtBxCheckInternet.ForeColor = Color.FromArgb( 0, 192, 0 );
                    txtBxCheckInternet.Text = "Доступно";
                    comboBoxSNMap.Enabled = true;
                }
                else
                {
                    txtBxCheckInternet.ForeColor = Color.FromArgb( 192, 0, 0 );
                    txtBxCheckInternet.Text = "Отсутствует";
                }
            } );
        }

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            //Test test = new Test();
            //test.Owner = this;
            //test.Show();
        }

        private void rButtonAllSensors_MouseClick(object sender, MouseEventArgs e)
        {
            dgvSens.DataSource = MainPresenter.GetSensorsList();

            rtbAmountSensors.Text = "Количество датчиков: " + dgvSens.Rows.Count.ToString();
        }

        private void rButtonChooseSensors_MouseClick(object sender, MouseEventArgs e)
        {
            SelectSensorsPresenter presenter = new SelectSensorsPresenter();
            SelectSensorsForm form = new SelectSensorsForm();

            form.FormClosed += (s, ev) => presenter.Invoke();
            presenter.StartClosing += () => ReturnSelectedSensors();

            presenter.View = form;
            presenter.Run( SensorRepository, DataRepository );
        }

        private void rButtonAllDates_MouseClick(object sender, EventArgs e)
        {
            //TODO: доделать
            dgvData.DataSource = MainPresenter.GetDataList();

            rtbSensorsValue.Text = "Показаний датчика: " + dgvData.Rows.Count.ToString();
        }

        private void rButtonChooseDate_MouseClick(object sender, EventArgs e)
        {
            var currentSensor = dgvSens.CurrentRow.DataBoundItem as Sensor;
            if(currentSensor != null)
            {
                SelectDatePresenter presenter = new SelectDatePresenter();
                SelectDateForm form = new SelectDateForm( currentSensor.Id );

                form.FormClosed += (s, ev) => presenter.Invoke();
                presenter.StartClosing += () => ReturnSelectedDates();

                presenter.View = form;
                presenter.Run( SensorRepository, DataRepository );
            }
        }

        //TODO: Допили клик по маркеру
        private void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {

        }
        #endregion

        #region Menu
        private void AboutProgramMenu_Click(object sender, EventArgs e)
        {
            var presenter = new AboutPresenter( new AboutForm() );
            presenter.Run(SensorRepository, DataRepository);
        }

        private void RestartMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddSensMenu_Click(object sender, EventArgs e)
        {
            //var presenter = new AddSensorPresenter( new AddSensorForm() );
            //presenter.Run();

            //dgvSens.Refresh();
            //dgvData.Refresh();
        }
        #endregion

        #region Filters
        //TODO: LINQ TO EF
        private void comboBoxSNMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach(Sensor s in SensorRepository.)
            //double lat, lng;

            //var sensor = (from c in context.Sensors
            //              where c.Name == comboBoxSNMap.Text
            //              select new { c.SensorId, c.Lat, c.Lng, c.Type }).First();

            //var data = (from c in context.DataSet
            //            where c.SensorId == sensor.SensorId
            //            orderby c.Date
            //            orderby c.Time
            //            select new { c.Date, c.Time, c.Value }).ToList();

            ////получаем координаты выбранных в combobox сенсоров
            //lat = Convert.ToDouble(sensor.Lat);
            //lng = Convert.ToDouble(sensor.Lng);

            //txtbxMapSType.Text = sensor.Type;
            //txtbxMapSStatus.Text = "Рабочее"; //TODO: сделать адекватную привязку состояния сенсора к программе

            //txtbxMapLastDate.Text = data[data.Count - 1].Date.ToString().Remove(10, 8);
            //txtbxMapLastTime.Text = data[data.Count - 1].Time.ToString();
            //txtbxMapLastValue.Text = data[data.Count - 1].Value.ToString();

            //MainMap.Position = new PointLatLng(lat, lng);
            //MainMap.OnMarkerClick;
        }
        #endregion

        #region DataGridView
        private void dgvSens_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (isDataLoadedFromDB)
            {
                Sensor currentSensor = dgvSens.CurrentRow.DataBoundItem as Sensor;

                if (currentSensor != null)
                {
                    //переделать!
                    dgvData.DataSource = currentSensor.DataCollection.OrderBy( v => v.Date ).ToList();

                    rtbAmountSensors.Text = "Количество датчиков: " + dgvSens.Rows.Count.ToString();
                    rtbSensorsValue.Text = "Показаний датчика: " + dgvData.Rows.Count.ToString();

                    unionChart.DataSource = dgvData.DataSource;
                    unionChart.Series["Датчик"].XValueMember = "Date";
                    unionChart.Series["Датчик"].YValueMembers = "Value";
                    unionChart.DataBind();
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