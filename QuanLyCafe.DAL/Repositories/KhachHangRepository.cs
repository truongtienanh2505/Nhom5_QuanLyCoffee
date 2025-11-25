using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using QuanLyCafe.Models;

namespace QuanLyCafe.DAL.Repositories
{
    public class KhachHangRepository
    {
        public List<KhachHang> GetAll()
        {
            var result = new List<KhachHang>();

            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                           "SELECT MaKH, TenKH, SDT, DiaChi FROM KhachHang", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new KhachHang
                        {
                            MaKH = (int)reader["MaKH"],
                            TenKH = (string)reader["TenKH"],
                            SDT = (string)reader["SDT"],
                            DiaChi = (string)reader["DiaChi"]
                        });
                    }
                }
            }

            return result;
        }

        public KhachHang? GetById(int maKh)
        {
            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                           "SELECT MaKH, TenKH, SDT, DiaChi FROM KhachHang WHERE MaKH = @MaKH", conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKh);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new KhachHang
                            {
                                MaKH = (int)reader["MaKH"],
                                TenKH = (string)reader["TenKH"],
                                SDT = (string)reader["SDT"],
                                DiaChi = (string)reader["DiaChi"]
                            };
                        }
                    }
                }
            }

            return null;
        }

        public void ThemKhachHang(KhachHang kh)
        {
            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand("SP_ThemKhachHang", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                    cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                    cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SuaKhachHang(KhachHang kh)
        {
            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand("SP_SuaKhachHang", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                    cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                    cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                    cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void XoaKhachHang(int maKh)
        {
            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                           "DELETE FROM HoaDon WHERE MaKH = @MaKH; " +
                           "DELETE FROM KhachHang WHERE MaKH = @MaKH;", conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKh);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<KhachHang> TimKiem(string keyword)
        {
            var list = new List<KhachHang>();

            keyword = keyword ?? "";

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                string query = "SELECT MaKH, TenKH, SDT, DiaChi FROM KhachHang WHERE TenKH LIKE @kw OR SDT LIKE @kw";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
<<<<<<< HEAD
<<<<<<< HEAD
                    cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");

=======
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
>>>>>>> 4a19a492e43cb4f94bae5345c185c9bbe5ed24d3
=======
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
>>>>>>> origin/Kieu_nx
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new KhachHang
                            {
                                MaKH = reader["MaKH"] != DBNull.Value ? (int)reader["MaKH"] : 0,
<<<<<<< HEAD
<<<<<<< HEAD
                                TenKH = reader["TenKH"]?.ToString() ?? "",
                                SDT = reader["SDT"]?.ToString() ?? "",
                                DiaChi = reader["DiaChi"]?.ToString() ?? ""
=======
                                TenKH = reader["TenKH"] != DBNull.Value ? reader["TenKH"].ToString() : string.Empty,
                                SDT = reader["SDT"] != DBNull.Value ? reader["SDT"].ToString() : string.Empty,
                                DiaChi = reader["DiaChi"] != DBNull.Value ? reader["DiaChi"].ToString() : string.Empty
>>>>>>> 4a19a492e43cb4f94bae5345c185c9bbe5ed24d3
=======
                                TenKH = reader["TenKH"] != DBNull.Value ? reader["TenKH"].ToString() : string.Empty,
                                SDT = reader["SDT"] != DBNull.Value ? reader["SDT"].ToString() : string.Empty,
                                DiaChi = reader["DiaChi"] != DBNull.Value ? reader["DiaChi"].ToString() : string.Empty
>>>>>>> origin/Kieu_nx
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
