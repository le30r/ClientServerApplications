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

namespace lab2_1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        /* string connstring = "Data Source=ws210-p;" +
                                     "Initial Catalog=Языки народов мира;" +
                                     "User ID=sa;" +
                                     "Password=evmsql";
        */

        string connstring = "Data Source=DESKTOP-8ER83ML\\SQLEXPRESS;Initial Catalog=Языки народов мира;Integrated Security=True";

        string NO_CONNECTION_ERROR = "Для выполнения запроса необходимо подключиться к базе данных";
        string ERROR = "Error";

        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = connstring;
        }


        private void btnConnect_Click(object sender, EventArgs e)
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
            } else
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

        private void executeIncreaseQuery_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL.INCREASE_ETHNICAL;
                int result = cmd.ExecuteNonQuery();
                increaseResultTestBox.Text = result.ToString();
            } 
            else
            {
                MessageBox.Show(this, NO_CONNECTION_ERROR, ERROR);
            }
        }

        private void executeAverageQuery_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL.GET_AVERAGE;
                avgTextBox.Text = cmd.ExecuteScalar().ToString();
            }
            else
            {
                MessageBox.Show(this, NO_CONNECTION_ERROR, ERROR);
            }
        }

        private void getCountriesInfo_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL.SELECT_COUNTRIES;
                DataTable dataTable = new DataTable();
                dataTable.Load(cmd.ExecuteReader());
                countryInfoDataGrid.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show(this, NO_CONNECTION_ERROR, ERROR);
            }
        }

        
    }
}
