using System;
using System.Collections.Generic;
using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;


namespace QuanLyCafe.BLL.Services
{
    public class ThongKeService : IThongKeService
    {
        private readonly ThongKeRepository _repo;

        public ThongKeService()
        {
            _repo = new ThongKeRepository();
        }

        public List<SanPham> GetSanPhamSapHetHan()
        {
            try
            {
                return _thongKeRepository.GetSanPhamSapHetHan();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách sản phẩm sắp hết hạn: " + ex.Message, ex);
            }
        }

        public List<DoanhThuNgay> GetDoanhThuNgay(DateTime? from = null, DateTime? to = null)
        {
            if (from.HasValue && to.HasValue && from > to)
                throw new ArgumentException("Từ ngày không được lớn hơn đến ngày.");

            try
            {
                return _thongKeRepository.GetDoanhThuNgay(from, to);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thống kê doanh thu: " + ex.Message, ex);
            }
        }
    }
}
