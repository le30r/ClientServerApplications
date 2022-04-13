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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConnect = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reduceResultBox = new System.Windows.Forms.TextBox();
            this.reduceButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.countryAddResultDataGrid = new System.Windows.Forms.DataGridView();
            this.addCountryButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.capitalTextBox = new System.Windows.Forms.TextBox();
            this.continentTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.deleteEthnicalResult = new System.Windows.Forms.TextBox();
            this.btnDeleteEthnical = new System.Windows.Forms.Button();
            this.language = new System.Windows.Forms.Label();
            this.countryName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteResultBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.delLangTextBox = new System.Windows.Forms.TextBox();
            this.delLangButton = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.sumCountResultBox = new System.Windows.Forms.TextBox();
            this.countryNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sumCountButton = new System.Windows.Forms.Button();
            this.radioHome = new System.Windows.Forms.RadioButton();
            this.radioRsreu = new System.Windows.Forms.RadioButton();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataSet11 = new lab3_1.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryAddResultDataGrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage6);
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
            this.tabPage1.Size = new System.Drawing.Size(544, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Уменьшить число жителей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reduceResultBox
            // 
            this.reduceResultBox.Location = new System.Drawing.Point(6, 124);
            this.reduceResultBox.Name = "reduceResultBox";
            this.reduceResultBox.ReadOnly = true;
            this.reduceResultBox.Size = new System.Drawing.Size(532, 20);
            this.reduceResultBox.TabIndex = 1;
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
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(195, 119);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(155, 20);
            this.numberTextBox.TabIndex = 7;
            // 
            // capitalTextBox
            // 
            this.capitalTextBox.Location = new System.Drawing.Point(195, 89);
            this.capitalTextBox.Name = "capitalTextBox";
            this.capitalTextBox.Size = new System.Drawing.Size(155, 20);
            this.capitalTextBox.TabIndex = 6;
            // 
            // continentTextBox
            // 
            this.continentTextBox.Location = new System.Drawing.Point(195, 62);
            this.continentTextBox.Name = "continentTextBox";
            this.continentTextBox.Size = new System.Drawing.Size(155, 20);
            this.continentTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(195, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 20);
            this.nameTextBox.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Столица";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название страны";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.deleteEthnicalResult);
            this.tabPage4.Controls.Add(this.btnDeleteEthnical);
            this.tabPage4.Controls.Add(this.language);
            this.tabPage4.Controls.Add(this.countryName);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(544, 317);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удалить этнический состав";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // deleteEthnicalResult
            // 
            this.deleteEthnicalResult.Location = new System.Drawing.Point(4, 130);
            this.deleteEthnicalResult.Name = "deleteEthnicalResult";
            this.deleteEthnicalResult.ReadOnly = true;
            this.deleteEthnicalResult.Size = new System.Drawing.Size(537, 20);
            this.deleteEthnicalResult.TabIndex = 5;
            // 
            // btnDeleteEthnical
            // 
            this.btnDeleteEthnical.Location = new System.Drawing.Point(188, 80);
            this.btnDeleteEthnical.Name = "btnDeleteEthnical";
            this.btnDeleteEthnical.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEthnical.TabIndex = 4;
            this.btnDeleteEthnical.Text = "Удалить";
            this.btnDeleteEthnical.UseVisualStyleBackColor = true;
            this.btnDeleteEthnical.Click += new System.EventHandler(this.btnDeleteEthnical_Click);
            // 
            // language
            // 
            this.language.AutoSize = true;
            this.language.Location = new System.Drawing.Point(45, 57);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(35, 13);
            this.language.TabIndex = 3;
            this.language.Text = "Язык";
            // 
            // countryName
            // 
            this.countryName.AutoSize = true;
            this.countryName.Location = new System.Drawing.Point(37, 31);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(43, 13);
            this.countryName.TabIndex = 2;
            this.countryName.Text = "Страна";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteResultBox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.delLangTextBox);
            this.tabPage3.Controls.Add(this.delLangButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(544, 317);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удалить язык";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteResultBox
            // 
            this.deleteResultBox.Location = new System.Drawing.Point(4, 109);
            this.deleteResultBox.Name = "deleteResultBox";
            this.deleteResultBox.ReadOnly = true;
            this.deleteResultBox.Size = new System.Drawing.Size(537, 20);
            this.deleteResultBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Название";
            // 
            // delLangTextBox
            // 
            this.delLangTextBox.Location = new System.Drawing.Point(122, 45);
            this.delLangTextBox.Name = "delLangTextBox";
            this.delLangTextBox.Size = new System.Drawing.Size(160, 20);
            this.delLangTextBox.TabIndex = 1;
            // 
            // delLangButton
            // 
            this.delLangButton.Location = new System.Drawing.Point(288, 43);
            this.delLangButton.Name = "delLangButton";
            this.delLangButton.Size = new System.Drawing.Size(75, 23);
            this.delLangButton.TabIndex = 0;
            this.delLangButton.Text = "Удалить";
            this.delLangButton.UseVisualStyleBackColor = true;
            this.delLangButton.Click += new System.EventHandler(this.delLangButton_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.sumCountResultBox);
            this.tabPage5.Controls.Add(this.countryNameBox);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.sumCountButton);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(544, 317);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Суммарная численность";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // sumCountResultBox
            // 
            this.sumCountResultBox.Location = new System.Drawing.Point(4, 157);
            this.sumCountResultBox.Name = "sumCountResultBox";
            this.sumCountResultBox.ReadOnly = true;
            this.sumCountResultBox.Size = new System.Drawing.Size(537, 20);
            this.sumCountResultBox.TabIndex = 3;
            // 
            // countryNameBox
            // 
            this.countryNameBox.Location = new System.Drawing.Point(123, 87);
            this.countryNameBox.Name = "countryNameBox";
            this.countryNameBox.Size = new System.Drawing.Size(199, 20);
            this.countryNameBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Название страны";
            // 
            // sumCountButton
            // 
            this.sumCountButton.Location = new System.Drawing.Point(328, 85);
            this.sumCountButton.Name = "sumCountButton";
            this.sumCountButton.Size = new System.Drawing.Size(158, 23);
            this.sumCountButton.TabIndex = 0;
            this.sumCountButton.Text = "Получить численность";
            this.sumCountButton.UseVisualStyleBackColor = true;
            this.sumCountButton.Click += new System.EventHandler(this.sumCountButton_Click);
            // 
            // radioHome
            // 
            this.radioHome.AutoSize = true;
            this.radioHome.Location = new System.Drawing.Point(441, 8);
            this.radioHome.Name = "radioHome";
            this.radioHome.Size = new System.Drawing.Size(53, 17);
            this.radioHome.TabIndex = 3;
            this.radioHome.TabStop = true;
            this.radioHome.Text = "Home";
            this.radioHome.UseVisualStyleBackColor = true;
            this.radioHome.CheckedChanged += new System.EventHandler(this.radioHome_CheckedChanged);
            // 
            // radioRsreu
            // 
            this.radioRsreu.AutoSize = true;
            this.radioRsreu.Location = new System.Drawing.Point(500, 8);
            this.radioRsreu.Name = "radioRsreu";
            this.radioRsreu.Size = new System.Drawing.Size(60, 17);
            this.radioRsreu.TabIndex = 4;
            this.radioRsreu.TabStop = true;
            this.radioRsreu.Text = "РГРТУ";
            this.radioRsreu.UseVisualStyleBackColor = true;
            this.radioRsreu.CheckedChanged += new System.EventHandler(this.radioRsreu_CheckedChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(544, 317);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Disconnect";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT * FROM Языки";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Код", System.Data.SqlDbType.Int, 0, "Код"),
            new System.Data.SqlClient.SqlParameter("@Название", System.Data.SqlDbType.NChar, 0, "Название"),
            new System.Data.SqlClient.SqlParameter("@Языковая_группа", System.Data.SqlDbType.NChar, 0, "Языковая группа"),
            new System.Data.SqlClient.SqlParameter("@Вид_знаковой_системы", System.Data.SqlDbType.NChar, 0, "Вид знаковой системы")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Код", System.Data.SqlDbType.Int, 0, "Код"),
            new System.Data.SqlClient.SqlParameter("@Название", System.Data.SqlDbType.NChar, 0, "Название"),
            new System.Data.SqlClient.SqlParameter("@Языковая_группа", System.Data.SqlDbType.NChar, 0, "Языковая группа"),
            new System.Data.SqlClient.SqlParameter("@Вид_знаковой_системы", System.Data.SqlDbType.NChar, 0, "Вид знаковой системы"),
            new System.Data.SqlClient.SqlParameter("@Original_Код", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Код", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Название", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Название", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Языковая_группа", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Языковая группа", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Языковая_группа", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Языковая группа", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Вид_знаковой_системы", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Вид знаковой системы", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Вид_знаковой_системы", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Вид знаковой системы", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Код", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Код", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Название", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Название", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Языковая_группа", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Языковая группа", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Языковая_группа", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Языковая группа", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Вид_знаковой_системы", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Вид знаковой системы", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Вид_знаковой_системы", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Вид знаковой системы", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Языки", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Код", "Код"),
                        new System.Data.Common.DataColumnMapping("Название", "Название"),
                        new System.Data.Common.DataColumnMapping("Языковая группа", "Языковая группа"),
                        new System.Data.Common.DataColumnMapping("Вид знаковой системы", "Вид знаковой системы")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ws210-p;Initial Catalog=\"Языки народов мира\";Persist Security Info=Tr" +
    "ue;User ID=sa;Password=evmsql";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 392);
            this.Controls.Add(this.radioRsreu);
            this.Controls.Add(this.radioHome);
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.RadioButton radioHome;
        private System.Windows.Forms.RadioButton radioRsreu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label countryName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label language;
        private System.Windows.Forms.Button btnDeleteEthnical;
        private System.Windows.Forms.TextBox deleteEthnicalResult;
        private System.Windows.Forms.TextBox deleteResultBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox delLangTextBox;
        private System.Windows.Forms.Button delLangButton;
        private System.Windows.Forms.TextBox sumCountResultBox;
        private System.Windows.Forms.TextBox countryNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sumCountButton;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet11;
    }
}

