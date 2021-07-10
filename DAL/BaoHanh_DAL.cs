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
            return KetNoi.GetDataTable("Select PhieuBaoHanh.MaPBH,PhieuBaoHanh.MaHDBH,NhanVien.TenNV,PhieuBaoHanh.NgayLapPhieu,PhieuBaoHanh.NgayLayHang,PhieuBaoHanh.TrangThai From PhieuBaoHanh, NhanVien Where PhieuBaoHanh.MaNV=NhanVien.MaNV" + condition);
        }

        public DataTable HienThiHDBH(string condition)
        {
            return KetNoi.GetDataTable("select * From HoaDonBanHang" + condition);
        }

        public DataTable HienThiCT_PhieuBaoHanh(string conditon)
        {
            return KetNoi.GetDataTable("select LK.TenLK,CT.SoLuong,CT.GhiChu From CT_PhieuBaoHanh CT , LinhKien LK Where LK.MaLK=CT.MaLK" + conditon);
        }

        public DataTable HienThiCT_PhieuBaoHanhTheoMa(string condition)
        {
            return KetNoi.GetDataTable(""+condition);
        }
        public void ThemPBH(PhieuBaoHanh ex)
        {
            KetNoi.ExecuteReader(@"Insert Into PhieuBaoHanh Values(N'" + ex.MaPBH + "',N'" + ex.MaHDBH + "',N'"+ex.MaNV+"','" + ex.NgayLap + "','"+ex.NgayLayHang+"',N'" + ex.TrangThai + "')");
        }

        public void ThemCTPhieuBaoHanh(CT_PhieuBaoHanh ex)
        {
            KetNoi.ExecuteReader(@"Insert Into CT_PhieuBaoHanh values(N'" + ex.MaPBH + "',N'" + ex.MaLK + "',N'" + ex.SoLuong + "',N'" + ex.GhiChu + "')");
        }

        public DataTable GetNhanVien(string Condition)
        {
            return KetNoi.GetDataTable("" + Condition);
        }

        public DataTable DSSP(string condition)
        {
            return KetNoi.GetDataTable("Select MaLK,TenLK From LinhKien"+condition);
        }

        public void XoaCTPhieuBaoHanh(CT_PhieuBaoHanh ex)
        {
            KetNoi.ExecuteReader(@" delete from CT_PhieuBaoHanh where MaPBH=N'"+ex.MaPBH+"'");
        }

        public void XoaPhieuBaoHanh(PhieuBaoHanh ex)
        {
            KetNoi.ExecuteReader(@"Delete From PhieuBaoHanh Where MaPBH=N'"+ex.MaPBH+"'");
        }

        public void Update_CTPBH(CT_PhieuBaoHanh ex)
       {
           KetNoi.ExecuteReader(@"update CT_PhieuBaoHanh Set SoLuong="+ex.SoLuong+",GhiChu=N'"+ex.GhiChu+"' Where MaPBH=N'"+ex.MaPBH+"' and MaLK=N'"+ex.MaLK+"'");
       }
       public void Update_PBH(PhieuBaoHanh ex)
       {
           KetNoi.ExecuteReader(@"update PhieuBaoHanh Set Where MaPBH=N'"+ex.MaPBH+"'");
       }

       public DataTable TimHD(string condition)
       {
           return KetNoi.GetDataTable(""+condition);
       }
    }
}
