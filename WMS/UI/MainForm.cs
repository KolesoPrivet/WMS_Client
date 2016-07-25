using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using WMS.UI;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Collections.Generic;
using WMS.DAL;
using System.Linq;
using System.Threading;

namespace WMS
{
    //TODO: всю логику нужно вынести из форм
    public partial class MainForm : Form    
    {
        private GMapOverlay markersOverlay;
        private readonly DBEntitiesContext context;
        private BindingSource bsForSensors, bsForValues;

        private string value; //переменная для подсчета количества данных в datagridview
        private string sensors; //переменная для подсчета количества сенсоров в datagridview


        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            context = new DBEntitiesContext();
        }

        //*******************************************************SOME_METHODS*******************************************************//

        private void EnableControls()
        {
            //Включаем контролы
            btnShwMap.Enabled = true;
            txtbxDate.Enabled = true;
            txtbxSName.Enabled = true;
            comboBoxSensorType.Enabled = true;
            AddSensMenu.Enabled = true;        
        }

        private void DisEnableControsl()
        {
            //Выключаем контролы
            btnShwMap.Enabled = false;
            txtbxSName.Enabled = false;
            txtbxDate.Enabled = false;
            txtbxTimeFrom.Enabled = false;
            txtbxTimeTo.Enabled = false;
            comboBoxSensorType.Enabled = false;
            comboBoxInterval.Enabled = false;
            comboBoxSNMap.Enabled = false;
            AddSensMenu.Enabled = false;
        }

        private void CheckAmountSens()
        {
            //узнать количество отображаемых показаний датчиков
            value = dgvData.Rows.Count.ToString();

            //показать значение value
            rtbSensorsValue.Text = "Показаний датчика: " + value;

            //узнать количество отображаемых датчиков
            sensors = dgvSens.Rows.Count.ToString();

            //показать значение sensors
            rtbAmountSensors.Text = "Количество датчиков: " + sensors;
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
                txtBxCheckInternet.ForeColor = Color.FromArgb(0,192,0);
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
                    sensorName += "\n" + dgvSens.Rows[count].Cells[3].Value.ToString();
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


        //*******************************************************EVENTS*******************************************************//
        
        //------------------------BUTTONS------------------------//
        private void btnRefreshDB_Click(object sender, EventArgs e)
        {
            try
            {
                bsForSensors = new BindingSource();
                bsForValues = new BindingSource();

                bsForSensors.DataSource = context.Sensors.ToList();
                bsForValues.DataSource = context.SValues.ToList();
                dgvSens.DataSource = bsForSensors;
                dgvData.DataSource = bsForValues;

                //SensorDV = new DataView(new DataTable("Sensors"));
                //ValuesDV = new DataView(dgvData.DataSource);

                dgvSens.RowHeadersVisible = false;
                dgvSens.AutoResizeColumn(1);

                //удаляем ненужные для отображения столбцы ID, LAT, LNG
                dgvSens.Columns["ID"].Visible = false;
                dgvSens.Columns["C_"].Visible = false;
                dgvSens.Columns["SValues"].Visible = false;
                dgvSens.Columns["LAT"].Visible = false;
                dgvSens.Columns["LNG"].Visible = false;

                dgvData.RowHeadersVisible = false;

                //удаляем ненужные для отображения столбцы ID, №, SensorID
                dgvData.Columns["ID"].Visible = false;
                dgvData.Columns["C_"].Visible = false;
                dgvData.Columns["Sensors"].Visible = false;
                dgvData.Columns["SensorID"].Visible = false;

                CheckAmountSens();
                EnableControls();
                MakeMarkers();

                btnRefreshDB.Enabled = false;

            }
            catch(Exception ex)
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

        //------------------------MENU------------------------//
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
            ASForm asf = new ASForm();
            asf.Owner = this;
            asf.Show();
            dgvSens.Refresh();
            dgvData.Refresh();
        }

        //------------------------FILTERS------------------------//
        private void textBoxSenName_TextChanged(object sender, EventArgs e)
        {
            string _filter = string.Format("Название LIKE '{0}%' +'%'", txtbxSName.Text);
        } 
        private void textBoxForDate_TextChanged(object sender, EventArgs e)
        {
            string _filter = string.Format("Convert([Дата], 'System.String') LIKE '{0}%' +'%'", txtbxDate.Text);
        }
        private void comboBoxSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _filter = string.Format("[Тип] LIKE '{0}%' +'%'", comboBoxSensorType.Text);
            CheckAmountSens();
        }
        private void comboBoxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
        } //TODO: допилить интервал 
        private void comboBoxSNMap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            double lat, lng;
            string name;

            bsForSensors.DataSource = context.Sensors.ToList();
            comboBoxSensorType.SelectedIndex = -1;
            //получаем координаты выбранных в combobox сенсоров
            lat = Convert.ToDouble(dgvSens.Rows[(comboBoxSNMap.SelectedIndex)].Cells[4].Value);
            lng = Convert.ToDouble(dgvSens.Rows[(comboBoxSNMap.SelectedIndex)].Cells[5].Value);
            name = Convert.ToString(dgvSens.Rows[(comboBoxSNMap.SelectedIndex)].Cells[2].Value);

            //добавляем текст в textbox'ы 1 - тип сенсора, 2 - состояние
            txtbxMapSType.Text = Convert.ToString(dgvSens.Rows[(comboBoxSNMap.SelectedIndex)].Cells[3].Value);
            txtbxMapSStatus.Text = "Рабочее"; //TODO: сделать адекватную привязку состояния сенсора к программе

            //фильтруем вьюшку по имени выбранного в комбике сенсора
            bsForSensors.DataSource = context.Sensors.Where(v => v.Название == txtbxMapSType.Text).ToList();
            dgvData.Refresh();
            //вставляем дату, время, значение последнего замера сенсором, 
            //дата, время, значение последнего замера = текущее количество показаний - 1, т.к. order by Дата, Время

                 txtbxMapLastDate.Text = (Convert.ToString(dgvData.Rows[Convert.ToInt16(value)-1].Cells[3].Value)).Remove(10, 8);
                 txtbxMapLastTime.Text = Convert.ToString(dgvData.Rows[Convert.ToInt16(value) - 1].Cells[4].Value);
                 txtbxMapLastValue.Text = Convert.ToString(dgvData.Rows[Convert.ToInt16(value) - 1].Cells[5].Value);

            MainMap.Position = new PointLatLng(lat, lng);
            //MainMap.OnMarkerClick;
        }
        private void textBoxForTimeFrom_TextChanged(object sender, EventArgs e)
        {

        } //TODO: допилить временной промежутком
        private void textBoxForTimeTo_TextChanged(object sender, EventArgs e)
        {

        } //TODO: допилить временной промежутком

        //------------------------DATA_GRID_VIEW------------------------//
        private void dgvSens_SelectionChanged(object sender, EventArgs e)
        {
            //при фильтрации в сенсорской DataGridView не забудем обновить текущее количество отображаемых сенсоров

            //фильтруем значения сенсоров в зависимости от выбранного сенсора

            //опять считаем количество сенсоров и значений
            CheckAmountSens();

            sensors = dgvSens.Rows.Count.ToString();
            rtbAmountSensors.Text = "Количество датчиков: " + sensors;

            //привязываем график к значениям сенсоров
            unionChart.Series["Датчик"].XValueMember = "Дата";
            unionChart.Series["Датчик"].YValueMembers = "Значение";
            unionChart.DataBind();
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            //при фильтрации значений не забываем считать количество значений
            value = dgvData.Rows.Count.ToString();
            rtbSensorsValue.Text = "Показаний датчика: " + value;
        }

        //------------------------LOADING_MAIN_FORM------------------------//
        private void MainForm_Load(object sender, EventArgs e)
        {
            DisEnableControsl();   
        }

        //------------------------LOADING_MAIN_MAP------------------------//
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

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Owner = this;
            test.Show();
        }

        private void dgvSens_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvSens[0, e.RowIndex].FormattedValue.ToString());
            bsForValues.DataSource = context.SValues.Where(v => v.SensorID == id).ToList();
            dgvData.Refresh();
        }

        //TODO: Допили клик по маркеру
        private void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            //PointLatLng pos = item.Position;

            //List<PointLatLng> list = new List<PointLatLng>();
            //double segm = Math.PI * 2 / 100;

            //for (int i = 0; i < 100; i++)
            //{
            //    double theta = segm * i;
            //    double a = pos.Lat + Math.Cos(theta) * 0.02;
            //    double b = pos.Lng + Math.Sin(theta) * 0.02;

            //    PointLatLng point = new PointLatLng(a, b);
            //    list.Add(point);
            //}

            //GMapPolygon poly = new GMapPolygon(list, "pol1");
            //markersOverlay.Polygons.Add(poly);
        }

        //------------------------CLOSE_APPLICATION------------------------// 
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Вы действительно желаете закрыть приложение?", "Закрыть", MessageBoxButtons.OKCancel) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}