using System.Windows.Forms;
using System.Data.SqlClient;
using System;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ConnectToSql()
        {
            SqlConnection conn = new SqlConnection();
            /* conn.ConnectionString = "Data Source=ws210-p;" +
                                     "Initial Catalog=Языки народов мира;" +
                                     "User ID=sa;" +
                                     "Password=evmsql";*/

            conn.ConnectionString = "Data Source=DESKTOP-8ER83ML\\SQLEXPRESS;Initial Catalog=Языки народов мира;Integrated Security=True";
            try
            {
                conn.Open();
                listBox1.Items.Add("Соединение открыто");
            }
            catch (SqlException e)
            {
                listBox1.Items.Add(e.StackTrace);
                MessageBox.Show(e.Message);
                foreach (SqlError err in e.Errors)
                {
                    listBox1.Items.Add("Сообщение: " + err.Message);
                    listBox1.Items.Add("Код ошибки: " + err.Number);
                }
            }
            finally
            {
                conn.Close();
                listBox1.Items.Add("Соединение закрыто");
            }

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ConnectToSql();
        }

       
    }
}

