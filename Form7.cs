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
    public partial class Form7 : Form
    {
        int temp = 30;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label1.Text = Data.name;
            textBox2.Text = "" + Data.cores;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.mhz = Data.mhz + 100;
            textBox1.Text = Data.mhz + " МГц";
            temp = temp + 2;
            textBox3.Text = temp + "°C";
            if (temp >= Data.temp)
            {
                Data.bal = Data.bal + 5;
                SoundPlayer losesound = new SoundPlayer(@"C:/Windows/Media/Windows Error.wav");
                losesound.Play();
                Form lose = new Form3();
                lose.Show();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
