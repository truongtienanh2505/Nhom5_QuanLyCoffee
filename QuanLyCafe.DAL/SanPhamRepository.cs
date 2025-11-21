using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyCafe.Models;

namespace QuanLyCafe.DAL.Repositories
{
    public class SanPhamRepository
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
                        cmd.CommandType = CommandType.StoredProcedure;
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
                        cmd.CommandType = CommandType.StoredProcedure;
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
        }
    }
}