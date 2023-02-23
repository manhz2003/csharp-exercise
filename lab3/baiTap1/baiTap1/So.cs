using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class So
    {
        private int a;
        private int b;

        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }

        public void Cong ()
        {
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
        }

        public void Tru()
        {
            int c = a - b;
            Console.WriteLine($"{a} - {b} = {c}");
        }

        public void Nhan()
        {
            int c = a * b;
            Console.WriteLine($"{a} x {b} = {c}");
        }

        public void Chia()
        {   
                       
            int c = a / b;
            Console.WriteLine($"{a} / {b} = {c}");

        }

        public void nhap ()
        {
            Console.Write("Nhập vào a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào b: ");
            b = int.Parse(Console.ReadLine());
        }

    }
}
