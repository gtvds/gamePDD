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

namespace gamePDD
{
    public partial class Form_Autorize : Form
    {
        public Form_Autorize()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string type;
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=GTVDS-PC\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True"))
            {
                sqlcon.Open();

                SqlCommand command = new SqlCommand("SELECT Type FROM [dbo].[Autorize_Users] WHERE Login = @login and Password = @password", sqlcon);
                command.Parameters.AddWithValue("@login", textBox1.Text);
                command.Parameters.AddWithValue("@password", textBox2.Text);
                type = (string)command.ExecuteScalar();
            }

            if (type == "admin")
            {
                this.Hide();
                Form_Registraton reg = new Form_Registraton();
                reg.Show();
            }
            else if (type == "user")
            {
                this.Hide();
                Form_Menu menu = new Form_Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Введите ещё раз либо зарегистрируйтесь!");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Registraton registration = new Form_Registraton();
            registration.Show();
        }
    }
    
}
