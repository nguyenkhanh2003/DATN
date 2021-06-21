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

       public DataTable GetSearch(string Condition)
       {
           return KetNoi.GetDataTable(""+Condition);
       }

    }
}
