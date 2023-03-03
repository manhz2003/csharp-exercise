using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class So
    {
        private int param;
        public int Param { get { return param; } set { param = value; } }
        public So (int param) { this.param = param; }
        
        public static So operator +(So a, So b)
        {
            return new So(a.Param + b.Param);
        }

        public static So operator -(So a, So b)
        {
            return new So(a.Param - b.Param);
        }

        public static So operator *(So a, So b)
        {
            return new So(a.Param * b.Param);
        }

        public static So operator /(So a, So b)
        {
            return new So(a.Param / b.Param);
        }

        public void SoNguyenTo()
        {
            if (param < 2)
            {
                Console.WriteLine("Đây không phải số nguyên tố !");
                return;
            }

            bool laSoNguyenTo = true;
            for (int i = 2; i <= Math.Sqrt(param); i++)
            {
                if (param % i == 0)
                {
                    laSoNguyenTo = false;
                    break;
                }
            }

            if (laSoNguyenTo)
            {
                Console.WriteLine("Đây là số nguyên tố");
            }
            else
            {
                Console.WriteLine("Đây không phải số nguyên tố !");
            }
        }




        public void ChanLe()
        {
            if(param % 2== 0)
            {
                Console.WriteLine("Đây là số chẵn !");
            }else
            {
                Console.WriteLine("Đây là số lẻ !");
            }
        }

        public override string ToString()
        {
            return param.ToString();
        }
    }
}
