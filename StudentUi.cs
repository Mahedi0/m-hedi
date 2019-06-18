using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class StudentUi : Form
    {
        private string connectionString;
        private SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;
            
        public StudentUi()
        {
            InitializeComponent();
            connectionString= @"Server=PC-301-20\SQLEXPRESS; Database=studentbd; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);

        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            //load District
            LoadDistrict();
        }
        private void LoadDistrict()
        {
            //
            sqlConnection.Open();

            //
            commandString = @"select *from districts";
            sqlCommand = new SqlCommand(commandString, sqlConnection);


            //
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable datatable = new DataTable();
            sqlDataAdapter.Fill(datatable);


            if (datatable.Rows.Count > 0)
                districtComboBox.DataSource = datatable;
            //
            sqlConnection.Close();



        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Insert();
        


        }
        private void Insert()
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            //
            sqlConnection

        }
    }
}
