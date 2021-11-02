using System;
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
    public partial class Form8 : Form
    {
        int mhz = 3600;
        int temp = 30;
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mhz = mhz + 100;
            temp = temp + 2;
            textBox1.Text = mhz + " МГц";
            textBox2.Text = temp + "°C";
            if (temp >= 100)
            {
                Data.bal += 270;
                this.Close();
                Form otval = new Form9();
                otval.Show();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox3.Text = "" + 4;
        }
    }
}
