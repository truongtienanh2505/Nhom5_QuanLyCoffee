using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyCafe.Models;

namespace QuanLyCafe.DAL.Repositories
{
    public class SanPhamRepository
    {
        public List<SanPham> GetAll()
        {
            var result = new List<SanPham>();

            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                           "SELECT MaSP, TenSP, DonGia, SoLuongTon, HanSuDung FROM SanPham", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new SanPham
                        {
                            MaSP = (int)reader["MaSP"],
                            TenSP = (string)reader["TenSP"],
                            DonGia = (decimal)reader["DonGia"],
                            SoLuongTon = (int)reader["SoLuongTon"],
                            HanSuDung = (DateTime)reader["HanSuDung"]
                        });
                    }
                }
            }

            return result;
        }

        public void ThemSanPham(SanPham sp)
        {
            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand("SP_ThemSanPham", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                    cmd.Parameters.AddWithValue("@DonGia", sp.DonGia);
                    cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                    cmd.Parameters.AddWithValue("@HanSuDung", sp.HanSuDung);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SuaSanPham(SanPham sp)
        {
            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand("SP_SuaSanPham", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                    cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                    cmd.Parameters.AddWithValue("@DonGia", sp.DonGia);
                    cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                    cmd.Parameters.AddWithValue("@HanSuDung", sp.HanSuDung);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
