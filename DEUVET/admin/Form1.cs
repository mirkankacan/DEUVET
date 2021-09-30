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

namespace admin
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source =xxxx; Initial Catalog = vetdatabase; Persist Security Info=True;User ID = sa; Password=123456");
        bool durum;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void a()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from kayit where Kullanıcı=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
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
            if(textBox1.Text!="" & textBox2.Text!="")
            {
                a();
                if (durum == true)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into kayit (Kullanıcı,Şifre) values(@p1,@p2)", conn);
                    cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Kayıt başarıyla eklendi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı daha önceden alınmış!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
