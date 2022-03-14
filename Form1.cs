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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_game1 game = new Form_game1();
            game.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Autorize autorize = new Form_Autorize();
            autorize.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
