using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using QuanLyCafe.Models;

namespace QuanLyCafe.DAL.Repositories
{
    public class ThongKeRepository
    {
        public List<SanPham> GetSanPhamSapHetHan()
        {
            var result = new List<SanPham>();

            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                           "SELECT MaSP, TenSP, DonGia, SoLuongTon, HanSuDung FROM VW_SanPhamSapHetHan", conn))
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

        public List<DoanhThuNgay> GetDoanhThuNgay(DateTime? from = null, DateTime? to = null)
        {
            var result = new List<DoanhThuNgay>();

            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                string sql = "SELECT Ngay, DoanhThu FROM VW_DoanhThuNgay";
                if (from.HasValue && to.HasValue)
                {
                    sql += " WHERE Ngay BETWEEN @From AND @To";
                }

                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (from.HasValue && to.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@From", from.Value.Date);
                        cmd.Parameters.AddWithValue("@To", to.Value.Date);
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new DoanhThuNgay
                            {
                                Ngay = (DateTime)reader["Ngay"],
                                DoanhThu = (decimal)reader["DoanhThu"]
                            });
                        }
                    }
                }
            }

            return result;
        }
    }
}
