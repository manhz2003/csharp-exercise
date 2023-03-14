using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class SinhVien
    {
        private string MaSV;
        private string HoTen;
        private int Tuoi;
        private string NgaySinh;
        private string DiaChi;

        public string masv { get { return MaSV; } set { MaSV = value; } }
        public string hoten { get { return HoTen; } set { HoTen = value; } }
        public int tuoi { get { return Tuoi; } set { Tuoi = value; } }
        public string ngaysinh { get { return NgaySinh; } set { NgaySinh = value; } }
        public string diachi { get { return DiaChi; } set { DiaChi = value; } }

        public SinhVien() { }

        public SinhVien(string MaSV, string HoTen, int Tuoi, string NgaySinh, string DiaChi)
        {
            this.MaSV = MaSV;
            this.HoTen = HoTen;
            this.Tuoi = Tuoi;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
        }

    }
}
