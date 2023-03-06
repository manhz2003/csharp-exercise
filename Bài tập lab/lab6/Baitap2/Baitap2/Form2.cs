using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap2
{
    public partial class Form2 : Form
    {
        private HangHoa hangHoa;
        public Form2(HangHoa hangHoa)
        {
            InitializeComponent();
            this.hangHoa = hangHoa;
            lblTenHang.Text = hangHoa.tenhang;
            lblMaHang.Text = hangHoa.mahang;
            lblSoLuong.Text = hangHoa.soluong.ToString();
            lblXuatSu.Text = hangHoa.xuatxu;
            lblGiaBan.Text = hangHoa.giaban.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
