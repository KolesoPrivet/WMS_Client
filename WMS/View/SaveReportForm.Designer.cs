﻿namespace WMS.View
{
    partial class SaveReportForm
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
            this.gpBoxSaveReportSensors = new System.Windows.Forms.GroupBox();
            this.chBoxSensorsNames = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxDates = new System.Windows.Forms.CheckedListBox();
            this.gpBoxSelectTimeInterval = new System.Windows.Forms.GroupBox();
            this.lblSecondTimeValue = new System.Windows.Forms.Label();
            this.txtBoxSecondTimeValue = new System.Windows.Forms.TextBox();
            this.lblFirstTimeValue = new System.Windows.Forms.Label();
            this.txtBoxFirstTimeValue = new System.Windows.Forms.TextBox();
            this.grBoxSaveAs = new System.Windows.Forms.GroupBox();
            this.btnPathExplorer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.progressBarSavingReport = new System.Windows.Forms.ProgressBar();
            this.gpBoxSaveReportSensors.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpBoxSelectTimeInterval.SuspendLayout();
            this.grBoxSaveAs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBoxSaveReportSensors
            // 
            this.gpBoxSaveReportSensors.Controls.Add(this.chBoxSensorsNames);
            this.gpBoxSaveReportSensors.Location = new System.Drawing.Point(12, 12);
            this.gpBoxSaveReportSensors.Name = "gpBoxSaveReportSensors";
            this.gpBoxSaveReportSensors.Size = new System.Drawing.Size(267, 135);
            this.gpBoxSaveReportSensors.TabIndex = 23;
            this.gpBoxSaveReportSensors.TabStop = false;
            this.gpBoxSaveReportSensors.Text = "Выберите датчик";
            // 
            // chBoxSensorsNames
            // 
            this.chBoxSensorsNames.CheckOnClick = true;
            this.chBoxSensorsNames.FormattingEnabled = true;
            this.chBoxSensorsNames.Location = new System.Drawing.Point(6, 19);
            this.chBoxSensorsNames.Name = "chBoxSensorsNames";
            this.chBoxSensorsNames.Size = new System.Drawing.Size(255, 109);
            this.chBoxSensorsNames.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxDates);
            this.groupBox1.Location = new System.Drawing.Point(285, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 135);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите дату";
            // 
            // chBoxDates
            // 
            this.chBoxDates.CheckOnClick = true;
            this.chBoxDates.FormattingEnabled = true;
            this.chBoxDates.Location = new System.Drawing.Point(6, 19);
            this.chBoxDates.Name = "chBoxDates";
            this.chBoxDates.Size = new System.Drawing.Size(255, 109);
            this.chBoxDates.TabIndex = 21;
            // 
            // gpBoxSelectTimeInterval
            // 
            this.gpBoxSelectTimeInterval.Controls.Add(this.lblSecondTimeValue);
            this.gpBoxSelectTimeInterval.Controls.Add(this.txtBoxSecondTimeValue);
            this.gpBoxSelectTimeInterval.Controls.Add(this.lblFirstTimeValue);
            this.gpBoxSelectTimeInterval.Controls.Add(this.txtBoxFirstTimeValue);
            this.gpBoxSelectTimeInterval.Location = new System.Drawing.Point(285, 153);
            this.gpBoxSelectTimeInterval.Name = "gpBoxSelectTimeInterval";
            this.gpBoxSelectTimeInterval.Size = new System.Drawing.Size(267, 48);
            this.gpBoxSelectTimeInterval.TabIndex = 27;
            this.gpBoxSelectTimeInterval.TabStop = false;
            this.gpBoxSelectTimeInterval.Text = "Выберите часовой промежуток";
            // 
            // lblSecondTimeValue
            // 
            this.lblSecondTimeValue.AutoSize = true;
            this.lblSecondTimeValue.Location = new System.Drawing.Point(132, 22);
            this.lblSecondTimeValue.Name = "lblSecondTimeValue";
            this.lblSecondTimeValue.Size = new System.Drawing.Size(25, 13);
            this.lblSecondTimeValue.TabIndex = 3;
            this.lblSecondTimeValue.Text = "До:";
            // 
            // txtBoxSecondTimeValue
            // 
            this.txtBoxSecondTimeValue.Location = new System.Drawing.Point(161, 19);
            this.txtBoxSecondTimeValue.MaxLength = 5;
            this.txtBoxSecondTimeValue.Name = "txtBoxSecondTimeValue";
            this.txtBoxSecondTimeValue.Size = new System.Drawing.Size(98, 20);
            this.txtBoxSecondTimeValue.TabIndex = 2;
            this.txtBoxSecondTimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFirstTimeValue
            // 
            this.lblFirstTimeValue.AutoSize = true;
            this.lblFirstTimeValue.Location = new System.Drawing.Point(6, 22);
            this.lblFirstTimeValue.Name = "lblFirstTimeValue";
            this.lblFirstTimeValue.Size = new System.Drawing.Size(23, 13);
            this.lblFirstTimeValue.TabIndex = 1;
            this.lblFirstTimeValue.Text = "От:";
            // 
            // txtBoxFirstTimeValue
            // 
            this.txtBoxFirstTimeValue.Location = new System.Drawing.Point(35, 19);
            this.txtBoxFirstTimeValue.MaxLength = 5;
            this.txtBoxFirstTimeValue.Name = "txtBoxFirstTimeValue";
            this.txtBoxFirstTimeValue.Size = new System.Drawing.Size(87, 20);
            this.txtBoxFirstTimeValue.TabIndex = 0;
            this.txtBoxFirstTimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.grBoxSaveAs.TabIndex = 28;
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
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(285, 207);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(267, 22);
            this.btnSaveFile.TabIndex = 29;
            this.btnSaveFile.Text = "Сохранить";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // progressBarSavingReport
            // 
            this.progressBarSavingReport.Location = new System.Drawing.Point(12, 235);
            this.progressBarSavingReport.Name = "progressBarSavingReport";
            this.progressBarSavingReport.Size = new System.Drawing.Size(540, 10);
            this.progressBarSavingReport.TabIndex = 0;
            // 
            // SaveReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 250);
            this.Controls.Add(this.progressBarSavingReport);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.grBoxSaveAs);
            this.Controls.Add(this.gpBoxSelectTimeInterval);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpBoxSaveReportSensors);
            this.Name = "SaveReportForm";
            this.Text = "Сохранить отчет";
            this.gpBoxSaveReportSensors.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpBoxSelectTimeInterval.ResumeLayout(false);
            this.gpBoxSelectTimeInterval.PerformLayout();
            this.grBoxSaveAs.ResumeLayout(false);
            this.grBoxSaveAs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBoxSaveReportSensors;
        private System.Windows.Forms.CheckedListBox chBoxSensorsNames;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chBoxDates;
        private System.Windows.Forms.GroupBox gpBoxSelectTimeInterval;
        private System.Windows.Forms.Label lblSecondTimeValue;
        private System.Windows.Forms.TextBox txtBoxSecondTimeValue;
        private System.Windows.Forms.Label lblFirstTimeValue;
        private System.Windows.Forms.TextBox txtBoxFirstTimeValue;
        private System.Windows.Forms.GroupBox grBoxSaveAs;
        private System.Windows.Forms.Button btnPathExplorer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.ProgressBar progressBarSavingReport;
    }
}