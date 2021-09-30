using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace VET
{
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection("server=xxx;user=sa;pwd=123456;database=vetdatabase;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        public Form3()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form3_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool durum;
        void a()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from kisiler where TC=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Silmek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                a();
                if (durum == false)
                {
                    if (textBox1.Text != "" & textBox1.TextLength>10)
                    {
                        conn.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "delete from hayvanlar where ID='" + textBox1.Text + "'; delete from kisiler where TC='" + textBox1.Text + "'";
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Kayıt başarıyla silindi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                        dt.Rows.Clear();
                        dt.Clear();
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        refresh();
                        textBox1.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Lütfen gerekli alanları doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("TC veritabanında bulunmuyor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void refresh()
        {
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from kisiler";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            adap.SelectCommand = cmd;
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            textBox1.Focus();
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from kisiler";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            adap.SelectCommand = cmd;
            adap.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            textBox1.DataBindings.Add("Text", bs, "TC");
            conn.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
