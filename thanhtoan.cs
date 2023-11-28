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
    public partial class thanhtoan : Form
    {
        public thanhtoan()
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
        private void thanhtoan_Load(object sender, EventArgs e)
        {
            bhien = new SqlConnection(str);
            bhien.Open();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
