using gamePDD.Уровень_3;
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
    public partial class Form_TrafficLight : Form
    {
        public Form_TrafficLight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ThemePDD f = new Form_ThemePDD();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            cn.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Tests] VALUES (@Name_test, @id_user)", cn);
            command1.Parameters.AddWithValue("@Name_test", "Светофоры");
            command1.Parameters.AddWithValue("@id_user", label1.Text);
            command1.ExecuteNonQuery();
            this.Hide();
            Form_lvl3 f3 = new Form_lvl3();
            f3.Show();
        }

        private void Form_TrafficLight_Load(object sender, EventArgs e)
        {
            String insertCmd = "SELECT MAX(id_user) FROM Users";
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
