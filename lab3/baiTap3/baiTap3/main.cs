namespace baiTap3
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào thông tin sinh viên");
            Console.WriteLine("Nhập tên sinh viên: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhập tuổi sinh viên: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm sinh viên: ");
            float diem = float.Parse(Console.ReadLine());

            sinhVien sv = new sinhVien(ten, tuoi, diem);
            Console.WriteLine("Thông tin sinh viên: ");
            sv.HienThi();
        }
    }
}