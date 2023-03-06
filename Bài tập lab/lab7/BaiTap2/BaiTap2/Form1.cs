using BaiTap1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTap2
{
    public partial class Form1 : Form
    {

        List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        BindingSource bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSV.Text;
            string HoTen = txtHoTen.Text;
            string NgaySinh = txtNgaySinh.Text;
            string DiaChi = txtDiaChi.Text;
            string Empty = string.Empty;
            int Tuoi = 0;

            if (MaSV == Empty || HoTen == Empty || NgaySinh == Empty || DiaChi == Empty)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin !");
                return;
            }

            try
            {
                Tuoi = int.Parse(txtTuoi.Text);
                if (Tuoi < 1)
                {
                    MessageBox.Show("Tuổi không thể nhỏ hơn 1 !");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập tuổi không hợp lệ !");
                return;
            }

            SinhVien sinhVien = new SinhVien();
            sinhVien.masv = MaSV;
            sinhVien.hoten = HoTen;
            sinhVien.tuoi = Tuoi;
            sinhVien.ngaysinh = NgaySinh;
            sinhVien.diachi = DiaChi;

            danhSachSinhVien.Add(sinhVien);
            bindingSource.DataSource = danhSachSinhVien;
            dataGridView1.DataSource = bindingSource;
            bindingSource.ResetBindings(false);

            dataGridView1.Columns[0].Width = 140;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].Width = 144;

            dataGridView1.Columns[0].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[1].HeaderText = "Họ và tên";
            dataGridView1.Columns[2].HeaderText = "Tuổi";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Địa chỉ";         
        }      

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtTuoi.Text = string.Empty;
            txtNgaySinh.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa danh sách không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}