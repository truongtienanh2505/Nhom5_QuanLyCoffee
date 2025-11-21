using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.Models;

namespace QuanLyCafe.DAL
{
    public class ThongKeRepository
    {
        public List<SanPham> GetSanPhamSapHetHan()
        {
            var result = new List<SanPham>();

            using (var conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                string sql = @"
                    SELECT MaSP, TenSP, DonGia, SoLuongTon, HanSuDung 
                    FROM SanPham 
                    WHERE HanSuDung <= DATEADD(DAY, 7, GETDATE())
                    ORDER BY HanSuDung ASC";
                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new SanPham
                        {
                            MaSP = (int)reader["MaSP"],
                            TenSP = reader["TenSP"].ToString() ?? "",
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
