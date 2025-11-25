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
        public void XoaSanPham(int maSP)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM SanPham WHERE MaSP = @MaSP", conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<SanPham> TimKiem(string keyword)
        {
            List<SanPham> list = new List<SanPham>();
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM SanPham WHERE TenSP LIKE @kw", conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(new SanPham
                    {
                        MaSP = (int)rd["MaSP"],
                        TenSP = rd["TenSP"] as string ?? string.Empty,
                        DonGia = (decimal)rd["DonGia"],
                        SoLuongTon = (int)rd["SoLuongTon"],
                        HanSuDung = (DateTime)rd["HanSuDung"]
                    });
                }
            }
            return list;
        }
        private readonly string _connStr = DatabaseConfig.ConnectionString;
            public List<SanPham> GetSanPhamSapHetHan()
        {
            List<SanPham> list = new List<SanPham>();

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM VW_SanPhamSapHetHan", conn);

                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(new SanPham
                    {
                        MaSP = (int)rd["MaSP"],
                        TenSP = rd["TenSP"] as string ?? string.Empty,
                        DonGia = (decimal)rd["DonGia"],
                        SoLuongTon = (int)rd["SoLuongTon"],
                        HanSuDung = (DateTime)rd["HanSuDung"]
                    });
                }
            }
            return list;
        }
        public SanPham? GetById(int id)
        {
            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                           "SELECT MaSP, TenSP, DonGia, SoLuongTon, HanSuDung FROM SanPham WHERE MaSP = @id",
                           conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            return new SanPham
                            {
                                MaSP = (int)rd["MaSP"],
                                TenSP = rd["TenSP"] as string ?? string.Empty,
                                DonGia = (decimal)rd["DonGia"],
                                SoLuongTon = (int)rd["SoLuongTon"],
                                HanSuDung = (DateTime)rd["HanSuDung"]
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
