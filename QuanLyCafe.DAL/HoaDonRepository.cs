using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyCafe.Models;

namespace QuanLyCafe.DAL.Repositories
{
    public class HoaDonRepository
    {
        public int TaoHoaDon(int? maKh)
        {
            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand("SP_TaoHoaDon", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKH", (object?)maKh ?? DBNull.Value);

                    var result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }

        public void TinhTienHoaDon(int maHd)
        {
            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand("SP_TinhTienHoaDon", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHD", maHd);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public HoaDon? GetById(int maHd)
        {
            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                           @"SELECT MaHD, MaKH, NgayGD, TongTien, KhuyenMai, SoTienPhaiTra 
                             FROM HoaDon WHERE MaHD = @MaHD", conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", maHd);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new HoaDon
                            {
                                MaHD = (int)reader["MaHD"],
                                MaKH = reader["MaKH"] == DBNull.Value ? null : (int?)reader["MaKH"],
                                NgayGD = (DateTime)reader["NgayGD"],
                                TongTien = (decimal)reader["TongTien"],
                                KhuyenMai = (decimal)reader["KhuyenMai"],
                                SoTienPhaiTra = (decimal)reader["SoTienPhaiTra"]
                            };
                        }
                    }
                }
            }

            return null;
        }

        public List<HoaDon> GetByDate(DateTime from, DateTime to)
        {
            var result = new List<HoaDon>();

            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                           @"SELECT MaHD, MaKH, NgayGD, TongTien, KhuyenMai, SoTienPhaiTra 
                             FROM HoaDon 
                             WHERE NgayGD BETWEEN @From AND @To", conn))
                {
                    cmd.Parameters.AddWithValue("@From", from);
                    cmd.Parameters.AddWithValue("@To", to);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new HoaDon
                            {
                                MaHD = (int)reader["MaHD"],
                                MaKH = reader["MaKH"] == DBNull.Value ? null : (int?)reader["MaKH"],
                                NgayGD = (DateTime)reader["NgayGD"],
                                TongTien = (decimal)reader["TongTien"],
                                KhuyenMai = (decimal)reader["KhuyenMai"],
                                SoTienPhaiTra = (decimal)reader["SoTienPhaiTra"]
                            });
                        }
                    }
                }
            }

            return result;
        }
    }
}
