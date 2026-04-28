using Mysqlx.Expr;

namespace student_Information_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLogIn studentLogIn = new StudentLogIn();
            studentLogIn.Show();
            // Hide current Login form
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.Show();
            // Hide current Login form
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}

