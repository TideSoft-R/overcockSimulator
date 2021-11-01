using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace overcocksimulator
{
    public partial class Form4 : Form
    {
        int temp = 30;
        int mhz = 3000;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mhz = mhz + 100;
            textBox3.Text = mhz + " МГц";
            temp = temp + 2;
            textBox1.Text = temp + "°C";
            textBox2.Text = "4";
            if (temp >= 110)
            {
                SoundPlayer losesound = new SoundPlayer(@"C:/Windows/Media/Windows Error.wav");
                losesound.Play();
                Form lose = new Form5();
                lose.Show();
                this.Close();
            }
        }
    }
}
