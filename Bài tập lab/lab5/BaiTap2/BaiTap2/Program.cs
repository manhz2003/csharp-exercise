namespace BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            So s1 = new So(2);
            So s2 = new So(5);
            So s3 = s1 + s2;
            Console.WriteLine($"{s1} + {s2} = {s3}");
            Console.WriteLine($"{s1} - {s2} = {s3}");
            Console.WriteLine($"{s1} * {s2} = {s3}");
            Console.WriteLine($"{s1} / {s2} = {s3}");
            s3.ChanLe();
            s3.SoNguyenTo();
            Console.ReadKey();
        }
    }
}