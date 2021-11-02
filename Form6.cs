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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.cores = Convert.ToInt32(nubmerofcores.Text);
            Data.temp = Convert.ToInt32(textBox1.Text);
            Data.mhz = Convert.ToInt32(textBox3.Text);
            Data.name = textBox2.Text;
            if (Data.cores > 0 && Data.cores <= 16 && Data.mhz > 0 && Data.mhz <= 4000 && Data.temp > 0 && Data.temp <= 150)
            {
                Form result = new Form7();
                result.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Еблан читай условия");
                this.Close();
                Form main = new Form1();
                main.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
