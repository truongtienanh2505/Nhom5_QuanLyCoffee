using System;
using System.Collections.Generic;
using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Services
{
    public class BanService : IBanService
    {
        private readonly BanRepository _repo;

        public BanService()
        {
            _repo = new BanRepository();
        }
        public void CapNhatTrangThai(int maBan, int trangThai)
        {
            ValidateTrangThai(maBan, trangThai);

            try
            {
                _repo.UpdateTrangThai(maBan, trangThai);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật trạng thái bàn: {ex.Message}", ex);
            }
        }
        public List<Ban> GetAll()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách bàn: " + ex.Message, ex);
            }
        }
        public Ban? GetById(int maBan)
        {
            if (maBan <= 0)
                throw new ArgumentException("Mã bàn không hợp lệ.");

            try
            {
                return _repo.GetById(maBan);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin bàn: " + ex.Message, ex);
            }
        }
        private void ValidateTrangThai(int maBan, int trangThai)
        {
            if (maBan <= 0)
                throw new ArgumentException("Mã bàn không hợp lệ.");

            if (trangThai < 0 || trangThai > 2)
                throw new ArgumentException("Trạng thái bàn không hợp lệ. Giá trị hợp lệ: 0, 1, 2");
        }
    }
}
