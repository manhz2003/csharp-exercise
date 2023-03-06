namespace BaiTap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();

            ps1.Nhap();
            ps2.Nhap();           

            Console.WriteLine($"{ps1} + {ps2} = " + (ps1 + ps2));
            Console.WriteLine($"{ps1} - {ps2} = " + (ps1 - ps2));
            Console.WriteLine($"{ps1} * {ps2} = " + (ps1 * ps2));
            Console.WriteLine($"{ps1} / {ps2} = " + (ps1 / ps2));

            Console.ReadKey();
        }
    }
}