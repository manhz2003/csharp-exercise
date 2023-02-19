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

        public So(int a)
        {
            this.a = a;
        }

        public int Cong(So so)
        {
            return this.a + so.a;
        }

        public int Tru(So so)
        {
            return this.a - so.a;
        }

        public int Nhan(So so)
        {
            return this.a * so.a;
        }

        public int Chia(So so)
        {
            return this.a / so.a;
        }
    }
}
