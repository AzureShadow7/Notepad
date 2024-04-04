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
using System.Diagnostics;

namespace RecipeFinder
{
    public partial class RecipeFinder : Form
    {
        string connectionString = @"Data Source=NGOZIS-PC77;Initial Catalog=test;Integrated Security=True;Encrypt=False";
        SqlCommand command;
        SqlDataReader dataReader;
        List<string> altCookingTimeList = new List<string>();

        public RecipeFinder()
        {
            InitializeComponent();
            FillCookingTimeComboBox();
            FillPrepTimeComboBox();
        }

        private void FillCookingTimeComboBox()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                if(sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                command = new SqlCommand("SELECT distinct cookTime from dbo.mealTable", sqlConnection);

                dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    string cookingTime = dataReader["cookTime"].ToString();
                    cookingTimeComboBox.Items.Add(cookingTime);
                }

                sqlConnection.Close();
            }
        }

        private void FillPrepTimeComboBox()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                command = new SqlCommand("SELECT distinct prepTime from dbo.mealTable", sqlConnection);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string cookingTime = dataReader["prepTime"].ToString();
                    prepTimeComboBox.Items.Add(cookingTime);
                }

                sqlConnection.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

                string query = "SELECT mealId, mealName, mainIngredient, secondaryIngredient, vegetarian, prepTime, cookTime FROM dbo.mealTable where mainIngredient LIKE '"
                    + textBox1.Text + "%'" + "and prepTime ='" + prepTimeComboBox.SelectedItem.ToString() + "' and cookTime ='" + cookingTimeComboBox.SelectedItem.ToString() + "'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable1 = new DataTable();
                sqlDataAdapter.Fill(dataTable1);

                recipeDataGridView.DataSource = dataTable1;

                sqlConnection.Close();
            }
            
        }
        
    }
}
