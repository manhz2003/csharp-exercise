using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class KhachHang
    {
        private string MaKhach;
        private string Tenkhach;
        private string DiaChi;

        public string maKhach{ get { return MaKhach; } set { MaKhach = value; }}
        public string tenKhach { get { return Tenkhach; } set { Tenkhach = value; }}
        public string diaChi { get { return DiaChi; } set { DiaChi = value; }}
        
        public KhachHang() { }

        public KhachHang(string MaKhach, string TenKhach, string DiaChi)
        {
            this.MaKhach = MaKhach;
            this.Tenkhach = TenKhach;
            this.DiaChi = DiaChi;
        }

        public void NhapKhachHang()
        {
            Console.Write("Nhập vào mã khách hàng: ");
            MaKhach = Console.ReadLine();
            Console.Write("Nhập vào tên khách hàng: ");
            tenKhach = Console.ReadLine();
            Console.Write("Nhập vào mã khách hàng: ");
            diaChi = Console.ReadLine();
        }
    }
}
