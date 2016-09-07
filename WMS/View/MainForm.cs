using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Linq;
using System.Threading.Tasks;

using GMap.NET;

using DomainModel.Abstract;
using DomainModel.Entity;

using Presentation.Presenter;
using Presentation.Common;
using Presentation.ViewModels;

namespace UI.View
{
    public partial class MainForm : Form, IView
    {
        #region Fields
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
        void IView.Show()
        {
            Application.Run( this );
        }

        private void DisEnableControsl()
        {
            rButtonAllDates.Enabled = false;
            rButtonChooseDate.Enabled = false;
            rButtonAllSensors.Enabled = false;
            rButtonChooseSensors.Enabled = false;
            btnShwMap.Enabled = false;
            AddSensMenu.Enabled = false;
            comboBoxSNMap.Enabled = false;
        }
        #endregion

        #region Buttons
        private async void btnRefreshDB_Click(object sender, EventArgs e)
        {
            btnRefreshDB.Enabled = false;

            dgvSens.DataSource = null;
            dgvData.DataSource = null;

            try
            {
                progressBarLoadDataFromDB.Minimum = 1;
                progressBarLoadDataFromDB.Maximum = 10;
                progressBarLoadDataFromDB.Style = ProgressBarStyle.Marquee;
                progressBarLoadDataFromDB.MarqueeAnimationSpeed = 30;

                dgvSens.DataSource = await Task.Factory.StartNew( () =>
                 {
                     var items = MainPresenter.GetSensorsList();

                     foreach (var i in items)
                         comboBoxSNMap.Items.Add( i.Name );

                     return items;
                 } );

                dgvData.DataSource = await Task.Factory.StartNew( () =>
                 {
                     return MainPresenter.GetDataList();
                 } );

                await Task.Factory.StartNew( () =>
                 {
                     MainMap.Overlays.Add( MainPresenter.GetMarkersOfSensors() );
                 } );

                if (!isDataLoadedFromDB)
                {
                    btnShwMap.Enabled = true;
                    AddSensMenu.Enabled = true;
                    rButtonAllSensors.Enabled = true;
                    rButtonChooseSensors.Enabled = true;
                    rButtonAllDates.Enabled = true;
                    rButtonChooseDate.Enabled = true;

                    btnRefreshDB.Text = "Обновить данные";
                }

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
                rtbSensorsValue.Text = "Показаний датчика: " + dgvData.Rows.Count.ToString();

                unionChart.DataSource = dgvData.DataSource;
                unionChart.Series["Датчик"].XValueMember = "Date";
                unionChart.Series["Датчик"].YValueMembers = "Value";
                unionChart.DataBind();

                btnRefreshDB.Enabled = true;
            }
            catch (Exception ex)
            {
                MainPresenter.LogsList.Add( new Log( DateTime.Now, Level.Critical, ex.ToString() ) );
            }
        }

        private async void btnShwMap_Click(object sender, EventArgs e)
        {
            MainMap.Visible = true;

            bool result = await Task.Factory.StartNew( () =>
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
                    return true;
                else
                    return false;
            } );

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

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            //Test test = new Test();
            //test.Owner = this;
            //test.Show();
        }

        private void btnSelectSensorsForQuiz_Click(object sender, EventArgs e)
        {
            SelectSensorsPresenter presenter = new SelectSensorsPresenter();
            SelectSensorsForm form = new SelectSensorsForm();

            form.FormClosed += (s, ev) =>
            {
                MainPresenter.RequestList.AddRange( SelectSensorsPresenter.FinalList );
                lblSelectedSensorsCount.Text = MainPresenter.RequestList.Count.ToString();
            };

            presenter.View = form;
            presenter.Run( MainPresenter.SensorRepository, MainPresenter.DataRepository );
        }

        private void btnMapRequest_Click(object sender, EventArgs e)
        {
            //TODO: Request to sensors
        }

        private void rButtonChooseSensors_MouseClick(object sender, MouseEventArgs e)
        {
            SelectSensorsPresenter presenter = new SelectSensorsPresenter();
            SelectSensorsForm form = new SelectSensorsForm();

            form.FormClosed += (s, ev) =>
            {
                if (SelectSensorsPresenter.FinalList.Count > 0)
                {
                    dgvSens.DataSource = SelectSensorsPresenter.FinalList;
                }
            };

            presenter.View = form;
            presenter.Run( MainPresenter.SensorRepository, MainPresenter.DataRepository );
        }

        private void rButtonAllSensors_MouseClick(object sender, MouseEventArgs e)
        {
            dgvSens.DataSource = MainPresenter.GetSensorsList();

            rtbAmountSensors.Text = "Количество датчиков: " + dgvSens.Rows.Count.ToString();
        }

        private void rButtonChooseDate_MouseClick(object sender, EventArgs e)
        {
            var currentRow = dgvSens.CurrentRow;
            if (currentRow != null)
            {
                var currentSensor = currentRow.DataBoundItem as Sensor;

                SelectDatePresenter presenter = new SelectDatePresenter();
                SelectDateForm form = new SelectDateForm( currentSensor.Id );

                form.FormClosed += (s, ev) =>
                {
                    if (SelectDatePresenter.FinalList.Count > 0)
                    {
                        dgvData.DataSource = SelectDatePresenter.FinalList.OrderBy( d => d.Date ).ToList();
                    }
                };

                presenter.View = form;
                presenter.Run( MainPresenter.SensorRepository, MainPresenter.DataRepository );
            }
            else
            {
                MessageBox.Show( "Необходимо выбрать датчик в таблице датчиков" );
            }
        }

        private void rButtonAllDates_MouseClick(object sender, EventArgs e)
        {
            var currentRow = dgvSens.CurrentRow;

            if (currentRow != null)
            {
                var currentSensor = currentRow.DataBoundItem as Sensor;
                dgvData.DataSource = currentSensor.DataCollection.OrderBy( v => v.Date ).ToList();

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
            var presenter = new AboutPresenter( new AboutForm() );
            presenter.Run( MainPresenter.SensorRepository, MainPresenter.DataRepository );
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
        private void comboBoxSNMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sensor currentSensor = MainPresenter.GetSensorByName( comboBoxSNMap.Text );
            Data lastDataOfCurrentSensor = MainPresenter.GetLastData( currentSensor );

            if (lastDataOfCurrentSensor != null)
            {

                txtBoxMapSType.Text = currentSensor.SensorType;
                txtBoxMapSStatus.Text = "Рабочее"; //доделать
                txtBoxMapLastDate.Text = lastDataOfCurrentSensor.Date.ToString().Remove( 10, 8 );
                txtBoxMapLastTime.Text = lastDataOfCurrentSensor.Time.ToString();
                txtBoxMapLastValue.Text = lastDataOfCurrentSensor.Value.ToString();

                if (currentSensor.Lat != null && currentSensor.Lng != null)
                    MainMap.Position = new PointLatLng( (double)currentSensor.Lat, (double)currentSensor.Lng );
            }
            else MessageBox.Show( "Выбранный датчик еще не получал данных" );
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
                    txtBoxCurrentSensor.Text = currentSensor.Name;

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

        private void tsmSaveReport_Click(object sender, EventArgs e)
        {

        }
    }
}