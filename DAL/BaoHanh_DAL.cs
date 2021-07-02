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
            return KetNoi.GetDataTable("Select PhieuBaoHanh.MaPBH,PhieuBaoHanh.MaHDBH,NhanVien.TenNV,PhieuBaoHanh.NgayLapPhieu,PhieuBaoHanh.TrangThai From PhieuBaoHanh, NhanVien Where PhieuBaoHanh.MaNV=NhanVien.MaNV" + condition);
        }

        public DataTable HienThiHDBH(string condition)
        {
            return KetNoi.GetDataTable("select * From HoaDonBanHang" + condition);
        }
        public void ThemPBH(PhieuBaoHanh ex)
        {
            KetNoi.ExecuteReader(@"Insert Into PhieuBaoHanh Values(N'" + ex.MaPBH + "',N'" + ex.MaHDBH + "',N'"+ex.MaNV+"','" + ex.NgayLap + "',N'" + ex.TrangThai + "')");
        }

        public void ThemCTPhieuBaoHanh(CT_PhieuBaoHanh ex)
        {
            KetNoi.ExecuteReader(@"Insert Into CT_PhieuBaoHanh values(N'" + ex.MaPBH + "',N'" + ex.MaLK + "'," + ex.SoLuong + ",N'" + ex.GhiChu + "')");
        }

        public DataTable GetNhanVien(string Condition)
        {
            return KetNoi.GetDataTable("" + Condition);
        }

        public DataTable DSSP(string condition)
        {
            return KetNoi.GetDataTable("Select MaLK,TenLK From LinhKien"+condition);
        }
    }
}
