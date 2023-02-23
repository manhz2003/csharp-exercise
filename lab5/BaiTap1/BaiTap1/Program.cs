namespace BaiTap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo ps = new PhanSo(4, 5);
            PhanSo ps2 = new PhanSo(2, 3);

            Console.WriteLine("cộng = "+(ps + ps2));
            Console.WriteLine("trừ  = " +(ps - ps2));
            Console.WriteLine("nhân = " + (ps * ps2));
            Console.WriteLine("chia = " + (ps / ps2));

            Console.ReadKey();
        }
    }
}