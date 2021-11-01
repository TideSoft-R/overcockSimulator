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
            if (Data.cores <= 0)
            {
                MessageBox.Show("Еблан нельзя нули писать");
            }
            if (Data.cores > 16)
            {
                MessageBox.Show("Еблан?");
            }
            if (Data.mhz <= 0)
            {
                MessageBox.Show("Еблан нельзя нули писать");
            }
            if (Data.mhz > 4000)
            {
                MessageBox.Show("Еблан?");
            }
            if (Data.temp <= 0)
            {
                MessageBox.Show("Еблан нельзя нули писать");
            }
            if (Data.temp > 150)
            {
                MessageBox.Show("Еблан?");
            }
            else
            {
                Form result = new Form7();
                result.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
