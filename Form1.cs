using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASE_RELATION_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void Savebutton1_Click(object sender, EventArgs e)
        {
            try
            {
                //1
                SqlConnection sqlConnection = new SqlConnection();
                string connectionstring = @"Server=PC-301-14\SQLEXPRESS; Database=STUDENTBD; Integrated Security)";
                sqlConnection.ConnectionString=connectionstring;

                //2
                SqlCommand sqlCommand=new SqlCommand();
                string commandstring=@"INSERT INTO DEPARTMENT(Name,Code)Values('Computer Science & Engineering)";
                sqlCommand.CommandText =commandstring;
                sqlCommand.Connection = sqlConnection;

                //3
                sqlConnection.Open();

                //4
                int isExecuted = 0;
                isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted>0)
                {
                    MessageBox.Show("Saved Successfully");
                

                }
                else
                {
                    MessageBox.Show("Save FAiled");
                }


            }   



                 
            
        }
    }
}
