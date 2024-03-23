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

namespace RecipeFinder
{
    public partial class RecipeFinder : Form
    {
        string connectionString = @"Data Source=NGOZIS-PC77;Initial Catalog=test;Integrated Security=True;Encrypt=False";

        public RecipeFinder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void prepTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * from dbo.mealTable", sqlConnection);
                DataTable dataTable1 = new DataTable();
                sqlDataAdapter.Fill(dataTable1);

                recipeDataGridView.DataSource = dataTable1;
            }
        }
    }
}
