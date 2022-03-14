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
    public partial class Form_usergame : Form
    {
        public Form_usergame()
        {
            InitializeComponent();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Autorize autorize = new Form_Autorize();
            autorize.Show();
        }
    }
}
