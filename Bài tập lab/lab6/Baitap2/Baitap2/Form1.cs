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
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtTenHang.Text == "" || txtMaHang.Text == "" || txtSoLuong.Text == "" || txtXuatXu.Text == "" || txtGiaban.Text == "" )
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
            string TenHang = txtTenHang.Text;
            string MaHang = txtMaHang.Text;
            int SoLuong;
            double GiaBan;
            try
            {
                SoLuong = int.Parse(txtSoLuong.Text);
                GiaBan = double.Parse(txtGiaban.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng form");
                return ;
            }
            string XuatXu = txtXuatXu.Text;
            

            HangHoa h = new HangHoa();
            h.tenhang = TenHang;
            h.mahang = MaHang;
            h.soluong = SoLuong;
            h.xuatxu = XuatXu;
            h.giaban = GiaBan;

            Form2 f2 = new Form2(h);
            f2.ShowDialog();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            txtTenHang.Text = "";
            txtMaHang.Text = "";
            txtSoLuong.Text = "";
            txtXuatXu.Text = "";
            txtGiaban.Text = "";
        }
    }
}
