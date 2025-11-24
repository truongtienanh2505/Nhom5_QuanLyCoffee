using QuanLyCafe.BLL.Interfaces;
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
    public partial class FrmDanhSachHoaDon : Form
    {
        private readonly IHoaDonService _hdService;
        private readonly IHoaDonChiTietService _ctService;
        public FrmDanhSachHoaDon(IHoaDonService hdService, IHoaDonChiTietService ctService)
        {
            InitializeComponent();
            _hdService = hdService;
            _ctService = ctService;
        }

        private void FrmDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now.AddMonths(-1); // mặc định 1 tháng gần nhất
            dtpTo.Value = DateTime.Now;

            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            dgvHoaDon.DataSource = _hdService.GetByDate(dtpFrom.Value.Date, dtpTo.Value.Date);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadHoaDon();
                return;
            }

            if (int.TryParse(txtSearch.Text, out int maHd))
            {
                var hd = _hdService.GetById(maHd);
                if (hd != null)
                    dgvHoaDon.DataSource = new List<HoaDon> { hd };
                else
                    dgvHoaDon.DataSource = new List<HoaDon>();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn hợp lệ!");
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!");
                return;
            }

            int maHd = (int)dgvHoaDon.SelectedRows[0].Cells["MaHD"].Value;

            FrmChiTietHoaDon frm = new FrmChiTietHoaDon(maHd, _hdService, _ctService);
            frm.ShowDialog();
        }
    }
}
