namespace BaiTap3
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            HoaDon hd = new HoaDon();
            
            int n = 0;
            do
            {
                Console.WriteLine("+---------------------------------------------------------+");
                Console.WriteLine("| chọn phím [1] để nhập và thêm thông tin hàng hóa.       |");
                Console.WriteLine("| chọn phím [2] để xem thông tin hàng hóa.                |");
                Console.WriteLine("| chọn phím [3] để xóa thông tin hàng hóa khỏi danh sách. |");
                Console.WriteLine("| chọn phím [4] để tìm kiếm hàng hóa có giá cao nhất.     |");
                Console.WriteLine("| chọn phím [0] để dừng chương trình.                     |");
                Console.WriteLine("+---------------------------------------------------------+");
                Console.Write("Mời chọn chức năng: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {                   
                    case 1: hd.ThemHangHoaN(); break;
                    case 2: hd.ThongTinHangHoa(); break;
                    case 3: hd.XoaHangHoa(); break;
                    case 4: hd.TimHangHoaGiaCaoNhat() ; break;
                    case 0: Console.WriteLine("Bạn đã dừng chương trình !"); break;
                    default:Console.WriteLine("Chọn sai mời chọn lại !"); break;
                }
            } while (n !=0);
                      
            Console.ReadKey();
        }
    }
}