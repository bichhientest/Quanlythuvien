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

namespace quanlythuvien
{
    public partial class Quanlythuthu : Form
    {
        public Quanlythuthu()
        {
            InitializeComponent();
        }
        SqlConnection bhien;
        SqlCommand scm;
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string str = @"Data Source=WINDOWS-11\HIENLTB;Initial Catalog=qlthuvien;Integrated Security=True";
        void load()
        {
            scm = bhien.CreateCommand();
            scm.CommandText = "select * from QLTHUTHU";
            sda.SelectCommand = scm;
            dt.Clear();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scm= bhien.CreateCommand();
            scm.CommandText = "insert into QLTHUTHU values('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "')";
            scm.ExecuteNonQuery();
            load();
            MessageBox.Show("Lưu thành công!");
        }


        private void Quanlythuthu_Load(object sender, EventArgs e)
        {
            bhien = new SqlConnection(str);
            bhien.Open();
            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            scm=bhien.CreateCommand();
            scm.CommandText = "update  QLTHUTHU set MATT='" + textBox1.Text + "',TENTT='" + textBox5.Text + "',SDT='" + textBox4.Text + "',EMAIL='" + textBox3.Text + "',GIOITINH='" + textBox2.Text + "' where MATT='"+textBox1.Text+"'";
            scm.ExecuteNonQuery() ;
            load();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            scm= bhien.CreateCommand();
            scm.CommandText = "delete from QLTHUTHU where MATT='" + textBox1.Text + "'";
            scm.ExecuteNonQuery() ;
            load();
            MessageBox.Show("Xóa thành công!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scm.CommandText = "select* from QLTHUTHU where MATT='" + textBox6.Text + "'";
            scm.ExecuteNonQuery() ;
            dt.Clear();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            load();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
