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
    public partial class Form_Perehod : System.Windows.Forms.Form
    {
        public Form_Perehod()
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
