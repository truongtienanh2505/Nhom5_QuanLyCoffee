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
        public List<DoanhThuThang> GetDoanhThuThang(int? nam = null)
        {
            var list = new List<DoanhThuThang>();

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                string sql = @"
                    SELECT YEAR(NgayGD) AS Nam,
                           MONTH(NgayGD) AS Thang,
                           SUM(SoTienPhaiTra) AS DoanhThu
                    FROM HoaDon
                    WHERE (@nam IS NULL OR YEAR(NgayGD) = @nam)
                    GROUP BY YEAR(NgayGD), MONTH(NgayGD)
                    ORDER BY YEAR(NgayGD), MONTH(NgayGD)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nam", (object)nam ?? DBNull.Value);

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(new DoanhThuThang
                    {
                        Nam = Convert.ToInt32(rd["Nam"]),
                        Thang = Convert.ToInt32(rd["Thang"]),
                        DoanhThu = Convert.ToDecimal(rd["DoanhThu"])
                    });
                }
            }
            return list;
        }
    }
}
