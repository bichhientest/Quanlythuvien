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
    public partial class dangxuat : Form
    {
        public dangxuat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            Close();
            Form1.ActiveForm.Close();

        }

        private void dangxuat_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
