using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using overcocksimulator.Properties;

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
            if (Data.bal < 100)
            {
                MessageBox.Show("ТЫ БОМЖ ЕБАННЫЙ");
            }
            else
            {
                Data.bal = Data.bal - 100;
                Form fx = new Form4();
                fx.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "БАЛАНС: " + Data.bal; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bal1 = Convert.ToString(Data.bal);
            Properties.Settings.Default.balance = bal1;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bal1 = Convert.ToInt32(Properties.Settings.Default.balance);
            Data.bal = bal1;
            label1.Text = "БАЛАНС: " + Data.bal;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form createproc = new Form6();
            createproc.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form createproc = new Form6();
            createproc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (Data.bal < 250)
            {
                MessageBox.Show("ТЫ БОМЖ ЕБАННЫЙ");
            }
            else
            {
                Data.bal -= 250;
                Form i3 = new Form8();
                i3.Show();
                this.Hide();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.NumPad5)
            {
                Data.bal += 9999;
                label1.Text = "БАЛАНС: " + Data.bal;
                MessageBox.Show("Вам было зачислено оверохуя денег на баланс");
            }
            if (e.KeyValue == (char)Keys.NumPad4)
            {
                Data.bal = 0;
                label1.Text = "БАЛАНС: " + Data.bal;
                MessageBox.Show("Баланс обнулён");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Data.bal < 150)
            {
                MessageBox.Show("ТЫ БОМЖ ЕБАННЫЙ");
            }
            else
            {
                Data.bal -= 150;
                Form celeron = new Form10();
                celeron.Show();
                this.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В версии 0.5");
        }
    }
}
