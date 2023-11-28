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
    public partial class Giaodienthuthu : Form
    {
        public Giaodienthuthu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quanlydocgia bhien=new Quanlydocgia();
            bhien.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quanlymuo_trasach bhien=new Quanlymuo_trasach();
            bhien.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quanlysach bhien=new Quanlysach();  
            bhien.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dangxuat bhiien=new dangxuat(); 
            bhiien.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            thanhtoan tt=new thanhtoan();
            tt.Show();
        }
    }
}
