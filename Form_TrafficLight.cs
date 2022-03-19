using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
