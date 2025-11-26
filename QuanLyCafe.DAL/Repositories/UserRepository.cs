using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.Models;


namespace QuanLyCafe.DAL.Repositories
{
    public class UserRepository
    {
        public User? Login(string username, string password)
        {
            using (var conn = DatabaseConfig.Connection)
            {
                string query = "SELECT * FROM NguoiDung WHERE TenDangNhap=@u AND MatKhau=@p";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserId = (int)reader["MaND"],
                        Username = reader["MaND"] as string ?? string.Empty
                    };
                }
            }
            return null;
        }
    }
}
