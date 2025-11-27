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
    public partial class FrmThongKe : Form
    {
        private readonly ThongKeService _thongKe;
        public FrmThongKe()
        {
            InitializeComponent();
            _thongKe = new ThongKeService();
        }

        private void btnThongKeNgay_Click(object sender, EventArgs e)
        {
            DateTime from = DateTime.Today;
            DateTime to = DateTime.Today;

            var listDoanhThu = _thongKe.GetDoanhThuNgay(from, to);

            decimal tongDoanhThu = listDoanhThu.Sum(d => d.DoanhThu);
            int soHD = listDoanhThu.Count;
            decimal tbHoaDon = soHD > 0 ? tongDoanhThu / soHD : 0;

            lblTongDoanhThu.Text = tongDoanhThu.ToString("N0") + " đ";
            lblSoHD.Text = soHD.ToString();
            lblTBHoaDon.Text = tbHoaDon.ToString("N0") + " đ";
        }

        private void btnThongKeThang_Click(object sender, EventArgs e)
        {
            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;
            var listDoanhThuThang = _thongKe.GetDoanhThuThang(year);

            var dataThang = listDoanhThuThang.FirstOrDefault(d => d.Thang == month);

            decimal tongDoanhThu = dataThang != null ? dataThang.DoanhThu : 0;

            DateTime from = new DateTime(year, month, 1);
            DateTime to = from.AddMonths(1).AddDays(-1);

            var listDoanhThuNgay = _thongKe.GetDoanhThuNgay(from, to);
            int soHD = listDoanhThuNgay.Count;

            decimal tbHoaDon = soHD > 0 ? tongDoanhThu / soHD : 0;

            lblTongDoanhThu.Text = tongDoanhThu.ToString("N0") + " đ";
            lblSoHD.Text = soHD.ToString();
            lblTBHoaDon.Text = tbHoaDon.ToString("N0") + " đ";
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Value = DateTime.Today;

            dtpThang.Format = DateTimePickerFormat.Custom;
            dtpThang.CustomFormat = "MM/yyyy";
            dtpThang.ShowUpDown = true;
            dtpThang.Value = DateTime.Today;
        }
    }
}
