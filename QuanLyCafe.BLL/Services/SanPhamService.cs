using System.Collections.Generic;
using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.DAL.Repositories;
using QuanLyCafe.Models;

namespace QuanLyCafe.BLL.Services
{
    public class SanPhamService : ISanPhamService
    {
        private readonly SanPhamRepository _spRepository;

        public SanPhamService()
        {
            _spRepository = new SanPhamRepository();
        }

        public List<SanPham> GetAll()
        {
            try
            {
                return _spRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách sản phẩm: " + ex.Message, ex);
            }
        }

        public void ThemSanPham(SanPham sp)
        {
            ValidateSanPham(sp);

            try
            {
                _spRepository.ThemSanPham(sp);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm sản phẩm: " + ex.Message, ex);
            }
        }

        public void SuaSanPham(SanPham sp)
        {
            ValidateSanPham(sp);

            if (sp.MaSp <= 0)
                throw new ArgumentException("Mã sản phẩm không hợp lệ.");

            try
            {
                _spRepository.SuaSanPham(sp);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa sản phẩm: " + ex.Message, ex);
            }
        }

        private void ValidateSanPham(SanPham sp)
        {
            if (sp == null)
                throw new ArgumentNullException(nameof(sp));

            if (string.IsNullOrWhiteSpace(sp.TenSp))
                throw new ArgumentException("Tên sản phẩm không được để trống.");

            if (sp.DonGia <= 0)
                throw new ArgumentException("Đơn giá phải lớn hơn 0.");

            if (sp.SoLuongTon < 0)
                throw new ArgumentException("Số lượng tồn không được âm.");
        }
    }
}
