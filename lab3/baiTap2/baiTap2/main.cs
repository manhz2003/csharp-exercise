namespace baiTap2
{
    internal class main
    {
        static void Main(string[] args)
        {
            tamGiac tg = new tamGiac();
            tg.Nhap();
            if (tg.KiemTraTamGiac())
            {
                Console.WriteLine("Chu vi tam giác là: " + tg.ChuViTamGiac());
                Console.WriteLine("Diện tích tam giác là: " + tg.DienTichTamGiac());
            }else
            {
                Console.WriteLine("Đây không phải tam giác !");
            }
            

            Console.ReadKey();
        }
    }
}