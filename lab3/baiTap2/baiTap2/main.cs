namespace baiTap2
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap canh A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap canh B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap canh C: ");
            double c = Convert.ToDouble(Console.ReadLine());
            tamGiac tamGiac = new tamGiac(a, b, c);
            if (tamGiac.KiemTraTamGiac())
            {
                Console.WriteLine("Chu vi cua tam giac la: " + tamGiac.TinhChuVi());
                Console.WriteLine("Dien tich cua tam giac la: " + tamGiac.TinhDienTich());
            }
            else
            {
                Console.WriteLine("Khong phai la tam giac");
            }
            Console.ReadKey();
        }
    }
}