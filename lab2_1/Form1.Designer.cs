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
            this.btnConnect = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabIncrease = new System.Windows.Forms.TabPage();
            this.tabAverage = new System.Windows.Forms.TabPage();
            this.tabGetInfoCountries = new System.Windows.Forms.TabPage();
            this.tabGetInfoEthnical = new System.Windows.Forms.TabPage();
            this.tabAddLangInfo = new System.Windows.Forms.TabPage();
            this.executeIncreaseQuery = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabIncrease.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(13, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(136, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Подключиться";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(155, 18);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 13);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Статус: ";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabIncrease);
            this.tabControlMain.Controls.Add(this.tabAverage);
            this.tabControlMain.Controls.Add(this.tabGetInfoCountries);
            this.tabControlMain.Controls.Add(this.tabGetInfoEthnical);
            this.tabControlMain.Controls.Add(this.tabAddLangInfo);
            this.tabControlMain.Location = new System.Drawing.Point(13, 61);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(452, 305);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabIncrease
            // 
            this.tabIncrease.Controls.Add(this.textBox1);
            this.tabIncrease.Controls.Add(this.executeIncreaseQuery);
            this.tabIncrease.Location = new System.Drawing.Point(4, 22);
            this.tabIncrease.Name = "tabIncrease";
            this.tabIncrease.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncrease.Size = new System.Drawing.Size(444, 279);
            this.tabIncrease.TabIndex = 0;
            this.tabIncrease.Text = "Увеличение этнического состава";
            this.tabIncrease.UseVisualStyleBackColor = true;
            // 
            // tabAverage
            // 
            this.tabAverage.Location = new System.Drawing.Point(4, 22);
            this.tabAverage.Name = "tabAverage";
            this.tabAverage.Padding = new System.Windows.Forms.Padding(3);
            this.tabAverage.Size = new System.Drawing.Size(585, 279);
            this.tabAverage.TabIndex = 1;
            this.tabAverage.Text = "Вывод средней численности";
            this.tabAverage.UseVisualStyleBackColor = true;
            // 
            // tabGetInfoCountries
            // 
            this.tabGetInfoCountries.Location = new System.Drawing.Point(4, 22);
            this.tabGetInfoCountries.Name = "tabGetInfoCountries";
            this.tabGetInfoCountries.Size = new System.Drawing.Size(444, 279);
            this.tabGetInfoCountries.TabIndex = 2;
            this.tabGetInfoCountries.Text = "Проверка информации о странах";
            this.tabGetInfoCountries.UseVisualStyleBackColor = true;
            // 
            // tabGetInfoEthnical
            // 
            this.tabGetInfoEthnical.Location = new System.Drawing.Point(4, 22);
            this.tabGetInfoEthnical.Name = "tabGetInfoEthnical";
            this.tabGetInfoEthnical.Size = new System.Drawing.Size(444, 279);
            this.tabGetInfoEthnical.TabIndex = 3;
            this.tabGetInfoEthnical.Text = "Проверка информации об этническом составе";
            this.tabGetInfoEthnical.UseVisualStyleBackColor = true;
            // 
            // tabAddLangInfo
            // 
            this.tabAddLangInfo.Location = new System.Drawing.Point(4, 22);
            this.tabAddLangInfo.Name = "tabAddLangInfo";
            this.tabAddLangInfo.Size = new System.Drawing.Size(585, 279);
            this.tabAddLangInfo.TabIndex = 4;
            this.tabAddLangInfo.Text = "Добавить информацию о новом языке";
            this.tabAddLangInfo.UseVisualStyleBackColor = true;
            // 
            // executeIncreaseQuery
            // 
            this.executeIncreaseQuery.Location = new System.Drawing.Point(306, 89);
            this.executeIncreaseQuery.Name = "executeIncreaseQuery";
            this.executeIncreaseQuery.Size = new System.Drawing.Size(131, 27);
            this.executeIncreaseQuery.TabIndex = 0;
            this.executeIncreaseQuery.Text = "Выполнить запрос";
            this.executeIncreaseQuery.UseVisualStyleBackColor = true;
            this.executeIncreaseQuery.Click += new System.EventHandler(this.executeIncreaseQuery_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 378);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "База данных \"Языки народов мира\"";
            this.tabControlMain.ResumeLayout(false);
            this.tabIncrease.ResumeLayout(false);
            this.tabIncrease.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
    }
}

