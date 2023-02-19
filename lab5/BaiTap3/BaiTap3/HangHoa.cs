using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class HangHoa
    {
        private string MaHang;
        private string TenHang;
        private double DonGia;

       public string maHang {set { MaHang = value; } get { return MaHang; }}

        public string tenHang {set { TenHang = value; } get { return TenHang; } }

        public double donGia { set { DonGia = value;} get { return DonGia; } }

        public HangHoa() { }

        public HangHoa (string MaHang, string TenHang, double DonGia)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.DonGia = DonGia;
        }

        public void NhapHangHoa()
        {
            Console.Write("Nhập vào mã hàng: ");
            MaHang = Console.ReadLine();

            Console.Write("Nhập vào tên hàng: ");
            TenHang = Console.ReadLine();

            Console.Write("Nhập vào đơn giá: ");
            DonGia = double.Parse(Console.ReadLine());
        }

    }
}
