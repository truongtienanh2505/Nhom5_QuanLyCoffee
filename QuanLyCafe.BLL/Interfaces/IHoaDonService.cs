using System;
using System.Collections.Generic;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Interfaces
{
        public interface IHoaDonService
        {
            int TaoHoaDon(int? maKh);
            void TinhTienHoaDon(int maHd);
            HoaDon? GetById(int maHd);
            List<HoaDon> GetByDate(DateTime from, DateTime to);
        }
}
