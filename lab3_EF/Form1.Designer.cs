namespace lab3_EF
{
    partial class Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.staticResultTextBox = new System.Windows.Forms.TextBox();
            this.staticQueryBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ethnicalButton = new System.Windows.Forms.Button();
            this.ethnicalResultTextBox = new System.Windows.Forms.TextBox();
            this.languagesResultTextBox = new System.Windows.Forms.TextBox();
            this.langButton = new System.Windows.Forms.Button();
            this.langNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.staticQueryBtn);
            this.tabPage1.Controls.Add(this.staticResultTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Статический запрос";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ethnicalResultTextBox);
            this.tabPage2.Controls.Add(this.ethnicalButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.languageTextBox);
            this.tabPage2.Controls.Add(this.countryTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Параметрический запрос. Этнический состав";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // staticResultTextBox
            // 
            this.staticResultTextBox.Location = new System.Drawing.Point(5, 43);
            this.staticResultTextBox.Multiline = true;
            this.staticResultTextBox.Name = "staticResultTextBox";
            this.staticResultTextBox.Size = new System.Drawing.Size(755, 82);
            this.staticResultTextBox.TabIndex = 0;
            // 
            // staticQueryBtn
            // 
            this.staticQueryBtn.Location = new System.Drawing.Point(685, 131);
            this.staticQueryBtn.Name = "staticQueryBtn";
            this.staticQueryBtn.Size = new System.Drawing.Size(75, 23);
            this.staticQueryBtn.TabIndex = 1;
            this.staticQueryBtn.Text = "Выполнить";
            this.staticQueryBtn.UseVisualStyleBackColor = true;
            this.staticQueryBtn.Click += new System.EventHandler(this.staticQueryBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.nameLabel);
            this.tabPage3.Controls.Add(this.langNameTextBox);
            this.tabPage3.Controls.Add(this.languagesResultTextBox);
            this.tabPage3.Controls.Add(this.langButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(767, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Параметрический запрос. Языки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(112, 44);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(180, 20);
            this.countryTextBox.TabIndex = 0;
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(112, 70);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(180, 20);
            this.languageTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Страна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Язык";
            // 
            // ethnicalButton
            // 
            this.ethnicalButton.Location = new System.Drawing.Point(217, 96);
            this.ethnicalButton.Name = "ethnicalButton";
            this.ethnicalButton.Size = new System.Drawing.Size(75, 23);
            this.ethnicalButton.TabIndex = 4;
            this.ethnicalButton.Text = "Выполнить";
            this.ethnicalButton.UseVisualStyleBackColor = true;
            this.ethnicalButton.Click += new System.EventHandler(this.ethnicalButton_Click);
            // 
            // ethnicalResultTextBox
            // 
            this.ethnicalResultTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ethnicalResultTextBox.Location = new System.Drawing.Point(3, 226);
            this.ethnicalResultTextBox.Multiline = true;
            this.ethnicalResultTextBox.Name = "ethnicalResultTextBox";
            this.ethnicalResultTextBox.Size = new System.Drawing.Size(761, 170);
            this.ethnicalResultTextBox.TabIndex = 5;
            // 
            // languagesResultTextBox
            // 
            this.languagesResultTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.languagesResultTextBox.Location = new System.Drawing.Point(0, 229);
            this.languagesResultTextBox.Multiline = true;
            this.languagesResultTextBox.Name = "languagesResultTextBox";
            this.languagesResultTextBox.Size = new System.Drawing.Size(767, 170);
            this.languagesResultTextBox.TabIndex = 7;
            // 
            // langButton
            // 
            this.langButton.Location = new System.Drawing.Point(221, 105);
            this.langButton.Name = "langButton";
            this.langButton.Size = new System.Drawing.Size(75, 23);
            this.langButton.TabIndex = 6;
            this.langButton.Text = "Выполнить";
            this.langButton.UseVisualStyleBackColor = true;
            this.langButton.Click += new System.EventHandler(this.langButton_Click);
            // 
            // langNameTextBox
            // 
            this.langNameTextBox.Location = new System.Drawing.Point(177, 79);
            this.langNameTextBox.Name = "langNameTextBox";
            this.langNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.langNameTextBox.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(79, 82);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(92, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Название языка";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form";
            this.Text = "EntityFramework";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button staticQueryBtn;
        private System.Windows.Forms.TextBox staticResultTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ethnicalButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox ethnicalResultTextBox;
        private System.Windows.Forms.TextBox langNameTextBox;
        private System.Windows.Forms.TextBox languagesResultTextBox;
        private System.Windows.Forms.Button langButton;
        private System.Windows.Forms.Label nameLabel;
    }
}

