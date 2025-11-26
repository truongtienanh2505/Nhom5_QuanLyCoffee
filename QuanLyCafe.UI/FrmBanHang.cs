using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.BLL.Services;
using QuanLyCafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.UI
{
    public partial class FrmBanHang : Form
    {
        private readonly ISanPhamService _spService;
        private readonly IKhachHangService _khService;
        private readonly IHoaDonService _hdService;
        private readonly IHoaDonChiTietService _ctService;

        private int _currentMaHD = 0;

        public FrmBanHang(ISanPhamService sp,
                          IKhachHangService kh,
                          IHoaDonService hd,
                          IHoaDonChiTietService ct)
        {
            InitializeComponent();
            _spService = sp;
            _khService = kh;
            _hdService = hd;
            _ctService = ct;
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadKhachHang();
        }
        private void LoadSanPham()
        {
            dgvSanPham.DataSource = _spService.GetAll();
        }

        private void LoadKhachHang()
        {
            cboKhachHang.DataSource = _khService.GetAll();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            int? maKh = null;

            if (cboKhachHang.SelectedValue != null)
                maKh = (int)cboKhachHang.SelectedValue;

            _currentMaHD = _hdService.TaoHoaDon(maKh);

            MessageBox.Show("Tạo hóa đơn thành công! Mã HD = " + _currentMaHD);
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.SelectedRows.Count == 0) return;

            int idCT = (int)dgvGioHang.SelectedRows[0].Cells["ID"].Value;
            _ctService.XoaChiTiet(idCT);

            LoadGioHang();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (_currentMaHD == 0)
            {
                MessageBox.Show("Chưa có hóa đơn!");
                return;
            }

            _hdService.TinhTienHoaDon(_currentMaHD);

            MessageBox.Show("Thanh toán thành công!");
            TinhTien();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (_currentMaHD == 0)
            {
                MessageBox.Show("Chưa có hóa đơn để in!");
                return;
            }

            FrmChiTietHoaDon frm = new FrmChiTietHoaDon(_currentMaHD, _hdService, _ctService);
            frm.ShowDialog();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (_currentMaHD == 0)
            {
                MessageBox.Show("Vui lòng tạo hóa đơn trước!");
                return;
            }

            if (dgvSanPham.SelectedRows.Count == 0) return;

            var sp = (SanPham)dgvSanPham.SelectedRows[0].DataBoundItem;
            int sl = (int)numSoLuong.Value;

            if (sl <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                return;
            }

            _ctService.ThemChiTiet(_currentMaHD, sp.MaSP, sl);
            MessageBox.Show("Đã thêm vào giỏ");

            LoadGioHang();
        }
        private void LoadGioHang()
        {
            dgvGioHang.DataSource = _ctService.GetByHoaDon(_currentMaHD);

            TinhTien();
        }
        private void TinhTien()
        {
            var hd = _hdService.GetById(_currentMaHD);
            if (hd == null) return;

            lblTongTien.Text = hd.TongTien.ToString("N0") + "đ";
            lblKhuyenMai.Text = hd.KhuyenMai.ToString("N0") + "đ";
            lblPhaiTra.Text = hd.SoTienPhaiTra.ToString("N0") + "đ";
        }
    }
}
