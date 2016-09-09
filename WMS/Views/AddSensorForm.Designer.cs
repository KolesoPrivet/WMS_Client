namespace UI.Views
{
    partial class AddSensorForm
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
            this.btnAddSens = new System.Windows.Forms.Button();
            this.txtbxAddType = new System.Windows.Forms.TextBox();
            this.txtbxAddName = new System.Windows.Forms.TextBox();
            this.txtbxLNG = new System.Windows.Forms.TextBox();
            this.txtbxLAT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddSens
            // 
            this.btnAddSens.Location = new System.Drawing.Point(195, 74);
            this.btnAddSens.Name = "btnAddSens";
            this.btnAddSens.Size = new System.Drawing.Size(226, 47);
            this.btnAddSens.TabIndex = 0;
            this.btnAddSens.Text = "Добавить";
            this.btnAddSens.UseVisualStyleBackColor = true;
            this.btnAddSens.Click += new System.EventHandler(this.btnAddSens_Click);
            // 
            // txtbxAddType
            // 
            this.txtbxAddType.Location = new System.Drawing.Point(79, 48);
            this.txtbxAddType.Name = "txtbxAddType";
            this.txtbxAddType.Size = new System.Drawing.Size(342, 20);
            this.txtbxAddType.TabIndex = 1;
            // 
            // txtbxAddName
            // 
            this.txtbxAddName.Location = new System.Drawing.Point(79, 22);
            this.txtbxAddName.Name = "txtbxAddName";
            this.txtbxAddName.Size = new System.Drawing.Size(342, 20);
            this.txtbxAddName.TabIndex = 2;
            // 
            // txtbxLNG
            // 
            this.txtbxLNG.Location = new System.Drawing.Point(79, 75);
            this.txtbxLNG.Name = "txtbxLNG";
            this.txtbxLNG.Size = new System.Drawing.Size(110, 20);
            this.txtbxLNG.TabIndex = 5;
            // 
            // txtbxLAT
            // 
            this.txtbxLAT.Location = new System.Drawing.Point(79, 101);
            this.txtbxLAT.Name = "txtbxLAT";
            this.txtbxLAT.Size = new System.Drawing.Size(110, 20);
            this.txtbxLAT.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тип:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Долгота:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Широта:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddSens);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbxAddType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbxAddName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbxLAT);
            this.groupBox1.Controls.Add(this.txtbxLNG);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 130);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Идентификационные данные";
            // 
            // ASForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 149);
            this.Controls.Add(this.groupBox1);
            this.Name = "ASForm";
            this.Text = "Новый датчик";
            this.Load += new System.EventHandler(this.ASForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddSens;
        private System.Windows.Forms.TextBox txtbxAddType;
        private System.Windows.Forms.TextBox txtbxAddName;
        private System.Windows.Forms.TextBox txtbxLNG;
        private System.Windows.Forms.TextBox txtbxLAT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}