using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TongHaiSoDAL;


namespace TongHaiSoBUS
{
    public class CalcBUS
    {
        CalcDAL dal = new CalcDAL();
        public int GetSum(int a, int b)
        {

            try
            {
                return dal.GetSum(a, b);
            }
            catch (Exception ex)
            {
                // Xử lý exception
                throw ex;
            }
        }

    }
}
