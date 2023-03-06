namespace BaiTap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            So s = new So();
            // nhập số để kiểm tra
            s.Nhap();

            // kiểm tra số chẵn lẻ
            s.KiemTraChanLe();

            // kiểm tra số nguyên tố
            s.KiemTraSoNguyenTo();

            // Kiểm tra số hoàn hảo
            s.KiemTraSohoanHao();

            // nạp chồng tính toán cộng trừ nhân chia 2 số, truyền qua contructor
            So x = new So(10);
            So y = new So(5);                      

            Console.WriteLine($"\n{x} + {y} = " + (x+y).ToString());
            Console.WriteLine($"{x} - {y} = " + (x-y).ToString());
            Console.WriteLine($"{x} * {y} = " + (x*y ).ToString());
            Console.WriteLine($"{x} / {y} = " + (x/y).ToString());

        }
    }
}