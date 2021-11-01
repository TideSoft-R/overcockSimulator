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

namespace TideSurfer
{
    public partial class SpeedtidePad : Form
    {
        int mhz = 2000;
        int temp = 30;
        public SpeedtidePad()
        {
            InitializeComponent();
        }
        private void save_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mhz = mhz + 100;
            textBox1.Text = mhz + " МГц";
            temp = temp + 2;
            textBox2.Text = temp + "°C";
            if (temp >= 90)
            {
                SoundPlayer youloose = new SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                youloose.Play();
                Form f = new Form2();
                f.Show();
                button1.Enabled = false;
            }
        }
    }
}
