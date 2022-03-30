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
    public partial class Form_Authorize : System.Windows.Forms.Form
    {
        public Form_Authorize()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Authorize));
            this.button1.BackgroundImage = global::gamePDD.Properties.Resources.кнопка_далее;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Authorize));
            this.button1.BackgroundImage = global::gamePDD.Properties.Resources.кнопка__далее_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = GamePDD; Integrated Security = True");
            cn.Open();
            
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("ТЫ НЕ ВВЕЛ СВОЕ ИМЯ, ПОПРОБУЙ ЕЩЁ РАЗ!", "Неудачное начало", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                SqlCommand command1 = new SqlCommand("INSERT INTO [Users] VALUES(@Name)", cn);
                command1.Parameters.AddWithValue("@Name", textBox1.Text);
                command1.ExecuteNonQuery();
                this.Hide();
                Form_ThemePDD f8 = new Form_ThemePDD();
                f8.Show();
            }
          
        }

        private void Form7_Autorize_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
