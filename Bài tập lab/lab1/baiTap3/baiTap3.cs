namespace baiTap3
{
    internal class Program
    {
        enum Numbers
        {
            Mot = 1, Hai = 2, Ba = 3, Bon = 4, Nam = 5
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào một số bất kỳ: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case (int)Numbers.Mot:
                    Console.WriteLine("Một");
                    break;
                case (int)Numbers.Hai:
                    Console.WriteLine("Hai");
                    break;
                case (int)Numbers.Ba:
                    Console.WriteLine("Ba");
                    break;
                case (int)Numbers.Bon:
                    Console.WriteLine("Bốn");
                    break;
                case (int)Numbers.Nam:
                    Console.WriteLine("Năm");
                    break;
                default:
                    Console.WriteLine("Số bạn nhập không hợp lệ");
                    break;
            }
            Console.ReadKey();
        }
    }
}