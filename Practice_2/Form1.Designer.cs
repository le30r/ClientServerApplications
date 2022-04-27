namespace Practice_2
{
    partial class MainForm
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
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.ManRadio = new System.Windows.Forms.RadioButton();
            this.WomanRadio = new System.Windows.Forms.RadioButton();
            this.MariageStatusBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.LastNameTextBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(120, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(12, 64);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.MiddleNameTextBox.TabIndex = 2;
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(12, 90);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(177, 20);
            this.birthdayPicker.TabIndex = 3;
            // 
            // ManRadio
            // 
            this.ManRadio.AutoSize = true;
            this.ManRadio.Location = new System.Drawing.Point(12, 116);
            this.ManRadio.Name = "ManRadio";
            this.ManRadio.Size = new System.Drawing.Size(71, 17);
            this.ManRadio.TabIndex = 4;
            this.ManRadio.TabStop = true;
            this.ManRadio.Text = "Мужской";
            this.ManRadio.UseVisualStyleBackColor = true;
            this.ManRadio.CheckedChanged += new System.EventHandler(this.ManRadio_CheckedChanged);
            // 
            // WomanRadio
            // 
            this.WomanRadio.AutoSize = true;
            this.WomanRadio.Location = new System.Drawing.Point(104, 116);
            this.WomanRadio.Name = "WomanRadio";
            this.WomanRadio.Size = new System.Drawing.Size(72, 17);
            this.WomanRadio.TabIndex = 5;
            this.WomanRadio.TabStop = true;
            this.WomanRadio.Text = "Женский";
            this.WomanRadio.UseVisualStyleBackColor = true;
            this.WomanRadio.CheckedChanged += new System.EventHandler(this.WomanRadio_CheckedChanged);
            // 
            // MariageStatusBox
            // 
            this.MariageStatusBox.FormattingEnabled = true;
            this.MariageStatusBox.Items.AddRange(new object[] {
            "Женат",
            "Не женат"});
            this.MariageStatusBox.Location = new System.Drawing.Point(12, 139);
            this.MariageStatusBox.Name = "MariageStatusBox";
            this.MariageStatusBox.Size = new System.Drawing.Size(177, 21);
            this.MariageStatusBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(12, 166);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(177, 23);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Внести данные";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 207);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MariageStatusBox);
            this.Controls.Add(this.WomanRadio);
            this.Controls.Add(this.ManRadio);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.RadioButton ManRadio;
        private System.Windows.Forms.RadioButton WomanRadio;
        private System.Windows.Forms.ComboBox MariageStatusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SubmitButton;
    }
}

