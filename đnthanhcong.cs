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
    public partial class đnthanhcong : Form
    {
        
        public đnthanhcong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
             Giaodienquanly quanly = new Giaodienquanly();
            quanly.Show();
            
        }
    }
}
