using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamePDD
{
    public partial class Form_Registraton : Form
    {
        public Form_Registraton()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Autorize autorize = new Form_Autorize();
            autorize.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            cn.Open();
            SqlCommand command1 = new SqlCommand("INSERT INTO [Users] VALUES(@Surname,@Name,@Age,@Pol)", cn);
            SqlCommand command2 = new SqlCommand("INSERT INTO [Autorize_Users] VALUES(@Login,@Password,@Type)", cn);
                command1.Parameters.AddWithValue("@Surname", textBox1.Text);
                command1.Parameters.AddWithValue("@Name", textBox2.Text);
                command1.Parameters.AddWithValue("@Age", textBox4.Text);
                command1.Parameters.AddWithValue("@Pol", textBox5.Text);
                command2.Parameters.AddWithValue("@Login", textBox7.Text);
                command2.Parameters.AddWithValue("@Password", textBox8.Text);
                command2.Parameters.AddWithValue("@Type", label10.Text);
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
            MessageBox.Show("Ваш аккаунт создан. Войдите в систему", "Успешная авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

    


