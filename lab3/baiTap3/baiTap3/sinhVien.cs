using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap3
{
    internal class sinhVien
    {
        public string tenSV;
        public int tuoiSV;
        public float diemSV;

        public sinhVien(string ten, int tuoi, float diem)
        {
            tenSV = ten;
            tuoiSV = tuoi;
            diemSV = diem;
        }

        public void HienThi()
        {
            Console.WriteLine("Tên sinh viên: " + tenSV);
            Console.WriteLine("Tuổi sinh viên: " + tuoiSV);
            Console.WriteLine("Điểm sinh viên: " + diemSV);
        }
    }
}
