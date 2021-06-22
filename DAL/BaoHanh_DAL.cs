using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class BaoHanh_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();

        public DataTable GetPBH(string condition)
        {
            return KetNoi.GetDataTable("Select * From PhieuBaoHanh"+condition);
        }

        public DataTable HienThiHDBH(string condition)
        {
            return KetNoi.GetDataTable("select * From HoaDonBanHang" + condition);
        }
        public void ThemPBH(PhieuBaoHanh ex)
        {
            KetNoi.ExecuteReader(@"Insert Into PhieuBaoHanh Values(N'" + ex.MaPBH + "',N'" + ex.MaHDBH + "','" + ex.NgayLap + "',N'" + ex.TrangThai + "')");
        }
    }
}
