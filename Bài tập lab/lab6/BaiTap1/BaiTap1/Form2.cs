using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class Form2 : Form
    {
        public string KetQua;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void lbKq_Click(object sender, EventArgs e)
        {
            lbKq.Text = KetQua;
        }
    }
}
