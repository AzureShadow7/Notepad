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
        SqlCommand command;
        SqlDataReader dataReader;

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
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                //command = new SqlCommand("SELECT * FROM dbo.mealTable WHERE mainIngredient = @param1 and prepTime = '" + prepTimeComboBox.SelectedItem.ToString()
                //    + "' cookTime = '" + cookingTimeComboBox.SelectedItem.ToString() + "'", sqlConnection);


                command = new SqlCommand("SELECT * FROM dbo.mealTable WHERE mainIngredient = @param1", sqlConnection);
                command.Parameters.AddWithValue("@param1", textBox1.Text);

                dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    recipeDisplayBox.Text = dataReader["mealName"].ToString();
                }
                else
                {
                    MessageBox.Show("No data for this ingredient");
                }
                sqlConnection.Close();

                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM dbo.mealTable WHERE mainIngredient LIKE'" + textBox1.Text + "%'", sqlConnection);
                //DataTable dataTable1 = new DataTable();
                //sqlDataAdapter.Fill(dataTable1);

                //recipeDataGridView.DataSource = dataTable1;

                //sqlConnection.Close();
            }
            
        }
    }
}
