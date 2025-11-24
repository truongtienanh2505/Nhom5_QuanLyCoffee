using QuanLyCafe.BLL.Interfaces;
using QuanLyCafe.BLL.Services;
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
    public partial class MainForm : Form
    {
        private readonly ThongKeService _thongKe;
        public MainForm()
        {
            InitializeComponent();
            _thongKe = new ThongKeService();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }
        private void LoadDashboard()
        {
            var spSapHetHan = _thongKe.GetSanPhamSapHetHan();
            lblSPHetHan.Text = spSapHetHan.Count.ToString();
            lblTotalSP.Text = spSapHetHan.Count.ToString();
            var doanhThu = _thongKe.GetDoanhThuNgay(DateTime.Today, DateTime.Today);
            lblDoanhThu.Text = doanhThu.FirstOrDefault()?.DoanhThu.ToString("N0") + " đ" ?? "0 đ";
            lblSoHD.Text = doanhThu.Count.ToString();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            new FrmSanPham().ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            new FrmKhachHang().ShowDialog();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ISanPhamService spService = new SanPhamService();
            IKhachHangService khService = new KhachHangService();
            IHoaDonService hdService = new HoaDonService();
            IHoaDonChiTietService hdctService = new HoaDonChiTietService();

            FrmBanHang frm = new FrmBanHang(spService, khService, hdService, hdctService);
            frm.ShowDialog();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            new FrmNhapKho().ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            new FrmThongKe().ShowDialog();
        }
    }
}
