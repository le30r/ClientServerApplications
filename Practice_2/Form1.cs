using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            birthdayPicker.MinDate = DateTime.Now.AddYears(-100);
            birthdayPicker.MaxDate = DateTime.Now;
            MariageStatusBox.Enabled = false;
        }


        private void ManRadio_CheckedChanged(object sender, EventArgs e)
        {
            MariageStatusBox.Enabled = true;
            MariageStatusBox.Items.Clear();
            MariageStatusBox.Items.Add("");
            MariageStatusBox.Items.Add("Женат");
            MariageStatusBox.Items.Add("Не женат");
            MariageStatusBox.SelectedIndex = 0;
        }

        private void WomanRadio_CheckedChanged(object sender, EventArgs e)
        {
            MariageStatusBox.Enabled = true;
            MariageStatusBox.Items.Clear();
            MariageStatusBox.Items.Add("");
            MariageStatusBox.Items.Add("Замужем");
            MariageStatusBox.Items.Add("Не замужем");
            MariageStatusBox.SelectedIndex = 0;
        }

        public bool CheckForm()
        {
            bool isNameAndLastNameFilled = !string.IsNullOrWhiteSpace(NameTextBox.Text) && !string.IsNullOrWhiteSpace(LastNameTextBox.Text);
            bool isManOrWomanPicked = ManRadio.Checked || WomanRadio.Checked;
            bool isMariageStatusPicked = MariageStatusBox.SelectedIndex > 0;

            return isNameAndLastNameFilled && isManOrWomanPicked && isMariageStatusPicked;
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Gender gender = ManRadio.Checked ? Gender.MAN : Gender.WOMAN;
                bool marriageStatus = MariageStatusBox.SelectedIndex == 1;
                Person person = new Person(NameTextBox.Text, MiddleNameTextBox.Text, LastNameTextBox.Text, birthdayPicker.Value, gender, marriageStatus);
                PersonHandler.AddPersonToFile(person);
            }
            else
            {
                MessageBox.Show("Вы не ввели или не выбрали все поля");
            }
        }
        
    }
}
