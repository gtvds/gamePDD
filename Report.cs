using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamePDD
{

    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        private Form classform;
        public Report(Form search) : this()
        {
            classform = search;

        }

        private void reportPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportPanel1_DragDrop(object sender, DragEventArgs e)
        {
           
        }

        private void Report_Load(object sender, EventArgs e)
        {
           
            label1.Font = new Font(Program.modernFont.Families[0], 32);
            label2.Font = new Font(Program.modernFont.Families[0], 32);
            label3.Font = new Font(Program.modernFont.Families[0], 32);
            label4.Font = new Font(Program.modernFont.Families[0], 28);
            label5.Font = new Font(Program.modernFont.Families[0], 28);
            label6.Font = new Font(Program.modernFont.Families[0], 28);
            label7.Font = new Font(Program.modernFont.Families[0], 28);
            label8.Font = new Font(Program.modernFont.Families[0], 32);

            String insertCmd = "SELECT max(Name) FROM Users WHERE Users.id_user = (select max(id_user) from users)";
            SqlConnection myConnection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            SqlCommand myCommand = new SqlCommand(insertCmd.ToString(), myConnection);
            myConnection.Open();
            SqlDataReader rd;
            rd = myCommand.ExecuteReader();
            while (rd.Read())
            {
                label1.Text = rd[0].ToString();
            }
            myConnection.Close();
            String insertCmd1 = "select count (name_test) from Tests inner join Users on Tests.id_user = Users.id_user where Users.id_user = (select max(id_user) from users)";
            SqlConnection myConnection1 = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            SqlCommand myCommand1 = new SqlCommand(insertCmd1.ToString(), myConnection1);
            myConnection1.Open();
            SqlDataReader rd1;
            rd1 = myCommand1.ExecuteReader();
            while (rd1.Read())
            {
                label2.Text = rd1[0].ToString();
            }

            String insertCmd2 = " select count(Correct_question) from Questions inner join Tests on Questions.id_test = Tests.id_test inner join Users on Tests.id_user = Users.id_user where Users.id_user = (select max(id_user) from users) and Correct_question = 'True'";
            SqlConnection myConnection2 = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            SqlCommand myCommand2 = new SqlCommand(insertCmd2.ToString(), myConnection2);
            myConnection2.Open();
            SqlDataReader rd2;
            rd2 = myCommand2.ExecuteReader();
            while (rd2.Read())
            {
                label3.Text = rd2[0].ToString();
            }

            String insertCmd3 = " select count(Correct_question) from Questions inner join Tests on Questions.id_test = Tests.id_test inner join Users on Tests.id_user = Users.id_user where Users.id_user = (select max(id_user) from users) and Correct_question = 'False'";
            SqlConnection myConnection3 = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            SqlCommand myCommand3 = new SqlCommand(insertCmd3.ToString(), myConnection3);
            myConnection3.Open();
            SqlDataReader rd3;
            rd3 = myCommand3.ExecuteReader();
            while (rd3.Read())
            {
                label8.Text = rd3[0].ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            classform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
