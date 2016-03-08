namespace WMS
{
    partial class AuthorForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxHidePass = new System.Windows.Forms.CheckBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxForPass = new System.Windows.Forms.TextBox();
            this.txtbxForLogin = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxHidePass);
            this.groupBox4.Controls.Add(this.btnEnter);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtbxForPass);
            this.groupBox4.Controls.Add(this.txtbxForLogin);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 102);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Авторизация";
            // 
            // checkBoxHidePass
            // 
            this.checkBoxHidePass.AutoSize = true;
            this.checkBoxHidePass.Location = new System.Drawing.Point(63, 74);
            this.checkBoxHidePass.Name = "checkBoxHidePass";
            this.checkBoxHidePass.Size = new System.Drawing.Size(114, 17);
            this.checkBoxHidePass.TabIndex = 19;
            this.checkBoxHidePass.Text = "Показать пароль";
            this.checkBoxHidePass.UseVisualStyleBackColor = true;
            this.checkBoxHidePass.CheckedChanged += new System.EventHandler(this.checkBoxHidePass_CheckedChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.Location = new System.Drawing.Point(247, 19);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(76, 52);
            this.btnEnter.TabIndex = 18;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Пароль: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Логин: ";
            // 
            // txtbxForPass
            // 
            this.txtbxForPass.Location = new System.Drawing.Point(63, 48);
            this.txtbxForPass.Name = "txtbxForPass";
            this.txtbxForPass.Size = new System.Drawing.Size(178, 20);
            this.txtbxForPass.TabIndex = 15;
            this.txtbxForPass.UseSystemPasswordChar = true;
            // 
            // txtbxForLogin
            // 
            this.txtbxForLogin.Location = new System.Drawing.Point(63, 22);
            this.txtbxForLogin.Name = "txtbxForLogin";
            this.txtbxForLogin.Size = new System.Drawing.Size(178, 20);
            this.txtbxForLogin.TabIndex = 14;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 122);
            this.Controls.Add(this.groupBox4);
            this.Name = "AuthorForm";
            this.Text = "Авторизация";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxForPass;
        private System.Windows.Forms.TextBox txtbxForLogin;
        private System.Windows.Forms.CheckBox checkBoxHidePass;
    }
}