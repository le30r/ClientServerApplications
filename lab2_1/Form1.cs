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
        string connstring = "Data Source=ws210-p;" +
                                    "Initial Catalog=Языки народов мира;" +
                                    "User ID=sa;" +
                                    "Password=evmsql";


        string x = "UPDATE ";

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
                    labelStatus.ForeColor = Color.Yellow;
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
                    labelStatus.ForeColor = Color.White;
                    btnConnect.Text = "Подключиться";
                }
            }
        }

        private void executeIncreaseQuery_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE ";
        }
    }
}
