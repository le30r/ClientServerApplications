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
        string NOT_FOUND_ERROR = "Запрос не вернул результатов";
        string ADD_ERROR = "При добавлении возникла ошибка";
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

        private void executeIncreaseQuery_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL.INCREASE_ETHNICAL;
                int result = cmd.ExecuteNonQuery();
                increaseResultTestBox.Text = "Затронуто " + result.ToString() + " строк";
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
                avgTextBox.Text = cmd.ExecuteScalar().ToString() + " человек";
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

        private void executeEthical_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL.SELECT_ETHICAL;
                cmd.Parameters.AddWithValue("@language", languageBox.Text.ToString());
                cmd.Parameters.AddWithValue("@country", countryBox.Text.ToString());

                DataTable dataTable = new DataTable();
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                ethnicalGridView.DataSource = dataTable;
                if (ethnicalGridView.RowCount == 0) MessageBox.Show(this, NOT_FOUND_ERROR, ERROR);
            }
            else
            {
                MessageBox.Show(this, NO_CONNECTION_ERROR, ERROR);
            }
        }



        private void languageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                executeEthical_Click(sender, e);
            }
        }

        private void addLanguageButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL.ADD_NEW_LANGUAGE;
            cmd.Parameters.AddWithValue("@name", nameBox.Text.ToLower().ToString());
            cmd.Parameters.AddWithValue("@group", groupBox.Text.ToLower().ToString());
            cmd.Parameters.AddWithValue("@sign_system", signSystemBox.Text.ToLower().ToString());
            int result = 0;
            try { result = cmd.ExecuteNonQuery(); }
            catch { MessageBox.Show(this, ADD_ERROR, ERROR); }


            if (result != 0)
            {
                SqlCommand verifyCmd = conn.CreateCommand();
                verifyCmd.CommandText = SQL.CHECK_ADDED_LANGUAGE;
                verifyCmd.Parameters.AddWithValue("@name", nameBox.Text.ToLower().ToString());

                DataTable dataTable = new DataTable();
                dataTable.Load(verifyCmd.ExecuteReader());
                addResultGridView.DataSource = dataTable;
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
