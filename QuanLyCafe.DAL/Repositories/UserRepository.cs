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
        public User Login(string username, string password)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE Username=@u AND Password=@p";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserId = (int)reader["UserId"],
                        Username = reader["Username"].ToString()
                    };
                }
            }
            return null;
        }
    }
}
