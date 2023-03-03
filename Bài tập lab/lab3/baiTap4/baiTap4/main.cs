namespace baiTap4
{
    internal class main
    {
        static void Main(string[] args)
        {
            Diem diemA = new Diem(1, 2);
            Diem diemB = new Diem(4, 6);

            double khoangCach = diemA.TinhKhoangCach(diemB);
            Console.WriteLine("Khoảng cách giữa hai điểm là: " + khoangCach);
            Console.ReadKey();
        }
    }
}