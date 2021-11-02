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
    public partial class Form10 : Form
    {
        int mhz = 3500;
        int temp = 30;
        public Form10()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mhz += 100;
            textBox2.Text = mhz + " МГц";
            temp += 2;
            textBox1.Text = temp + "°C";
            if (temp >= 90)
            {
                SoundPlayer lose = new SoundPlayer(@"C:/windows/media/windows error.wav");
                lose.Play();
                Data.bal += 165;
                this.Close();
                Form otval = new Form3();
                otval.Show();
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            textBox3.Text = "" + 2;
        }
    }
}
