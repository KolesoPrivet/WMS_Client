using WMS.DAL;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SValuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxCheckForQuery = new System.Windows.Forms.ComboBox();
            this.btnMapAskSens = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBxCheckInternet = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnShwMap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSNMap = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbxMapLastTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxMapLastDate = new System.Windows.Forms.TextBox();
            this.txtbxMapLastValue = new System.Windows.Forms.TextBox();
            this.txtbxMapSStatus = new System.Windows.Forms.TextBox();
            this.txtbxMapSType = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.tabPageSensor = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.unionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStartMonitoring = new System.Windows.Forms.Button();
            this.dgvSens = new System.Windows.Forms.DataGridView();
            this.btnRefreshDB = new System.Windows.Forms.Button();
            this.rtbAmountSensors = new System.Windows.Forms.RichTextBox();
            this.comboBoxSensorType = new System.Windows.Forms.ComboBox();
            this.txtbxSName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.карта = new System.Windows.Forms.TabControl();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSensMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.SValuesBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPageSensor.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unionChart)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSens)).BeginInit();
            this.карта.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox9);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainMap);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 667);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dataGridView1);
            this.groupBox9.Controls.Add(this.button2);
            this.groupBox9.Controls.Add(this.button1);
            this.groupBox9.Controls.Add(this.comboBoxCheckForQuery);
            this.groupBox9.Controls.Add(this.btnMapAskSens);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Location = new System.Drawing.Point(4, 323);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(283, 284);
            this.groupBox9.TabIndex = 24;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Опрос";
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Название:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtBxCheckInternet);
            this.groupBox6.Location = new System.Drawing.Point(3, 613);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(283, 51);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Подключение к сети Интернет";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnShwMap);
            this.groupBox5.Location = new System.Drawing.Point(4, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(283, 57);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Отображение карты";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSNMap);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 240);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Поиск";
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.txtbxMapSStatus);
            this.groupBox7.Controls.Add(this.txtbxMapSType);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Location = new System.Drawing.Point(6, 48);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(271, 184);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Результаты поиска";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.txtbxMapLastTime);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.txtbxMapLastDate);
            this.groupBox8.Controls.Add(this.txtbxMapLastValue);
            this.groupBox8.Location = new System.Drawing.Point(6, 74);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(259, 101);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Последняя активность";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Время:";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Значение:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Дата:";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Тип датчика:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Состояние:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Название:";
            // 
            // MainMap
            // 
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(7, 0);
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
            this.tabPageSensor.Controls.Add(this.groupBox4);
            this.tabPageSensor.Controls.Add(this.groupBox3);
            this.tabPageSensor.Controls.Add(this.groupBox2);
            this.tabPageSensor.Controls.Add(this.label3);
            this.tabPageSensor.Location = new System.Drawing.Point(4, 22);
            this.tabPageSensor.Name = "tabPageSensor";
            this.tabPageSensor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSensor.Size = new System.Drawing.Size(1084, 673);
            this.tabPageSensor.TabIndex = 0;
            this.tabPageSensor.Text = "Датчики";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.unionChart);
            this.groupBox4.Location = new System.Drawing.Point(6, 336);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1072, 272);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "График";
            // 
            // unionChart
            // 
            chartArea4.Name = "ChartArea1";
            this.unionChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.unionChart.Legends.Add(legend4);
            this.unionChart.Location = new System.Drawing.Point(6, 19);
            this.unionChart.Name = "unionChart";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Blue;
            series4.Legend = "Legend1";
            series4.Name = "Датчик";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.unionChart.Series.Add(series4);
            this.unionChart.Size = new System.Drawing.Size(1060, 247);
            this.unionChart.TabIndex = 6;
            this.unionChart.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBoxInterval);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtbxDate);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dgvData);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rtbSensorsValue);
            this.groupBox3.Controls.Add(this.txtbxTimeFrom);
            this.groupBox3.Controls.Add(this.txtbxTimeTo);
            this.groupBox3.Location = new System.Drawing.Point(553, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 324);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные";
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
            this.dgvData.Size = new System.Drawing.Size(513, 213);
            this.dgvData.TabIndex = 0;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStartMonitoring);
            this.groupBox2.Controls.Add(this.dgvSens);
            this.groupBox2.Controls.Add(this.btnRefreshDB);
            this.groupBox2.Controls.Add(this.rtbAmountSensors);
            this.groupBox2.Controls.Add(this.comboBoxSensorType);
            this.groupBox2.Controls.Add(this.txtbxSName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 324);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Идентификация датчиков";
            // 
            // btnStartMonitoring
            // 
            this.btnStartMonitoring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartMonitoring.Location = new System.Drawing.Point(392, 16);
            this.btnStartMonitoring.Name = "btnStartMonitoring";
            this.btnStartMonitoring.Size = new System.Drawing.Size(127, 75);
            this.btnStartMonitoring.TabIndex = 17;
            this.btnStartMonitoring.Text = "Начать мониторинг";
            this.btnStartMonitoring.UseVisualStyleBackColor = true;
            this.btnStartMonitoring.Click += new System.EventHandler(this.btnStartMonitoring_Click);
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
            this.btnRefreshDB.Location = new System.Drawing.Point(261, 16);
            this.btnRefreshDB.Name = "btnRefreshDB";
            this.btnRefreshDB.Size = new System.Drawing.Size(127, 75);
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
            this.rtbAmountSensors.Size = new System.Drawing.Size(249, 24);
            this.rtbAmountSensors.TabIndex = 15;
            this.rtbAmountSensors.Text = "Количество датчиков: 0";
            // 
            // comboBoxSensorType
            // 
            this.comboBoxSensorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensorType.FormattingEnabled = true;
            this.comboBoxSensorType.Items.AddRange(new object[] {
            "Датчик температуры",
            "Датчик атмосферного давления",
            "Датчик скорости ветра"});
            this.comboBoxSensorType.Location = new System.Drawing.Point(87, 45);
            this.comboBoxSensorType.Name = "comboBoxSensorType";
            this.comboBoxSensorType.Size = new System.Drawing.Size(168, 21);
            this.comboBoxSensorType.TabIndex = 14;
            this.comboBoxSensorType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSensorType_SelectedIndexChanged);
            // 
            // txtbxSName
            // 
            this.txtbxSName.Location = new System.Drawing.Point(87, 22);
            this.txtbxSName.Name = "txtbxSName";
            this.txtbxSName.Size = new System.Drawing.Size(168, 20);
            this.txtbxSName.TabIndex = 9;
            this.txtbxSName.TextChanged += new System.EventHandler(this.textBoxSenName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Название:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Тип датчика:";
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
            this.карта.Controls.Add(this.tabPageSensor);
            this.карта.Controls.Add(this.tabPage1);
            this.карта.Location = new System.Drawing.Point(11, 29);
            this.карта.Name = "карта";
            this.карта.SelectedIndex = 0;
            this.карта.Size = new System.Drawing.Size(1092, 699);
            this.карта.TabIndex = 4;
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
            this.menuStrip1.Size = new System.Drawing.Size(1111, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(12, 734);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1087, 139);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Мониторинг";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 885);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.карта);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Беспроводная система мониторинга WMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SValuesBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPageSensor.ResumeLayout(false);
            this.tabPageSensor.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unionChart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSens)).EndInit();
            this.карта.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource SValuesBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtBxCheckInternet;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnShwMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtbxMapSStatus;
        private System.Windows.Forms.TextBox txtbxMapSType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.TabPage tabPageSensor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart unionChart;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSens;
        internal System.Windows.Forms.Button btnRefreshDB;
        private System.Windows.Forms.RichTextBox rtbAmountSensors;
        private System.Windows.Forms.ComboBox comboBoxSensorType;
        private System.Windows.Forms.TextBox txtbxSName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbxMapLastTime;
        private System.Windows.Forms.ToolStripMenuItem RestartMenu;
        private System.Windows.Forms.ToolStripMenuItem AddSensMenu;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnMapAskSens;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Button btnStartMonitoring;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCheckForQuery;
    }
}

