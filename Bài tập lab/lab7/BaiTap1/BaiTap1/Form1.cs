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
    public partial class Form1 : Form
    {
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        public Form1()
        {
            InitializeComponent();
        }      

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSV.Text;
            string HoTen = txtHoTen.Text;
            string NgaySinh = txtNgaySinh.Text;
            string DiaChi = txtDiaChi.Text;
            string Empty = string.Empty;
            int Tuoi = 0;

            if(MaSV == Empty || HoTen == Empty || NgaySinh == Empty || DiaChi == Empty)
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
            

            SinhVien sv = new SinhVien(MaSV, HoTen, Tuoi, NgaySinh, DiaChi);
            danhSachSinhVien.Add(sv);
            
            foreach (SinhVien item in danhSachSinhVien)
            {
                ListViewItem lvItem = new ListViewItem(item.masv);
                lvItem.SubItems.Add(item.hoten);
                lvItem.SubItems.Add(item.tuoi.ToString());
                lvItem.SubItems.Add(item.ngaysinh);
                lvItem.SubItems.Add(item.diachi);
                listView1.Items.Add(lvItem);
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // xóa dữ liệu trong textBox
            txtMaSV.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtTuoi.Text = string.Empty;
            txtNgaySinh.Text = string.Empty;
            txtDiaChi.Text = string.Empty;

            // Xóa ảnh trên khung ảnh
            pictureBox1.Image = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (danhSachSinhVien.Count == 0)
            {
                MessageBox.Show("Bạn chưa có dữ liệu để xóa.");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa danh sách không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                listView1.Items.Clear();
            }
        }


    }
}
