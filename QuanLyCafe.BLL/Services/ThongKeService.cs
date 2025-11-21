using System;
using System.Collections.Generic;
using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Services
{
    public class ThongKeService : IThongKeService
    {
        private readonly ThongKeRepository _thongKeRepository;

        public ThongKeService()
        {
            _thongKeRepository = new ThongKeRepository();
        }

        public List<SanPham> GetSanPhamSapHetHan()
        {
            return _thongKeRepository.GetSanPhamSapHetHan();
        }

        public List<DoanhThuNgay> GetDoanhThuNgay(DateTime? from = null, DateTime? to = null)
        {
            if (from.HasValue && to.HasValue && from > to)
                throw new ArgumentException("Từ ngày không được lớn hơn đến ngày.");

            return _thongKeRepository.GetDoanhThuNgay(from, to);
        }
    }
}
