namespace baiTap2
{
    internal class baiTap2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + 1.0 / i;
            }
            Console.WriteLine("Tổng s = 1 + 1/2 +... + 1/n = " + s);
            Console.ReadKey();
        }
    }
}