using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using WMS.UI;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using WMS.DAL;
using System.Linq;
using System.Collections.Generic;

namespace WMS
{
    public partial class MainForm : Form
    {
        #region Fields
        private GMapOverlay markersOverlay;
        private readonly DBEntitiesContext context;
        private bool isDataLoadedFromDB;
        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            context = new DBEntitiesContext();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisEnableControsl();
        }

        private void MainMap_Load(object sender, EventArgs e)
        {
            CheckConToInternet();
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

            MainMap.Position = new PointLatLng(55.75393, 37.620795);
        }
        #endregion

        #region Supporting methods
        private void EnableControls()
        {
            //Включаем контролы
            btnShwMap.Enabled = true;
            txtbxDate.Enabled = true;
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
            txtbxDate.Enabled = false;
            txtbxTimeFrom.Enabled = false;
            txtbxTimeTo.Enabled = false;
            comboBoxInterval.Enabled = false;
            comboBoxSNMap.Enabled = false;
            AddSensMenu.Enabled = false;
        }

        private void CheckConToInternet()
        {
            //пингуем yandex.ru для проверки подключения интернета
            IPStatus status = IPStatus.Unknown;
            try
            {
                status = new Ping().Send("yandex.ru").Status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (status == IPStatus.Success)
            {
                txtBxCheckInternet.ForeColor = Color.FromArgb(0, 192, 0);
                txtBxCheckInternet.Text = "Доступно";
                comboBoxSNMap.Enabled = true;
            }
            else
            {
                txtBxCheckInternet.ForeColor = Color.FromArgb(192, 0, 0);
                txtBxCheckInternet.Text = "Отсутствует";
            }
        }

        private void MakeMarkers()
        {

            comboBoxSNMap.Items.Clear();
            /* Создание маркеров на карте 
             * по текущим значениям долготы и широты каждого датчика*/
            try
            {
                markersOverlay = new GMapOverlay("markers");
                markersOverlay.Markers.Clear();
                double lat, lng;
                int count = 0;
                string sensorName;

                foreach (var row in dgvSens.Rows)
                {
                    sensorName = dgvSens.Rows[count].Cells[2].Value.ToString();
                    comboBoxCheckForQuery.Items.Add(sensorName);
                    comboBoxSNMap.Items.Add(sensorName);

                    lat = Convert.ToDouble(dgvSens.Rows[count].Cells[4].Value);
                    lng = Convert.ToDouble(dgvSens.Rows[count].Cells[5].Value);

                    //по координатам ставим маркер на карте
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lng),
                      GMarkerGoogleType.red);

                    //текущий маркер добавляем в список маркеров
                    markersOverlay.Markers.Add(marker);

                    //текст над маркером
                    marker.ToolTipText = sensorName;

                    count++;
                }
                //добавляем список маркеров на карту
                MainMap.Overlays.Add(markersOverlay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Buttons
        private void btnRefreshDB_Click(object sender, EventArgs e)
        {
            dgvSens.DataSource = null;
            dgvData.DataSource = null;

            try
            {
                //progressBarLoadDataFromDB.Minimum = 1;
                //progressBarLoadDataFromDB.Maximum = context.Sensors.Count() + context.Values.Count();

                #region dgvSens settings
                dgvSens.DataSource = context.Sensors.ToList();

                dgvSens.RowHeadersVisible = false;

                dgvSens.Columns["ID"].Visible = false;
                dgvSens.Columns["Values"].Visible = false;
                dgvSens.Columns["Name"].Width = 50;
                dgvSens.Columns["Type"].Width = 200;

                dgvSens.ClearSelection();
                #endregion

                #region dgvData settings
                dgvData.DataSource = (from c in context.Values
                                      orderby c.Date
                                      select c).ToList();

                dgvData.RowHeadersVisible = false;

                dgvData.Columns["ID"].Visible = false;
                dgvData.Columns["Sensor"].Visible = false;
                dgvData.Columns["SensorID"].Visible = false;
                #endregion

                MakeMarkers();
                EnableControls();

                btnRefreshDB.Enabled = false;
                isDataLoadedFromDB = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnShwMap_Click(object sender, EventArgs e)
        {
            //отображаем карту
            MainMap.Visible = true;
            comboBoxSNMap.Enabled = true;
            comboBoxCheckForQuery.Enabled = true;

            //выключаем кнопку от греха подальше
            btnShwMap.Enabled = false;
        }

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Owner = this;
            test.Show();
        }

        private void rButtonAllSensors_MouseClick(object sender, MouseEventArgs e)
        {
            dgvSens.DataSource = context.Sensors.ToList();

            rtbAmountSensors.Text = "Количество датчиков: " + dgvSens.Rows.Count.ToString();
        }

        private void rButtonChooseSensors_MouseClick(object sender, MouseEventArgs e)
        {
            List<Sensors> sensors = new List<Sensors>();
            SelectSensorsForm selectSensorsForm = new SelectSensorsForm(context, sensors);
            selectSensorsForm.Owner = this;
            selectSensorsForm.ShowDialog();

            if (selectSensorsForm.IsDisposed)
            {
                dgvSens.DataSource = sensors;
            }
            else
            {
                selectSensorsForm.Dispose();
                dgvSens.DataSource = sensors;
            }

            dgvSens.Refresh();
        }

        //TODO: Допили клик по маркеру
        private void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {

        }
        #endregion

        #region Menu
        private void AboutProgramMenu_Click(object sender, EventArgs e)
        {
            //объект формы "о программе"
            AboutForm af = new AboutForm();
            af.Show();
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
            AddSensorForm addSensorForm = new AddSensorForm();
            addSensorForm.Owner = this;
            addSensorForm.Show();
            dgvSens.Refresh();
            dgvData.Refresh();
        }
        #endregion

        #region Filters

        private void textBoxForDate_TextChanged(object sender, EventArgs e)
        {
            string _filter = string.Format("Convert([Дата], 'System.String') LIKE '{0}%' +'%'", txtbxDate.Text);
        }

        private void comboBoxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
        } //TODO: допилить интервал 

        //TODO: LINQ TO EF
        private void comboBoxSNMap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            double lat, lng;

            var sensor = (from c in context.Sensors
                          where c.Name == comboBoxSNMap.Text
                          select new { c.ID, c.LAT, c.LNG, c.Type }).First();

            var data = (from c in context.Values
                        where c.SensorID == sensor.ID
                        orderby c.Date
                        orderby c.Time
                        select new { c.Date, c.Time, c.Value }).ToList();

            //получаем координаты выбранных в combobox сенсоров
            lat = Convert.ToDouble(sensor.LAT);
            lng = Convert.ToDouble(sensor.LNG);

            txtbxMapSType.Text = sensor.Type;
            txtbxMapSStatus.Text = "Рабочее"; //TODO: сделать адекватную привязку состояния сенсора к программе

            txtbxMapLastDate.Text = data[data.Count - 1].Date.ToString().Remove(10, 8);
            txtbxMapLastTime.Text = data[data.Count - 1].Time.ToString();
            txtbxMapLastValue.Text = data[data.Count - 1].Value.ToString();

            MainMap.Position = new PointLatLng(lat, lng);
            //MainMap.OnMarkerClick;
        }

        private void textBoxForTimeFrom_TextChanged(object sender, EventArgs e)
        {

        } //TODO: допилить временной промежутком

        private void textBoxForTimeTo_TextChanged(object sender, EventArgs e)
        {

        } //TODO: допилить временной промежутком
        #endregion

        #region DataGridView
        private void dgvSens_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (isDataLoadedFromDB)
            {
                var currentSensor = dgvSens.CurrentRow.DataBoundItem as Sensors;
                dgvData.DataSource = currentSensor.Values.OrderBy(v => v.Date).ToList();

                rtbSensorsValue.Text = "Показаний датчика: " + dgvData.Rows.Count.ToString();

                unionChart.DataSource = dgvData.DataSource;
                unionChart.Series["Датчик"].XValueMember = "Date";
                unionChart.Series["Датчик"].YValueMembers = "Value";
                unionChart.DataBind();
            }
        }

        private void dgvSens_SelectionChanged(object sender, EventArgs e)
        {
            if (isDataLoadedFromDB)
            {
                rtbSensorsValue.Text = "Показаний датчика: " + dgvData.Rows.Count.ToString();

                //привязываем график к значениям сенсоров
                unionChart.DataSource = dgvData.DataSource;
                unionChart.Series["Датчик"].XValueMember = "Date";
                unionChart.Series["Датчик"].YValueMembers = "Value";
                unionChart.DataBind();
            }
        }
        #endregion

        //------------------------CLOSE_APPLICATION------------------------// 
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно желаете закрыть приложение?", "Закрыть", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                e.Cancel = false;
                context.Dispose();
            }
            else
                e.Cancel = true;
        }
    }
}