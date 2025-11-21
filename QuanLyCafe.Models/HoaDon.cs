using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.Models
{
    public class HoaDon
    {
        public int MaHD { get; set; }
        public int? MaKH { get; set; }
        public DateTime NgayGD { get; set; }
        public decimal TongTien { get; set; }
        public decimal KhuyenMai { get; set; }
        public decimal SoTienPhaiTra { get; set; }
    }
}
