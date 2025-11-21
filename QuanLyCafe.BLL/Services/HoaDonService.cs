using System;
using System.Collections.Generic;
using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Services
{
    public class HoaDonService : IHoaDonService
    {
        private readonly HoaDonRepository _repo;

        public HoaDonService()
        {
            _repo = new HoaDonRepository();
        }

        public int TaoHoaDon(int? maKh)
        {
            return _repo.TaoHoaDon(maKh);
        }

        public void TinhTienHoaDon(int maHd)
        {
            _repo.TinhTienHoaDon(maHd);
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
