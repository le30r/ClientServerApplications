
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab3_2_1
{
    public partial class Form1 : Form
    {
        string connectionString =
            "Data Source=DESKTOP-8ER83ML\\SQLEXPRESS;Initial Catalog=Языки народов мира;Integrated Security=True";
        SqlConnection connection = new SqlConnection();

        SqlDataAdapter daCountries;

        DataSet ds;


        SqlCommand cmdInsert;
        SqlCommand cmdUpdate;
        SqlCommand cmdDelete;
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = connectionString;
            connection.Open();

            CreateAdapter();
            CreateDataSet();
            CreateCommands();
            daCountries.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

            dgCountries.DataSource = ds.Tables["Страны"];
            SelectCountries();
        }

        void CreateAdapter()
        {
            daCountries = new SqlDataAdapter();
            SqlCommand cmdSelect = connection.CreateCommand();
            cmdSelect.CommandText = "SELECT * FROM Страны;";
            daCountries.SelectCommand = cmdSelect;

            daCountries.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        }

        void CreateDataSet()
        {
            ds = new DataSet();
            daCountries.Fill(ds, "Страны");
        }

        void CreateCommands()
        {
            cmdInsert = connection.CreateCommand();
            cmdInsert.CommandText = "INSERT INTO Страны VALUES (@Код, @Название, @Материк, @Столица, @КоличествоЖителей);";
            daCountries.InsertCommand = cmdInsert;
            daCountries.InsertCommand.Parameters.Add("@Код", SqlDbType.Int, 10, "Код");
            daCountries.InsertCommand.Parameters.Add("@Название", SqlDbType.NChar, 25, "Название");
            daCountries.InsertCommand.Parameters.Add("@Материк", SqlDbType.NChar, 25, "Материк");
            daCountries.InsertCommand.Parameters.Add("@Столица", SqlDbType.NChar, 25, "Столица");
            daCountries.InsertCommand.Parameters.Add("@КоличествоЖителей", SqlDbType.BigInt, 30, "Количество жителей");


            cmdDelete = connection.CreateCommand();
            cmdDelete.CommandText = "DELETE FROM Страны WHERE @Код = Код;";
            cmdDelete.Parameters.Add("@Код", SqlDbType.Int, 10, "Код").SourceVersion = DataRowVersion.Original;
            daCountries.DeleteCommand = cmdDelete;
           

            cmdUpdate = connection.CreateCommand();
            cmdUpdate.CommandText = "UPDATE Страны " +
                "SET Название = @Название, Материк = @Материк, Столица = @Столица, [Количество жителей] = @КоличествоЖителей " +
                "WHERE Код = @Код;";
            cmdUpdate.Parameters.Add("@Код", SqlDbType.Int, 10, "Код").SourceVersion = DataRowVersion.Original;
            cmdUpdate.Parameters.Add("@Название", SqlDbType.NChar, 25, "Название");
            cmdUpdate.Parameters.Add("@Материк", SqlDbType.NChar, 25, "Материк");
            cmdUpdate.Parameters.Add("@Столица", SqlDbType.NChar, 25, "Столица");
            cmdUpdate.Parameters.Add("@КоличествоЖителей", SqlDbType.BigInt, 30, "Количество жителей");
            daCountries.UpdateCommand = cmdUpdate;
           

        }

        private void btnSelect_Click(object sender, System.EventArgs e)
        {
            SelectCountries();
        }

        private void SelectCountries()
        {
            ds.Tables["Страны"].Clear();
            daCountries.Fill(ds.Tables["Страны"]);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            daCountries.Update(ds.Tables["Страны"].Select(null, null, DataViewRowState.Deleted));
            daCountries.Update(ds.Tables["Страны"].Select(null, null, DataViewRowState.ModifiedCurrent));
            daCountries.Update(ds.Tables["Страны"].Select(null, null, DataViewRowState.Added));
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

        private void dgCountries_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
        }
    }
}
