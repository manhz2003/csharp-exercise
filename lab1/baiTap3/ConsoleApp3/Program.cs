internal class Program
{
    enum So { Mot = 1, Hai, Ba, Bon, Nam, Sau, Bay, Tam, Chin, Muoi };
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhập vào một số: ");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine("Một");
                break;
            case 2:
                Console.WriteLine("Hai");
                break;
            case 3:
                Console.WriteLine("Ba");
                break;
            case 4:
                Console.WriteLine("Bốn");
                break;
            case 5:
                Console.WriteLine("Năm");
                break;
            case 6:
                Console.WriteLine("Sáu");
                break;
            case 7:
                Console.WriteLine("Bảy");
                break;
            case 8:
                Console.WriteLine("Tám");
                break;
            case 9:
                Console.WriteLine("Chín");
                break;
            case 10:
                Console.WriteLine("Mười");
                break;
            default:
                Console.WriteLine("Không tìm thấy kết quả");
                break;
        }
    }
}