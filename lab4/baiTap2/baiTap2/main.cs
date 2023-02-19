namespace baiTap2
{
    internal class main
    {
        static void Main(string[] args)
        {
            SV1 sv1 = new SV1
            {
                HoTen = "Nguyễn Thế Mạnh",
                CMND = "123456789",
                QueQuan = "Hà Nội",
                GhiChu = "Đang là sinh viên",
                MaSinhVien = "SV001"
            };

            Console.WriteLine(sv1);

            SV2 sv2 = new SV2
            {
                HoTen = "Lương Thị Lan Anh",
                CMND = "987654321",
                QueQuan = "Hồ Chí Minh",
                GhiChu = "Đang là sinh viên",
                MaSinhVien = "SV002",
                ThongTinCaNhan = "Ngành CNTT"
            };

            Console.WriteLine(sv2);
            Console.ReadKey();
        }
    }
}