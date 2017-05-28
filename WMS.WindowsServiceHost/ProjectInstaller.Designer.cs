namespace WMS.WindowsServiceHost
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.wmsServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.wmsServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // wmsServiceProcessInstaller
            // 
            this.wmsServiceProcessInstaller.Password = null;
            this.wmsServiceProcessInstaller.Username = null;
            // 
            // wmsServiceInstaller
            // 
            this.wmsServiceInstaller.Description = "WMS server service";
            this.wmsServiceInstaller.ServiceName = "WMSService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.wmsServiceProcessInstaller,
            this.wmsServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller wmsServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller wmsServiceInstaller;
    }
}