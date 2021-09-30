using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VET
{
    public partial class Form2 : Form
    {
            SqlConnection conn = new SqlConnection("server=xxx;user=sa;pwd=123456;database=vetdatabase;");
        SqlCommand cmd = new SqlCommand();
        string rad1, rad2, rad3, rad4, rad5, rad6, tarih;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rad2 = "Aşısı yok";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            rad3 = "Aşısı var";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            rad3 = "Aşısı yok";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            rad4 = "Aşısı var";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            rad4 = "Aşısı yok";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            rad5 = "Aşısı var";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            rad5 = "Aşısı yok";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            rad6 = "Aşısı var";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            rad6 = "Aşısı yok";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Başına 0 yazmadan giriniz...";
                textBox5.ForeColor = Color.DarkGray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Başına 0 yazmadan giriniz...")
            {
                textBox5.Text = null;
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Zorunlu değil...";
                textBox9.ForeColor = Color.DarkGray;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Zorunlu değil...")
            {
                textBox9.Text = null;
                textBox9.ForeColor = Color.Black;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Zorunlu değil...")
            {
                textBox6.Text = null;
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Zorunlu değil...";
                textBox6.ForeColor = Color.DarkGray;
            }
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.TextLength > 0)
            {
                textBox7.Text = char.ToUpper(textBox7.Text[0]).ToString() + textBox7.Text.Substring(1);
                textBox7.SelectionStart = textBox7.TextLength;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.TextLength > 0)
            {
                textBox8.Text = char.ToUpper(textBox8.Text[0]).ToString() + textBox8.Text.Substring(1);
                textBox8.SelectionStart = textBox8.TextLength;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.TextLength > 0)
            {
                textBox9.Text = char.ToUpper(textBox9.Text[0]).ToString() + textBox9.Text.Substring(1);
                textBox9.SelectionStart = textBox9.TextLength;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
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
            private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "Zorunlu değil...")
            {
                textBox6.Text = "0";

            }
            if (textBox9.Text == "Zorunlu değil...")
            {
                textBox9.Text = "";
            }
            a();
            if (durum == true)
            {
                if (textBox5.TextLength > 9 & textBox1.TextLength > 10 & textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox7.Text != "" & textBox8.Text != "" & tarih != "" & rad1 != "" & rad2 != "" & rad3 != "" & rad4 != "" & rad5 != "" & rad6 != "")
                {
                    conn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into kisiler(TC,Ad,Soyad,Mail,Telefon,Tarih,Ücret) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "'," + Int32.Parse(textBox6.Text) + "); insert into hayvanlar(ID,Tür,Cins,Hastalık,Parazit,Karma1,Karma2,Kuduz,Lösemi,Mantar) values('" + textBox1.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox7.Text + "','" + rad1 + "','" + rad2 + "','" + rad3 + "','" + rad4 + "','" + rad5 + "','" + rad6 + "')";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Kayıt başarıyla eklendi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    radioButton9.Checked = false;
                    radioButton10.Checked = false;
                    radioButton11.Checked = false;
                    radioButton12.Checked = false;
                    dateTimePicker1.Value = DateTime.Now;
                    textBox5.Text = "Başına 0 yazmadan giriniz...";
                    textBox5.ForeColor = Color.DarkGray;
                    textBox9.Text = "Zorunlu değil...";
                    textBox9.ForeColor = Color.DarkGray;
                    textBox6.Text = "Zorunlu değil...";
                    textBox6.ForeColor = Color.DarkGray;
                    textBox1.Focus();
                }

                else
                {
                    MessageBox.Show("Lütfen gerekli alanları doğru bir şekilde doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Bu TC daha önceden veritabanına kaydedilmiş!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tarih = Convert.ToString(dateTimePicker1.Value);
        }

        private void Form2_Leave(object sender, EventArgs e)
        {
            Application.Exit(); 
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rad1 = "Aşısı var";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rad1 = "Aşısı yok";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            rad2 = "Aşısı var";
        }
    }
}

