using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_Information_Data
{
    public partial class GradingSystem : Form
    {
        public GradingSystem()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void Student_Dashboard_Load(object sender, EventArgs e)
        {

        }


        private void LoadStudents()
        {
            string search = txtSearch.Text.Trim();
            // Create a new database connection using the simplified DBConnect class
            DBConnect db = new DBConnect();
            try
            {

                // Open the connection to MySQL
                db.Open();
                // SQL query to select all columns from the students table
                string query = @"SELECT id, firstname, lastname, course,
section, age, birthdate
                FROM student_info
WHERE firstname LIKE @search
OR lastname LIKE @search
OR course LIKE @search
OR section LIKE @search
OR birthdate LIKE @search";

                // Create a command to execute the SQL query
                MySql.Data.MySqlClient.MySqlCommand cmd = new
                MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                // Add wildcards for partial search
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                // DataAdapter is used to fill a DataTable with the query results
                MySql.Data.MySqlClient.MySqlDataAdapter adapter =
                new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                // Create a DataTable to store the query results
                System.Data.DataTable table = new System.Data.DataTable();
                // Fill the DataTable with data from the database
                adapter.Fill(table);
                // Bind the DataTable to the DataGridView to display data
                dgvStudents.DataSource = table;
                // Change column headers to be more readable
                dgvStudents.Columns["id"].HeaderText = "Student ID";
                dgvStudents.Columns["firstname"].HeaderText = "First Name";
                dgvStudents.Columns["lastname"].HeaderText = "Last Name";
                dgvStudents.Columns["course"].HeaderText = "Course";
                dgvStudents.Columns["section"].HeaderText = "Section";
                dgvStudents.Columns["age"].HeaderText = "Age";
                dgvStudents.Columns["birthdate"].HeaderText = "Birthdate";

                // Dispose command and adapter to free resources
                adapter.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Always close the database connection
                db.Close();

            }
        }


        private void txtBrithdate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




