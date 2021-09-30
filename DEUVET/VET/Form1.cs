using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
namespace VET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");

            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            label1.Text = Convert.ToString(bugun);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

     
    }
}
