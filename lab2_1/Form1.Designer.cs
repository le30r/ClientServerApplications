namespace lab2_1
{
    partial class Form1
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
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConnect = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabIncrease = new System.Windows.Forms.TabPage();
            this.increaseResultTestBox = new System.Windows.Forms.TextBox();
            this.executeIncreaseQuery = new System.Windows.Forms.Button();
            this.tabAverage = new System.Windows.Forms.TabPage();
            this.executeAverageQuery = new System.Windows.Forms.Button();
            this.avgTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabGetInfoCountries = new System.Windows.Forms.TabPage();
            this.getCountriesInfo = new System.Windows.Forms.Button();
            this.countryInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.tabGetInfoEthnical = new System.Windows.Forms.TabPage();
            this.tabAddLangInfo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlMain.SuspendLayout();
            this.tabIncrease.SuspendLayout();
            this.tabAverage.SuspendLayout();
            this.tabGetInfoCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryInfoDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // labelStatus
            // 
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.Name = "labelStatus";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabIncrease);
            this.tabControlMain.Controls.Add(this.tabAverage);
            this.tabControlMain.Controls.Add(this.tabGetInfoCountries);
            this.tabControlMain.Controls.Add(this.tabGetInfoEthnical);
            this.tabControlMain.Controls.Add(this.tabAddLangInfo);
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            // 
            // tabIncrease
            // 
            this.tabIncrease.Controls.Add(this.increaseResultTestBox);
            this.tabIncrease.Controls.Add(this.executeIncreaseQuery);
            resources.ApplyResources(this.tabIncrease, "tabIncrease");
            this.tabIncrease.Name = "tabIncrease";
            this.tabIncrease.UseVisualStyleBackColor = true;
            // 
            // increaseResultTestBox
            // 
            resources.ApplyResources(this.increaseResultTestBox, "increaseResultTestBox");
            this.increaseResultTestBox.Name = "increaseResultTestBox";
            // 
            // executeIncreaseQuery
            // 
            resources.ApplyResources(this.executeIncreaseQuery, "executeIncreaseQuery");
            this.executeIncreaseQuery.Name = "executeIncreaseQuery";
            this.executeIncreaseQuery.UseVisualStyleBackColor = true;
            this.executeIncreaseQuery.Click += new System.EventHandler(this.executeIncreaseQuery_Click);
            // 
            // tabAverage
            // 
            this.tabAverage.Controls.Add(this.executeAverageQuery);
            this.tabAverage.Controls.Add(this.avgTextBox);
            this.tabAverage.Controls.Add(this.label1);
            resources.ApplyResources(this.tabAverage, "tabAverage");
            this.tabAverage.Name = "tabAverage";
            this.tabAverage.UseVisualStyleBackColor = true;
            // 
            // executeAverageQuery
            // 
            resources.ApplyResources(this.executeAverageQuery, "executeAverageQuery");
            this.executeAverageQuery.Name = "executeAverageQuery";
            this.executeAverageQuery.UseVisualStyleBackColor = true;
            this.executeAverageQuery.Click += new System.EventHandler(this.executeAverageQuery_Click);
            // 
            // avgTextBox
            // 
            resources.ApplyResources(this.avgTextBox, "avgTextBox");
            this.avgTextBox.Name = "avgTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabGetInfoCountries
            // 
            this.tabGetInfoCountries.Controls.Add(this.getCountriesInfo);
            this.tabGetInfoCountries.Controls.Add(this.countryInfoDataGrid);
            resources.ApplyResources(this.tabGetInfoCountries, "tabGetInfoCountries");
            this.tabGetInfoCountries.Name = "tabGetInfoCountries";
            this.tabGetInfoCountries.UseVisualStyleBackColor = true;
            // 
            // getCountriesInfo
            // 
            resources.ApplyResources(this.getCountriesInfo, "getCountriesInfo");
            this.getCountriesInfo.Name = "getCountriesInfo";
            this.getCountriesInfo.UseVisualStyleBackColor = true;
            this.getCountriesInfo.Click += new System.EventHandler(this.getCountriesInfo_Click);
            // 
            // countryInfoDataGrid
            // 
            this.countryInfoDataGrid.AllowUserToAddRows = false;
            this.countryInfoDataGrid.AllowUserToDeleteRows = false;
            this.countryInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.countryInfoDataGrid, "countryInfoDataGrid");
            this.countryInfoDataGrid.Name = "countryInfoDataGrid";
            this.countryInfoDataGrid.ReadOnly = true;
            // 
            // tabGetInfoEthnical
            // 
            resources.ApplyResources(this.tabGetInfoEthnical, "tabGetInfoEthnical");
            this.tabGetInfoEthnical.Name = "tabGetInfoEthnical";
            this.tabGetInfoEthnical.UseVisualStyleBackColor = true;
            // 
            // tabAddLangInfo
            // 
            resources.ApplyResources(this.tabAddLangInfo, "tabAddLangInfo");
            this.tabAddLangInfo.Name = "tabAddLangInfo";
            this.tabAddLangInfo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.labelStatus);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabIncrease.ResumeLayout(false);
            this.tabIncrease.PerformLayout();
            this.tabAverage.ResumeLayout(false);
            this.tabAverage.PerformLayout();
            this.tabGetInfoCountries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countryInfoDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabIncrease;
        private System.Windows.Forms.Button executeIncreaseQuery;
        private System.Windows.Forms.TabPage tabAverage;
        private System.Windows.Forms.TabPage tabGetInfoCountries;
        private System.Windows.Forms.TabPage tabGetInfoEthnical;
        private System.Windows.Forms.TabPage tabAddLangInfo;
        private System.Windows.Forms.TextBox increaseResultTestBox;
        private System.Windows.Forms.Button executeAverageQuery;
        private System.Windows.Forms.TextBox avgTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView countryInfoDataGrid;
        private System.Windows.Forms.Button getCountriesInfo;
        private System.Windows.Forms.Panel panel1;
    }
}

