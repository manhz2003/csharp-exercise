namespace baiTap5
{
    internal class baiTap5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số n: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c;
            Console.Write(a + " " + b);

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }

            Console.ReadKey();
        }
    }
}