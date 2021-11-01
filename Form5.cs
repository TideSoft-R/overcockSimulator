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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.bal = Data.bal + 110;
            this.Close();
            Form form = new Form1();
            form.Show();
            string bal1 = Convert.ToString(Data.bal);
            Properties.Settings.Default.balance = bal1;
            Properties.Settings.Default.Save();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
