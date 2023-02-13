﻿namespace baiTap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("1. tam giác vuông đặc");
                Console.WriteLine("2. tam giác vuông rỗng");
                Console.WriteLine("3. hình vuông rỗng");
                Console.WriteLine("Nhập vào số để chọn hình: ");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Tam giác vuông đặc: ");
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Tam giác vuông rỗng: ");
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                if (i == 0 || j == 0 || j == i)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Hình vuông rỗng: ");
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (i == 0 || i == 4 || j == 0 || j == 4)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.WriteLine("không hợp lệ.");
                        break;
                }
            Console.ReadKey();
        }
    }
}