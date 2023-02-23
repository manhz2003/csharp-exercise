using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap3
{
    internal class sinhVien
    {
        private string tenSV;
        private int tuoiSV;
        private float diemSV;

        public string tensv { get; set; }
        public int tuoisv { get; set; }
        public string diemsv { get; set; }

        public sinhVien(string tenSV, int tuoiSV, float diemSV)
        {
            this.tenSV = tenSV;
            this.tuoiSV = tuoiSV;
            this.diemSV = diemSV;
        }

        public void HienThi()
        {
            Console.WriteLine("{0,-15} {1,-10} {2,-10}", "Tên", "Tuổi", "Điểm");           
            Console.WriteLine("{0,-15} {1,-10} {2,-10:N1}", tenSV, tuoiSV, diemSV);
        }
    }
}
