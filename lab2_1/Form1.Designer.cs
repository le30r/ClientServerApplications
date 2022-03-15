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
            this.ethnicalGridView = new System.Windows.Forms.DataGridView();
            this.executeEthical = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.languageBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.tabAddLangInfo = new System.Windows.Forms.TabPage();
            this.addResultGridView = new System.Windows.Forms.DataGridView();
            this.addLanguageButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.signSystemBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlMain.SuspendLayout();
            this.tabIncrease.SuspendLayout();
            this.tabAverage.SuspendLayout();
            this.tabGetInfoCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryInfoDataGrid)).BeginInit();
            this.tabGetInfoEthnical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ethnicalGridView)).BeginInit();
            this.tabAddLangInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addResultGridView)).BeginInit();
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
            this.tabGetInfoEthnical.Controls.Add(this.ethnicalGridView);
            this.tabGetInfoEthnical.Controls.Add(this.executeEthical);
            this.tabGetInfoEthnical.Controls.Add(this.label3);
            this.tabGetInfoEthnical.Controls.Add(this.label2);
            this.tabGetInfoEthnical.Controls.Add(this.languageBox);
            this.tabGetInfoEthnical.Controls.Add(this.countryBox);
            resources.ApplyResources(this.tabGetInfoEthnical, "tabGetInfoEthnical");
            this.tabGetInfoEthnical.Name = "tabGetInfoEthnical";
            this.tabGetInfoEthnical.UseVisualStyleBackColor = true;
            // 
            // ethnicalGridView
            // 
            this.ethnicalGridView.AllowUserToAddRows = false;
            this.ethnicalGridView.AllowUserToDeleteRows = false;
            this.ethnicalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.ethnicalGridView, "ethnicalGridView");
            this.ethnicalGridView.Name = "ethnicalGridView";
            this.ethnicalGridView.ReadOnly = true;
            // 
            // executeEthical
            // 
            resources.ApplyResources(this.executeEthical, "executeEthical");
            this.executeEthical.Name = "executeEthical";
            this.executeEthical.UseVisualStyleBackColor = true;
            this.executeEthical.Click += new System.EventHandler(this.executeEthical_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // languageBox
            // 
            resources.ApplyResources(this.languageBox, "languageBox");
            this.languageBox.Name = "languageBox";
            this.languageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.languageBox_KeyDown);
            // 
            // countryBox
            // 
            resources.ApplyResources(this.countryBox, "countryBox");
            this.countryBox.Name = "countryBox";
            // 
            // tabAddLangInfo
            // 
            this.tabAddLangInfo.Controls.Add(this.addResultGridView);
            this.tabAddLangInfo.Controls.Add(this.addLanguageButton);
            this.tabAddLangInfo.Controls.Add(this.label6);
            this.tabAddLangInfo.Controls.Add(this.signSystemBox);
            this.tabAddLangInfo.Controls.Add(this.groupBox);
            this.tabAddLangInfo.Controls.Add(this.label5);
            this.tabAddLangInfo.Controls.Add(this.label4);
            this.tabAddLangInfo.Controls.Add(this.nameBox);
            resources.ApplyResources(this.tabAddLangInfo, "tabAddLangInfo");
            this.tabAddLangInfo.Name = "tabAddLangInfo";
            this.tabAddLangInfo.UseVisualStyleBackColor = true;
            // 
            // addResultGridView
            // 
            this.addResultGridView.AllowUserToAddRows = false;
            this.addResultGridView.AllowUserToDeleteRows = false;
            this.addResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.addResultGridView, "addResultGridView");
            this.addResultGridView.Name = "addResultGridView";
            this.addResultGridView.ReadOnly = true;
            // 
            // addLanguageButton
            // 
            resources.ApplyResources(this.addLanguageButton, "addLanguageButton");
            this.addLanguageButton.Name = "addLanguageButton";
            this.addLanguageButton.UseVisualStyleBackColor = true;
            this.addLanguageButton.Click += new System.EventHandler(this.addLanguageButton_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // signSystemBox
            // 
            resources.ApplyResources(this.signSystemBox, "signSystemBox");
            this.signSystemBox.Name = "signSystemBox";
            // 
            // groupBox
            // 
            resources.ApplyResources(this.groupBox, "groupBox");
            this.groupBox.Name = "groupBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // nameBox
            // 
            resources.ApplyResources(this.nameBox, "nameBox");
            this.nameBox.Name = "nameBox";
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControlMain.ResumeLayout(false);
            this.tabIncrease.ResumeLayout(false);
            this.tabIncrease.PerformLayout();
            this.tabAverage.ResumeLayout(false);
            this.tabAverage.PerformLayout();
            this.tabGetInfoCountries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countryInfoDataGrid)).EndInit();
            this.tabGetInfoEthnical.ResumeLayout(false);
            this.tabGetInfoEthnical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ethnicalGridView)).EndInit();
            this.tabAddLangInfo.ResumeLayout(false);
            this.tabAddLangInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addResultGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView ethnicalGridView;
        private System.Windows.Forms.Button executeEthical;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox languageBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addLanguageButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox signSystemBox;
        private System.Windows.Forms.TextBox groupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView addResultGridView;
    }
}

