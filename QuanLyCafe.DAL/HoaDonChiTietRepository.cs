using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyCafe.Models;

namespace QuanLyCafe.DAL.Repositories
{
    public class HoaDonChiTietRepository
    {
        public void ThemChiTiet(int maHd, int maSp, int soLuong)
        {
            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand("SP_ThemCTHD", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHD", maHd);
                    cmd.Parameters.AddWithValue("@MaSP", maSp);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<HoaDonChiTiet> GetByHoaDon(int maHd)
        {
            var result = new List<HoaDonChiTiet>();

            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                           @"SELECT ID, MaHD, MaSP, SoLuong, DonGia 
                             FROM HoaDonChiTiet 
                             WHERE MaHD = @MaHD", conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", maHd);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new HoaDonChiTiet
                            {
                                ID = (int)reader["ID"],
                                MaHD = (int)reader["MaHD"],
                                MaSP = (int)reader["MaSP"],
                                SoLuong = (int)reader["SoLuong"],
                                DonGia = (decimal)reader["DonGia"]
                            });
                        }
                    }
                }
            }

            return result;
        }
    }
}
