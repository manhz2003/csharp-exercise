using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap2
{
    internal class tamGiac
    {
        private double a;
        private double b;
        private double c;

        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double C { get { return c; } set { c = value; } }

        public double ChuViTamGiac()
        {
            return a + b+ c;
            
        }

        public double DienTichTamGiac ()
        {
            double p = ChuViTamGiac() / 2;
            return  Math.Sqrt((p - a) * (p-b) *(p-c));
        }


        public bool KiemTraTamGiac()
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }

        public void Nhap()
        {
            Console.Write("Nhập vào cạnh a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào cạnh b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào cạnh c: ");
            c = double.Parse(Console.ReadLine());
        }
    }
}
