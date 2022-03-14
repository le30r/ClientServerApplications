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
using System.Configuration;

namespace lab1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
       
        }

  
        private void btnRun_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.
            ConnectionStrings["Config"].ConnectionString;
            listBox1.Items.Add("Строка соединения: "
            + conn.ConnectionString);
            try
            {
                listBox1.Items.Add("Соединение открыто");
                conn.Open();
            }
            catch (SqlException ex)
            {
                listBox1.Items.Add("Ошибка соединения");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                listBox1.Items.Add("Соединение закрыто");
            }
        }
    }
}
