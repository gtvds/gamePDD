﻿using System;
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
    public partial class Form_great : Form
    {
        public Form_great()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ThemePDD tpdd = new Form_ThemePDD();
            tpdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report fr = new Report(this);
            fr.Show();
        }
    }
}
