﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace overcocksimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form xeon = new Form2();
            xeon.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fx = new Form4();
            fx.Show();
            this.Hide();
        }
    }
}