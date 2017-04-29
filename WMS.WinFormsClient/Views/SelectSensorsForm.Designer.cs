namespace WMS.WinFormsClient
{
    partial class SelectSensorsForm
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
            this.chBoxSensorsNames = new System.Windows.Forms.CheckedListBox();
            this.gpBoxSelectSensorsNames = new System.Windows.Forms.GroupBox();
            this.gpBoxSelectSensorsTypes = new System.Windows.Forms.GroupBox();
            this.comboBoxSensorType = new System.Windows.Forms.ComboBox();
            this.btnAcceptSelection = new System.Windows.Forms.Button();
            this.gpBoxSelectSensorsNames.SuspendLayout();
            this.gpBoxSelectSensorsTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // chBoxSensorsNames
            // 
            this.chBoxSensorsNames.CheckOnClick = true;
            this.chBoxSensorsNames.FormattingEnabled = true;
            this.chBoxSensorsNames.Location = new System.Drawing.Point( 6, 19 );
            this.chBoxSensorsNames.Name = "chBoxSensorsNames";
            this.chBoxSensorsNames.Size = new System.Drawing.Size( 255, 109 );
            this.chBoxSensorsNames.TabIndex = 21;
            // 
            // gpBoxSelectSensorsNames
            // 
            this.gpBoxSelectSensorsNames.Controls.Add( this.chBoxSensorsNames );
            this.gpBoxSelectSensorsNames.Location = new System.Drawing.Point( 12, 12 );
            this.gpBoxSelectSensorsNames.Name = "gpBoxSelectSensorsNames";
            this.gpBoxSelectSensorsNames.Size = new System.Drawing.Size( 267, 135 );
            this.gpBoxSelectSensorsNames.TabIndex = 22;
            this.gpBoxSelectSensorsNames.TabStop = false;
            this.gpBoxSelectSensorsNames.Text = "По имени датчика";
            // 
            // gpBoxSelectSensorsTypes
            // 
            this.gpBoxSelectSensorsTypes.Controls.Add( this.comboBoxSensorType );
            this.gpBoxSelectSensorsTypes.Location = new System.Drawing.Point( 12, 153 );
            this.gpBoxSelectSensorsTypes.Name = "gpBoxSelectSensorsTypes";
            this.gpBoxSelectSensorsTypes.Size = new System.Drawing.Size( 267, 51 );
            this.gpBoxSelectSensorsTypes.TabIndex = 23;
            this.gpBoxSelectSensorsTypes.TabStop = false;
            this.gpBoxSelectSensorsTypes.Text = "По типу датчика";
            // 
            // comboBoxSensorType
            // 
            this.comboBoxSensorType.AllowDrop = true;
            this.comboBoxSensorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensorType.FormattingEnabled = true;
            this.comboBoxSensorType.Location = new System.Drawing.Point( 6, 19 );
            this.comboBoxSensorType.Name = "comboBoxSensorType";
            this.comboBoxSensorType.Size = new System.Drawing.Size( 255, 21 );
            this.comboBoxSensorType.TabIndex = 0;
            this.comboBoxSensorType.SelectedIndexChanged += new System.EventHandler( this.comboBoxSensorType_SelectedIndexChanged );
            // 
            // btnAcceptSelection
            // 
            this.btnAcceptSelection.Location = new System.Drawing.Point( 12, 210 );
            this.btnAcceptSelection.Name = "btnAcceptSelection";
            this.btnAcceptSelection.Size = new System.Drawing.Size( 267, 39 );
            this.btnAcceptSelection.TabIndex = 24;
            this.btnAcceptSelection.Text = "OK";
            this.btnAcceptSelection.UseVisualStyleBackColor = true;
            this.btnAcceptSelection.Click += new System.EventHandler( this.btnAcceptSelection_Click );
            // 
            // SelectSensorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 291, 257 );
            this.Controls.Add( this.btnAcceptSelection );
            this.Controls.Add( this.gpBoxSelectSensorsTypes );
            this.Controls.Add( this.gpBoxSelectSensorsNames );
            this.Name = "SelectSensorsForm";
            this.Text = "Выборка датчиков";
            this.Load += new System.EventHandler( this.SelectSensorsForm_Load );
            this.gpBoxSelectSensorsNames.ResumeLayout( false );
            this.gpBoxSelectSensorsTypes.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion
        private System.Windows.Forms.CheckedListBox chBoxSensorsNames;
        private System.Windows.Forms.GroupBox gpBoxSelectSensorsNames;
        private System.Windows.Forms.GroupBox gpBoxSelectSensorsTypes;
        private System.Windows.Forms.Button btnAcceptSelection;
        private System.Windows.Forms.ComboBox comboBoxSensorType;
    }
}