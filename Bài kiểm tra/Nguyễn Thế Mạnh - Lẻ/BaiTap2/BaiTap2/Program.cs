namespace BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.Nhap();
            Console.WriteLine(sv.ToString());
        }

    }
}