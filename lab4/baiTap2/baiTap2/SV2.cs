using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap2
{
    internal class SV2 : Person
    {
        public string MaSinhVien { get; set; }
        public string ThongTinCaNhan { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nMã sinh viên: {MaSinhVien}\nThông tin cá nhân: {ThongTinCaNhan}";
        }
    }
}
