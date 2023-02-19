using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap2
{
    internal class tamGiac
    {
        public double CanhA { get; set; }
        public double CanhB { get; set; }
        public double CanhC { get; set; }

        public tamGiac(double a, double b, double c)
        {
            CanhA = a;
            CanhB = b;
            CanhC = c;
        }

        public double TinhChuVi()
        {
            return CanhA + CanhB + CanhC;
        }

        public double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC));
        }

        public bool KiemTraTamGiac()
        {
            if (CanhA + CanhB > CanhC && CanhA + CanhC > CanhB && CanhB + CanhC > CanhA)
            {
                return true;
            }
            return false;
        }
    }
}
