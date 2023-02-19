namespace baiTap1
{
    internal class main
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                HoTen = "Nguyễn Thế Mạnh",
                CMND = "001205031554",
                QueQuan = "Hà Nội",
                GhiChu = "backend java developer"
            };

            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}