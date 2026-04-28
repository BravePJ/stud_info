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
    public partial class StudentLogIn : Form
    {
        public StudentLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Get the username and password from the textboxes and remove extra spaces
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            // Check if username or password is empty
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return; // Stop the login process
            }
            // Create database connection object
            DBConnect db = new DBConnect();
            try
            {
                db.Open(); // Open database connection
                           // SQL query to count matching username and password
                string query = "SELECT COUNT(*) FROM userlogin WHERE " +
                    "username = @username AND password = @password";
                // Create MySQL command
                MySql.Data.MySqlClient.MySqlCommand cmd =
               new MySql.Data.MySqlClient.MySqlCommand(query,
                db.Connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                // Execute query and get result (number of matched records)
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose(); // Release command resources
                               // If exactly 1 record found, login successful

                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    // Open Student Dashboard form
                    GradingSystem grade = new GradingSystem();
                    grade.Show();
                    // Hide current Login form
                    this.Hide();
                }
                else
                {
                    // If no match found
                    MessageBox.Show("Invalid Username or Password.");
                }
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close(); // Close database connection
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            // Hide current Login form
            this.Hide();
        }
    }
}

