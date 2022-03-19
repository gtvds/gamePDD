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
    public partial class Form_ThemePDD : System.Windows.Forms.Form
    {
        public Form_ThemePDD()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Transport f9 = new Form_Transport();
            f9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Transport f9 = new Form_Transport();
            f9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Perehod f = new Form_Perehod();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_TrafficLight f = new Form_TrafficLight();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form__PDD f = new Form__PDD();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_RoadZnak f = new Form_RoadZnak();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_ThemePDD_Load(object sender, EventArgs e)
        {
            
        }
    }
}
