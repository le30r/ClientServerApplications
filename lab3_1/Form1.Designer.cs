namespace lab3_1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reduceButton = new System.Windows.Forms.Button();
            this.reduceResultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.continentTextBox = new System.Windows.Forms.TextBox();
            this.capitalTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.addCountryButton = new System.Windows.Forms.Button();
            this.countryAddResultDataGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryAddResultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Подключение";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(113, 13);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 13);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Статус: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 343);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reduceResultBox);
            this.tabPage1.Controls.Add(this.reduceButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Уменьшить число жителей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.countryAddResultDataGrid);
            this.tabPage2.Controls.Add(this.addCountryButton);
            this.tabPage2.Controls.Add(this.numberTextBox);
            this.tabPage2.Controls.Add(this.capitalTextBox);
            this.tabPage2.Controls.Add(this.continentTextBox);
            this.tabPage2.Controls.Add(this.nameTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить новую страну";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(544, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удалить язык";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(544, 271);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удалить этнический состав";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(544, 271);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Суммарная численность";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reduceButton
            // 
            this.reduceButton.Location = new System.Drawing.Point(409, 150);
            this.reduceButton.Name = "reduceButton";
            this.reduceButton.Size = new System.Drawing.Size(129, 23);
            this.reduceButton.TabIndex = 0;
            this.reduceButton.Text = "Выполнить запрос";
            this.reduceButton.UseVisualStyleBackColor = true;
            this.reduceButton.Click += new System.EventHandler(this.reduceButton_Click);
            // 
            // reduceResultBox
            // 
            this.reduceResultBox.Location = new System.Drawing.Point(6, 124);
            this.reduceResultBox.Name = "reduceResultBox";
            this.reduceResultBox.ReadOnly = true;
            this.reduceResultBox.Size = new System.Drawing.Size(532, 20);
            this.reduceResultBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название страны";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Материк";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Столица";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Численность населения";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(195, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // continentTextBox
            // 
            this.continentTextBox.Location = new System.Drawing.Point(195, 62);
            this.continentTextBox.Name = "continentTextBox";
            this.continentTextBox.Size = new System.Drawing.Size(155, 20);
            this.continentTextBox.TabIndex = 5;
            // 
            // capitalTextBox
            // 
            this.capitalTextBox.Location = new System.Drawing.Point(195, 89);
            this.capitalTextBox.Name = "capitalTextBox";
            this.capitalTextBox.Size = new System.Drawing.Size(155, 20);
            this.capitalTextBox.TabIndex = 6;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(195, 119);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(155, 20);
            this.numberTextBox.TabIndex = 7;
            // 
            // addCountryButton
            // 
            this.addCountryButton.Location = new System.Drawing.Point(275, 145);
            this.addCountryButton.Name = "addCountryButton";
            this.addCountryButton.Size = new System.Drawing.Size(75, 23);
            this.addCountryButton.TabIndex = 8;
            this.addCountryButton.Text = "Добавить";
            this.addCountryButton.UseVisualStyleBackColor = true;
            this.addCountryButton.Click += new System.EventHandler(this.addCountryButton_Click);
            // 
            // countryAddResultDataGrid
            // 
            this.countryAddResultDataGrid.AllowUserToAddRows = false;
            this.countryAddResultDataGrid.AllowUserToDeleteRows = false;
            this.countryAddResultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryAddResultDataGrid.Location = new System.Drawing.Point(3, 193);
            this.countryAddResultDataGrid.Name = "countryAddResultDataGrid";
            this.countryAddResultDataGrid.ReadOnly = true;
            this.countryAddResultDataGrid.Size = new System.Drawing.Size(541, 124);
            this.countryAddResultDataGrid.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 392);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryAddResultDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox reduceResultBox;
        private System.Windows.Forms.Button reduceButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button addCountryButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox capitalTextBox;
        private System.Windows.Forms.TextBox continentTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView countryAddResultDataGrid;
    }
}

