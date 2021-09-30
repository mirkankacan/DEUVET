using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace VET
{
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection("server=xxx;user=sa;pwd=123456;database=vetdatabase;");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        SqlDataReader rd;
        string a, b, c, d, ee, f;
        public Form5()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mesajım = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("deuveteriner@gmail.com", "987123@deu");
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com";
                istemci.EnableSsl = true;
                mesajım.To.Add(textBox3.Text);
                mesajım.From = new MailAddress("deuveteriner@gmail.com");
                mesajım.Subject = "DEUVET Bilgilendirme";

                conn.Open();
                cmd2.Connection = conn;
                cmd2.CommandText = "select Parazit,Karma1,Karma2,Kuduz,Lösemi,Mantar from hayvanlar where ID='" + textBox1.Text + "'";
                cmd2.CommandType = CommandType.Text;
                rd = cmd2.ExecuteReader();
                while (rd.Read())
                {
                    a = rd[0].ToString();
                    b = rd[1].ToString();
                    c = rd[2].ToString();
                    d = rd[3].ToString();
                    ee = rd[4].ToString();
                    f = rd[5].ToString();
                }
                conn.Close();

                textBox4.Text = textBox4.Text + Environment.NewLine + Environment.NewLine + "Hastanın güncel durumu aşağıdaki gibidir; " + Environment.NewLine + "Parazit:" + a + Environment.NewLine + "Karma1:" + b +Environment.NewLine + "Karma2:" + c + Environment.NewLine + "Kuduz:" + d + Environment.NewLine + "Lösemi:" + ee + Environment.NewLine + "Mantar:" + f  ;
                mesajım.Body = textBox4.Text;             
                istemci.Send(mesajım);
                MessageBox.Show("Mail başarıyla gönderildi!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Clear();
                textBox4.Clear();
                textBox3.Focus();
            }
            catch
            {
                MessageBox.Show("Mail gönderilemedi!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox3.Focus();
            textBox4.Clear();
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Ad,Soyad,Telefon,Mail,TC from kisiler";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            adap.SelectCommand = cmd;
            adap.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            textBox3.DataBindings.Add("Text", bs, "Mail");
            textBox1.DataBindings.Add("Text", bs, "TC");
            conn.Close();
        }

        private void Form5_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
          
        }
    }
}
