namespace WMS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gpBoxSensorQuery = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxCheckForQuery = new System.Windows.Forms.ComboBox();
            this.btnMapAskSens = new System.Windows.Forms.Button();
            this.lbSensorNameForQuery = new System.Windows.Forms.Label();
            this.gpBoxInternetConnectionCheck = new System.Windows.Forms.GroupBox();
            this.txtBxCheckInternet = new System.Windows.Forms.TextBox();
            this.gpBoxMapView = new System.Windows.Forms.GroupBox();
            this.btnShwMap = new System.Windows.Forms.Button();
            this.gpBoxSearch = new System.Windows.Forms.GroupBox();
            this.comboBoxSNMap = new System.Windows.Forms.ComboBox();
            this.gpBoxSearchResult = new System.Windows.Forms.GroupBox();
            this.gpBoxLastActivity = new System.Windows.Forms.GroupBox();
            this.lbTimeOfLastActivity = new System.Windows.Forms.Label();
            this.txtbxMapLastTime = new System.Windows.Forms.TextBox();
            this.lbValueOfLastActivity = new System.Windows.Forms.Label();
            this.lbDateOfLastActivity = new System.Windows.Forms.Label();
            this.txtbxMapLastDate = new System.Windows.Forms.TextBox();
            this.txtbxMapLastValue = new System.Windows.Forms.TextBox();
            this.txtbxMapSStatus = new System.Windows.Forms.TextBox();
            this.txtbxMapSType = new System.Windows.Forms.TextBox();
            this.lbSensorTypeForResultOfSearch = new System.Windows.Forms.Label();
            this.lbSensorState = new System.Windows.Forms.Label();
            this.lbSensorNameForSearch = new System.Windows.Forms.Label();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.tabPageSensor = new System.Windows.Forms.TabPage();
            this.gpBoxGraphic = new System.Windows.Forms.GroupBox();
            this.unionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gpBoxData = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxInterval = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbSensorsValue = new System.Windows.Forms.RichTextBox();
            this.txtbxTimeFrom = new System.Windows.Forms.TextBox();
            this.txtbxTimeTo = new System.Windows.Forms.TextBox();
            this.gpBoxSensorIdentity = new System.Windows.Forms.GroupBox();
            this.progressBarLoadDataFromDB = new System.Windows.Forms.ProgressBar();
            this.gpBoxSensorsView = new System.Windows.Forms.GroupBox();
            this.rButtonAllSensors = new System.Windows.Forms.RadioButton();
            this.rButtonChooseSensors = new System.Windows.Forms.RadioButton();
            this.dgvSens = new System.Windows.Forms.DataGridView();
            this.btnRefreshDB = new System.Windows.Forms.Button();
            this.rtbAmountSensors = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.карта = new System.Windows.Forms.TabControl();
            this.Мониторинг = new System.Windows.Forms.TabPage();
            this.btnStartMonitoring = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSensMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SValuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpBoxSensorQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpBoxInternetConnectionCheck.SuspendLayout();
            this.gpBoxMapView.SuspendLayout();
            this.gpBoxSearch.SuspendLayout();
            this.gpBoxSearchResult.SuspendLayout();
            this.gpBoxLastActivity.SuspendLayout();
            this.tabPageSensor.SuspendLayout();
            this.gpBoxGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unionChart)).BeginInit();
            this.gpBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gpBoxSensorIdentity.SuspendLayout();
            this.gpBoxSensorsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSens)).BeginInit();
            this.карта.SuspendLayout();
            this.Мониторинг.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SValuesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1084, 673);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Карта датчиков";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.gpBoxSensorQuery);
            this.splitContainer1.Panel1.Controls.Add(this.gpBoxInternetConnectionCheck);
            this.splitContainer1.Panel1.Controls.Add(this.gpBoxMapView);
            this.splitContainer1.Panel1.Controls.Add(this.gpBoxSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainMap);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 667);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 0;
            // 
            // gpBoxSensorQuery
            // 
            this.gpBoxSensorQuery.Controls.Add(this.dataGridView1);
            this.gpBoxSensorQuery.Controls.Add(this.button2);
            this.gpBoxSensorQuery.Controls.Add(this.button1);
            this.gpBoxSensorQuery.Controls.Add(this.comboBoxCheckForQuery);
            this.gpBoxSensorQuery.Controls.Add(this.btnMapAskSens);
            this.gpBoxSensorQuery.Controls.Add(this.lbSensorNameForQuery);
            this.gpBoxSensorQuery.Location = new System.Drawing.Point(4, 323);
            this.gpBoxSensorQuery.Name = "gpBoxSensorQuery";
            this.gpBoxSensorQuery.Size = new System.Drawing.Size(283, 284);
            this.gpBoxSensorQuery.TabIndex = 24;
            this.gpBoxSensorQuery.TabStop = false;
            this.gpBoxSensorQuery.Text = "Опрос";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(270, 163);
            this.dataGridView1.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxCheckForQuery
            // 
            this.comboBoxCheckForQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCheckForQuery.Enabled = false;
            this.comboBoxCheckForQuery.FormattingEnabled = true;
            this.comboBoxCheckForQuery.Location = new System.Drawing.Point(90, 19);
            this.comboBoxCheckForQuery.Name = "comboBoxCheckForQuery";
            this.comboBoxCheckForQuery.Size = new System.Drawing.Size(181, 21);
            this.comboBoxCheckForQuery.TabIndex = 22;
            // 
            // btnMapAskSens
            // 
            this.btnMapAskSens.Enabled = false;
            this.btnMapAskSens.Location = new System.Drawing.Point(6, 249);
            this.btnMapAskSens.Name = "btnMapAskSens";
            this.btnMapAskSens.Size = new System.Drawing.Size(271, 29);
            this.btnMapAskSens.TabIndex = 23;
            this.btnMapAskSens.Text = "Опросить";
            this.btnMapAskSens.UseVisualStyleBackColor = true;
            // 
            // lbSensorNameForQuery
            // 
            this.lbSensorNameForQuery.AutoSize = true;
            this.lbSensorNameForQuery.Location = new System.Drawing.Point(12, 24);
            this.lbSensorNameForQuery.Name = "lbSensorNameForQuery";
            this.lbSensorNameForQuery.Size = new System.Drawing.Size(60, 13);
            this.lbSensorNameForQuery.TabIndex = 21;
            this.lbSensorNameForQuery.Text = "Название:";
            // 
            // gpBoxInternetConnectionCheck
            // 
            this.gpBoxInternetConnectionCheck.Controls.Add(this.txtBxCheckInternet);
            this.gpBoxInternetConnectionCheck.Location = new System.Drawing.Point(3, 613);
            this.gpBoxInternetConnectionCheck.Name = "gpBoxInternetConnectionCheck";
            this.gpBoxInternetConnectionCheck.Size = new System.Drawing.Size(283, 51);
            this.gpBoxInternetConnectionCheck.TabIndex = 22;
            this.gpBoxInternetConnectionCheck.TabStop = false;
            this.gpBoxInternetConnectionCheck.Text = "Подключение к сети Интернет";
            // 
            // txtBxCheckInternet
            // 
            this.txtBxCheckInternet.BackColor = System.Drawing.SystemColors.Window;
            this.txtBxCheckInternet.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBxCheckInternet.Location = new System.Drawing.Point(6, 19);
            this.txtBxCheckInternet.Name = "txtBxCheckInternet";
            this.txtBxCheckInternet.ReadOnly = true;
            this.txtBxCheckInternet.Size = new System.Drawing.Size(271, 20);
            this.txtBxCheckInternet.TabIndex = 19;
            this.txtBxCheckInternet.TabStop = false;
            this.txtBxCheckInternet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpBoxMapView
            // 
            this.gpBoxMapView.Controls.Add(this.btnShwMap);
            this.gpBoxMapView.Location = new System.Drawing.Point(4, 260);
            this.gpBoxMapView.Name = "gpBoxMapView";
            this.gpBoxMapView.Size = new System.Drawing.Size(283, 57);
            this.gpBoxMapView.TabIndex = 21;
            this.gpBoxMapView.TabStop = false;
            this.gpBoxMapView.Text = "Отображение карты";
            // 
            // btnShwMap
            // 
            this.btnShwMap.Location = new System.Drawing.Point(6, 19);
            this.btnShwMap.Name = "btnShwMap";
            this.btnShwMap.Size = new System.Drawing.Size(271, 29);
            this.btnShwMap.TabIndex = 19;
            this.btnShwMap.Text = "Отобразить";
            this.btnShwMap.UseVisualStyleBackColor = true;
            this.btnShwMap.Click += new System.EventHandler(this.btnShwMap_Click);
            // 
            // gpBoxSearch
            // 
            this.gpBoxSearch.Controls.Add(this.comboBoxSNMap);
            this.gpBoxSearch.Controls.Add(this.gpBoxSearchResult);
            this.gpBoxSearch.Controls.Add(this.lbSensorNameForSearch);
            this.gpBoxSearch.Location = new System.Drawing.Point(3, 14);
            this.gpBoxSearch.Name = "gpBoxSearch";
            this.gpBoxSearch.Size = new System.Drawing.Size(283, 240);
            this.gpBoxSearch.TabIndex = 20;
            this.gpBoxSearch.TabStop = false;
            this.gpBoxSearch.Text = " Поиск";
            // 
            // comboBoxSNMap
            // 
            this.comboBoxSNMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSNMap.FormattingEnabled = true;
            this.comboBoxSNMap.Location = new System.Drawing.Point(90, 19);
            this.comboBoxSNMap.Name = "comboBoxSNMap";
            this.comboBoxSNMap.Size = new System.Drawing.Size(181, 21);
            this.comboBoxSNMap.TabIndex = 20;
            this.comboBoxSNMap.SelectedIndexChanged += new System.EventHandler(this.comboBoxSNMap_SelectedIndexChanged_1);
            // 
            // gpBoxSearchResult
            // 
            this.gpBoxSearchResult.Controls.Add(this.gpBoxLastActivity);
            this.gpBoxSearchResult.Controls.Add(this.txtbxMapSStatus);
            this.gpBoxSearchResult.Controls.Add(this.txtbxMapSType);
            this.gpBoxSearchResult.Controls.Add(this.lbSensorTypeForResultOfSearch);
            this.gpBoxSearchResult.Controls.Add(this.lbSensorState);
            this.gpBoxSearchResult.Location = new System.Drawing.Point(6, 48);
            this.gpBoxSearchResult.Name = "gpBoxSearchResult";
            this.gpBoxSearchResult.Size = new System.Drawing.Size(271, 184);
            this.gpBoxSearchResult.TabIndex = 19;
            this.gpBoxSearchResult.TabStop = false;
            this.gpBoxSearchResult.Text = "Результаты поиска";
            // 
            // gpBoxLastActivity
            // 
            this.gpBoxLastActivity.Controls.Add(this.lbTimeOfLastActivity);
            this.gpBoxLastActivity.Controls.Add(this.txtbxMapLastTime);
            this.gpBoxLastActivity.Controls.Add(this.lbValueOfLastActivity);
            this.gpBoxLastActivity.Controls.Add(this.lbDateOfLastActivity);
            this.gpBoxLastActivity.Controls.Add(this.txtbxMapLastDate);
            this.gpBoxLastActivity.Controls.Add(this.txtbxMapLastValue);
            this.gpBoxLastActivity.Location = new System.Drawing.Point(6, 74);
            this.gpBoxLastActivity.Name = "gpBoxLastActivity";
            this.gpBoxLastActivity.Size = new System.Drawing.Size(259, 101);
            this.gpBoxLastActivity.TabIndex = 24;
            this.gpBoxLastActivity.TabStop = false;
            this.gpBoxLastActivity.Text = "Последняя активность";
            // 
            // lbTimeOfLastActivity
            // 
            this.lbTimeOfLastActivity.AutoSize = true;
            this.lbTimeOfLastActivity.Location = new System.Drawing.Point(6, 48);
            this.lbTimeOfLastActivity.Name = "lbTimeOfLastActivity";
            this.lbTimeOfLastActivity.Size = new System.Drawing.Size(43, 13);
            this.lbTimeOfLastActivity.TabIndex = 27;
            this.lbTimeOfLastActivity.Text = "Время:";
            // 
            // txtbxMapLastTime
            // 
            this.txtbxMapLastTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxMapLastTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtbxMapLastTime.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtbxMapLastTime.Location = new System.Drawing.Point(78, 45);
            this.txtbxMapLastTime.Name = "txtbxMapLastTime";
            this.txtbxMapLastTime.ReadOnly = true;
            this.txtbxMapLastTime.Size = new System.Drawing.Size(175, 20);
            this.txtbxMapLastTime.TabIndex = 26;
            this.txtbxMapLastTime.TabStop = false;
            this.txtbxMapLastTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbValueOfLastActivity
            // 
            this.lbValueOfLastActivity.AutoSize = true;
            this.lbValueOfLastActivity.Location = new System.Drawing.Point(6, 74);
            this.lbValueOfLastActivity.Name = "lbValueOfLastActivity";
            this.lbValueOfLastActivity.Size = new System.Drawing.Size(58, 13);
            this.lbValueOfLastActivity.TabIndex = 25;
            this.lbValueOfLastActivity.Text = "Значение:";
            // 
            // lbDateOfLastActivity
            // 
            this.lbDateOfLastActivity.AutoSize = true;
            this.lbDateOfLastActivity.Location = new System.Drawing.Point(6, 22);
            this.lbDateOfLastActivity.Name = "lbDateOfLastActivity";
            this.lbDateOfLastActivity.Size = new System.Drawing.Size(36, 13);
            this.lbDateOfLastActivity.TabIndex = 24;
            this.lbDateOfLastActivity.Text = "Дата:";
            // 
            // txtbxMapLastDate
            // 
            this.txtbxMapLastDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxMapLastDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtbxMapLastDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtbxMapLastDate.Location = new System.Drawing.Point(78, 19);
            this.txtbxMapLastDate.Name = "txtbxMapLastDate";
            this.txtbxMapLastDate.ReadOnly = true;
            this.txtbxMapLastDate.Size = new System.Drawing.Size(175, 20);
            this.txtbxMapLastDate.TabIndex = 19;
            this.txtbxMapLastDate.TabStop = false;
            this.txtbxMapLastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbxMapLastValue
            // 
            this.txtbxMapLastValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxMapLastValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtbxMapLastValue.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtbxMapLastValue.Location = new System.Drawing.Point(78, 71);
            this.txtbxMapLastValue.Name = "txtbxMapLastValue";
            this.txtbxMapLastValue.ReadOnly = true;
            this.txtbxMapLastValue.Size = new System.Drawing.Size(175, 20);
            this.txtbxMapLastValue.TabIndex = 23;
            this.txtbxMapLastValue.TabStop = false;
            this.txtbxMapLastValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbxMapSStatus
            // 
            this.txtbxMapSStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxMapSStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtbxMapSStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtbxMapSStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtbxMapSStatus.Location = new System.Drawing.Point(84, 48);
            this.txtbxMapSStatus.Name = "txtbxMapSStatus";
            this.txtbxMapSStatus.ReadOnly = true;
            this.txtbxMapSStatus.Size = new System.Drawing.Size(181, 20);
            this.txtbxMapSStatus.TabIndex = 18;
            this.txtbxMapSStatus.TabStop = false;
            this.txtbxMapSStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbxMapSType
            // 
            this.txtbxMapSType.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxMapSType.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtbxMapSType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtbxMapSType.Location = new System.Drawing.Point(84, 22);
            this.txtbxMapSType.Name = "txtbxMapSType";
            this.txtbxMapSType.ReadOnly = true;
            this.txtbxMapSType.Size = new System.Drawing.Size(181, 20);
            this.txtbxMapSType.TabIndex = 16;
            this.txtbxMapSType.TabStop = false;
            this.txtbxMapSType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSensorTypeForResultOfSearch
            // 
            this.lbSensorTypeForResultOfSearch.AutoSize = true;
            this.lbSensorTypeForResultOfSearch.Location = new System.Drawing.Point(6, 25);
            this.lbSensorTypeForResultOfSearch.Name = "lbSensorTypeForResultOfSearch";
            this.lbSensorTypeForResultOfSearch.Size = new System.Drawing.Size(72, 13);
            this.lbSensorTypeForResultOfSearch.TabIndex = 3;
            this.lbSensorTypeForResultOfSearch.Text = "Тип датчика:";
            // 
            // lbSensorState
            // 
            this.lbSensorState.AutoSize = true;
            this.lbSensorState.Location = new System.Drawing.Point(7, 51);
            this.lbSensorState.Name = "lbSensorState";
            this.lbSensorState.Size = new System.Drawing.Size(64, 13);
            this.lbSensorState.TabIndex = 17;
            this.lbSensorState.Text = "Состояние:";
            // 
            // lbSensorNameForSearch
            // 
            this.lbSensorNameForSearch.AutoSize = true;
            this.lbSensorNameForSearch.Location = new System.Drawing.Point(12, 24);
            this.lbSensorNameForSearch.Name = "lbSensorNameForSearch";
            this.lbSensorNameForSearch.Size = new System.Drawing.Size(60, 13);
            this.lbSensorNameForSearch.TabIndex = 1;
            this.lbSensorNameForSearch.Text = "Название:";
            // 
            // MainMap
            // 
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(15, -4);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 2;
            this.MainMap.MinZoom = 2;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(785, 674);
            this.MainMap.TabIndex = 0;
            this.MainMap.Visible = false;
            this.MainMap.Zoom = 0D;
            this.MainMap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.MainMap_OnMarkerClick);
            this.MainMap.Load += new System.EventHandler(this.MainMap_Load);
            // 
            // tabPageSensor
            // 
            this.tabPageSensor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageSensor.Controls.Add(this.gpBoxGraphic);
            this.tabPageSensor.Controls.Add(this.gpBoxData);
            this.tabPageSensor.Controls.Add(this.gpBoxSensorIdentity);
            this.tabPageSensor.Controls.Add(this.label3);
            this.tabPageSensor.Location = new System.Drawing.Point(4, 22);
            this.tabPageSensor.Name = "tabPageSensor";
            this.tabPageSensor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSensor.Size = new System.Drawing.Size(1084, 673);
            this.tabPageSensor.TabIndex = 0;
            this.tabPageSensor.Text = "Данные";
            // 
            // gpBoxGraphic
            // 
            this.gpBoxGraphic.Controls.Add(this.unionChart);
            this.gpBoxGraphic.Location = new System.Drawing.Point(6, 336);
            this.gpBoxGraphic.Name = "gpBoxGraphic";
            this.gpBoxGraphic.Size = new System.Drawing.Size(1072, 331);
            this.gpBoxGraphic.TabIndex = 16;
            this.gpBoxGraphic.TabStop = false;
            this.gpBoxGraphic.Text = "График";
            // 
            // unionChart
            // 
            chartArea1.Name = "ChartArea1";
            this.unionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.unionChart.Legends.Add(legend1);
            this.unionChart.Location = new System.Drawing.Point(6, 19);
            this.unionChart.Name = "unionChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Датчик";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.unionChart.Series.Add(series1);
            this.unionChart.Size = new System.Drawing.Size(1060, 306);
            this.unionChart.TabIndex = 6;
            this.unionChart.Text = "chart1";
            // 
            // gpBoxData
            // 
            this.gpBoxData.Controls.Add(this.label7);
            this.gpBoxData.Controls.Add(this.comboBoxInterval);
            this.gpBoxData.Controls.Add(this.label2);
            this.gpBoxData.Controls.Add(this.txtbxDate);
            this.gpBoxData.Controls.Add(this.label9);
            this.gpBoxData.Controls.Add(this.dgvData);
            this.gpBoxData.Controls.Add(this.label1);
            this.gpBoxData.Controls.Add(this.label8);
            this.gpBoxData.Controls.Add(this.rtbSensorsValue);
            this.gpBoxData.Controls.Add(this.txtbxTimeFrom);
            this.gpBoxData.Controls.Add(this.txtbxTimeTo);
            this.gpBoxData.Location = new System.Drawing.Point(537, 6);
            this.gpBoxData.Name = "gpBoxData";
            this.gpBoxData.Size = new System.Drawing.Size(541, 324);
            this.gpBoxData.TabIndex = 14;
            this.gpBoxData.TabStop = false;
            this.gpBoxData.Text = "Данные";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Часовой промежуток:";
            // 
            // comboBoxInterval
            // 
            this.comboBoxInterval.AllowDrop = true;
            this.comboBoxInterval.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInterval.FormattingEnabled = true;
            this.comboBoxInterval.Items.AddRange(new object[] {
            "за всё время",
            "30 минут",
            "1 час",
            "5 часов"});
            this.comboBoxInterval.Location = new System.Drawing.Point(336, 75);
            this.comboBoxInterval.Name = "comboBoxInterval";
            this.comboBoxInterval.Size = new System.Drawing.Size(174, 21);
            this.comboBoxInterval.TabIndex = 9;
            this.comboBoxInterval.SelectedIndexChanged += new System.EventHandler(this.comboBoxInterval_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = " Интервал:";
            // 
            // txtbxDate
            // 
            this.txtbxDate.Location = new System.Drawing.Point(56, 33);
            this.txtbxDate.Name = "txtbxDate";
            this.txtbxDate.Size = new System.Drawing.Size(130, 20);
            this.txtbxDate.TabIndex = 12;
            this.txtbxDate.TextChanged += new System.EventHandler(this.textBoxForDate_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "До";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(6, 102);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(529, 213);
            this.dgvData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "От: ";
            // 
            // rtbSensorsValue
            // 
            this.rtbSensorsValue.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbSensorsValue.Enabled = false;
            this.rtbSensorsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbSensorsValue.Location = new System.Drawing.Point(6, 73);
            this.rtbSensorsValue.Name = "rtbSensorsValue";
            this.rtbSensorsValue.Size = new System.Drawing.Size(249, 24);
            this.rtbSensorsValue.TabIndex = 10;
            this.rtbSensorsValue.Text = "Показаний датчика: 0";
            // 
            // txtbxTimeFrom
            // 
            this.txtbxTimeFrom.Location = new System.Drawing.Point(410, 22);
            this.txtbxTimeFrom.Name = "txtbxTimeFrom";
            this.txtbxTimeFrom.Size = new System.Drawing.Size(100, 20);
            this.txtbxTimeFrom.TabIndex = 11;
            this.txtbxTimeFrom.TextChanged += new System.EventHandler(this.textBoxForTimeFrom_TextChanged);
            // 
            // txtbxTimeTo
            // 
            this.txtbxTimeTo.Location = new System.Drawing.Point(410, 45);
            this.txtbxTimeTo.Name = "txtbxTimeTo";
            this.txtbxTimeTo.Size = new System.Drawing.Size(100, 20);
            this.txtbxTimeTo.TabIndex = 10;
            this.txtbxTimeTo.TextChanged += new System.EventHandler(this.textBoxForTimeTo_TextChanged);
            // 
            // gpBoxSensorIdentity
            // 
            this.gpBoxSensorIdentity.Controls.Add(this.progressBarLoadDataFromDB);
            this.gpBoxSensorIdentity.Controls.Add(this.gpBoxSensorsView);
            this.gpBoxSensorIdentity.Controls.Add(this.dgvSens);
            this.gpBoxSensorIdentity.Controls.Add(this.btnRefreshDB);
            this.gpBoxSensorIdentity.Controls.Add(this.rtbAmountSensors);
            this.gpBoxSensorIdentity.Location = new System.Drawing.Point(6, 6);
            this.gpBoxSensorIdentity.Name = "gpBoxSensorIdentity";
            this.gpBoxSensorIdentity.Size = new System.Drawing.Size(525, 324);
            this.gpBoxSensorIdentity.TabIndex = 13;
            this.gpBoxSensorIdentity.TabStop = false;
            this.gpBoxSensorIdentity.Text = "Идентификация датчиков";
            // 
            // progressBarLoadDataFromDB
            // 
            this.progressBarLoadDataFromDB.Location = new System.Drawing.Point(230, 74);
            this.progressBarLoadDataFromDB.Name = "progressBarLoadDataFromDB";
            this.progressBarLoadDataFromDB.Size = new System.Drawing.Size(289, 23);
            this.progressBarLoadDataFromDB.TabIndex = 5;
            // 
            // gpBoxSensorsView
            // 
            this.gpBoxSensorsView.Controls.Add(this.rButtonAllSensors);
            this.gpBoxSensorsView.Controls.Add(this.rButtonChooseSensors);
            this.gpBoxSensorsView.Location = new System.Drawing.Point(6, 16);
            this.gpBoxSensorsView.Name = "gpBoxSensorsView";
            this.gpBoxSensorsView.Size = new System.Drawing.Size(218, 53);
            this.gpBoxSensorsView.TabIndex = 19;
            this.gpBoxSensorsView.TabStop = false;
            this.gpBoxSensorsView.Text = "Отобразить";
            // 
            // rButtonAllSensors
            // 
            this.rButtonAllSensors.AutoSize = true;
            this.rButtonAllSensors.Checked = true;
            this.rButtonAllSensors.Location = new System.Drawing.Point(17, 24);
            this.rButtonAllSensors.Name = "rButtonAllSensors";
            this.rButtonAllSensors.Size = new System.Drawing.Size(87, 17);
            this.rButtonAllSensors.TabIndex = 17;
            this.rButtonAllSensors.TabStop = true;
            this.rButtonAllSensors.Text = "Все датчики";
            this.rButtonAllSensors.UseVisualStyleBackColor = true;
            this.rButtonAllSensors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rButtonAllSensors_MouseClick);
            // 
            // rButtonChooseSensors
            // 
            this.rButtonChooseSensors.AutoSize = true;
            this.rButtonChooseSensors.Location = new System.Drawing.Point(119, 24);
            this.rButtonChooseSensors.Name = "rButtonChooseSensors";
            this.rButtonChooseSensors.Size = new System.Drawing.Size(81, 17);
            this.rButtonChooseSensors.TabIndex = 18;
            this.rButtonChooseSensors.TabStop = true;
            this.rButtonChooseSensors.Text = "Выборочно";
            this.rButtonChooseSensors.UseVisualStyleBackColor = true;
            this.rButtonChooseSensors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rButtonChooseSensors_MouseClick);
            // 
            // dgvSens
            // 
            this.dgvSens.AllowUserToAddRows = false;
            this.dgvSens.AllowUserToDeleteRows = false;
            this.dgvSens.AllowUserToResizeColumns = false;
            this.dgvSens.AllowUserToResizeRows = false;
            this.dgvSens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSens.Location = new System.Drawing.Point(6, 102);
            this.dgvSens.Name = "dgvSens";
            this.dgvSens.ReadOnly = true;
            this.dgvSens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSens.Size = new System.Drawing.Size(513, 213);
            this.dgvSens.TabIndex = 16;
            this.dgvSens.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSens_CellEnter);
            this.dgvSens.SelectionChanged += new System.EventHandler(this.dgvSens_SelectionChanged);
            // 
            // btnRefreshDB
            // 
            this.btnRefreshDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshDB.Location = new System.Drawing.Point(230, 16);
            this.btnRefreshDB.Name = "btnRefreshDB";
            this.btnRefreshDB.Size = new System.Drawing.Size(289, 53);
            this.btnRefreshDB.TabIndex = 13;
            this.btnRefreshDB.Text = "Получить данные";
            this.btnRefreshDB.UseVisualStyleBackColor = true;
            this.btnRefreshDB.Click += new System.EventHandler(this.btnRefreshDB_Click);
            // 
            // rtbAmountSensors
            // 
            this.rtbAmountSensors.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbAmountSensors.Enabled = false;
            this.rtbAmountSensors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbAmountSensors.Location = new System.Drawing.Point(6, 75);
            this.rtbAmountSensors.Name = "rtbAmountSensors";
            this.rtbAmountSensors.Size = new System.Drawing.Size(218, 24);
            this.rtbAmountSensors.TabIndex = 15;
            this.rtbAmountSensors.Text = "Количество датчиков: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // карта
            // 
            this.карта.AccessibleName = "";
            this.карта.Controls.Add(this.tabPageSensor);
            this.карта.Controls.Add(this.tabPage1);
            this.карта.Controls.Add(this.Мониторинг);
            this.карта.Location = new System.Drawing.Point(7, 30);
            this.карта.Name = "карта";
            this.карта.SelectedIndex = 0;
            this.карта.Size = new System.Drawing.Size(1092, 699);
            this.карта.TabIndex = 4;
            this.карта.Tag = "";
            // 
            // Мониторинг
            // 
            this.Мониторинг.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Мониторинг.Controls.Add(this.btnStartMonitoring);
            this.Мониторинг.Controls.Add(this.groupBox10);
            this.Мониторинг.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Мониторинг.Location = new System.Drawing.Point(4, 22);
            this.Мониторинг.Name = "Мониторинг";
            this.Мониторинг.Padding = new System.Windows.Forms.Padding(3);
            this.Мониторинг.Size = new System.Drawing.Size(1084, 673);
            this.Мониторинг.TabIndex = 2;
            this.Мониторинг.Text = "Мониторинг";
            // 
            // btnStartMonitoring
            // 
            this.btnStartMonitoring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartMonitoring.Location = new System.Drawing.Point(351, 36);
            this.btnStartMonitoring.Name = "btnStartMonitoring";
            this.btnStartMonitoring.Size = new System.Drawing.Size(127, 75);
            this.btnStartMonitoring.TabIndex = 18;
            this.btnStartMonitoring.Text = "Начать мониторинг";
            this.btnStartMonitoring.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox10.Location = new System.Drawing.Point(99, 123);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 100);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "groupBox10";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestartMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "Файл";
            // 
            // RestartMenu
            // 
            this.RestartMenu.Name = "RestartMenu";
            this.RestartMenu.Size = new System.Drawing.Size(148, 22);
            this.RestartMenu.Text = "Перезагрузка";
            this.RestartMenu.Click += new System.EventHandler(this.RestartMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(148, 22);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // PropertiesMenu
            // 
            this.PropertiesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSensMenu});
            this.PropertiesMenu.Name = "PropertiesMenu";
            this.PropertiesMenu.Size = new System.Drawing.Size(79, 20);
            this.PropertiesMenu.Text = "Настройки";
            // 
            // AddSensMenu
            // 
            this.AddSensMenu.Name = "AddSensMenu";
            this.AddSensMenu.Size = new System.Drawing.Size(166, 22);
            this.AddSensMenu.Text = "Добавить датчик";
            this.AddSensMenu.Click += new System.EventHandler(this.AddSensMenu_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(68, 20);
            this.HelpMenu.Text = "Помощь";
            // 
            // AboutProgramMenu
            // 
            this.AboutProgramMenu.Name = "AboutProgramMenu";
            this.AboutProgramMenu.Size = new System.Drawing.Size(149, 22);
            this.AboutProgramMenu.Text = "О программе";
            this.AboutProgramMenu.Click += new System.EventHandler(this.AboutProgramMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.PropertiesMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 734);
            this.Controls.Add(this.карта);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Беспроводная система мониторинга WMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpBoxSensorQuery.ResumeLayout(false);
            this.gpBoxSensorQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpBoxInternetConnectionCheck.ResumeLayout(false);
            this.gpBoxInternetConnectionCheck.PerformLayout();
            this.gpBoxMapView.ResumeLayout(false);
            this.gpBoxSearch.ResumeLayout(false);
            this.gpBoxSearch.PerformLayout();
            this.gpBoxSearchResult.ResumeLayout(false);
            this.gpBoxSearchResult.PerformLayout();
            this.gpBoxLastActivity.ResumeLayout(false);
            this.gpBoxLastActivity.PerformLayout();
            this.tabPageSensor.ResumeLayout(false);
            this.tabPageSensor.PerformLayout();
            this.gpBoxGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unionChart)).EndInit();
            this.gpBoxData.ResumeLayout(false);
            this.gpBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gpBoxSensorIdentity.ResumeLayout(false);
            this.gpBoxSensorsView.ResumeLayout(false);
            this.gpBoxSensorsView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSens)).EndInit();
            this.карта.ResumeLayout(false);
            this.Мониторинг.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SValuesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource SValuesBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gpBoxInternetConnectionCheck;
        private System.Windows.Forms.TextBox txtBxCheckInternet;
        private System.Windows.Forms.GroupBox gpBoxMapView;
        private System.Windows.Forms.Button btnShwMap;
        private System.Windows.Forms.GroupBox gpBoxSearch;
        private System.Windows.Forms.GroupBox gpBoxSearchResult;
        private System.Windows.Forms.TextBox txtbxMapSStatus;
        private System.Windows.Forms.TextBox txtbxMapSType;
        private System.Windows.Forms.Label lbSensorTypeForResultOfSearch;
        private System.Windows.Forms.Label lbSensorState;
        private System.Windows.Forms.Label lbSensorNameForSearch;
        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.TabPage tabPageSensor;
        private System.Windows.Forms.GroupBox gpBoxGraphic;
        private System.Windows.Forms.DataVisualization.Charting.Chart unionChart;
        private System.Windows.Forms.GroupBox gpBoxData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbSensorsValue;
        private System.Windows.Forms.TextBox txtbxTimeFrom;
        private System.Windows.Forms.TextBox txtbxTimeTo;
        private System.Windows.Forms.GroupBox gpBoxSensorIdentity;
        private System.Windows.Forms.DataGridView dgvSens;
        private System.Windows.Forms.Button btnRefreshDB;
        private System.Windows.Forms.RichTextBox rtbAmountSensors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl карта;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem PropertiesMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBoxSNMap;
        private System.Windows.Forms.TextBox txtbxMapLastValue;
        private System.Windows.Forms.TextBox txtbxMapLastDate;
        private System.Windows.Forms.GroupBox gpBoxLastActivity;
        private System.Windows.Forms.Label lbValueOfLastActivity;
        private System.Windows.Forms.Label lbDateOfLastActivity;
        private System.Windows.Forms.Label lbTimeOfLastActivity;
        private System.Windows.Forms.TextBox txtbxMapLastTime;
        private System.Windows.Forms.ToolStripMenuItem RestartMenu;
        private System.Windows.Forms.ToolStripMenuItem AddSensMenu;
        private System.Windows.Forms.GroupBox gpBoxSensorQuery;
        private System.Windows.Forms.Button btnMapAskSens;
        private System.Windows.Forms.Label lbSensorNameForQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCheckForQuery;
        private System.Windows.Forms.TabPage Мониторинг;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnStartMonitoring;
        private System.Windows.Forms.GroupBox gpBoxSensorsView;
        private System.Windows.Forms.RadioButton rButtonAllSensors;
        private System.Windows.Forms.RadioButton rButtonChooseSensors;
        private System.Windows.Forms.ProgressBar progressBarLoadDataFromDB;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

