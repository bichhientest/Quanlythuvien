using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythuvien
{
    public partial class quenmk : Form
    {
        public quenmk()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Random rnd = new Random();
            int maxacnhan=rnd.Next(1000,10000);
            MessageBox.Show("Mã xác nhận: " + maxacnhan.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxn = 0;
            if (Int32.TryParse(textBox1.Text, out maxn) && maxn >= 1000 && maxn <= 9999)
            {
                MessageBox.Show("Thành công!");
                Close();
            }
            else
            {
                MessageBox.Show("Mã không đúng!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void quenmk_Load(object sender, EventArgs e)
        {

        }
    }
}
