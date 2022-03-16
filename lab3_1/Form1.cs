using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab3_1
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection();
        string connstring = "Data Source=ws210-p;" +
                                     "Initial Catalog=Языки народов мира;" +
                                     "User ID=sa;" +
                                     "Password=evmsql";

        // string connstring = "Data Source=DESKTOP-8ER83ML\\SQLEXPRESS;Initial Catalog=Языки народов мира;Integrated Security=True";
        SqlCommand reduceCmd;
        SqlCommand addNewCountryCmd;

        string NO_CONNECTION_ERROR = "Для выполнения запроса необходимо подключиться к базе данных";
        string NOT_FOUND_ERROR = "Запрос не вернул результатов";
        string ADD_ERROR = "При добавлении возникла ошибка";
        string ERROR = "Error";

        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = connstring;
            createNonQueries();

        }

        public void createNonQueries()
        {
            reduceCmd = conn.CreateCommand();
            reduceCmd.CommandType = CommandType.StoredProcedure;
            reduceCmd.CommandText = "ReducePopulation";

            addNewCountryCmd = conn.CreateCommand();
            addNewCountryCmd.CommandType = CommandType.StoredProcedure;
            addNewCountryCmd.CommandText = SQL.ADD_COUNTRY;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    labelStatus.Text = "Статус: подключено";
                    labelStatus.ForeColor = Color.Green;
                    btnConnect.Text = "Отключиться";
                }
                catch (SqlException ex)
                {
                    conn.Close();
                    labelStatus.Text = "Статус: ошибка " + ex.Message;
                    labelStatus.ForeColor = Color.OrangeRed;
                    btnConnect.Text = "Подключиться";
                }
            }
            else
            {
                try
                {
                    conn.Close();
                    labelStatus.Text = "Статус: отключено";
                    labelStatus.ForeColor = Color.Red;
                    btnConnect.Text = "Подключиться";
                }
                catch (SqlException ex)
                {
                    conn.Close();
                    labelStatus.Text = "Статус: ошибка " + ex.Message;
                    labelStatus.ForeColor = Color.OrangeRed;
                    btnConnect.Text = "Подключиться";
                }
            }
        }

        private void reduceButton_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                int result = reduceCmd.ExecuteNonQuery();
                reduceResultBox.Text = "Изменено " + result + " строк";
            }
            else
            {
                MessageBox.Show(this, NO_CONNECTION_ERROR, ERROR);
            }
        }

        private void addCountryButton_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                addNewCountryCmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                addNewCountryCmd.Parameters.AddWithValue("@continent", continentTextBox.Text);
                addNewCountryCmd.Parameters.AddWithValue("@capital", capitalTextBox.Text);
                addNewCountryCmd.Parameters.AddWithValue("@number", numberTextBox.Text);

                addNewCountryCmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show(this, NO_CONNECTION_ERROR, ERROR);
            }
        }
    }
}
