using gamePDD._1_уровень;
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
    public partial class Form_lvl_1 : System.Windows.Forms.Form
    {

        public Form_lvl_1()
        {
            InitializeComponent();
            
        }
        private void button3_Click(object sender, EventArgs e)
        {  
            pictureBox5.Hide();
            SqlConnection cn = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            cn.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn);
            command1.Parameters.AddWithValue("@Answer_questions", "Наземный");
            command1.Parameters.AddWithValue("@Correct_question", "True");
            command1.Parameters.AddWithValue("@id_test", label1.Text);
            command1.ExecuteNonQuery();
            cn.Close();
            pictureBox4.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            pictureBox4.Hide();
            SqlConnection cn = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            cn.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn);
            command1.Parameters.AddWithValue("@Answer_questions", "Водный");
            command1.Parameters.AddWithValue("@Correct_question", "False");
            command1.Parameters.AddWithValue("@id_test", label1.Text);
            command1.ExecuteNonQuery();
            cn.Close();
            pictureBox5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Hide();
            SqlConnection cn = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            cn.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn);
            command1.Parameters.AddWithValue("@Answer_questions", "Подземный");
            command1.Parameters.AddWithValue("@Correct_question", "False");
            command1.Parameters.AddWithValue("@id_test", label1.Text);
            command1.ExecuteNonQuery();
            cn.Close();
            pictureBox5.Show();
        }

        private void Form_lvl1_Load(object sender, EventArgs e)
        {
            String insertCmd = "SELECT MAX(id_test) FROM Tests WHERE Name_test = 'Транспорт'";
            SqlConnection myConnection = new SqlConnection("Data Source=GTVDS-PC\\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            SqlCommand myCommand = new SqlCommand(insertCmd.ToString(), myConnection);
            myConnection.Open();
            SqlDataReader rd;
            rd = myCommand.ExecuteReader();
            while (rd.Read())
            {
                label1.Text = rd[0].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_lvl_2 f = new Form_lvl_2();
            f.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
    }
