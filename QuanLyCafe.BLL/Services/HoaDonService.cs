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

        public HoaDonService()
        {
            _hoaDonRepository = new HoaDonRepository();
        }

        public int TaoHoaDon(int? maKh)
        {
            if (maKh.HasValue && maKh.Value <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ.");

            return _hoaDonRepository.TaoHoaDon(maKh);
        }

        public void TinhTienHoaDon(int maHd)
        {
            if (maHd <= 0)
                throw new ArgumentException("Mã hóa đơn không hợp lệ.");

            _hoaDonRepository.TinhTienHoaDon(maHd);
        }

        public HoaDon? GetById(int maHd)
        {
            if (maHd <= 0)
                throw new ArgumentException("Mã hóa đơn không hợp lệ.");

            return _hoaDonRepository.GetById(maHd);
        }

        public List<HoaDon> GetByDate(DateTime from, DateTime to)
        {
            if (from > to)
                throw new ArgumentException("Từ ngày không được lớn hơn đến ngày.");

            return _hoaDonRepository.GetByDate(from, to);
        }
    }
}
