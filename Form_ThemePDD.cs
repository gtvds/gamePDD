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
        int levelTh = 0;
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
            switch (levelTh)
            {
                case 1:
                    pictureBox2.BackColor = System.Drawing.Color.Transparent;
                    pictureBox2.BackgroundImage = global::gamePDD.Properties.Resources.Ресурс_49;
                    pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox2.Location = new System.Drawing.Point(268, 82);
                    pictureBox2.Name = "pictureBox2";
                    pictureBox2.Size = new System.Drawing.Size(690, 147);
                    pictureBox2.TabIndex = 1;
                    pictureBox2.TabStop = false;
                    break;
                case 2:
                    Console.WriteLine("case 3");
                    break;
                case 3:
                    Console.WriteLine("case 5");
                    break;
                case 4:
                    Console.WriteLine("case 5");
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_ThemePDD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
