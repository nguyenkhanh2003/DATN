using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class NhapKho_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();

        public DataTable GetData(string Condition)
        {
            return KetNoi.GetDataTable("Select MaLK,TenLK from LinhKien" + Condition);
        }
        public DataTable GetDSSP(string Condition)
        {
            return KetNoi.GetDataTable("" + Condition);
        }

        public DataTable GetNhanVien(string Condition)
        {
            return KetNoi.GetDataTable("" + Condition);
        }

        public DataTable GetNCC(string condition)
        {
            return KetNoi.GetDataTable("Select * From NhaCungCap" + condition);
        }
        public void AddHoaDon(HoaDonNhapHang ex)
        {
            KetNoi.ExecuteReader(@"insert into HoaDonNhapHang(MaHDNH,MaNCC,MaNV,NgayLapHDNH,TongTien,TrangThai)
Values(N'" + ex.MaHDNH + "',N'" + ex.MaNCC + "',N'" + ex.MaNV + "','" + ex.NgayLapHDNH + "'," + ex.TongTien + ",N'" + ex.TrangThai + "')");
        }

        public void AddCTHD(CT_HoaDonNhapHang exx)
        {
            KetNoi.ExecuteReader(@"insert into CT_HoaDonNhapHang(MaHDNH,MaLK,SoLuong,DonGia,KhuyenMai,ThanhTien,TrangThai)
values(N'" + exx.MaHDNH + "',N'" + exx.MaLK + "'," + exx.SoLuong + "," + exx.DonGia + "," + exx.KhuyenMai + "," + exx.ThanhTien + ",N'" + exx.TrangThai + "')");
        }

    }
}
