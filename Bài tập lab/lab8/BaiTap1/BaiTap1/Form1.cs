using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TongHaiSoBUS;

namespace BaiTap1
{
    public partial class Form1 : Form
    {
        private CalcBUS bus = new CalcBUS();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(txtA.Text);
            int s2 = int.Parse(txtB.Text);

            int sum = bus.GetSum(s1, s2);
            txtKetQua.Text = sum.ToString();
        }
    }
}
