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
    public partial class FrmLichSuNhapKho : Form
    {
        private readonly NhapKhoService _nhapKhoService;

        public FrmLichSuNhapKho()
        {
            InitializeComponent();
            _nhapKhoService = new NhapKhoService();
            LoadSanPham();
            LoadLichSuNhapKho();
        }
        private void LoadSanPham()
        {
            var sanPhamService = new QuanLyCafe.BLL.Services.SanPhamService();
            var listSP = sanPhamService.GetAll();

            cboSanPham.DataSource = listSP;
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";
            cboSanPham.SelectedIndex = -1;
        }
        private void LoadLichSuNhapKho()
        {
            dgvLichSu.Rows.Clear();

            List<NhapKho> listNhap = new List<NhapKho>();

            if (cboSanPham.SelectedIndex > -1)
            {
                int maSP = Convert.ToInt32(cboSanPham.SelectedValue);
                listNhap = _nhapKhoService.GetBySanPham(maSP);
            }
            else
            {

            }
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date.AddDays(1).AddSeconds(-1);

            foreach (var nk in listNhap)
            {
                if (nk.NgayNhap >= from && nk.NgayNhap <= to)
                {
                    dgvLichSu.Rows.Add(nk.MaNK, nk.MaSP, nk.SoLuong, nk.NgayNhap.ToString("dd/MM/yyyy HH:mm"));
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadLichSuNhapKho();
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLichSuNhapKho();
        }
    }
}
