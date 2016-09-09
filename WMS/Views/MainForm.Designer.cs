namespace UI.Views
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gpBoxSensorQuery = new System.Windows.Forms.GroupBox();
            this.btnSelectSensorsForRequest = new System.Windows.Forms.Button();
            this.lblSelectedSensorsCount = new System.Windows.Forms.Label();
            this.lblSelectedSensors = new System.Windows.Forms.Label();
            this.dgvQA = new System.Windows.Forms.DataGridView();
            this.btnMapRequest = new System.Windows.Forms.Button();
            this.gpBoxInternetConnectionCheck = new System.Windows.Forms.GroupBox();
            this.txtBoxCheckInternet = new System.Windows.Forms.TextBox();
            this.gpBoxMapView = new System.Windows.Forms.GroupBox();
            this.btnShwMap = new System.Windows.Forms.Button();
            this.gpBoxSearch = new System.Windows.Forms.GroupBox();
            this.comboBoxSNMap = new System.Windows.Forms.ComboBox();
            this.gpBoxSearchResult = new System.Windows.Forms.GroupBox();
            this.gpBoxLastActivity = new System.Windows.Forms.GroupBox();
            this.lbTimeOfLastActivity = new System.Windows.Forms.Label();
            this.txtBoxMapLastTime = new System.Windows.Forms.TextBox();
            this.lbValueOfLastActivity = new System.Windows.Forms.Label();
            this.lbDateOfLastActivity = new System.Windows.Forms.Label();
            this.txtBoxMapLastDate = new System.Windows.Forms.TextBox();
            this.txtBoxMapLastValue = new System.Windows.Forms.TextBox();
            this.txtBoxMapSStatus = new System.Windows.Forms.TextBox();
            this.txtBoxMapSType = new System.Windows.Forms.TextBox();
            this.lbSensorTypeForResultOfSearch = new System.Windows.Forms.Label();
            this.lbSensorState = new System.Windows.Forms.Label();
            this.lbSensorNameForSearch = new System.Windows.Forms.Label();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.tabPageSensor = new System.Windows.Forms.TabPage();
            this.gpBoxGraphic = new System.Windows.Forms.GroupBox();
            this.unionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gpBoxData = new System.Windows.Forms.GroupBox();
            this.grBoxDataView = new System.Windows.Forms.GroupBox();
            this.rButtonAllDates = new System.Windows.Forms.RadioButton();
            this.rButtonChooseDate = new System.Windows.Forms.RadioButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.rtbSensorsValue = new System.Windows.Forms.RichTextBox();
            this.gpBoxSensorIdentity = new System.Windows.Forms.GroupBox();
            this.grBoxCurrentSensor = new System.Windows.Forms.GroupBox();
            this.txtBoxCurrentSensor = new System.Windows.Forms.TextBox();
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
            this.grBoxGettingData = new System.Windows.Forms.GroupBox();
            this.grBoxFiltration = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grBoxMonitoringSettings = new System.Windows.Forms.GroupBox();
            this.btnStartMonitoring = new System.Windows.Forms.Button();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSensMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.grBoxLogs = new System.Windows.Forms.GroupBox();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpBoxSensorQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQA)).BeginInit();
            this.gpBoxInternetConnectionCheck.SuspendLayout();
            this.gpBoxMapView.SuspendLayout();
            this.gpBoxSearch.SuspendLayout();
            this.gpBoxSearchResult.SuspendLayout();
            this.gpBoxLastActivity.SuspendLayout();
            this.tabPageSensor.SuspendLayout();
            this.gpBoxGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unionChart)).BeginInit();
            this.gpBoxData.SuspendLayout();
            this.grBoxDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gpBoxSensorIdentity.SuspendLayout();
            this.grBoxCurrentSensor.SuspendLayout();
            this.gpBoxSensorsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSens)).BeginInit();
            this.карта.SuspendLayout();
            this.Мониторинг.SuspendLayout();
            this.grBoxGettingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grBoxMonitoringSettings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grBoxLogs.SuspendLayout();
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
            this.gpBoxSensorQuery.Controls.Add(this.btnSelectSensorsForRequest);
            this.gpBoxSensorQuery.Controls.Add(this.lblSelectedSensorsCount);
            this.gpBoxSensorQuery.Controls.Add(this.lblSelectedSensors);
            this.gpBoxSensorQuery.Controls.Add(this.dgvQA);
            this.gpBoxSensorQuery.Controls.Add(this.btnMapRequest);
            this.gpBoxSensorQuery.Location = new System.Drawing.Point(4, 323);
            this.gpBoxSensorQuery.Name = "gpBoxSensorQuery";
            this.gpBoxSensorQuery.Size = new System.Drawing.Size(283, 284);
            this.gpBoxSensorQuery.TabIndex = 24;
            this.gpBoxSensorQuery.TabStop = false;
            this.gpBoxSensorQuery.Text = "Опрос";
            // 
            // btnSelectSensorsForRequest
            // 
            this.btnSelectSensorsForRequest.Location = new System.Drawing.Point(136, 11);
            this.btnSelectSensorsForRequest.Name = "btnSelectSensorsForRequest";
            this.btnSelectSensorsForRequest.Size = new System.Drawing.Size(141, 23);
            this.btnSelectSensorsForRequest.TabIndex = 26;
            this.btnSelectSensorsForRequest.Text = "Выбрать";
            this.btnSelectSensorsForRequest.UseVisualStyleBackColor = true;
            this.btnSelectSensorsForRequest.Click += new System.EventHandler(this.btnSelectSensorsForQuiz_Click);
            // 
            // lblSelectedSensorsCount
            // 
            this.lblSelectedSensorsCount.AutoSize = true;
            this.lblSelectedSensorsCount.Location = new System.Drawing.Point(116, 16);
            this.lblSelectedSensorsCount.Name = "lblSelectedSensorsCount";
            this.lblSelectedSensorsCount.Size = new System.Drawing.Size(13, 13);
            this.lblSelectedSensorsCount.TabIndex = 25;
            this.lblSelectedSensorsCount.Text = "0";
            this.lblSelectedSensorsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedSensors
            // 
            this.lblSelectedSensors.AutoSize = true;
            this.lblSelectedSensors.Location = new System.Drawing.Point(6, 16);
            this.lblSelectedSensors.Name = "lblSelectedSensors";
            this.lblSelectedSensors.Size = new System.Drawing.Size(104, 13);
            this.lblSelectedSensors.TabIndex = 24;
            this.lblSelectedSensors.Text = "Выбрано датчиков:";
            // 
            // dgvQA
            // 
            this.dgvQA.Location = new System.Drawing.Point(5, 75);
            this.dgvQA.Name = "dgvQA";
            this.dgvQA.Size = new System.Drawing.Size(271, 203);
            this.dgvQA.TabIndex = 0;
            // 
            // btnMapRequest
            // 
            this.btnMapRequest.Enabled = false;
            this.btnMapRequest.Location = new System.Drawing.Point(5, 40);
            this.btnMapRequest.Name = "btnMapRequest";
            this.btnMapRequest.Size = new System.Drawing.Size(272, 29);
            this.btnMapRequest.TabIndex = 23;
            this.btnMapRequest.Text = "Опросить";
            this.btnMapRequest.UseVisualStyleBackColor = true;
            this.btnMapRequest.Click += new System.EventHandler(this.btnMapRequest_Click);
            // 
            // gpBoxInternetConnectionCheck
            // 
            this.gpBoxInternetConnectionCheck.Controls.Add(this.txtBoxCheckInternet);
            this.gpBoxInternetConnectionCheck.Location = new System.Drawing.Point(3, 613);
            this.gpBoxInternetConnectionCheck.Name = "gpBoxInternetConnectionCheck";
            this.gpBoxInternetConnectionCheck.Size = new System.Drawing.Size(283, 51);
            this.gpBoxInternetConnectionCheck.TabIndex = 22;
            this.gpBoxInternetConnectionCheck.TabStop = false;
            this.gpBoxInternetConnectionCheck.Text = "Подключение к сети Интернет";
            // 
            // txtBoxCheckInternet
            // 
            this.txtBoxCheckInternet.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxCheckInternet.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxCheckInternet.Location = new System.Drawing.Point(6, 19);
            this.txtBoxCheckInternet.Name = "txtBoxCheckInternet";
            this.txtBoxCheckInternet.ReadOnly = true;
            this.txtBoxCheckInternet.Size = new System.Drawing.Size(271, 20);
            this.txtBoxCheckInternet.TabIndex = 19;
            this.txtBoxCheckInternet.TabStop = false;
            this.txtBoxCheckInternet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.comboBoxSNMap.SelectedIndexChanged += new System.EventHandler(this.comboBoxSNMap_SelectedIndexChanged);
            // 
            // gpBoxSearchResult
            // 
            this.gpBoxSearchResult.Controls.Add(this.gpBoxLastActivity);
            this.gpBoxSearchResult.Controls.Add(this.txtBoxMapSStatus);
            this.gpBoxSearchResult.Controls.Add(this.txtBoxMapSType);
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
            this.gpBoxLastActivity.Controls.Add(this.txtBoxMapLastTime);
            this.gpBoxLastActivity.Controls.Add(this.lbValueOfLastActivity);
            this.gpBoxLastActivity.Controls.Add(this.lbDateOfLastActivity);
            this.gpBoxLastActivity.Controls.Add(this.txtBoxMapLastDate);
            this.gpBoxLastActivity.Controls.Add(this.txtBoxMapLastValue);
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
            // txtBoxMapLastTime
            // 
            this.txtBoxMapLastTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMapLastTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMapLastTime.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtBoxMapLastTime.Location = new System.Drawing.Point(78, 45);
            this.txtBoxMapLastTime.Name = "txtBoxMapLastTime";
            this.txtBoxMapLastTime.ReadOnly = true;
            this.txtBoxMapLastTime.Size = new System.Drawing.Size(175, 20);
            this.txtBoxMapLastTime.TabIndex = 26;
            this.txtBoxMapLastTime.TabStop = false;
            this.txtBoxMapLastTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtBoxMapLastDate
            // 
            this.txtBoxMapLastDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMapLastDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMapLastDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtBoxMapLastDate.Location = new System.Drawing.Point(78, 19);
            this.txtBoxMapLastDate.Name = "txtBoxMapLastDate";
            this.txtBoxMapLastDate.ReadOnly = true;
            this.txtBoxMapLastDate.Size = new System.Drawing.Size(175, 20);
            this.txtBoxMapLastDate.TabIndex = 19;
            this.txtBoxMapLastDate.TabStop = false;
            this.txtBoxMapLastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxMapLastValue
            // 
            this.txtBoxMapLastValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMapLastValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMapLastValue.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtBoxMapLastValue.Location = new System.Drawing.Point(78, 71);
            this.txtBoxMapLastValue.Name = "txtBoxMapLastValue";
            this.txtBoxMapLastValue.ReadOnly = true;
            this.txtBoxMapLastValue.Size = new System.Drawing.Size(175, 20);
            this.txtBoxMapLastValue.TabIndex = 23;
            this.txtBoxMapLastValue.TabStop = false;
            this.txtBoxMapLastValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxMapSStatus
            // 
            this.txtBoxMapSStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMapSStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMapSStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtBoxMapSStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtBoxMapSStatus.Location = new System.Drawing.Point(84, 48);
            this.txtBoxMapSStatus.Name = "txtBoxMapSStatus";
            this.txtBoxMapSStatus.ReadOnly = true;
            this.txtBoxMapSStatus.Size = new System.Drawing.Size(181, 20);
            this.txtBoxMapSStatus.TabIndex = 18;
            this.txtBoxMapSStatus.TabStop = false;
            this.txtBoxMapSStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxMapSType
            // 
            this.txtBoxMapSType.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMapSType.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMapSType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtBoxMapSType.Location = new System.Drawing.Point(84, 22);
            this.txtBoxMapSType.Name = "txtBoxMapSType";
            this.txtBoxMapSType.ReadOnly = true;
            this.txtBoxMapSType.Size = new System.Drawing.Size(181, 20);
            this.txtBoxMapSType.TabIndex = 16;
            this.txtBoxMapSType.TabStop = false;
            this.txtBoxMapSType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.gpBoxData.Controls.Add(this.grBoxDataView);
            this.gpBoxData.Controls.Add(this.dgvData);
            this.gpBoxData.Controls.Add(this.rtbSensorsValue);
            this.gpBoxData.Location = new System.Drawing.Point(537, 6);
            this.gpBoxData.Name = "gpBoxData";
            this.gpBoxData.Size = new System.Drawing.Size(541, 324);
            this.gpBoxData.TabIndex = 14;
            this.gpBoxData.TabStop = false;
            this.gpBoxData.Text = "Данные";
            // 
            // grBoxDataView
            // 
            this.grBoxDataView.Controls.Add(this.rButtonAllDates);
            this.grBoxDataView.Controls.Add(this.rButtonChooseDate);
            this.grBoxDataView.Location = new System.Drawing.Point(6, 16);
            this.grBoxDataView.Name = "grBoxDataView";
            this.grBoxDataView.Size = new System.Drawing.Size(218, 53);
            this.grBoxDataView.TabIndex = 20;
            this.grBoxDataView.TabStop = false;
            this.grBoxDataView.Text = "Отобразить";
            // 
            // rButtonAllDates
            // 
            this.rButtonAllDates.AutoSize = true;
            this.rButtonAllDates.Checked = true;
            this.rButtonAllDates.Location = new System.Drawing.Point(17, 24);
            this.rButtonAllDates.Name = "rButtonAllDates";
            this.rButtonAllDates.Size = new System.Drawing.Size(85, 17);
            this.rButtonAllDates.TabIndex = 17;
            this.rButtonAllDates.TabStop = true;
            this.rButtonAllDates.Text = "Все данные";
            this.rButtonAllDates.UseVisualStyleBackColor = true;
            this.rButtonAllDates.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rButtonAllDates_MouseClick);
            // 
            // rButtonChooseDate
            // 
            this.rButtonChooseDate.AutoSize = true;
            this.rButtonChooseDate.Location = new System.Drawing.Point(119, 24);
            this.rButtonChooseDate.Name = "rButtonChooseDate";
            this.rButtonChooseDate.Size = new System.Drawing.Size(81, 17);
            this.rButtonChooseDate.TabIndex = 18;
            this.rButtonChooseDate.TabStop = true;
            this.rButtonChooseDate.Text = "Выборочно";
            this.rButtonChooseDate.UseVisualStyleBackColor = true;
            this.rButtonChooseDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rButtonChooseDate_MouseClick);
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
            // rtbSensorsValue
            // 
            this.rtbSensorsValue.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbSensorsValue.Enabled = false;
            this.rtbSensorsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbSensorsValue.Location = new System.Drawing.Point(6, 73);
            this.rtbSensorsValue.Name = "rtbSensorsValue";
            this.rtbSensorsValue.Size = new System.Drawing.Size(218, 24);
            this.rtbSensorsValue.TabIndex = 10;
            this.rtbSensorsValue.Text = "Показаний датчика: 0";
            // 
            // gpBoxSensorIdentity
            // 
            this.gpBoxSensorIdentity.Controls.Add(this.grBoxCurrentSensor);
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
            // grBoxCurrentSensor
            // 
            this.grBoxCurrentSensor.Controls.Add(this.txtBoxCurrentSensor);
            this.grBoxCurrentSensor.Location = new System.Drawing.Point(230, 19);
            this.grBoxCurrentSensor.Name = "grBoxCurrentSensor";
            this.grBoxCurrentSensor.Size = new System.Drawing.Size(154, 49);
            this.grBoxCurrentSensor.TabIndex = 20;
            this.grBoxCurrentSensor.TabStop = false;
            this.grBoxCurrentSensor.Text = "Выбранный датчик";
            // 
            // txtBoxCurrentSensor
            // 
            this.txtBoxCurrentSensor.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxCurrentSensor.Location = new System.Drawing.Point(10, 23);
            this.txtBoxCurrentSensor.Name = "txtBoxCurrentSensor";
            this.txtBoxCurrentSensor.ReadOnly = true;
            this.txtBoxCurrentSensor.Size = new System.Drawing.Size(138, 20);
            this.txtBoxCurrentSensor.TabIndex = 22;
            this.txtBoxCurrentSensor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBarLoadDataFromDB
            // 
            this.progressBarLoadDataFromDB.BackColor = System.Drawing.Color.YellowGreen;
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
            this.dgvSens.MultiSelect = false;
            this.dgvSens.Name = "dgvSens";
            this.dgvSens.ReadOnly = true;
            this.dgvSens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSens.Size = new System.Drawing.Size(513, 213);
            this.dgvSens.TabIndex = 16;
            this.dgvSens.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSens_CellEnter);
            // 
            // btnRefreshDB
            // 
            this.btnRefreshDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshDB.Location = new System.Drawing.Point(390, 16);
            this.btnRefreshDB.Name = "btnRefreshDB";
            this.btnRefreshDB.Size = new System.Drawing.Size(129, 53);
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
            this.Мониторинг.Controls.Add(this.grBoxGettingData);
            this.Мониторинг.Controls.Add(this.grBoxMonitoringSettings);
            this.Мониторинг.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Мониторинг.Location = new System.Drawing.Point(4, 22);
            this.Мониторинг.Name = "Мониторинг";
            this.Мониторинг.Padding = new System.Windows.Forms.Padding(3);
            this.Мониторинг.Size = new System.Drawing.Size(1084, 673);
            this.Мониторинг.TabIndex = 2;
            this.Мониторинг.Text = "Мониторинг";
            // 
            // grBoxGettingData
            // 
            this.grBoxGettingData.Controls.Add(this.grBoxFiltration);
            this.grBoxGettingData.Controls.Add(this.dataGridView1);
            this.grBoxGettingData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grBoxGettingData.Location = new System.Drawing.Point(449, 3);
            this.grBoxGettingData.Name = "grBoxGettingData";
            this.grBoxGettingData.Size = new System.Drawing.Size(629, 664);
            this.grBoxGettingData.TabIndex = 19;
            this.grBoxGettingData.TabStop = false;
            this.grBoxGettingData.Text = "Получаемые данные";
            // 
            // grBoxFiltration
            // 
            this.grBoxFiltration.Location = new System.Drawing.Point(6, 384);
            this.grBoxFiltration.Name = "grBoxFiltration";
            this.grBoxFiltration.Size = new System.Drawing.Size(617, 274);
            this.grBoxFiltration.TabIndex = 2;
            this.grBoxFiltration.TabStop = false;
            this.grBoxFiltration.Text = "Фильтрация";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 359);
            this.dataGridView1.TabIndex = 1;
            // 
            // grBoxMonitoringSettings
            // 
            this.grBoxMonitoringSettings.Controls.Add(this.btnStartMonitoring);
            this.grBoxMonitoringSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grBoxMonitoringSettings.Location = new System.Drawing.Point(6, 3);
            this.grBoxMonitoringSettings.Name = "grBoxMonitoringSettings";
            this.grBoxMonitoringSettings.Size = new System.Drawing.Size(437, 664);
            this.grBoxMonitoringSettings.TabIndex = 0;
            this.grBoxMonitoringSettings.TabStop = false;
            this.grBoxMonitoringSettings.Text = "Настройки";
            // 
            // btnStartMonitoring
            // 
            this.btnStartMonitoring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartMonitoring.Location = new System.Drawing.Point(187, 362);
            this.btnStartMonitoring.Name = "btnStartMonitoring";
            this.btnStartMonitoring.Size = new System.Drawing.Size(127, 75);
            this.btnStartMonitoring.TabIndex = 18;
            this.btnStartMonitoring.Text = "Начать мониторинг";
            this.btnStartMonitoring.UseVisualStyleBackColor = true;
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsMenu,
            this.RestartMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "Файл";
            // 
            // SaveAsMenu
            // 
            this.SaveAsMenu.Name = "SaveAsMenu";
            this.SaveAsMenu.Size = new System.Drawing.Size(152, 22);
            this.SaveAsMenu.Text = "Сохранить в...";
            this.SaveAsMenu.Click += new System.EventHandler(this.SaveAsMenu_Click);
            // 
            // RestartMenu
            // 
            this.RestartMenu.Name = "RestartMenu";
            this.RestartMenu.Size = new System.Drawing.Size(152, 22);
            this.RestartMenu.Text = "Перезагрузка";
            this.RestartMenu.Click += new System.EventHandler(this.RestartMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(152, 22);
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
            // rtbLogs
            // 
            this.rtbLogs.Location = new System.Drawing.Point(6, 19);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.Size = new System.Drawing.Size(1071, 139);
            this.rtbLogs.TabIndex = 5;
            this.rtbLogs.Text = "";
            // 
            // grBoxLogs
            // 
            this.grBoxLogs.Controls.Add(this.rtbLogs);
            this.grBoxLogs.Location = new System.Drawing.Point(11, 735);
            this.grBoxLogs.Name = "grBoxLogs";
            this.grBoxLogs.Size = new System.Drawing.Size(1083, 164);
            this.grBoxLogs.TabIndex = 5;
            this.grBoxLogs.TabStop = false;
            this.grBoxLogs.Text = "Вывод";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 911);
            this.Controls.Add(this.grBoxLogs);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvQA)).EndInit();
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
            this.grBoxDataView.ResumeLayout(false);
            this.grBoxDataView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gpBoxSensorIdentity.ResumeLayout(false);
            this.grBoxCurrentSensor.ResumeLayout(false);
            this.grBoxCurrentSensor.PerformLayout();
            this.gpBoxSensorsView.ResumeLayout(false);
            this.gpBoxSensorsView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSens)).EndInit();
            this.карта.ResumeLayout(false);
            this.Мониторинг.ResumeLayout(false);
            this.grBoxGettingData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grBoxMonitoringSettings.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grBoxLogs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gpBoxInternetConnectionCheck;
        private System.Windows.Forms.TextBox txtBoxCheckInternet;
        private System.Windows.Forms.GroupBox gpBoxMapView;
        private System.Windows.Forms.Button btnShwMap;
        private System.Windows.Forms.GroupBox gpBoxSearch;
        private System.Windows.Forms.GroupBox gpBoxSearchResult;
        private System.Windows.Forms.TextBox txtBoxMapSStatus;
        private System.Windows.Forms.TextBox txtBoxMapSType;
        private System.Windows.Forms.Label lbSensorTypeForResultOfSearch;
        private System.Windows.Forms.Label lbSensorState;
        private System.Windows.Forms.Label lbSensorNameForSearch;
        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.TabPage tabPageSensor;
        private System.Windows.Forms.GroupBox gpBoxGraphic;
        private System.Windows.Forms.DataVisualization.Charting.Chart unionChart;
        private System.Windows.Forms.GroupBox gpBoxData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.RichTextBox rtbSensorsValue;
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
        private System.Windows.Forms.TextBox txtBoxMapLastValue;
        private System.Windows.Forms.TextBox txtBoxMapLastDate;
        private System.Windows.Forms.GroupBox gpBoxLastActivity;
        private System.Windows.Forms.Label lbValueOfLastActivity;
        private System.Windows.Forms.Label lbDateOfLastActivity;
        private System.Windows.Forms.Label lbTimeOfLastActivity;
        private System.Windows.Forms.TextBox txtBoxMapLastTime;
        private System.Windows.Forms.ToolStripMenuItem RestartMenu;
        private System.Windows.Forms.ToolStripMenuItem AddSensMenu;
        private System.Windows.Forms.GroupBox gpBoxSensorQuery;
        private System.Windows.Forms.Button btnMapRequest;
        private System.Windows.Forms.DataGridView dgvQA;
        private System.Windows.Forms.TabPage Мониторинг;
        private System.Windows.Forms.GroupBox grBoxMonitoringSettings;
        private System.Windows.Forms.Button btnStartMonitoring;
        private System.Windows.Forms.GroupBox gpBoxSensorsView;
        private System.Windows.Forms.RadioButton rButtonAllSensors;
        private System.Windows.Forms.RadioButton rButtonChooseSensors;
        private System.Windows.Forms.ProgressBar progressBarLoadDataFromDB;
        private System.Windows.Forms.GroupBox grBoxDataView;
        private System.Windows.Forms.RadioButton rButtonAllDates;
        private System.Windows.Forms.RadioButton rButtonChooseDate;
        private System.Windows.Forms.GroupBox grBoxCurrentSensor;
        private System.Windows.Forms.TextBox txtBoxCurrentSensor;
        private System.Windows.Forms.GroupBox grBoxGettingData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelectSensorsForRequest;
        private System.Windows.Forms.Label lblSelectedSensorsCount;
        private System.Windows.Forms.Label lblSelectedSensors;
        private System.Windows.Forms.GroupBox grBoxFiltration;
        private System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.GroupBox grBoxLogs;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenu;
    }
}

