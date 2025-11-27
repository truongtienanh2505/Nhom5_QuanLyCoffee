using Microsoft.Data.SqlClient;

namespace QuanLyCafe.DAL
{
   
    public static class DatabaseConfig
    {
       
        public static string ConnectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=QuanLyCoffee;User Id=sa;Password=123456;TrustServerCertificate=True;";


        public static SqlConnection Connection
        {
            get
            {
                var conn = new SqlConnection(ConnectionString);
                conn.Open();
                return conn;
            }
        }
    }
}
