namespace WMS.WinFormsClient
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
            this.gpBoxInternetConnectionCheck = new System.Windows.Forms.GroupBox();
            this.TxtBoxCheckInternet = new System.Windows.Forms.TextBox();
            this.gpBoxMapView = new System.Windows.Forms.GroupBox();
            this.ButtonShowMap = new System.Windows.Forms.Button();
            this.gpBoxSearch = new System.Windows.Forms.GroupBox();
            this.ComboBoxSNMap = new System.Windows.Forms.ComboBox();
            this.gpBoxSearchResult = new System.Windows.Forms.GroupBox();
            this.gpBoxLastActivity = new System.Windows.Forms.GroupBox();
            this.lbTimeOfLastActivity = new System.Windows.Forms.Label();
            this.TxtBoxMapLastTime = new System.Windows.Forms.TextBox();
            this.lbValueOfLastActivity = new System.Windows.Forms.Label();
            this.lbDateOfLastActivity = new System.Windows.Forms.Label();
            this.TxtBoxMapLastDate = new System.Windows.Forms.TextBox();
            this.TxtBoxMapLastValue = new System.Windows.Forms.TextBox();
            this.TxtBoxMapSStatus = new System.Windows.Forms.TextBox();
            this.TxtBoxMapSType = new System.Windows.Forms.TextBox();
            this.lbSensorTypeForResultOfSearch = new System.Windows.Forms.Label();
            this.lbSensorState = new System.Windows.Forms.Label();
            this.lbSensorNameForSearch = new System.Windows.Forms.Label();
            this.grBoxMap = new System.Windows.Forms.GroupBox();
            this.SensorMap = new GMap.NET.WindowsForms.GMapControl();
            this.tabPageSensor = new System.Windows.Forms.TabPage();
            this.gpBoxGraphic = new System.Windows.Forms.GroupBox();
            this.UnionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gpBoxData = new System.Windows.Forms.GroupBox();
            this.grBoxDataView = new System.Windows.Forms.GroupBox();
            this.RButtonAllDates = new System.Windows.Forms.RadioButton();
            this.RButtonChooseDate = new System.Windows.Forms.RadioButton();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.RtbSensorsValue = new System.Windows.Forms.RichTextBox();
            this.gpBoxSensorIdentity = new System.Windows.Forms.GroupBox();
            this.grBoxCurrentSensor = new System.Windows.Forms.GroupBox();
            this.TxtBoxCurrentSensor = new System.Windows.Forms.TextBox();
            this.ProgressBarLoadDataFromDB = new System.Windows.Forms.ProgressBar();
            this.gpBoxSensorsView = new System.Windows.Forms.GroupBox();
            this.RButtonAllSensors = new System.Windows.Forms.RadioButton();
            this.RButtonChooseSensors = new System.Windows.Forms.RadioButton();
            this.DgvSens = new System.Windows.Forms.DataGridView();
            this.ButtonRefreshDB = new System.Windows.Forms.Button();
            this.RtbAmountSensors = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Мониторинг = new System.Windows.Forms.TabPage();
            this.grBoxGettingData = new System.Windows.Forms.GroupBox();
            this.rtbSensorsCountQuiz = new System.Windows.Forms.RichTextBox();
            this.rtbDataCountQuiz = new System.Windows.Forms.RichTextBox();
            this.grBoxMonitoringFiltration = new System.Windows.Forms.GroupBox();
            this.btnFiltration = new System.Windows.Forms.Button();
            this.grBoxFiltrationBySensorName = new System.Windows.Forms.GroupBox();
            this.btnSelectSensorsForаFiltration = new System.Windows.Forms.Button();
            this.DgvQuizResult = new System.Windows.Forms.DataGridView();
            this.grBoxMonitoringMap = new System.Windows.Forms.GroupBox();
            this.SensorMonitoringMap = new GMap.NET.WindowsForms.GMapControl();
            this.grBoxMonitoringSettings = new System.Windows.Forms.GroupBox();
            this.gpBoxSensorQuery = new System.Windows.Forms.GroupBox();
            this.RtbSelectedSensorsCount = new System.Windows.Forms.RichTextBox();
            this.ProgressBarMonitoring = new System.Windows.Forms.ProgressBar();
            this.ButtonSelectSensorsForRequest = new System.Windows.Forms.Button();
            this.ButtonRequestNetwork = new System.Windows.Forms.Button();
            this.grBoxQuizResult = new System.Windows.Forms.GroupBox();
            this.RButtonOnlySave = new System.Windows.Forms.RadioButton();
            this.RButtonOnlyShow = new System.Windows.Forms.RadioButton();
            this.RButtonSaveAndShow = new System.Windows.Forms.RadioButton();
            this.grBoxInterval = new System.Windows.Forms.GroupBox();
            this.DtpTo = new System.Windows.Forms.DateTimePicker();
            this.DtpFrom = new System.Windows.Forms.DateTimePicker();
            this.RtbQuizNumber = new System.Windows.Forms.RichTextBox();
            this.ComboBoxSelectQuizInterval = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIntervalFrom = new System.Windows.Forms.Label();
            this.GroupBoxMonitoringType = new System.Windows.Forms.GroupBox();
            this.comboBoxMonitoringType = new System.Windows.Forms.ComboBox();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RtbLogs = new System.Windows.Forms.RichTextBox();
            this.grBoxLogs = new System.Windows.Forms.GroupBox();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpBoxInternetConnectionCheck.SuspendLayout();
            this.gpBoxMapView.SuspendLayout();
            this.gpBoxSearch.SuspendLayout();
            this.gpBoxSearchResult.SuspendLayout();
            this.gpBoxLastActivity.SuspendLayout();
            this.grBoxMap.SuspendLayout();
            this.tabPageSensor.SuspendLayout();
            this.gpBoxGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnionChart)).BeginInit();
            this.gpBoxData.SuspendLayout();
            this.grBoxDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.gpBoxSensorIdentity.SuspendLayout();
            this.grBoxCurrentSensor.SuspendLayout();
            this.gpBoxSensorsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSens)).BeginInit();
            this.tabControl.SuspendLayout();
            this.Мониторинг.SuspendLayout();
            this.grBoxGettingData.SuspendLayout();
            this.grBoxMonitoringFiltration.SuspendLayout();
            this.grBoxFiltrationBySensorName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvQuizResult)).BeginInit();
            this.grBoxMonitoringMap.SuspendLayout();
            this.grBoxMonitoringSettings.SuspendLayout();
            this.gpBoxSensorQuery.SuspendLayout();
            this.grBoxQuizResult.SuspendLayout();
            this.grBoxInterval.SuspendLayout();
            this.GroupBoxMonitoringType.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.gpBoxInternetConnectionCheck);
            this.splitContainer1.Panel1.Controls.Add(this.gpBoxMapView);
            this.splitContainer1.Panel1.Controls.Add(this.gpBoxSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grBoxMap);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 667);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 0;
            // 
            // gpBoxInternetConnectionCheck
            // 
            this.gpBoxInternetConnectionCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxInternetConnectionCheck.Controls.Add(this.TxtBoxCheckInternet);
            this.gpBoxInternetConnectionCheck.Location = new System.Drawing.Point(3, 613);
            this.gpBoxInternetConnectionCheck.Name = "gpBoxInternetConnectionCheck";
            this.gpBoxInternetConnectionCheck.Size = new System.Drawing.Size(283, 51);
            this.gpBoxInternetConnectionCheck.TabIndex = 22;
            this.gpBoxInternetConnectionCheck.TabStop = false;
            this.gpBoxInternetConnectionCheck.Text = "Подключение к сети Интернет";
            // 
            // TxtBoxCheckInternet
            // 
            this.TxtBoxCheckInternet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxCheckInternet.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxCheckInternet.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxCheckInternet.Location = new System.Drawing.Point(6, 19);
            this.TxtBoxCheckInternet.Name = "TxtBoxCheckInternet";
            this.TxtBoxCheckInternet.ReadOnly = true;
            this.TxtBoxCheckInternet.Size = new System.Drawing.Size(271, 20);
            this.TxtBoxCheckInternet.TabIndex = 19;
            this.TxtBoxCheckInternet.TabStop = false;
            this.TxtBoxCheckInternet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpBoxMapView
            // 
            this.gpBoxMapView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxMapView.Controls.Add(this.ButtonShowMap);
            this.gpBoxMapView.Location = new System.Drawing.Point(4, 260);
            this.gpBoxMapView.Name = "gpBoxMapView";
            this.gpBoxMapView.Size = new System.Drawing.Size(283, 57);
            this.gpBoxMapView.TabIndex = 21;
            this.gpBoxMapView.TabStop = false;
            this.gpBoxMapView.Text = "Отображение карты";
            // 
            // ButtonShowMap
            // 
            this.ButtonShowMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonShowMap.Enabled = false;
            this.ButtonShowMap.Location = new System.Drawing.Point(6, 19);
            this.ButtonShowMap.Name = "ButtonShowMap";
            this.ButtonShowMap.Size = new System.Drawing.Size(271, 29);
            this.ButtonShowMap.TabIndex = 19;
            this.ButtonShowMap.Text = "Отобразить";
            this.ButtonShowMap.UseVisualStyleBackColor = true;
            this.ButtonShowMap.Click += new System.EventHandler(this.ButtonShowMap_Click);
            // 
            // gpBoxSearch
            // 
            this.gpBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxSearch.Controls.Add(this.ComboBoxSNMap);
            this.gpBoxSearch.Controls.Add(this.gpBoxSearchResult);
            this.gpBoxSearch.Controls.Add(this.lbSensorNameForSearch);
            this.gpBoxSearch.Location = new System.Drawing.Point(3, 14);
            this.gpBoxSearch.Name = "gpBoxSearch";
            this.gpBoxSearch.Size = new System.Drawing.Size(283, 240);
            this.gpBoxSearch.TabIndex = 20;
            this.gpBoxSearch.TabStop = false;
            this.gpBoxSearch.Text = " Поиск";
            // 
            // ComboBoxSNMap
            // 
            this.ComboBoxSNMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSNMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSNMap.Enabled = false;
            this.ComboBoxSNMap.FormattingEnabled = true;
            this.ComboBoxSNMap.Location = new System.Drawing.Point(90, 19);
            this.ComboBoxSNMap.Name = "ComboBoxSNMap";
            this.ComboBoxSNMap.Size = new System.Drawing.Size(181, 21);
            this.ComboBoxSNMap.TabIndex = 20;
            this.ComboBoxSNMap.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSNMap_SelectedIndexChanged);
            // 
            // gpBoxSearchResult
            // 
            this.gpBoxSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxSearchResult.Controls.Add(this.gpBoxLastActivity);
            this.gpBoxSearchResult.Controls.Add(this.TxtBoxMapSStatus);
            this.gpBoxSearchResult.Controls.Add(this.TxtBoxMapSType);
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
            this.gpBoxLastActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxLastActivity.Controls.Add(this.lbTimeOfLastActivity);
            this.gpBoxLastActivity.Controls.Add(this.TxtBoxMapLastTime);
            this.gpBoxLastActivity.Controls.Add(this.lbValueOfLastActivity);
            this.gpBoxLastActivity.Controls.Add(this.lbDateOfLastActivity);
            this.gpBoxLastActivity.Controls.Add(this.TxtBoxMapLastDate);
            this.gpBoxLastActivity.Controls.Add(this.TxtBoxMapLastValue);
            this.gpBoxLastActivity.Location = new System.Drawing.Point(6, 74);
            this.gpBoxLastActivity.Name = "gpBoxLastActivity";
            this.gpBoxLastActivity.Size = new System.Drawing.Size(259, 101);
            this.gpBoxLastActivity.TabIndex = 24;
            this.gpBoxLastActivity.TabStop = false;
            this.gpBoxLastActivity.Text = "Последняя активность";
            // 
            // lbTimeOfLastActivity
            // 
            this.lbTimeOfLastActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimeOfLastActivity.AutoSize = true;
            this.lbTimeOfLastActivity.Location = new System.Drawing.Point(6, 48);
            this.lbTimeOfLastActivity.Name = "lbTimeOfLastActivity";
            this.lbTimeOfLastActivity.Size = new System.Drawing.Size(43, 13);
            this.lbTimeOfLastActivity.TabIndex = 27;
            this.lbTimeOfLastActivity.Text = "Время:";
            // 
            // TxtBoxMapLastTime
            // 
            this.TxtBoxMapLastTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxMapLastTime.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxMapLastTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxMapLastTime.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtBoxMapLastTime.Location = new System.Drawing.Point(78, 45);
            this.TxtBoxMapLastTime.Name = "TxtBoxMapLastTime";
            this.TxtBoxMapLastTime.ReadOnly = true;
            this.TxtBoxMapLastTime.Size = new System.Drawing.Size(175, 20);
            this.TxtBoxMapLastTime.TabIndex = 26;
            this.TxtBoxMapLastTime.TabStop = false;
            this.TxtBoxMapLastTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbValueOfLastActivity
            // 
            this.lbValueOfLastActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValueOfLastActivity.AutoSize = true;
            this.lbValueOfLastActivity.Location = new System.Drawing.Point(6, 74);
            this.lbValueOfLastActivity.Name = "lbValueOfLastActivity";
            this.lbValueOfLastActivity.Size = new System.Drawing.Size(58, 13);
            this.lbValueOfLastActivity.TabIndex = 25;
            this.lbValueOfLastActivity.Text = "Значение:";
            // 
            // lbDateOfLastActivity
            // 
            this.lbDateOfLastActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDateOfLastActivity.AutoSize = true;
            this.lbDateOfLastActivity.Location = new System.Drawing.Point(6, 22);
            this.lbDateOfLastActivity.Name = "lbDateOfLastActivity";
            this.lbDateOfLastActivity.Size = new System.Drawing.Size(36, 13);
            this.lbDateOfLastActivity.TabIndex = 24;
            this.lbDateOfLastActivity.Text = "Дата:";
            // 
            // TxtBoxMapLastDate
            // 
            this.TxtBoxMapLastDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxMapLastDate.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxMapLastDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxMapLastDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtBoxMapLastDate.Location = new System.Drawing.Point(78, 19);
            this.TxtBoxMapLastDate.Name = "TxtBoxMapLastDate";
            this.TxtBoxMapLastDate.ReadOnly = true;
            this.TxtBoxMapLastDate.Size = new System.Drawing.Size(175, 20);
            this.TxtBoxMapLastDate.TabIndex = 19;
            this.TxtBoxMapLastDate.TabStop = false;
            this.TxtBoxMapLastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxMapLastValue
            // 
            this.TxtBoxMapLastValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxMapLastValue.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxMapLastValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxMapLastValue.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtBoxMapLastValue.Location = new System.Drawing.Point(78, 71);
            this.TxtBoxMapLastValue.Name = "TxtBoxMapLastValue";
            this.TxtBoxMapLastValue.ReadOnly = true;
            this.TxtBoxMapLastValue.Size = new System.Drawing.Size(175, 20);
            this.TxtBoxMapLastValue.TabIndex = 23;
            this.TxtBoxMapLastValue.TabStop = false;
            this.TxtBoxMapLastValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxMapSStatus
            // 
            this.TxtBoxMapSStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxMapSStatus.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxMapSStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxMapSStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtBoxMapSStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtBoxMapSStatus.Location = new System.Drawing.Point(84, 48);
            this.TxtBoxMapSStatus.Name = "TxtBoxMapSStatus";
            this.TxtBoxMapSStatus.ReadOnly = true;
            this.TxtBoxMapSStatus.Size = new System.Drawing.Size(181, 20);
            this.TxtBoxMapSStatus.TabIndex = 18;
            this.TxtBoxMapSStatus.TabStop = false;
            this.TxtBoxMapSStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxMapSType
            // 
            this.TxtBoxMapSType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxMapSType.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxMapSType.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxMapSType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtBoxMapSType.Location = new System.Drawing.Point(84, 22);
            this.TxtBoxMapSType.Name = "TxtBoxMapSType";
            this.TxtBoxMapSType.ReadOnly = true;
            this.TxtBoxMapSType.Size = new System.Drawing.Size(181, 20);
            this.TxtBoxMapSType.TabIndex = 16;
            this.TxtBoxMapSType.TabStop = false;
            this.TxtBoxMapSType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSensorTypeForResultOfSearch
            // 
            this.lbSensorTypeForResultOfSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSensorTypeForResultOfSearch.AutoSize = true;
            this.lbSensorTypeForResultOfSearch.Location = new System.Drawing.Point(6, 25);
            this.lbSensorTypeForResultOfSearch.Name = "lbSensorTypeForResultOfSearch";
            this.lbSensorTypeForResultOfSearch.Size = new System.Drawing.Size(72, 13);
            this.lbSensorTypeForResultOfSearch.TabIndex = 3;
            this.lbSensorTypeForResultOfSearch.Text = "Тип датчика:";
            // 
            // lbSensorState
            // 
            this.lbSensorState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSensorState.AutoSize = true;
            this.lbSensorState.Location = new System.Drawing.Point(7, 51);
            this.lbSensorState.Name = "lbSensorState";
            this.lbSensorState.Size = new System.Drawing.Size(64, 13);
            this.lbSensorState.TabIndex = 17;
            this.lbSensorState.Text = "Состояние:";
            // 
            // lbSensorNameForSearch
            // 
            this.lbSensorNameForSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSensorNameForSearch.AutoSize = true;
            this.lbSensorNameForSearch.Location = new System.Drawing.Point(12, 24);
            this.lbSensorNameForSearch.Name = "lbSensorNameForSearch";
            this.lbSensorNameForSearch.Size = new System.Drawing.Size(60, 13);
            this.lbSensorNameForSearch.TabIndex = 1;
            this.lbSensorNameForSearch.Text = "Название:";
            // 
            // grBoxMap
            // 
            this.grBoxMap.Controls.Add(this.SensorMap);
            this.grBoxMap.Location = new System.Drawing.Point(3, 3);
            this.grBoxMap.Name = "grBoxMap";
            this.grBoxMap.Size = new System.Drawing.Size(778, 661);
            this.grBoxMap.TabIndex = 1;
            this.grBoxMap.TabStop = false;
            this.grBoxMap.Text = "Карта датчиков";
            // 
            // SensorMap
            // 
            this.SensorMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SensorMap.Bearing = 0F;
            this.SensorMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SensorMap.CanDragMap = true;
            this.SensorMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.SensorMap.GrayScaleMode = false;
            this.SensorMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.SensorMap.LevelsKeepInMemmory = 5;
            this.SensorMap.Location = new System.Drawing.Point(6, 19);
            this.SensorMap.MarkersEnabled = true;
            this.SensorMap.MaxZoom = 2;
            this.SensorMap.MinZoom = 2;
            this.SensorMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.SensorMap.Name = "SensorMap";
            this.SensorMap.NegativeMode = false;
            this.SensorMap.PolygonsEnabled = true;
            this.SensorMap.RetryLoadTile = 0;
            this.SensorMap.RoutesEnabled = true;
            this.SensorMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.SensorMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.SensorMap.ShowTileGridLines = false;
            this.SensorMap.Size = new System.Drawing.Size(766, 636);
            this.SensorMap.TabIndex = 0;
            this.SensorMap.Visible = false;
            this.SensorMap.Zoom = 0D;
            this.SensorMap.Load += new System.EventHandler(this.SettingMaps);
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
            this.gpBoxGraphic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxGraphic.Controls.Add(this.UnionChart);
            this.gpBoxGraphic.Location = new System.Drawing.Point(6, 336);
            this.gpBoxGraphic.Name = "gpBoxGraphic";
            this.gpBoxGraphic.Size = new System.Drawing.Size(1072, 331);
            this.gpBoxGraphic.TabIndex = 16;
            this.gpBoxGraphic.TabStop = false;
            this.gpBoxGraphic.Text = "График";
            // 
            // UnionChart
            // 
            this.UnionChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.UnionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.UnionChart.Legends.Add(legend1);
            this.UnionChart.Location = new System.Drawing.Point(6, 19);
            this.UnionChart.Name = "UnionChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Датчик";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.UnionChart.Series.Add(series1);
            this.UnionChart.Size = new System.Drawing.Size(1060, 306);
            this.UnionChart.TabIndex = 6;
            this.UnionChart.Text = "chart1";
            // 
            // gpBoxData
            // 
            this.gpBoxData.Controls.Add(this.grBoxDataView);
            this.gpBoxData.Controls.Add(this.DgvData);
            this.gpBoxData.Controls.Add(this.RtbSensorsValue);
            this.gpBoxData.Location = new System.Drawing.Point(537, 6);
            this.gpBoxData.Name = "gpBoxData";
            this.gpBoxData.Size = new System.Drawing.Size(541, 324);
            this.gpBoxData.TabIndex = 14;
            this.gpBoxData.TabStop = false;
            this.gpBoxData.Text = "Данные";
            // 
            // grBoxDataView
            // 
            this.grBoxDataView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxDataView.Controls.Add(this.RButtonAllDates);
            this.grBoxDataView.Controls.Add(this.RButtonChooseDate);
            this.grBoxDataView.Location = new System.Drawing.Point(6, 16);
            this.grBoxDataView.Name = "grBoxDataView";
            this.grBoxDataView.Size = new System.Drawing.Size(218, 53);
            this.grBoxDataView.TabIndex = 20;
            this.grBoxDataView.TabStop = false;
            this.grBoxDataView.Text = "Отобразить";
            // 
            // RButtonAllDates
            // 
            this.RButtonAllDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RButtonAllDates.AutoSize = true;
            this.RButtonAllDates.Checked = true;
            this.RButtonAllDates.Enabled = false;
            this.RButtonAllDates.Location = new System.Drawing.Point(17, 24);
            this.RButtonAllDates.Name = "RButtonAllDates";
            this.RButtonAllDates.Size = new System.Drawing.Size(85, 17);
            this.RButtonAllDates.TabIndex = 17;
            this.RButtonAllDates.TabStop = true;
            this.RButtonAllDates.Text = "Все данные";
            this.RButtonAllDates.UseVisualStyleBackColor = true;
            this.RButtonAllDates.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RButtonAllDates_MouseClick);
            // 
            // RButtonChooseDate
            // 
            this.RButtonChooseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RButtonChooseDate.AutoSize = true;
            this.RButtonChooseDate.Enabled = false;
            this.RButtonChooseDate.Location = new System.Drawing.Point(119, 24);
            this.RButtonChooseDate.Name = "RButtonChooseDate";
            this.RButtonChooseDate.Size = new System.Drawing.Size(81, 17);
            this.RButtonChooseDate.TabIndex = 18;
            this.RButtonChooseDate.TabStop = true;
            this.RButtonChooseDate.Text = "Выборочно";
            this.RButtonChooseDate.UseVisualStyleBackColor = true;
            this.RButtonChooseDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RButtonChooseDate_MouseClick);
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToResizeRows = false;
            this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(6, 102);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(529, 213);
            this.DgvData.TabIndex = 0;
            // 
            // RtbSensorsValue
            // 
            this.RtbSensorsValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RtbSensorsValue.BackColor = System.Drawing.SystemColors.Menu;
            this.RtbSensorsValue.Enabled = false;
            this.RtbSensorsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbSensorsValue.Location = new System.Drawing.Point(6, 73);
            this.RtbSensorsValue.Name = "RtbSensorsValue";
            this.RtbSensorsValue.Size = new System.Drawing.Size(218, 24);
            this.RtbSensorsValue.TabIndex = 10;
            this.RtbSensorsValue.Text = "Показаний датчика: 0";
            // 
            // gpBoxSensorIdentity
            // 
            this.gpBoxSensorIdentity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpBoxSensorIdentity.Controls.Add(this.grBoxCurrentSensor);
            this.gpBoxSensorIdentity.Controls.Add(this.ProgressBarLoadDataFromDB);
            this.gpBoxSensorIdentity.Controls.Add(this.gpBoxSensorsView);
            this.gpBoxSensorIdentity.Controls.Add(this.DgvSens);
            this.gpBoxSensorIdentity.Controls.Add(this.ButtonRefreshDB);
            this.gpBoxSensorIdentity.Controls.Add(this.RtbAmountSensors);
            this.gpBoxSensorIdentity.Location = new System.Drawing.Point(6, 6);
            this.gpBoxSensorIdentity.Name = "gpBoxSensorIdentity";
            this.gpBoxSensorIdentity.Size = new System.Drawing.Size(525, 324);
            this.gpBoxSensorIdentity.TabIndex = 13;
            this.gpBoxSensorIdentity.TabStop = false;
            this.gpBoxSensorIdentity.Text = "Идентификация датчиков";
            // 
            // grBoxCurrentSensor
            // 
            this.grBoxCurrentSensor.Controls.Add(this.TxtBoxCurrentSensor);
            this.grBoxCurrentSensor.Location = new System.Drawing.Point(230, 19);
            this.grBoxCurrentSensor.Name = "grBoxCurrentSensor";
            this.grBoxCurrentSensor.Size = new System.Drawing.Size(154, 49);
            this.grBoxCurrentSensor.TabIndex = 20;
            this.grBoxCurrentSensor.TabStop = false;
            this.grBoxCurrentSensor.Text = "Выбранный датчик";
            // 
            // TxtBoxCurrentSensor
            // 
            this.TxtBoxCurrentSensor.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxCurrentSensor.Location = new System.Drawing.Point(6, 23);
            this.TxtBoxCurrentSensor.Name = "TxtBoxCurrentSensor";
            this.TxtBoxCurrentSensor.ReadOnly = true;
            this.TxtBoxCurrentSensor.Size = new System.Drawing.Size(142, 20);
            this.TxtBoxCurrentSensor.TabIndex = 22;
            this.TxtBoxCurrentSensor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProgressBarLoadDataFromDB
            // 
            this.ProgressBarLoadDataFromDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressBarLoadDataFromDB.BackColor = System.Drawing.Color.YellowGreen;
            this.ProgressBarLoadDataFromDB.Location = new System.Drawing.Point(230, 74);
            this.ProgressBarLoadDataFromDB.Name = "ProgressBarLoadDataFromDB";
            this.ProgressBarLoadDataFromDB.Size = new System.Drawing.Size(289, 23);
            this.ProgressBarLoadDataFromDB.TabIndex = 5;
            // 
            // gpBoxSensorsView
            // 
            this.gpBoxSensorsView.Controls.Add(this.RButtonAllSensors);
            this.gpBoxSensorsView.Controls.Add(this.RButtonChooseSensors);
            this.gpBoxSensorsView.Location = new System.Drawing.Point(6, 16);
            this.gpBoxSensorsView.Name = "gpBoxSensorsView";
            this.gpBoxSensorsView.Size = new System.Drawing.Size(218, 53);
            this.gpBoxSensorsView.TabIndex = 19;
            this.gpBoxSensorsView.TabStop = false;
            this.gpBoxSensorsView.Text = "Отобразить";
            // 
            // RButtonAllSensors
            // 
            this.RButtonAllSensors.AutoSize = true;
            this.RButtonAllSensors.Checked = true;
            this.RButtonAllSensors.Enabled = false;
            this.RButtonAllSensors.Location = new System.Drawing.Point(17, 24);
            this.RButtonAllSensors.Name = "RButtonAllSensors";
            this.RButtonAllSensors.Size = new System.Drawing.Size(87, 17);
            this.RButtonAllSensors.TabIndex = 17;
            this.RButtonAllSensors.TabStop = true;
            this.RButtonAllSensors.Text = "Все датчики";
            this.RButtonAllSensors.UseVisualStyleBackColor = true;
            this.RButtonAllSensors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RButtonAllSensors_MouseClick);
            // 
            // RButtonChooseSensors
            // 
            this.RButtonChooseSensors.AutoSize = true;
            this.RButtonChooseSensors.Enabled = false;
            this.RButtonChooseSensors.Location = new System.Drawing.Point(119, 24);
            this.RButtonChooseSensors.Name = "RButtonChooseSensors";
            this.RButtonChooseSensors.Size = new System.Drawing.Size(81, 17);
            this.RButtonChooseSensors.TabIndex = 18;
            this.RButtonChooseSensors.TabStop = true;
            this.RButtonChooseSensors.Text = "Выборочно";
            this.RButtonChooseSensors.UseVisualStyleBackColor = true;
            this.RButtonChooseSensors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RButtonChooseSensors_MouseClick);
            // 
            // DgvSens
            // 
            this.DgvSens.AllowUserToAddRows = false;
            this.DgvSens.AllowUserToDeleteRows = false;
            this.DgvSens.AllowUserToResizeRows = false;
            this.DgvSens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvSens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSens.Location = new System.Drawing.Point(6, 102);
            this.DgvSens.MultiSelect = false;
            this.DgvSens.Name = "DgvSens";
            this.DgvSens.ReadOnly = true;
            this.DgvSens.RowHeadersVisible = false;
            this.DgvSens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSens.Size = new System.Drawing.Size(513, 213);
            this.DgvSens.TabIndex = 16;
            this.DgvSens.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSens_CellEnter);
            // 
            // ButtonRefreshDB
            // 
            this.ButtonRefreshDB.Location = new System.Drawing.Point(390, 16);
            this.ButtonRefreshDB.Name = "ButtonRefreshDB";
            this.ButtonRefreshDB.Size = new System.Drawing.Size(129, 53);
            this.ButtonRefreshDB.TabIndex = 13;
            this.ButtonRefreshDB.Text = "Получить данные";
            this.ButtonRefreshDB.UseVisualStyleBackColor = true;
            this.ButtonRefreshDB.Click += new System.EventHandler(this.ButtonRefreshDB_Click);
            // 
            // RtbAmountSensors
            // 
            this.RtbAmountSensors.BackColor = System.Drawing.SystemColors.Menu;
            this.RtbAmountSensors.Enabled = false;
            this.RtbAmountSensors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbAmountSensors.Location = new System.Drawing.Point(6, 75);
            this.RtbAmountSensors.Name = "RtbAmountSensors";
            this.RtbAmountSensors.Size = new System.Drawing.Size(218, 24);
            this.RtbAmountSensors.TabIndex = 15;
            this.RtbAmountSensors.Text = "Количество датчиков: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "";
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageSensor);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.Мониторинг);
            this.tabControl.Location = new System.Drawing.Point(7, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1092, 699);
            this.tabControl.TabIndex = 4;
            this.tabControl.Tag = "";
            // 
            // Мониторинг
            // 
            this.Мониторинг.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Мониторинг.Controls.Add(this.grBoxGettingData);
            this.Мониторинг.Controls.Add(this.grBoxMonitoringMap);
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
            this.grBoxGettingData.Controls.Add(this.rtbSensorsCountQuiz);
            this.grBoxGettingData.Controls.Add(this.rtbDataCountQuiz);
            this.grBoxGettingData.Controls.Add(this.grBoxMonitoringFiltration);
            this.grBoxGettingData.Controls.Add(this.DgvQuizResult);
            this.grBoxGettingData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grBoxGettingData.Location = new System.Drawing.Point(6, 331);
            this.grBoxGettingData.Name = "grBoxGettingData";
            this.grBoxGettingData.Size = new System.Drawing.Size(1071, 336);
            this.grBoxGettingData.TabIndex = 19;
            this.grBoxGettingData.TabStop = false;
            this.grBoxGettingData.Text = "Полученные данные";
            // 
            // rtbSensorsCountQuiz
            // 
            this.rtbSensorsCountQuiz.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbSensorsCountQuiz.Enabled = false;
            this.rtbSensorsCountQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbSensorsCountQuiz.Location = new System.Drawing.Point(6, 207);
            this.rtbSensorsCountQuiz.Name = "rtbSensorsCountQuiz";
            this.rtbSensorsCountQuiz.Size = new System.Drawing.Size(218, 24);
            this.rtbSensorsCountQuiz.TabIndex = 17;
            this.rtbSensorsCountQuiz.Text = "Количество датчиков: 0";
            // 
            // rtbDataCountQuiz
            // 
            this.rtbDataCountQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDataCountQuiz.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbDataCountQuiz.Enabled = false;
            this.rtbDataCountQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDataCountQuiz.Location = new System.Drawing.Point(230, 207);
            this.rtbDataCountQuiz.Name = "rtbDataCountQuiz";
            this.rtbDataCountQuiz.Size = new System.Drawing.Size(218, 24);
            this.rtbDataCountQuiz.TabIndex = 11;
            this.rtbDataCountQuiz.Text = "Показаний датчика: 0";
            // 
            // grBoxMonitoringFiltration
            // 
            this.grBoxMonitoringFiltration.Controls.Add(this.btnFiltration);
            this.grBoxMonitoringFiltration.Controls.Add(this.grBoxFiltrationBySensorName);
            this.grBoxMonitoringFiltration.Location = new System.Drawing.Point(6, 237);
            this.grBoxMonitoringFiltration.Name = "grBoxMonitoringFiltration";
            this.grBoxMonitoringFiltration.Size = new System.Drawing.Size(1059, 94);
            this.grBoxMonitoringFiltration.TabIndex = 2;
            this.grBoxMonitoringFiltration.TabStop = false;
            this.grBoxMonitoringFiltration.Text = "Фильтрация";
            // 
            // btnFiltration
            // 
            this.btnFiltration.Location = new System.Drawing.Point(826, 13);
            this.btnFiltration.Name = "btnFiltration";
            this.btnFiltration.Size = new System.Drawing.Size(227, 75);
            this.btnFiltration.TabIndex = 28;
            this.btnFiltration.Text = "ОК";
            this.btnFiltration.UseVisualStyleBackColor = true;
            // 
            // grBoxFiltrationBySensorName
            // 
            this.grBoxFiltrationBySensorName.Controls.Add(this.btnSelectSensorsForаFiltration);
            this.grBoxFiltrationBySensorName.Location = new System.Drawing.Point(6, 19);
            this.grBoxFiltrationBySensorName.Name = "grBoxFiltrationBySensorName";
            this.grBoxFiltrationBySensorName.Size = new System.Drawing.Size(239, 69);
            this.grBoxFiltrationBySensorName.TabIndex = 0;
            this.grBoxFiltrationBySensorName.TabStop = false;
            this.grBoxFiltrationBySensorName.Text = "По названию датчика";
            // 
            // btnSelectSensorsForаFiltration
            // 
            this.btnSelectSensorsForаFiltration.Location = new System.Drawing.Point(6, 19);
            this.btnSelectSensorsForаFiltration.Name = "btnSelectSensorsForаFiltration";
            this.btnSelectSensorsForаFiltration.Size = new System.Drawing.Size(227, 44);
            this.btnSelectSensorsForаFiltration.TabIndex = 27;
            this.btnSelectSensorsForаFiltration.Text = "Выбрать";
            this.btnSelectSensorsForаFiltration.UseVisualStyleBackColor = true;
            // 
            // DgvQuizResult
            // 
            this.DgvQuizResult.AllowUserToAddRows = false;
            this.DgvQuizResult.AllowUserToDeleteRows = false;
            this.DgvQuizResult.AllowUserToResizeRows = false;
            this.DgvQuizResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvQuizResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvQuizResult.Location = new System.Drawing.Point(6, 19);
            this.DgvQuizResult.Name = "DgvQuizResult";
            this.DgvQuizResult.ReadOnly = true;
            this.DgvQuizResult.RowHeadersVisible = false;
            this.DgvQuizResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvQuizResult.Size = new System.Drawing.Size(1059, 182);
            this.DgvQuizResult.TabIndex = 1;
            // 
            // grBoxMonitoringMap
            // 
            this.grBoxMonitoringMap.Controls.Add(this.SensorMonitoringMap);
            this.grBoxMonitoringMap.Location = new System.Drawing.Point(448, 3);
            this.grBoxMonitoringMap.Name = "grBoxMonitoringMap";
            this.grBoxMonitoringMap.Size = new System.Drawing.Size(629, 322);
            this.grBoxMonitoringMap.TabIndex = 20;
            this.grBoxMonitoringMap.TabStop = false;
            this.grBoxMonitoringMap.Text = "Карта датчиков";
            // 
            // SensorMonitoringMap
            // 
            this.SensorMonitoringMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SensorMonitoringMap.Bearing = 0F;
            this.SensorMonitoringMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SensorMonitoringMap.CanDragMap = true;
            this.SensorMonitoringMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.SensorMonitoringMap.GrayScaleMode = false;
            this.SensorMonitoringMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.SensorMonitoringMap.LevelsKeepInMemmory = 5;
            this.SensorMonitoringMap.Location = new System.Drawing.Point(6, 19);
            this.SensorMonitoringMap.MarkersEnabled = true;
            this.SensorMonitoringMap.MaxZoom = 2;
            this.SensorMonitoringMap.MinZoom = 2;
            this.SensorMonitoringMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.SensorMonitoringMap.Name = "SensorMonitoringMap";
            this.SensorMonitoringMap.NegativeMode = false;
            this.SensorMonitoringMap.PolygonsEnabled = true;
            this.SensorMonitoringMap.RetryLoadTile = 0;
            this.SensorMonitoringMap.RoutesEnabled = true;
            this.SensorMonitoringMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.SensorMonitoringMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.SensorMonitoringMap.ShowTileGridLines = false;
            this.SensorMonitoringMap.Size = new System.Drawing.Size(617, 297);
            this.SensorMonitoringMap.TabIndex = 0;
            this.SensorMonitoringMap.Visible = false;
            this.SensorMonitoringMap.Zoom = 0D;
            this.SensorMonitoringMap.Load += new System.EventHandler(this.SettingMaps);
            // 
            // grBoxMonitoringSettings
            // 
            this.grBoxMonitoringSettings.Controls.Add(this.gpBoxSensorQuery);
            this.grBoxMonitoringSettings.Controls.Add(this.grBoxQuizResult);
            this.grBoxMonitoringSettings.Controls.Add(this.grBoxInterval);
            this.grBoxMonitoringSettings.Controls.Add(this.GroupBoxMonitoringType);
            this.grBoxMonitoringSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grBoxMonitoringSettings.Location = new System.Drawing.Point(6, 3);
            this.grBoxMonitoringSettings.Name = "grBoxMonitoringSettings";
            this.grBoxMonitoringSettings.Size = new System.Drawing.Size(437, 322);
            this.grBoxMonitoringSettings.TabIndex = 0;
            this.grBoxMonitoringSettings.TabStop = false;
            this.grBoxMonitoringSettings.Text = "Настройки";
            // 
            // gpBoxSensorQuery
            // 
            this.gpBoxSensorQuery.Controls.Add(this.RtbSelectedSensorsCount);
            this.gpBoxSensorQuery.Controls.Add(this.ProgressBarMonitoring);
            this.gpBoxSensorQuery.Controls.Add(this.ButtonSelectSensorsForRequest);
            this.gpBoxSensorQuery.Controls.Add(this.ButtonRequestNetwork);
            this.gpBoxSensorQuery.Location = new System.Drawing.Point(6, 227);
            this.gpBoxSensorQuery.Name = "gpBoxSensorQuery";
            this.gpBoxSensorQuery.Size = new System.Drawing.Size(425, 89);
            this.gpBoxSensorQuery.TabIndex = 25;
            this.gpBoxSensorQuery.TabStop = false;
            this.gpBoxSensorQuery.Text = "Опрос";
            // 
            // RtbSelectedSensorsCount
            // 
            this.RtbSelectedSensorsCount.BackColor = System.Drawing.SystemColors.Menu;
            this.RtbSelectedSensorsCount.Enabled = false;
            this.RtbSelectedSensorsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbSelectedSensorsCount.Location = new System.Drawing.Point(6, 19);
            this.RtbSelectedSensorsCount.Name = "RtbSelectedSensorsCount";
            this.RtbSelectedSensorsCount.Size = new System.Drawing.Size(174, 24);
            this.RtbSelectedSensorsCount.TabIndex = 18;
            this.RtbSelectedSensorsCount.Text = "Датчиков выбрано: 0";
            // 
            // ProgressBarMonitoring
            // 
            this.ProgressBarMonitoring.Location = new System.Drawing.Point(186, 53);
            this.ProgressBarMonitoring.Name = "ProgressBarMonitoring";
            this.ProgressBarMonitoring.Size = new System.Drawing.Size(232, 29);
            this.ProgressBarMonitoring.TabIndex = 26;
            // 
            // ButtonSelectSensorsForRequest
            // 
            this.ButtonSelectSensorsForRequest.Location = new System.Drawing.Point(186, 19);
            this.ButtonSelectSensorsForRequest.Name = "ButtonSelectSensorsForRequest";
            this.ButtonSelectSensorsForRequest.Size = new System.Drawing.Size(233, 24);
            this.ButtonSelectSensorsForRequest.TabIndex = 26;
            this.ButtonSelectSensorsForRequest.Text = "Выбрать";
            this.ButtonSelectSensorsForRequest.UseVisualStyleBackColor = true;
            this.ButtonSelectSensorsForRequest.Click += new System.EventHandler(this.ButtonSelectSensorsForRequest_Click);
            // 
            // ButtonRequestNetwork
            // 
            this.ButtonRequestNetwork.Enabled = false;
            this.ButtonRequestNetwork.Location = new System.Drawing.Point(5, 53);
            this.ButtonRequestNetwork.Name = "ButtonRequestNetwork";
            this.ButtonRequestNetwork.Size = new System.Drawing.Size(175, 29);
            this.ButtonRequestNetwork.TabIndex = 23;
            this.ButtonRequestNetwork.Text = "Опросить";
            this.ButtonRequestNetwork.UseVisualStyleBackColor = true;
            this.ButtonRequestNetwork.Click += new System.EventHandler(this.ButtonRequestNetwork_Click);
            // 
            // grBoxQuizResult
            // 
            this.grBoxQuizResult.Controls.Add(this.RButtonOnlySave);
            this.grBoxQuizResult.Controls.Add(this.RButtonOnlyShow);
            this.grBoxQuizResult.Controls.Add(this.RButtonSaveAndShow);
            this.grBoxQuizResult.Location = new System.Drawing.Point(6, 153);
            this.grBoxQuizResult.Name = "grBoxQuizResult";
            this.grBoxQuizResult.Size = new System.Drawing.Size(425, 68);
            this.grBoxQuizResult.TabIndex = 29;
            this.grBoxQuizResult.TabStop = false;
            this.grBoxQuizResult.Text = "Результаты опроса";
            // 
            // RButtonOnlySave
            // 
            this.RButtonOnlySave.AutoSize = true;
            this.RButtonOnlySave.Location = new System.Drawing.Point(9, 45);
            this.RButtonOnlySave.Name = "RButtonOnlySave";
            this.RButtonOnlySave.Size = new System.Drawing.Size(145, 17);
            this.RButtonOnlySave.TabIndex = 2;
            this.RButtonOnlySave.Text = "Только сохранить в БД";
            this.RButtonOnlySave.UseVisualStyleBackColor = true;
            this.RButtonOnlySave.Click += new System.EventHandler(this.RadioButtonOnlySave_Click);
            // 
            // RButtonOnlyShow
            // 
            this.RButtonOnlyShow.AutoSize = true;
            this.RButtonOnlyShow.Checked = true;
            this.RButtonOnlyShow.Location = new System.Drawing.Point(9, 22);
            this.RButtonOnlyShow.Name = "RButtonOnlyShow";
            this.RButtonOnlyShow.Size = new System.Drawing.Size(123, 17);
            this.RButtonOnlyShow.TabIndex = 1;
            this.RButtonOnlyShow.TabStop = true;
            this.RButtonOnlyShow.Text = "Только отобразить";
            this.RButtonOnlyShow.UseVisualStyleBackColor = true;
            this.RButtonOnlyShow.Click += new System.EventHandler(this.RadioButtonOnlyShow_Click);
            // 
            // RButtonSaveAndShow
            // 
            this.RButtonSaveAndShow.AutoSize = true;
            this.RButtonSaveAndShow.Location = new System.Drawing.Point(242, 22);
            this.RButtonSaveAndShow.Name = "RButtonSaveAndShow";
            this.RButtonSaveAndShow.Size = new System.Drawing.Size(177, 17);
            this.RButtonSaveAndShow.TabIndex = 0;
            this.RButtonSaveAndShow.Text = "Отобразить и сохранить в БД";
            this.RButtonSaveAndShow.UseVisualStyleBackColor = true;
            this.RButtonSaveAndShow.Click += new System.EventHandler(this.RadioButtonSaveAndShow_Click);
            // 
            // grBoxInterval
            // 
            this.grBoxInterval.Controls.Add(this.DtpTo);
            this.grBoxInterval.Controls.Add(this.DtpFrom);
            this.grBoxInterval.Controls.Add(this.RtbQuizNumber);
            this.grBoxInterval.Controls.Add(this.ComboBoxSelectQuizInterval);
            this.grBoxInterval.Controls.Add(this.label1);
            this.grBoxInterval.Controls.Add(this.lblIntervalFrom);
            this.grBoxInterval.Location = new System.Drawing.Point(6, 75);
            this.grBoxInterval.Name = "grBoxInterval";
            this.grBoxInterval.Size = new System.Drawing.Size(425, 72);
            this.grBoxInterval.TabIndex = 28;
            this.grBoxInterval.TabStop = false;
            this.grBoxInterval.Text = "Интервал";
            // 
            // DtpTo
            // 
            this.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpTo.Location = new System.Drawing.Point(37, 45);
            this.DtpTo.Name = "DtpTo";
            this.DtpTo.Size = new System.Drawing.Size(63, 20);
            this.DtpTo.TabIndex = 17;
            // 
            // DtpFrom
            // 
            this.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpFrom.Location = new System.Drawing.Point(37, 16);
            this.DtpFrom.Name = "DtpFrom";
            this.DtpFrom.Size = new System.Drawing.Size(63, 20);
            this.DtpFrom.TabIndex = 6;
            // 
            // RtbQuizNumber
            // 
            this.RtbQuizNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.RtbQuizNumber.Enabled = false;
            this.RtbQuizNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbQuizNumber.Location = new System.Drawing.Point(119, 15);
            this.RtbQuizNumber.Name = "RtbQuizNumber";
            this.RtbQuizNumber.Size = new System.Drawing.Size(294, 24);
            this.RtbQuizNumber.TabIndex = 16;
            this.RtbQuizNumber.Text = "Сеть будет опрошена: 0 раз";
            // 
            // ComboBoxSelectQuizInterval
            // 
            this.ComboBoxSelectQuizInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSelectQuizInterval.FormattingEnabled = true;
            this.ComboBoxSelectQuizInterval.Location = new System.Drawing.Point(119, 45);
            this.ComboBoxSelectQuizInterval.Name = "ComboBoxSelectQuizInterval";
            this.ComboBoxSelectQuizInterval.Size = new System.Drawing.Size(294, 21);
            this.ComboBoxSelectQuizInterval.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "До:";
            // 
            // lblIntervalFrom
            // 
            this.lblIntervalFrom.AutoSize = true;
            this.lblIntervalFrom.Location = new System.Drawing.Point(6, 22);
            this.lblIntervalFrom.Name = "lblIntervalFrom";
            this.lblIntervalFrom.Size = new System.Drawing.Size(23, 13);
            this.lblIntervalFrom.TabIndex = 2;
            this.lblIntervalFrom.Text = "От:";
            // 
            // GroupBoxMonitoringType
            // 
            this.GroupBoxMonitoringType.Controls.Add(this.comboBoxMonitoringType);
            this.GroupBoxMonitoringType.Location = new System.Drawing.Point(6, 19);
            this.GroupBoxMonitoringType.Name = "GroupBoxMonitoringType";
            this.GroupBoxMonitoringType.Size = new System.Drawing.Size(425, 50);
            this.GroupBoxMonitoringType.TabIndex = 26;
            this.GroupBoxMonitoringType.TabStop = false;
            this.GroupBoxMonitoringType.Text = "Тип мониторинга";
            // 
            // comboBoxMonitoringType
            // 
            this.comboBoxMonitoringType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonitoringType.FormattingEnabled = true;
            this.comboBoxMonitoringType.Location = new System.Drawing.Point(5, 19);
            this.comboBoxMonitoringType.Name = "comboBoxMonitoringType";
            this.comboBoxMonitoringType.Size = new System.Drawing.Size(414, 21);
            this.comboBoxMonitoringType.TabIndex = 0;
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
            this.SaveAsMenu.Enabled = false;
            this.SaveAsMenu.Name = "SaveAsMenu";
            this.SaveAsMenu.Size = new System.Drawing.Size(179, 22);
            this.SaveAsMenu.Text = "Сохранить в Excel...";
            this.SaveAsMenu.Click += new System.EventHandler(this.SaveAsMenu_Click);
            // 
            // RestartMenu
            // 
            this.RestartMenu.Name = "RestartMenu";
            this.RestartMenu.Size = new System.Drawing.Size(179, 22);
            this.RestartMenu.Text = "Перезагрузка";
            this.RestartMenu.Click += new System.EventHandler(this.RestartMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(179, 22);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // PropertiesMenu
            // 
            this.PropertiesMenu.Name = "PropertiesMenu";
            this.PropertiesMenu.Size = new System.Drawing.Size(79, 20);
            this.PropertiesMenu.Text = "Настройки";
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
            this.AboutProgramMenu.Size = new System.Drawing.Size(152, 22);
            this.AboutProgramMenu.Text = "О программе";
            this.AboutProgramMenu.Click += new System.EventHandler(this.AboutProgramMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.PropertiesMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(203, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RtbLogs
            // 
            this.RtbLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RtbLogs.BackColor = System.Drawing.SystemColors.GrayText;
            this.RtbLogs.ForeColor = System.Drawing.SystemColors.Info;
            this.RtbLogs.Location = new System.Drawing.Point(6, 19);
            this.RtbLogs.Name = "RtbLogs";
            this.RtbLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtbLogs.Size = new System.Drawing.Size(1071, 139);
            this.RtbLogs.TabIndex = 5;
            this.RtbLogs.Text = "";
            // 
            // grBoxLogs
            // 
            this.grBoxLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxLogs.Controls.Add(this.RtbLogs);
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
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
            this.gpBoxInternetConnectionCheck.ResumeLayout(false);
            this.gpBoxInternetConnectionCheck.PerformLayout();
            this.gpBoxMapView.ResumeLayout(false);
            this.gpBoxSearch.ResumeLayout(false);
            this.gpBoxSearch.PerformLayout();
            this.gpBoxSearchResult.ResumeLayout(false);
            this.gpBoxSearchResult.PerformLayout();
            this.gpBoxLastActivity.ResumeLayout(false);
            this.gpBoxLastActivity.PerformLayout();
            this.grBoxMap.ResumeLayout(false);
            this.tabPageSensor.ResumeLayout(false);
            this.tabPageSensor.PerformLayout();
            this.gpBoxGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnionChart)).EndInit();
            this.gpBoxData.ResumeLayout(false);
            this.grBoxDataView.ResumeLayout(false);
            this.grBoxDataView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.gpBoxSensorIdentity.ResumeLayout(false);
            this.grBoxCurrentSensor.ResumeLayout(false);
            this.grBoxCurrentSensor.PerformLayout();
            this.gpBoxSensorsView.ResumeLayout(false);
            this.gpBoxSensorsView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSens)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.Мониторинг.ResumeLayout(false);
            this.grBoxGettingData.ResumeLayout(false);
            this.grBoxMonitoringFiltration.ResumeLayout(false);
            this.grBoxFiltrationBySensorName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvQuizResult)).EndInit();
            this.grBoxMonitoringMap.ResumeLayout(false);
            this.grBoxMonitoringSettings.ResumeLayout(false);
            this.gpBoxSensorQuery.ResumeLayout(false);
            this.grBoxQuizResult.ResumeLayout(false);
            this.grBoxQuizResult.PerformLayout();
            this.grBoxInterval.ResumeLayout(false);
            this.grBoxInterval.PerformLayout();
            this.GroupBoxMonitoringType.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox TxtBoxCheckInternet;
        private System.Windows.Forms.GroupBox gpBoxMapView;
        private System.Windows.Forms.Button ButtonShowMap;
        private System.Windows.Forms.GroupBox gpBoxSearch;
        private System.Windows.Forms.GroupBox gpBoxSearchResult;
        private System.Windows.Forms.TextBox TxtBoxMapSStatus;
        private System.Windows.Forms.TextBox TxtBoxMapSType;
        private System.Windows.Forms.Label lbSensorTypeForResultOfSearch;
        private System.Windows.Forms.Label lbSensorState;
        private System.Windows.Forms.Label lbSensorNameForSearch;
        private GMap.NET.WindowsForms.GMapControl SensorMap;
        private System.Windows.Forms.TabPage tabPageSensor;
        private System.Windows.Forms.GroupBox gpBoxGraphic;
        private System.Windows.Forms.DataVisualization.Charting.Chart UnionChart;
        private System.Windows.Forms.GroupBox gpBoxData;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.RichTextBox RtbSensorsValue;
        private System.Windows.Forms.GroupBox gpBoxSensorIdentity;
        private System.Windows.Forms.DataGridView DgvSens;
        private System.Windows.Forms.Button ButtonRefreshDB;
        private System.Windows.Forms.RichTextBox RtbAmountSensors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem PropertiesMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox ComboBoxSNMap;
        private System.Windows.Forms.TextBox TxtBoxMapLastValue;
        private System.Windows.Forms.TextBox TxtBoxMapLastDate;
        private System.Windows.Forms.GroupBox gpBoxLastActivity;
        private System.Windows.Forms.Label lbValueOfLastActivity;
        private System.Windows.Forms.Label lbDateOfLastActivity;
        private System.Windows.Forms.Label lbTimeOfLastActivity;
        private System.Windows.Forms.TextBox TxtBoxMapLastTime;
        private System.Windows.Forms.ToolStripMenuItem RestartMenu;
        private System.Windows.Forms.TabPage Мониторинг;
        private System.Windows.Forms.GroupBox grBoxMonitoringSettings;
        private System.Windows.Forms.GroupBox gpBoxSensorsView;
        private System.Windows.Forms.RadioButton RButtonAllSensors;
        private System.Windows.Forms.RadioButton RButtonChooseSensors;
        private System.Windows.Forms.ProgressBar ProgressBarLoadDataFromDB;
        private System.Windows.Forms.GroupBox grBoxDataView;
        private System.Windows.Forms.RadioButton RButtonAllDates;
        private System.Windows.Forms.RadioButton RButtonChooseDate;
        private System.Windows.Forms.GroupBox grBoxCurrentSensor;
        private System.Windows.Forms.TextBox TxtBoxCurrentSensor;
        private System.Windows.Forms.GroupBox grBoxGettingData;
        private System.Windows.Forms.DataGridView DgvQuizResult;
        private System.Windows.Forms.GroupBox grBoxMonitoringFiltration;
        private System.Windows.Forms.RichTextBox RtbLogs;
        private System.Windows.Forms.GroupBox grBoxLogs;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenu;
        private System.Windows.Forms.GroupBox GroupBoxMonitoringType;
        private System.Windows.Forms.ComboBox comboBoxMonitoringType;
        private System.Windows.Forms.GroupBox gpBoxSensorQuery;
        private System.Windows.Forms.ProgressBar ProgressBarMonitoring;
        private System.Windows.Forms.Button ButtonSelectSensorsForRequest;
        private System.Windows.Forms.Button ButtonRequestNetwork;
        private System.Windows.Forms.GroupBox grBoxMonitoringMap;
        private GMap.NET.WindowsForms.GMapControl SensorMonitoringMap;
        private System.Windows.Forms.GroupBox grBoxMap;
        private System.Windows.Forms.GroupBox grBoxInterval;
        private System.Windows.Forms.ComboBox ComboBoxSelectQuizInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIntervalFrom;
        private System.Windows.Forms.GroupBox grBoxQuizResult;
        private System.Windows.Forms.RadioButton RButtonOnlySave;
        private System.Windows.Forms.RadioButton RButtonOnlyShow;
        private System.Windows.Forms.RadioButton RButtonSaveAndShow;
        private System.Windows.Forms.RichTextBox rtbSensorsCountQuiz;
        private System.Windows.Forms.RichTextBox rtbDataCountQuiz;
        private System.Windows.Forms.RichTextBox RtbSelectedSensorsCount;
        private System.Windows.Forms.RichTextBox RtbQuizNumber;
        private System.Windows.Forms.Button btnFiltration;
        private System.Windows.Forms.GroupBox grBoxFiltrationBySensorName;
        private System.Windows.Forms.Button btnSelectSensorsForаFiltration;
        private System.Windows.Forms.DateTimePicker DtpFrom;
        private System.Windows.Forms.DateTimePicker DtpTo;
    }
}

