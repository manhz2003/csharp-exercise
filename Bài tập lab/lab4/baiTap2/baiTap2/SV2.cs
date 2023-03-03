using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap2
{
    internal class SV2
    {
        private string MaSinhVien;
        public string maSinhVien { get { return MaSinhVien; } set { maSinhVien = value; } }

        private Person Person;
        public Person person { get { return Person; } set { Person = value; } }

        public SV2 (string MaSinhVien, Person Person)
        {
            this.MaSinhVien= MaSinhVien;
            this.Person = Person;
        }

        public override string ToString()
        {
            return $"Mã sinh viên: {MaSinhVien} \n" + person.ToString();
        }

    }
}
