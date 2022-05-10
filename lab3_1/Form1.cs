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
using System.Data.Common;

namespace lab3_1
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection();

        string connRSREU = "Data Source=ws210-p;" +
                           "Initial Catalog=Языки народов мира;" +
                           "User ID=sa;" +
                           "Password=evmsql";

        string connHome =
            "Data Source=DESKTOP-3SQA61C\\SQLEXPRESS;Initial Catalog=Языки народов мира;Integrated Security=True";

        SqlCommand reduceCmd;
        SqlCommand addNewCountryCmd;
        SqlCommand deleteEthicalCmd;
        SqlCommand deleteLangCmd;
        SqlCommand getSumCountCmd;

        string NO_CONNECTION_ERROR = "Для выполнения запроса необходимо подключиться к базе данных";
        string NOT_FOUND_ERROR = "Запрос не вернул результатов";
        string ADD_ERROR = "При добавлении возникла ошибка";
        string ERROR = "Error";



        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = null;
            radioHome_CheckedChanged(this, new EventArgs());
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

            deleteEthicalCmd = conn.CreateCommand();
            deleteEthicalCmd.CommandType = CommandType.StoredProcedure;
            deleteEthicalCmd.CommandText = "DeleteEthnical";

            deleteLangCmd = conn.CreateCommand();
            deleteLangCmd.CommandType = CommandType.StoredProcedure;
            deleteLangCmd.CommandText = "DeleteLanguage";

            getSumCountCmd = conn.CreateCommand();
            getSumCountCmd.CommandType = CommandType.StoredProcedure;
            getSumCountCmd.CommandText = "GetSumCount";

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
                addNewCountryCmd.Parameters.Clear();
                addNewCountryCmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                addNewCountryCmd.Parameters.AddWithValue("@continent", continentTextBox.Text);
                addNewCountryCmd.Parameters.AddWithValue("@capital", capitalTextBox.Text);
                addNewCountryCmd.Parameters.AddWithValue("@number", numberTextBox.Text);

                addNewCountryCmd.ExecuteNonQuery();

                SqlCommand verifyCmd = conn.CreateCommand();
                verifyCmd.CommandText = SQL.CHECK_ADDED_COUNTRY;
                verifyCmd.Parameters.AddWithValue("@name", nameTextBox.Text.ToLower().ToString());

                DataTable dataTable = new DataTable();
                dataTable.Load(verifyCmd.ExecuteReader());
                countryAddResultDataGrid.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show(this, NO_CONNECTION_ERROR, ERROR);
            }

        }

        private void radioHome_CheckedChanged(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.ConnectionString = connHome;
        }

        private void radioRsreu_CheckedChanged(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.ConnectionString = connRSREU;
        }

        private void btnDeleteEthnical_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Open)
            {
                deleteEthicalCmd.Parameters.Clear();
                deleteEthicalCmd.Parameters.AddWithValue("@country", nameTextBox.Text);
                deleteEthicalCmd.Parameters.AddWithValue("@lang", nameTextBox.Text);

                int res = deleteEthicalCmd.ExecuteNonQuery();

                deleteEthnicalResult.Text = "Удалено " + res + " записей";
            }
            else
            {
                MessageBox.Show(this, NO_CONNECTION_ERROR, ERROR);
            }


        }

        private void delLangButton_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                deleteLangCmd.Parameters.Clear();
                deleteLangCmd.Parameters.Add("@name", SqlDbType.NChar).Value = delLangTextBox.Text;
                deleteLangCmd.Parameters.Add("@out", SqlDbType.Int);
                deleteLangCmd.Parameters["@out"].Direction = ParameterDirection.ReturnValue;


                SqlDataReader rdr = deleteLangCmd.ExecuteReader();

                deleteResultBox.Text = Convert.ToInt32(deleteLangCmd.Parameters["@out"].Value).ToString();
                rdr.Close();
            }
            else
            {
                MessageBox.Show(this, NO_CONNECTION_ERROR, ERROR);
            }

        }

        private void sumCountButton_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                getSumCountCmd.Parameters.Clear();
                getSumCountCmd.Parameters.AddWithValue("@country", countryNameBox.Text);

                var returnParameter = getSumCountCmd.Parameters.Add("@sum", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.Output;

                getSumCountCmd.ExecuteNonQuery();

                sumCountResultBox.Text = returnParameter.Value.ToString();
            }
            else
            {
                MessageBox.Show(this, NO_CONNECTION_ERROR, ERROR);
            }
        }

        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs args)
        {
            if (args.Status == UpdateStatus.ErrorsOccurred)
            {
                MessageBox.Show(args.Errors.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                args.Status = UpdateStatus.SkipCurrentRow;
            }
        }


    }
}
