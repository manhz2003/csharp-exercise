using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class SinhVien
    {
        private string HoTen;
        private int Tuoi;
        private string NgaySinh;
        private string DiaChi;
        private double DiemHocKy;

        public string hoten { get { return HoTen; } set { HoTen = value; } }
        public int tuoi { get { return Tuoi; } set { Tuoi = value; } }
        public string diachi { get { return DiaChi; } set { DiaChi = value; } }

        public double diem { get { return DiemHocKy; } set { DiemHocKy = value; } }

        public string ngaySinh { get { return NgaySinh; } set { NgaySinh = value; } }

        public void Nhap()
        {
            Console.Write("Nhập vào họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập vào tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhập vào ngày sinh: ");
            NgaySinh = Console.ReadLine();

            Console.Write("Nhập vào địa chỉ: ");
            DiaChi = Console.ReadLine();
          
        }

        public override string ToString()
        {
            return $"Họ tên sinh viên là: {HoTen} \nTuổi là: {Tuoi} \nNgày sinh: {NgaySinh} \nĐịa chỉ {DiaChi} \nĐiểm học kỳ: {DiemHocKy}";
        }


    }
}
