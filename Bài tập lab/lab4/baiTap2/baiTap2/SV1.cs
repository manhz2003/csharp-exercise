using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap2
{
    internal class SV1 : Person
    {
        public string MaSinhVien { get; set; }
        public SV1(string MaSinhVien, string HoTen, string CMND, string QueQuan, string GhiChu) : base(HoTen, CMND, QueQuan, GhiChu)
        {
            // tham chiếu đến contructor ở lớp cha person
        }

        public override string ToString()
        {
            return  $"Mã sinh viên: {MaSinhVien} \n" + base.ToString();
        }
    }
}
