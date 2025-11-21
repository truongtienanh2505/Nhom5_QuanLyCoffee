using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyCafe.Models;

namespace QuanLyCafe.DAL.Repositories
{
    public class NhapKhoRepository
    {
        public void NhapKho(int maSp, int soLuong)
        {
            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand("SP_NhapKho", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSP", maSp);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<NhapKho> GetBySanPham(int maSp)
        {
            var result = new List<NhapKho>();

            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                           @"SELECT MaNK, MaSP, SoLuong, NgayNhap 
                             FROM NhapKho 
                             WHERE MaSP = @MaSP", conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSp);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new NhapKho
                            {
                                MaNK = (int)reader["MaNK"],
                                MaSP = (int)reader["MaSP"],
                                SoLuong = (int)reader["SoLuong"],
                                NgayNhap = (DateTime)reader["NgayNhap"]
                            });
                        }
                    }
                }
            }

            return result;
        }
    }
}