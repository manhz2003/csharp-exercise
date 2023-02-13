namespace baiTap1
{
    internal class baiTap1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào số n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 2; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Tổng của dãy số từ 2 đến " + n + " là: " + sum);
            Console.ReadKey();
        }
    }
}