using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_HoaDonNhapHang
    {
        public string MaHDNH { get; set; }
        public string MaLK { get; set;}
        public int? SoLuong { get; set; }
        public int? DonGia { get; set; }
        public int ThanhTien{get;set;}
        public int KhuyenMai{get;set;}
        public string TrangThai { get; set; }
    }
}
