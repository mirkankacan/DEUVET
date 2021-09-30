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
    public partial class Form7 : Form
    {
        SqlConnection conn = new SqlConnection("server=xxx;user=sa;pwd=123456;database=vetdatabase;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        string rad1, rad2, rad3, rad4, rad5, rad6;
        

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            textBox1.Enabled = false;
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from hayvanlar";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            adap.SelectCommand = cmd;
            adap.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            textBox1.DataBindings.Add("Text", bs, "ID");
            textBox8.DataBindings.Add("Text", bs, "Tür");
            textBox9.DataBindings.Add("Text", bs, "Cins");
            textBox7.DataBindings.Add("Text", bs, "Hastalık");
            
            conn.Close();    
        }      
     
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rad1 = "Aşısı yok";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            rad2 = "Aşısı var";
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));

        }

        private void select(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string val1 = row.Cells[4].Value.ToString();
                string val2 = row.Cells[5].Value.ToString();
                string val3 = row.Cells[6].Value.ToString();
                string val4 = row.Cells[7].Value.ToString();
                string val5 = row.Cells[8].Value.ToString();
                string val6 = row.Cells[9].Value.ToString();

                if (val1=="Asisi var")
                {
                    radioButton1.Checked = true;
                }
                else if (val1=="Asisi yok")
                {
                    radioButton2.Checked = true;
                }
                if (val2 == "Asisi var")
                {
                    radioButton4.Checked = true;
                }
                else if (val2 == "Asisi yok")
                {
                    radioButton3.Checked = true;
                }
                if (val3 == "Asisi var")
                {
                    radioButton8.Checked = true;
                }
                else if (val3 == "Asisi yok")
                {
                    radioButton7.Checked = true;
                }
                if (val4 == "Asisi var")
                {
                    radioButton6.Checked = true;
                }
                else if (val4 == "Asisi yok")
                {
                    radioButton5.Checked = true;
                }
                if (val5 == "Asisi var")
                {
                    radioButton10.Checked = true;
                }
                else if (val5 == "Asisi yok")
                {
                    radioButton9.Checked = true;
                }
                if (val6 == "Asisi var")
                {
                    radioButton12.Checked = true;
                }
                else if (val6 == "Asisi yok")
                {
                    radioButton11.Checked = true;
                }
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.TextLength > 0)
            {
                textBox7.Text = char.ToUpper(textBox7.Text[0]).ToString() + textBox7.Text.Substring(1);
                textBox7.SelectionStart = textBox7.TextLength;
            }
        }

        private void Form7_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        void refresh()
        {
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from hayvanlar";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            adap.SelectCommand = cmd;
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" & textBox8.Text != "" & textBox7.Text != "")
                {
                    conn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update hayvanlar set ID='" + textBox1.Text + "',Tür='" + textBox8.Text + "',Cins='" + textBox9.Text + "',Hastalık='" + textBox7.Text + "',Parazit='" + rad1 + "',Karma1='" + rad2 + "',Karma2='" + rad3 + "',Kuduz='" + rad4 + "',Lösemi='" + rad5 + "',Mantar='" + rad6 + "' where ID='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Kayıt başarıyla güncellendi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);         
                    dataGridView1.DataSource = null;
                    dt.Rows.Clear();
                    dt.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    refresh();
                   
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rad1 = "Aşısı var";
        }
    }
}
