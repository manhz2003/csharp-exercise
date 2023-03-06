using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    public class HangHoa
    {
        private string TenHang;
        private string MaHang;
        private int SoLuong;
        private string XuatXu;
        private double GiaBan;

        public string tenhang { get { return TenHang; } set { TenHang = value; } }
        public string mahang { get { return MaHang; } set { MaHang = value; } }
        public int soluong { get { return SoLuong; } set { SoLuong = value; } }
        public string xuatxu { get { return XuatXu; } set { XuatXu = value; } }
        public double giaban { get { return GiaBan; } set { GiaBan = value; } }

        public HangHoa() { }

        
    }
}
