namespace baiTap2
{
    internal class main
    {
        static void Main(string[] args)
        {
           SV1 sv1 = new SV1 ("20210719", "Nguyễn Thế Mạnh", "947324347989", "Hà Nội", "Backend java developer");           
           Console.WriteLine(sv1.ToString());

           Person p2 = new Person("Tuyên Quang", "Lương Thị Lan Anh", "73204832423", "Backend java developer");
           SV2 sv2 = new SV2("20210997", p2);
           Console.WriteLine(sv2.ToString());
           Console.ReadKey();
        }
    }
}