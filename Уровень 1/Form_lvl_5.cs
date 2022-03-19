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

namespace gamePDD._1_уровень
{
    public partial class Form_lvl_5 : Form
    {
        public Form_lvl_5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox5.Hide();
            SqlConnection cn = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            cn.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn);
            command1.Parameters.AddWithValue("@Answer_questions", "Общественный");
            command1.Parameters.AddWithValue("@Correct_question", "True");
            command1.Parameters.AddWithValue("@id_test", label1.Text);
            command1.ExecuteNonQuery();
            cn.Close();
            pictureBox4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Hide();
            SqlConnection cn = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            cn.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn);
            command1.Parameters.AddWithValue("@Answer_questions", "Воздушный");
            command1.Parameters.AddWithValue("@Correct_question", "False");
            command1.Parameters.AddWithValue("@id_test", label1.Text);
            command1.ExecuteNonQuery();
            cn.Close();
            pictureBox5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox4.Hide();
            SqlConnection cn = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            cn.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Questions] VALUES(@Answer_questions, @Correct_question, @id_test) ", cn);
            command1.Parameters.AddWithValue("@Answer_questions", "Личный");
            command1.Parameters.AddWithValue("@Correct_question", "False");
            command1.Parameters.AddWithValue("@id_test", label1.Text);
            command1.ExecuteNonQuery();
            cn.Close();
            pictureBox5.Show();
        }

        private void Form_lvl_5_Load(object sender, EventArgs e)
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
    }
    }

