using Microsoft.Data.SqlClient;

namespace QuanLyCafe.DAL
{
   
    public static class DatabaseConfig
    {
       
        public static string ConnectionString =
            "Server=localhost;Database=QuanLyCoffee;User Id=sa;Password=123456;TrustServerCertificate=True;";

      
        public static SqlConnection GetConnection()
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
