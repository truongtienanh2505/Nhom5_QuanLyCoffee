using System;
using System.Collections.Generic;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Interfaces
{
    public interface IThongKeService
    {
        List<SanPham> GetSanPhamSapHetHan();
        List<DoanhThuNgay> GetDoanhThuNgay(DateTime? from = null, DateTime? to = null);
        List<DoanhThuThang> GetDoanhThuThang(int? nam = null);

    }
}