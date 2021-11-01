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
    }
}
