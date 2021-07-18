using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class HoaDon_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();

        public DataTable GetHoaDon(string Condition)
        {
            return KetNoi.GetDataTable("Select HoaDonBanHang.MaHDBH,TenKH,TennV,HoaDonBanHang.NgayLapHDBH,TongTien,HoaDonBanHang.TrangThai From HoaDonBanHang,NhanVien,KhachHang Where NhanVien.MaNV=HoaDonBanHang.MaNV and KhachHang.MaKH=HoaDonBanHang.MaKH" + Condition);
        }

        public DataTable HienThiHDTheoMa(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }
        public DataTable GetCtHoaDon(string Condition)
        {
            return KetNoi.GetDataTable(""+Condition);

        }
        public DataTable GetNhanVien(string conditon)
        {
            return KetNoi.GetDataTable("Select MaNV,TenNV From NhanVien" + conditon);
        }

        public DataTable GetKhachHang(string conditon)
        {
            return KetNoi.GetDataTable("select MaKH,TenKH From KhachHang"+conditon);
        }

        public DataTable GetLinhKien(string condition)
        {
            return KetNoi.GetDataTable("Select MaLK,TenLK From LinhKien"+condition);
        }

        public DataTable GetLinhKienT(string condition)
        {
            return KetNoi.GetDataTable(""+condition);
        }
        public void UpdateHoaDon(HoaDonBanHang ex)
        {
            KetNoi.ExecuteReader(@"update HoaDonBanHang Set MaKH=N'"+ex.MaKH+"',MaNV=N'"+ex.MaNV+"',NgayLapHDBH=N'"+ex.NgayLapHDBH+"',TongTien="+ex.TongTien+",TrangThai=N'"+ex.TrangThai+"' Where MaHDBH=N'"+ex.MaHDBH+"'");
        }

        public void UpdateCTHoaDon(CT_HoaDonBanHang exx)
        {
            KetNoi.ExecuteReader(@"Update CT_HoaDonBanHang Set SoLuong="+exx.SoLuong+",DonGia="+exx.DonGia+",KhuyenMai="+exx.KhuyenMai+",ThanhTien="+exx.ThanhTien+",TrangThai=N'"+exx.TrangThai+"'Where MaLK=N'"+exx.MaLK+ "' and  MaHDBH=N'" + exx.MaHDBH + "'");
        }

        public void ThemCTHD(CT_HoaDonBanHang ex)
        {
            KetNoi.ExecuteReader(@"Insert Into CT_HoaDonBanHang(MaHDBH,MaLK,SoLuong,DonGia,KhuyenMai,ThanhTien,TrangThai) Values(N'"+ex.MaHDBH+"',N'"+ex.MaLK+"',"+ex.SoLuong+","+ex.DonGia+","+ex.KhuyenMai+","+ex.ThanhTien+",N'"+ex.TrangThai+"')");
        }

        public void DeleteCTHd(CT_HoaDonBanHang ex)
        {
            KetNoi.ExecuteReader(@"Delete From CT_HoaDonBanhang Where MaHDBH=N'"+ex.MaHDBH+"'");
        }
        public void DeleteHoaDon(HoaDonBanHang ex)
        {
            KetNoi.ExecuteReader(@"Delete From HoaDonBanHang Where MaHDBH=N'" + ex.MaHDBH + "'");
        }

       public DataTable GetSearch(string Condition)
       {
           return KetNoi.GetDataTable(""+Condition);
       }

    }
}
