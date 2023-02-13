namespace baiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhập vào chiều cao: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("nhập vào bán kính: ");
            double r = double.Parse(Console.ReadLine());

            double sxq = 2 * Math.PI * h * r;
            Console.WriteLine("diện tích xung quanh của hình trụ là: {0:0.00}", sxq);

            double vxq = Math.PI * r * r * h;
            Console.WriteLine("thể tích hình trụ là: {0:0.00}", vxq);
        }
    }
}