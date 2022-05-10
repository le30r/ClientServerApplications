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
            "Data Source=DESKTOP-8ER83ML\\SQLEXPRESS;Initial Catalog=Языки народов мира;Integrated Security=True";

        string NO_CONNECTION_ERROR = "Для выполнения запроса необходимо подключиться к базе данных";
        string NOT_FOUND_ERROR = "Запрос не вернул результатов";
        string ADD_ERROR = "При добавлении возникла ошибка";
        string ERROR = "Error";



        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = null;

            daLanguages.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            dgLanguages.DataSource = ds.Языки;
            SelectLanguages();
        }

      
        private void dgLanguages_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
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
        public void SelectLanguages()
        {
            ds.Языки.Clear();
            daLanguages.Fill(ds.Языки); 
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectLanguages();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         
        daLanguages.Update(ds.Языки.Select(null, null, DataViewRowState.Deleted));
        daLanguages.Update(ds.Языки.Select(null, null, DataViewRowState.ModifiedCurrent));
        daLanguages.Update(ds.Языки.Select(null, null, DataViewRowState.Added));
            
        }
    }
}
