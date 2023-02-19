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
        private List<HangHoa> HangHoaList = new List<HangHoa>();

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
            this.KhachHang = KhachHang;
            HangHoaList = new List<HangHoa>();
        }

        // tạo hàm nhập nhiều lần
        public void NhapHangHoaN()
        {
            Console.Write("Nhập vào số lượng hàng hóa cần thêm: ");
            int z = int.Parse(Console.ReadLine());
            for (int i = 0; i < z; i++)
            {
                HangHoa hh = new HangHoa();
                hh.NhapHangHoa();
                HangHoaList.Add(hh);
            }
        }

        public void ThemHangHoa(HangHoa HangHoa)
        {
           
            HangHoaList.Add(HangHoa);
            Console.WriteLine("Bạn đã thêm vào danh sách");
        }

        public void XoaHangHoa (HangHoa HangHoa)
        {
            HangHoaList.Remove(HangHoa);
            Console.WriteLine("Bạn đã xóa danh sách hàng hóa thành công !");
        }

        public void ThongTinHangHoa()
        {
            Console.WriteLine("danh sách hàng hóa: ");
            foreach (HangHoa h in HangHoaList)
            {
                if (h != null) // chỉ in ra các giá trị hàng hóa khác null
                {
                    Console.WriteLine($"Ma hang: {h.maHang}, Ten hang: {h.tenHang}, Don gia: {h.donGia}");
                }
            }
        }

        

       
        }

    }

