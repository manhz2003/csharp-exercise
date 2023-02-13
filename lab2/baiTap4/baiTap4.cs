namespace baiTap4
{
    internal class baiTap4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập chiều dài cạnh thứ nhất: ");
            double canh1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều dài cạnh thứ hai: ");
            double canh2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều dài cạnh thứ ba: ");
            double canh3 = double.Parse(Console.ReadLine());

            if (canh1 + canh2 > canh3 && canh1 + canh3 > canh2 && canh2 + canh3 > canh1)
            {
                Console.WriteLine("Đây là tam giác");

                if (canh1 == canh2 && canh2 == canh3)
                {
                    Console.WriteLine("Tam giác đều");
                }
                else if (canh1 == canh2 || canh2 == canh3 || canh1 == canh3)
                {
                    Console.WriteLine("Tam giác cân");
                }
                else
                {
                    Console.WriteLine("Tam giác thường");
                }
            }
            else
            {
                Console.WriteLine("Đây không phải là tam giác");
            }
            Console.ReadKey();
        }
    }
}