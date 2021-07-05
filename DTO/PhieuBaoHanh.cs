using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuBaoHanh
    {
        public string MaPBH { get; set; }
        public string MaHDBH { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayLayHang { get; set; }
        public string TrangThai { get; set; }
    }
}
