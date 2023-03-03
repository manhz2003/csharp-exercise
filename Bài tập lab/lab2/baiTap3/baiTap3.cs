namespace baiTap3
{
    internal class baiTap3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào số cần kiểm tra: ");
            int num = int.Parse(Console.ReadLine());
            int i;
            bool b = true;

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    b = false;
                    break;
                }
            }

            if (b)
            {
                Console.WriteLine(num + " là số nguyên tố");
            }
            else
            {
                Console.WriteLine(num + " không phải là số nguyên tố");
            }

            Console.ReadKey();
        }
    }
}