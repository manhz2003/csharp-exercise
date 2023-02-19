namespace BaiTap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HangHoa hh = new HangHoa();
            hh.NhapHangHoa();

            HoaDon hd = new HoaDon();
            hd.ThemHangHoa(hh);
            hd.ThongTinHangHoa();
            Console.ReadKey();
        }
    }
}