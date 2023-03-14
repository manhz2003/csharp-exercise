using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHaiSoDAL
{
    public class CalcDAL
    {
        private string connectionString = "Data Source=DESKTOP-PGUV9BA;Initial Catalog=TinhTongHaiSo;Integrated Security=True";
        public int GetSum(int a, int b)
        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "GetSum";

                command.Parameters.AddWithValue("@a", a);
                command.Parameters.AddWithValue("@b", b);

                result = (int)command.ExecuteScalar();

                // Lưu dữ liệu vào database
                SqlCommand insertCommand = new SqlCommand();
                insertCommand.Connection = connection;
                insertCommand.CommandType = System.Data.CommandType.Text;
                insertCommand.CommandText = "INSERT INTO calc (a, b, result) VALUES (@a, @b, @result)";

                insertCommand.Parameters.AddWithValue("@a", a);
                insertCommand.Parameters.AddWithValue("@b", b);
                insertCommand.Parameters.AddWithValue("@result", result);

                insertCommand.ExecuteNonQuery();
            }

            return result;
        }



    }
}
