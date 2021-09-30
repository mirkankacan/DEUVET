using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VET
{
    public partial class Form8 : Form
    {
        SqlConnection conn = new SqlConnection("server=xxx;user=sa;pwd=123456;database=vetdatabase;");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlDataAdapter adap2 = new SqlDataAdapter();
        DataTable dt2 = new DataTable();
        DataTable dt = new DataTable();
        public Form8()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd2.Connection = conn;
            cmd.CommandText = "select * from kisiler";
            cmd2.CommandText = "select * from hayvanlar";
            cmd2.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            cmd2.ExecuteScalar();
            adap.SelectCommand = cmd;
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            adap2.SelectCommand = cmd2;
            adap2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            conn.Close();
        }
    }
}
