namespace UI.Views
{
    partial class SaveAsForm
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
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBarSavingInto = new System.Windows.Forms.ProgressBar();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.grBoxSaveAs = new System.Windows.Forms.GroupBox();
            this.btnPathExplorer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.gpBoxSelectTimeInterval = new System.Windows.Forms.GroupBox();
            this.lblSecondTimeValue = new System.Windows.Forms.Label();
            this.txtBoxSecondTimeValue = new System.Windows.Forms.TextBox();
            this.lblFirstTimeValue = new System.Windows.Forms.Label();
            this.txtBoxFirstTimeValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxDates = new System.Windows.Forms.CheckedListBox();
            this.gpBoxSaveReportSensors = new System.Windows.Forms.GroupBox();
            this.gpBoxSensorsNames = new System.Windows.Forms.GroupBox();
            this.comboBoxSensorName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSensorType = new System.Windows.Forms.ComboBox();
            this.checkBoxEnableTimeInterval = new System.Windows.Forms.CheckBox();
            this.grBoxSaveAs.SuspendLayout();
            this.gpBoxSelectTimeInterval.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpBoxSaveReportSensors.SuspendLayout();
            this.gpBoxSensorsNames.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarSavingInto
            // 
            this.progressBarSavingInto.Location = new System.Drawing.Point(12, 235);
            this.progressBarSavingInto.Name = "progressBarSavingInto";
            this.progressBarSavingInto.Size = new System.Drawing.Size(540, 10);
            this.progressBarSavingInto.TabIndex = 30;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Enabled = false;
            this.btnSaveFile.Location = new System.Drawing.Point(285, 207);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(267, 22);
            this.btnSaveFile.TabIndex = 35;
            this.btnSaveFile.Text = "Сохранить";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // grBoxSaveAs
            // 
            this.grBoxSaveAs.Controls.Add(this.btnPathExplorer);
            this.grBoxSaveAs.Controls.Add(this.label1);
            this.grBoxSaveAs.Controls.Add(this.textBox1);
            this.grBoxSaveAs.Controls.Add(this.lblFileName);
            this.grBoxSaveAs.Location = new System.Drawing.Point(12, 151);
            this.grBoxSaveAs.Name = "grBoxSaveAs";
            this.grBoxSaveAs.Size = new System.Drawing.Size(267, 78);
            this.grBoxSaveAs.TabIndex = 34;
            this.grBoxSaveAs.TabStop = false;
            this.grBoxSaveAs.Text = "Сохранить";
            // 
            // btnPathExplorer
            // 
            this.btnPathExplorer.Location = new System.Drawing.Point(79, 47);
            this.btnPathExplorer.Name = "btnPathExplorer";
            this.btnPathExplorer.Size = new System.Drawing.Size(182, 23);
            this.btnPathExplorer.TabIndex = 6;
            this.btnPathExplorer.Text = "Выбрать";
            this.btnPathExplorer.UseVisualStyleBackColor = true;
            this.btnPathExplorer.Click += new System.EventHandler(this.btnPathExplorer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Путь:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 21);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(6, 24);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(67, 13);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "Имя файла:";
            // 
            // gpBoxSelectTimeInterval
            // 
            this.gpBoxSelectTimeInterval.Controls.Add(this.checkBoxEnableTimeInterval);
            this.gpBoxSelectTimeInterval.Controls.Add(this.lblSecondTimeValue);
            this.gpBoxSelectTimeInterval.Controls.Add(this.txtBoxSecondTimeValue);
            this.gpBoxSelectTimeInterval.Controls.Add(this.lblFirstTimeValue);
            this.gpBoxSelectTimeInterval.Controls.Add(this.txtBoxFirstTimeValue);
            this.gpBoxSelectTimeInterval.Location = new System.Drawing.Point(285, 153);
            this.gpBoxSelectTimeInterval.Name = "gpBoxSelectTimeInterval";
            this.gpBoxSelectTimeInterval.Size = new System.Drawing.Size(267, 48);
            this.gpBoxSelectTimeInterval.TabIndex = 33;
            this.gpBoxSelectTimeInterval.TabStop = false;
            this.gpBoxSelectTimeInterval.Text = "Выберите часовой промежуток";
            // 
            // lblSecondTimeValue
            // 
            this.lblSecondTimeValue.AutoSize = true;
            this.lblSecondTimeValue.Location = new System.Drawing.Point(145, 22);
            this.lblSecondTimeValue.Name = "lblSecondTimeValue";
            this.lblSecondTimeValue.Size = new System.Drawing.Size(25, 13);
            this.lblSecondTimeValue.TabIndex = 3;
            this.lblSecondTimeValue.Text = "До:";
            // 
            // txtBoxSecondTimeValue
            // 
            this.txtBoxSecondTimeValue.Enabled = false;
            this.txtBoxSecondTimeValue.Location = new System.Drawing.Point(176, 19);
            this.txtBoxSecondTimeValue.MaxLength = 5;
            this.txtBoxSecondTimeValue.Name = "txtBoxSecondTimeValue";
            this.txtBoxSecondTimeValue.Size = new System.Drawing.Size(83, 20);
            this.txtBoxSecondTimeValue.TabIndex = 2;
            this.txtBoxSecondTimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFirstTimeValue
            // 
            this.lblFirstTimeValue.AutoSize = true;
            this.lblFirstTimeValue.Location = new System.Drawing.Point(27, 22);
            this.lblFirstTimeValue.Name = "lblFirstTimeValue";
            this.lblFirstTimeValue.Size = new System.Drawing.Size(23, 13);
            this.lblFirstTimeValue.TabIndex = 1;
            this.lblFirstTimeValue.Text = "От:";
            // 
            // txtBoxFirstTimeValue
            // 
            this.txtBoxFirstTimeValue.Enabled = false;
            this.txtBoxFirstTimeValue.Location = new System.Drawing.Point(56, 19);
            this.txtBoxFirstTimeValue.MaxLength = 5;
            this.txtBoxFirstTimeValue.Name = "txtBoxFirstTimeValue";
            this.txtBoxFirstTimeValue.Size = new System.Drawing.Size(83, 20);
            this.txtBoxFirstTimeValue.TabIndex = 0;
            this.txtBoxFirstTimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxDates);
            this.groupBox1.Location = new System.Drawing.Point(285, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 135);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите дату";
            // 
            // chBoxDates
            // 
            this.chBoxDates.CheckOnClick = true;
            this.chBoxDates.Enabled = false;
            this.chBoxDates.FormattingEnabled = true;
            this.chBoxDates.Location = new System.Drawing.Point(6, 19);
            this.chBoxDates.Name = "chBoxDates";
            this.chBoxDates.Size = new System.Drawing.Size(255, 109);
            this.chBoxDates.TabIndex = 21;
            // 
            // gpBoxSaveReportSensors
            // 
            this.gpBoxSaveReportSensors.Controls.Add(this.groupBox2);
            this.gpBoxSaveReportSensors.Controls.Add(this.gpBoxSensorsNames);
            this.gpBoxSaveReportSensors.Location = new System.Drawing.Point(12, 12);
            this.gpBoxSaveReportSensors.Name = "gpBoxSaveReportSensors";
            this.gpBoxSaveReportSensors.Size = new System.Drawing.Size(267, 135);
            this.gpBoxSaveReportSensors.TabIndex = 31;
            this.gpBoxSaveReportSensors.TabStop = false;
            this.gpBoxSaveReportSensors.Text = "Выберите датчик";
            // 
            // gpBoxSensorsNames
            // 
            this.gpBoxSensorsNames.Controls.Add(this.comboBoxSensorName);
            this.gpBoxSensorsNames.Location = new System.Drawing.Point(6, 19);
            this.gpBoxSensorsNames.Name = "gpBoxSensorsNames";
            this.gpBoxSensorsNames.Size = new System.Drawing.Size(255, 55);
            this.gpBoxSensorsNames.TabIndex = 24;
            this.gpBoxSensorsNames.TabStop = false;
            this.gpBoxSensorsNames.Text = "Имя датчика";
            // 
            // comboBoxSensorName
            // 
            this.comboBoxSensorName.AllowDrop = true;
            this.comboBoxSensorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensorName.FormattingEnabled = true;
            this.comboBoxSensorName.Location = new System.Drawing.Point(6, 18);
            this.comboBoxSensorName.Name = "comboBoxSensorName";
            this.comboBoxSensorName.Size = new System.Drawing.Size(243, 21);
            this.comboBoxSensorName.TabIndex = 0;
            this.comboBoxSensorName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSensorName_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxSensorType);
            this.groupBox2.Location = new System.Drawing.Point(6, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 55);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип датчика";
            // 
            // comboBoxSensorType
            // 
            this.comboBoxSensorType.AllowDrop = true;
            this.comboBoxSensorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensorType.FormattingEnabled = true;
            this.comboBoxSensorType.Location = new System.Drawing.Point(6, 18);
            this.comboBoxSensorType.Name = "comboBoxSensorType";
            this.comboBoxSensorType.Size = new System.Drawing.Size(243, 21);
            this.comboBoxSensorType.TabIndex = 0;
            this.comboBoxSensorType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSensorType_SelectedIndexChanged);
            // 
            // checkBoxEnableTimeInterval
            // 
            this.checkBoxEnableTimeInterval.AutoSize = true;
            this.checkBoxEnableTimeInterval.Location = new System.Drawing.Point(6, 25);
            this.checkBoxEnableTimeInterval.Name = "checkBoxEnableTimeInterval";
            this.checkBoxEnableTimeInterval.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEnableTimeInterval.TabIndex = 5;
            this.checkBoxEnableTimeInterval.UseVisualStyleBackColor = true;
            this.checkBoxEnableTimeInterval.CheckedChanged += new System.EventHandler(this.checkBoxEnableTimeInterval_CheckedChanged);
            // 
            // SaveAsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 251);
            this.Controls.Add(this.progressBarSavingInto);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.grBoxSaveAs);
            this.Controls.Add(this.gpBoxSelectTimeInterval);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpBoxSaveReportSensors);
            this.Name = "SaveAsForm";
            this.Text = "Сохранить в...";
            this.Load += new System.EventHandler(this.SaveAsForm_Load);
            this.grBoxSaveAs.ResumeLayout(false);
            this.grBoxSaveAs.PerformLayout();
            this.gpBoxSelectTimeInterval.ResumeLayout(false);
            this.gpBoxSelectTimeInterval.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gpBoxSaveReportSensors.ResumeLayout(false);
            this.gpBoxSensorsNames.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarSavingInto;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.GroupBox grBoxSaveAs;
        private System.Windows.Forms.Button btnPathExplorer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.GroupBox gpBoxSelectTimeInterval;
        private System.Windows.Forms.Label lblSecondTimeValue;
        private System.Windows.Forms.TextBox txtBoxSecondTimeValue;
        private System.Windows.Forms.Label lblFirstTimeValue;
        private System.Windows.Forms.TextBox txtBoxFirstTimeValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chBoxDates;
        private System.Windows.Forms.GroupBox gpBoxSaveReportSensors;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxSensorType;
        private System.Windows.Forms.GroupBox gpBoxSensorsNames;
        private System.Windows.Forms.ComboBox comboBoxSensorName;
        private System.Windows.Forms.CheckBox checkBoxEnableTimeInterval;
    }
}