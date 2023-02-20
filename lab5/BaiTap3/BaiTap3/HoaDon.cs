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

        // tạo đối tượng hàng hóa
        HangHoa hh = new HangHoa();

        // tạo getter và setter cho khách hàng
        public KhachHang khachHang{ get { return khachHang; } set { khachHang = value; } }       
        
        public List <HoaDon> hoaDonList 
        { 
            get { return hoaDonList; } 
            set { hoaDonList = value; } 
        }
        
        // tạo hàm thêm đối tượng
        public void ThemHangHoaN()
        {
            Console.Write("Nhập vào số lượng hàng hóa cần thêm: ");
            int z = int.Parse(Console.ReadLine());
            for (int i = 0; i < z; i++)
            {
                
                hh.NhapHangHoa();
                HangHoaList.Add(hh);
                Console.WriteLine("Bạn đã thêm hàng hóa vào danh sách");
            }
        }

        public void XoaHangHoa()
        {
            if (HangHoaList.Contains(hh))
            {
                HangHoaList.Remove(hh);
                Console.WriteLine("Bạn đã xóa danh sách hàng hóa thành công !");
            }
            else
            {
                Console.WriteLine("Không tìm thấy hàng hóa cần xóa trong danh sách !");
            }
        }

        public void ThongTinHangHoa()
        {
            if (HangHoaList.Count == 0)
            {
                Console.WriteLine("Danh sách hàng hóa hiện tại đang rỗng!");
                return;
            }

            Console.WriteLine("Danh sách hàng hóa: ");
            foreach (HangHoa h in HangHoaList)
            {
                Console.WriteLine($"Mã hàng: {h.maHang}, Tên hàng: {h.tenHang}, giá hàng: {h.donGia}");
            }
        }

        public void TimHangHoaGiaCaoNhat()
        {
            if (HangHoaList.Count == 0)
            {
                Console.WriteLine("Danh sách hàng hóa rỗng, bạn cần nhập thông tin trước !");
                return;
            }

            HangHoa maxGiaHangHoa = HangHoaList[0];
            foreach (HangHoa h in HangHoaList)
            {
                if (h.donGia > maxGiaHangHoa.donGia)
                {
                    maxGiaHangHoa = h;
                }
            }

            Console.WriteLine("Hàng hóa có giá cao nhất là:");
            Console.WriteLine("Mã hàng: {0}, Tên hàng: {1}, Đơn giá: {2}", maxGiaHangHoa.maHang, maxGiaHangHoa.tenHang, maxGiaHangHoa.donGia);
        }


    }
    }

