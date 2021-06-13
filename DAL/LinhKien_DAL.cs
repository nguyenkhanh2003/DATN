using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
   public class LinhKien_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return KetNoi.GetDataTable("select MaLK,LoaiLinhKien.TenLLK,NhaCungCap.TenNCC,TenLK,BaoHanh,XuatXu,TinhTrang,DonViTinh,DonGia,SoLuong,HinhAnh,LinhKien.TrangThai from LinhKien, NhaCungCap,LoaiLinhKien Where NhaCungCap.MaNCC=LinhKien.MaNCC and LoaiLinhKien.MaLLK=LinhKien.MaLLK" + Condition);
        }
        //TÌM KIẾM
        public DataTable GetSearch(string Condition)
        {
            return KetNoi.GetDataTable(""+Condition);
        }
        // THÊM DỮ LIỆU
        public void AddData(LinhKien ex)
        {
            KetNoi.ExecuteReader(@"Insert INTO LinhKien(MaLK,MaLLK,MaNCC,TenLK,BaoHanh,XuatXu,TinhTrang,DonViTinh,DonGia,SoLuong,HinhAnh,TrangThai) VALUES(N'"+ex.MaLK+"',N'"+ex.MaLLK+"',N'"+ex.MaNCC+"',N'"+ex.TenLK+"',N'"+ex.BaoHanh+"',N'"+ex.XuatXu+"',N'"+ex.TinhTrang+"',"+ex.DonViTinh+","+ex.DonGia+","+ex.SoLuong+",N'"+ex.HinhAnh+"',N'"+ex.TrangThai+"')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(LinhKien ex)
        {
            KetNoi.ExecuteReader(@"Update LinhKien SET MaLLk=N'"+ex.MaLLK+"',MaNCC=N'"+ex.MaNCC+"',TenLK=N'"+ex.TenLK+"',BaoHanh=N'"+ex.BaoHanh+"',XuatXu=N'"+ex.XuatXu+"',TinhTrang=N'"+ex.TinhTrang+"',DonViTinh="+ex.DonViTinh+",DonGia="+ex.DonGia+",SoLuong="+ex.SoLuong+",HinhAnh=N'"+ex.HinhAnh+"',TrangThai=N'"+ex.TrangThai+"' Where MaLK=N'"+ex.MaLK+"'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(LinhKien ex)
        {
            KetNoi.ExecuteReader(@"DELETE From LinhKien Where MaLK=N'"+ex.MaLK+"'");
        }
    }
}
