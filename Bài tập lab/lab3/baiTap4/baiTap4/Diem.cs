using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap4
{
    internal class Diem
    {
        private int x, y;
        public int X { get { return x; }  set { x = value; } }
        public int Y { get { return y; } set { y = value; } } 

        public Diem(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double TinhKhoangCach(Diem diemKhac)
        {
            int deltaX = this.x - diemKhac.x;
            int deltaY = this.y - diemKhac.y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
