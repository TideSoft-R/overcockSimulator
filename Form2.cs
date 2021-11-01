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
    public partial class Form2 : Form
    {
        int temp = 30;
        int mhz = 2000;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mhz = mhz + 100;
            textBox1.Text = mhz + " МГц";
            temp = temp + 2;
            textBox2.Text = temp + "°C";
            textBox3.Text = "6";
            if (temp >= 90)
            {
                SoundPlayer losesound = new SoundPlayer(@"C:/Windows/Media/Windows Error.wav");
                losesound.Play();
                Form lose = new Form3();
                lose.Show();
                this.Close();
            }
        }
    }
}
