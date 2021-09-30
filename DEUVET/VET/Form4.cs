using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VET
{
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection("server=xxx;user=sa;pwd=123456;database=vetdatabase;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        public Form4()
        {
            InitializeComponent();
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {       
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & dateTimePicker1.Value!=null)
            { 
                conn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update kisiler set TC='" + textBox1.Text + "',Ad='" + textBox2.Text + "',Soyad='" + textBox3.Text + "',Mail='" + textBox4.Text + "',Telefon='" + textBox5.Text + "',Tarih='" + dateTimePicker1.Value + "' where TC='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Kayıt başarıyla güncellendi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                    dt.Rows.Clear();
                    dt.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    refresh();                
                    dateTimePicker1.Value = DateTime.Now;
                }
            else
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
          
            }
            catch
            {
                MessageBox.Show("Kayıt güncellenemedi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }            
        }

        private void Form4_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            textBox1.Enabled = false;
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
            textBox2.DataBindings.Add("Text", bs, "Ad");
            textBox3.DataBindings.Add("Text", bs, "Soyad");
            textBox4.DataBindings.Add("Text", bs, "Mail");
            textBox5.DataBindings.Add("Text", bs, "Telefon");
            dateTimePicker1.DataBindings.Add("Text", bs, "Tarih");
            conn.Close();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            {
                textBox2.Text = char.ToUpper(textBox2.Text[0]).ToString() + textBox2.Text.Substring(1);
                textBox2.SelectionStart = textBox2.TextLength;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength > 0)
            {
                textBox3.Text = char.ToUpper(textBox3.Text[0]).ToString() + textBox3.Text.Substring(1);
                textBox3.SelectionStart = textBox3.TextLength;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
