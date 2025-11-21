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
            return _repo.GetSanPhamSapHetHan();
        }

        public List<DoanhThuNgay> GetDoanhThuNgay(DateTime? from = null, DateTime? to = null)
        {
            return _repo.GetDoanhThuNgay(from, to);
        }
        public List<DoanhThuThang> GetDoanhThuThang(int? nam = null)
        {
            return _repo.GetDoanhThuThang(nam);
        }
    }
}
