namespace UI.View
{
    partial class SelectDateForm
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
            this.btnAcceptSelection = new System.Windows.Forms.Button();
            this.gpBoxSelectTimeInterval = new System.Windows.Forms.GroupBox();
            this.gpBoxSelectDate = new System.Windows.Forms.GroupBox();
            this.chBoxDates = new System.Windows.Forms.CheckedListBox();
            this.txtBoxFirstTimeValue = new System.Windows.Forms.TextBox();
            this.lblFirstTimeValue = new System.Windows.Forms.Label();
            this.lblSecondTimeValue = new System.Windows.Forms.Label();
            this.txtBoxSecondTimeValue = new System.Windows.Forms.TextBox();
            this.gpBoxSelectTimeInterval.SuspendLayout();
            this.gpBoxSelectDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAcceptSelection
            // 
            this.btnAcceptSelection.Location = new System.Drawing.Point(12, 210);
            this.btnAcceptSelection.Name = "btnAcceptSelection";
            this.btnAcceptSelection.Size = new System.Drawing.Size(267, 39);
            this.btnAcceptSelection.TabIndex = 27;
            this.btnAcceptSelection.Text = "OK";
            this.btnAcceptSelection.UseVisualStyleBackColor = true;
            this.btnAcceptSelection.Click += new System.EventHandler(this.btnAcceptSelection_Click);
            // 
            // gpBoxSelectTimeInterval
            // 
            this.gpBoxSelectTimeInterval.Controls.Add(this.lblSecondTimeValue);
            this.gpBoxSelectTimeInterval.Controls.Add(this.txtBoxSecondTimeValue);
            this.gpBoxSelectTimeInterval.Controls.Add(this.lblFirstTimeValue);
            this.gpBoxSelectTimeInterval.Controls.Add(this.txtBoxFirstTimeValue);
            this.gpBoxSelectTimeInterval.Location = new System.Drawing.Point(12, 151);
            this.gpBoxSelectTimeInterval.Name = "gpBoxSelectTimeInterval";
            this.gpBoxSelectTimeInterval.Size = new System.Drawing.Size(267, 53);
            this.gpBoxSelectTimeInterval.TabIndex = 26;
            this.gpBoxSelectTimeInterval.TabStop = false;
            this.gpBoxSelectTimeInterval.Text = "По часовому промежутку";
            // 
            // gpBoxSelectDate
            // 
            this.gpBoxSelectDate.Controls.Add(this.chBoxDates);
            this.gpBoxSelectDate.Location = new System.Drawing.Point(12, 10);
            this.gpBoxSelectDate.Name = "gpBoxSelectDate";
            this.gpBoxSelectDate.Size = new System.Drawing.Size(267, 135);
            this.gpBoxSelectDate.TabIndex = 25;
            this.gpBoxSelectDate.TabStop = false;
            this.gpBoxSelectDate.Text = "По дате";
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
            // txtBoxFirstTimeValue
            // 
            this.txtBoxFirstTimeValue.Location = new System.Drawing.Point(35, 19);
            this.txtBoxFirstTimeValue.MaxLength = 5;
            this.txtBoxFirstTimeValue.Name = "txtBoxFirstTimeValue";
            this.txtBoxFirstTimeValue.Size = new System.Drawing.Size(87, 20);
            this.txtBoxFirstTimeValue.TabIndex = 0;
            this.txtBoxFirstTimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtBoxSecondTimeValue.Location = new System.Drawing.Point(163, 19);
            this.txtBoxSecondTimeValue.MaxLength = 5;
            this.txtBoxSecondTimeValue.Name = "txtBoxSecondTimeValue";
            this.txtBoxSecondTimeValue.Size = new System.Drawing.Size(98, 20);
            this.txtBoxSecondTimeValue.TabIndex = 2;
            this.txtBoxSecondTimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 257);
            this.Controls.Add(this.btnAcceptSelection);
            this.Controls.Add(this.gpBoxSelectTimeInterval);
            this.Controls.Add(this.gpBoxSelectDate);
            this.Name = "SelectDateForm";
            this.Text = "SelectDateForm";
            this.Load += new System.EventHandler(this.SelectDateForm_Load);
            this.gpBoxSelectTimeInterval.ResumeLayout(false);
            this.gpBoxSelectTimeInterval.PerformLayout();
            this.gpBoxSelectDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAcceptSelection;
        private System.Windows.Forms.GroupBox gpBoxSelectTimeInterval;
        private System.Windows.Forms.GroupBox gpBoxSelectDate;
        private System.Windows.Forms.CheckedListBox chBoxDates;
        private System.Windows.Forms.TextBox txtBoxFirstTimeValue;
        private System.Windows.Forms.Label lblSecondTimeValue;
        private System.Windows.Forms.TextBox txtBoxSecondTimeValue;
        private System.Windows.Forms.Label lblFirstTimeValue;
    }
}