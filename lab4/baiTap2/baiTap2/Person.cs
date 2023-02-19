using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap2
{
    internal class Person
    {
        public string HoTen { get; set; }
        public string CMND { get; set; }
        public string QueQuan { get; set; }
        public string GhiChu { get; set; }

        public override string ToString()
        {
            return $"Họ tên: {HoTen}\nCMND: {CMND}\nQuê quán: {QueQuan}\nGhi chú: {GhiChu}";
        }
    }
}
