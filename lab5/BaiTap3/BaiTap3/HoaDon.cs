using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class HoaDon
    {
        private KhachHang KhachHang;
        private List<HangHoa> HangHoaList;

        // tạo getter và setter cho khách hàng
        public KhachHang khachHang{
            get { return khachHang; }
            set { khachHang = value; }
}       
        // tạo getter và setter cho hóa đơn
        public List <HoaDon> hoaDonList 
        { 
            get { return hoaDonList; } 
            set { hoaDonList = value; } 
        }  

        // tạo contructor cho class hóa đơn

        // contructor rỗng
        public HoaDon() { }

        // contructor truyền các tham số cần nhập vào
        public HoaDon(KhachHang KhachHang)
        {
            this.khachHang = KhachHang;
            HangHoaList = new List<HangHoa>();

        }

        public void ThemHangHoa(HangHoa HangHoa)
        {
            HangHoaList.Add(HangHoa);
        }

        public void ThongTinHangHoa()
        {
            Console.WriteLine("danh sách hàng hóa: ");
            foreach (HangHoa h in HangHoaList)
            {
                Console.WriteLine ($"Ma hang: {h.maHang}, Ten hang: {h.tenHang}, Don gia: {h.donGia}");
            }
        }


    }
}
