using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class PhanSo
    {
        private int TuSo;
        private int MauSo;

        public int tuso { get { return TuSo; } set { TuSo = value; } }
        public int muso { get { return MauSo; } set { MauSo = value; } }

        public PhanSo(int TuSo, int MauSo) 
        { 
            this.TuSo = TuSo;
            this.MauSo = MauSo;
        }

        public PhanSo() { }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.MauSo = a.MauSo * b.MauSo;
            c.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            return c;
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.MauSo = a.MauSo - b.MauSo;
            c.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            return c;
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.TuSo = a.TuSo * b.TuSo;
            c.MauSo = a.MauSo * b.MauSo;          
            return c;
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.TuSo = a.TuSo * b.MauSo;
            c.MauSo = a.MauSo * b.TuSo;
            return c;
        }

        public void Nhap()
        {
            Console.Write("Mời nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());

            Console.Write("Mời nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{TuSo}/{MauSo}";
        }        

    }
}
