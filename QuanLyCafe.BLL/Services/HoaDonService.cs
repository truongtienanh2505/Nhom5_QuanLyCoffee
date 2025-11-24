using System;
using System.Collections.Generic;
using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Services
{
    public class HoaDonService : IHoaDonService
    {
        private readonly HoaDonRepository _hoaDonRepository;
        private readonly HoaDonChiTietRepository _chiTietRepository;

        public HoaDonService()
        {
            _hoaDonRepository = new HoaDonRepository();
            _chiTietRepository = new HoaDonChiTietRepository();
        }

        public int TaoHoaDon(int? maKh)
        {
            return _repo.TaoHoaDon(maKh);
        }

        public void TinhTienHoaDon(int maHd)
        {
            if (maHd <= 0)
                throw new ArgumentException("Mã hóa đơn không hợp lệ.");

            var dsChiTiet = _chiTietRepository.GetByHoaDon(maHd);

            if (dsChiTiet == null || dsChiTiet.Count == 0)
                throw new Exception("Hóa đơn chưa có sản phẩm nào.");
            decimal tongTien = dsChiTiet.Sum(x => x.SoLuong * x.DonGia);
            _hoaDonRepository.UpdateTongTien(maHd, tongTien);
        }

        public HoaDon? GetById(int maHd)
        {
            return _repo.GetById(maHd);
        }

        public List<HoaDon> GetByDate(DateTime from, DateTime to)
        {
            return _repo.GetByDate(from, to);
        }
    }
}
