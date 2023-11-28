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
    public partial class Quanlymuo_trasach : Form
    {
        public Quanlymuo_trasach()
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
            scm.CommandText = "select * from QLMUONTRASACH";
            sda.SelectCommand = scm;
            dt.Clear();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Quanlymuontrasach_Load(object sender, EventArgs e)
        {
            bhien = new SqlConnection(str);
            bhien.Open();
            load();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            scm=bhien.CreateCommand();
            scm.CommandText="insert into QLMUONTRASACH values('"+ textBox1.Text+"','"+textBox7.Text+"','"+textBox10.Text+"','"+textBox9.Text+"','"+textBox6.Text+"','"+textBox5.Text+"',"+ textBox4.Text+"','"+ textBox3.Text+"','"+textBox2.Text+"','"+textBox11.Text+"')";
            scm.ExecuteNonQuery();
            load();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            scm = bhien.CreateCommand();
            scm.CommandText = "delete from QLMUONTRASACH where MAMT='" + textBox1.Text +"')";
            scm.ExecuteNonQuery();
            load();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i=dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox10.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox7.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox11.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox9.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quanlymuo_trasach_Load(object sender, EventArgs e)
        {
            bhien=new SqlConnection(str);
            bhien.Open();
            load();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            scm=bhien.CreateCommand();
            scm.CommandText="update QLMUONTRASACH set MAMT='"+textBox1.Text+"',MADG='"+textBox10.Text+"',TENDG='"+textBox7.Text+"',MATT='"+textBox11.Text+"',MASACH='"+ textBox9.Text+"', TENSACH='"+textBox6.Text+"',SOLUONG='"+textBox5.Text+"',NGAYMUON='"+textBox4.Text+"',NGAYHENTRA='"+textBox3.Text+"',NGAYTRA='"+textBox2.Text+"')";
            scm.ExecuteNonQuery();
            load();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scm.CommandText="select * from QLMUONTRASACH where MAMT='"+textBox8.Text+"'";
            scm.ExecuteNonQuery();
            dt.Clear();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
