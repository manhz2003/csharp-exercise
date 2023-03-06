using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class So
    {
       
        private int a;

        // xây dựng hàm get set để public dữ liệu cho biến private
        public int A { get { return a; } set { a = value; } }
      
        // contructor rỗng để tạo đối tượng
        public So()
        {

        }

        // hàm nhập để kiểm tra số
        public void Nhap()
        {
            Console.Write("Nhập vào giá trị a = ");
            a = int.Parse(Console.ReadLine());
        }


        // kiểm tra chẵn lẻ
        public void KiemTraChanLe()
        {
            if(a % 2 == 0)
            {
                Console.WriteLine("Đây là số chẵn !");
            }else
            {
                Console.WriteLine("Đây là số lẻ !");
            }
        }
        
        // kiểm tra số nguyên tố
        public void KiemTraSoNguyenTo()
        {            
            bool b = true;

            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    b = false;
                    break;
                }
            }

            if (b)
            {
                Console.WriteLine("Đây là số nguyên tố !");
            }
            else
            {
                Console.WriteLine("Đây không phải là số nguyên tố !");
            }
        }

        // kiểm tra số hoàn hảo
        public void KiemTraSohoanHao()
        {
            int sum = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == a)
            {
                Console.WriteLine("Đây là số hoàn hảo !");
            }else
            {
                Console.WriteLine("Đây không phải số hoàn hảo !");
            }

        }

        // contructor nhập giá trị vào để tính toán nạp chồng
        public So(int a)
        {
            this.a = a;
        }

        // nạp chồng phương thức
        public static So operator +(So x, So y)
        {
            return new So(x.a + y.a);
        }

        public static So operator -(So x, So y)
        {
            return new So(x.a - y.a);
        }

        public static So operator *(So x, So y)
        {
            return new So(x.a + y.a);
        }

        public static So operator /(So x, So y)
        {
            return new So(x.a / y.a);
        }

        // hiển thị
        public override string ToString()
        {
            return a.ToString();
        }


    }
}
