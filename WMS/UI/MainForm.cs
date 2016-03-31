using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using WMS.UI;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace WMS
{
    //TODO: всю логику нужно вынести из форм
    public partial class MainForm : Form    
    {
        DataSet GenDataSet;
        DoSome ds = new DoSome();
        DataView SensorDV, ValuesDV;
        
        private string value; //переменная для подсчета количества данных в datagridview
        private string sensors; //переменная для подсчета количества сенсоров в datagridview


        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        //*******************************************************SOME_METHODS*******************************************************//
        private void FillGenDataSet()
        {
            //заполняем DataSet и устанавливаем отношения между таблицами
            GenDataSet = ds.GetAllInfo();
        }
        private void BindingGridView()
        {
            // если в DataSet есть таблицы, то связываем DataGridView с DataView
            if (GenDataSet.Tables.Count > 0)

                dgvSens.DataSource = SensorDV;
                dgvData.DataSource = ValuesDV;
        }

        //TODO: Допили клик по маркеру
        private void TestMethod(object sender, EventArgs e)
        {
            MessageBox.Show("Событие");
        }

        private void DelColnRowForSens()
        {
            //удаляем страшную шапку
            dgvSens.RowHeadersVisible = false;

            //устанавливает автоматический размер для колонки с номерами строк
            dgvSens.AutoResizeColumn(1);

            //удаляем ненужные для отображения столбцы ID, LAT, LNG
            dgvSens.Columns["ID"].Visible = false;
            dgvSens.Columns["LAT"].Visible = false;
            dgvSens.Columns["LNG"].Visible = false;
        }

        private void DelColnRowForData()
        {
            //удаляем страшную шапку
            dgvData.RowHeadersVisible = false;

            //удаляем ненужные для отображения столбцы ID, №, SensorID
            dgvData.Columns["ID"].Visible = false;
            dgvData.Columns["№"].Visible = false;
            dgvData.Columns["SensorID"].Visible = false;
        }

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
            catch { }

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
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                markersOverlay.Markers.Clear();
                double lat, lng;
                int count = 0;
                string sensorName;
                //пробежимся по Сенсоровской гридвьюшке и из нее выцепим названия сенсоров и их координаты
                foreach (var row in SensorDV)
                {
                    sensorName = dgvSens.Rows[count].Cells[2].Value.ToString();
                    sensorName += "\n" + dgvSens.Rows[count].Cells[3].Value.ToString();
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
            FillGenDataSet();

            //закидываем в переменные ссылки на экземлпяры DataView в конструктора которых кидаем таблицы из DataSet
            SensorDV = new DataView(GenDataSet.Tables["SensorsTable"]);
            ValuesDV = new DataView(GenDataSet.Tables["ValuesTable"]);

            BindingGridView();
            CheckAmountSens();
            DelColnRowForData();
            DelColnRowForSens();
            EnableControls();
            MakeMarkers();

            btnRefreshDB.Enabled = false;
        }             
        private void btnShwMap_Click(object sender, EventArgs e)
        {
            //отображаем карту
            MainMap.Visible = true;
            comboBoxSNMap.Enabled = true;

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
            SensorDV.RowFilter = _filter;
        } 
        private void textBoxForDate_TextChanged(object sender, EventArgs e)
        {
            string _filter = string.Format("Convert([Дата], 'System.String') LIKE '{0}%' +'%'", txtbxDate.Text);
            ValuesDV.RowFilter = _filter;
        }
        private void comboBoxSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _filter = string.Format("[Тип] LIKE '{0}%' +'%'", comboBoxSensorType.Text);
            SensorDV.RowFilter = _filter;
            CheckAmountSens();
        }
        private void comboBoxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
        } //TODO: допилить интервал 
        private void comboBoxSNMap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            double lat, lng;
            string name;

            SensorDV.RowFilter = null;
            comboBoxSensorType.SelectedIndex = -1;
            //получаем координаты выбранных в combobox сенсоров
            lat = Convert.ToDouble(dgvSens.Rows[(comboBoxSNMap.SelectedIndex)].Cells[4].Value);
            lng = Convert.ToDouble(dgvSens.Rows[(comboBoxSNMap.SelectedIndex)].Cells[5].Value);
            name = Convert.ToString(dgvSens.Rows[(comboBoxSNMap.SelectedIndex)].Cells[2].Value);

            //добавляем текст в textbox'ы 1 - тип сенсора, 2 - состояние
            txtbxMapSType.Text = Convert.ToString(dgvSens.Rows[(comboBoxSNMap.SelectedIndex)].Cells[3].Value);
            txtbxMapSStatus.Text = "Рабочее"; //TODO: сделать адекватную привязку состояния сенсора к программе

            //фильтруем вьюшку по имени выбранного в комбике сенсора
            SensorDV.RowFilter = string.Format("Название LIKE '{0}%' +'%'", name);
            //вставляем дату, время, значение последнего замера сенсором, 
            //дата, время, значение последнего замера = текущее количество показаний - 1, т.к. order by Дата, Время

                 txtbxMapLastDate.Text = (Convert.ToString(dgvData.Rows[Convert.ToInt16(value)-1].Cells[3].Value)).Remove(10, 8);
                 txtbxMapLastTime.Text = Convert.ToString(dgvData.Rows[Convert.ToInt16(value) - 1].Cells[4].Value);
                 txtbxMapLastValue.Text = Convert.ToString(dgvData.Rows[Convert.ToInt16(value) - 1].Cells[5].Value);

            MainMap.Position = new PointLatLng(lat, lng);
            //MainMap.OnMarkerClick;

            //в конце чистим фильтр
            SensorDV.RowFilter = null;

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
            sensors = dgvSens.Rows.Count.ToString();
            rtbAmountSensors.Text = "Количество датчиков: " + sensors;

            //привязываем график к значениям сенсоров
            unionChart.DataSource = ValuesDV;
            unionChart.Series["Датчик"].XValueMember = "Дата";
            unionChart.Series["Датчик"].YValueMembers = "Значение";
            unionChart.DataBind();
        }
        private void dgvSens_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //фильтруем значения сенсоров в зависимости от выбранного сенсора
            ValuesDV.RowFilter = string.Format("SensorID ='{0}'", dgvSens[0, e.RowIndex].FormattedValue.ToString());

            //опять считаем количество сенсоров и значений
            CheckAmountSens();
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
            // TODO: This line of code loads data into the 'generalDBDataSet.SensorValues' table. You can move, or remove it, as needed.
            dgvSens.CellEnter += new DataGridViewCellEventHandler(dgvSens_CellEnter);
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

            //Вешаем обработчик клика по маркеру
            MainMap.OnMarkerClick += new MarkerClick(TestMethod);
        }

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Owner = this;
            test.Show();
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