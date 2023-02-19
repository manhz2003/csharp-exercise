namespace lab3
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào giá trị của a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào giá trị của b: ");
            int b = int.Parse(Console.ReadLine());

            So soA = new So(a);
            So soB = new So(b);

            Console.WriteLine("Tổng của 2 số là: " + soA.Cong(soB));
            Console.WriteLine("Hiệu của 2 số là: " + soA.Tru(soB));
            Console.WriteLine("Tích của 2 số là: " + soA.Nhan(soB));
            Console.WriteLine("Thương của 2 số là: " + soA.Chia(soB));
            Console.ReadKey();
        }
    }
}