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
            return KetNoi.GetDataTable("select MaLK,LoaiLinhKien.MaLLK,NhaSanXuat.TenNSX,TenLK,BaoHanh,NgaySanXuat,TinhTrang,DonViTinh,DonGia,SoLuong,HinhAnh,LinhKien.TrangThai from LinhKien, NhaSanXuat,LoaiLinhKien Where NhaSanXuat.MaNSX=LinhKien.MaNSX and LoaiLinhKien.MaLLK=LinhKien.MaLLK" + Condition);
        }
        //TÌM KIẾM
        public DataTable GetSearch(string Condition)
        {
            return KetNoi.GetDataTable(""+Condition);
        }
        // THÊM DỮ LIỆU
        public void AddData(LinhKien ex)
        {
            KetNoi.ExecuteReader(@"Insert INTO LinhKien(MaLK,MaLLK,MaNSX,TenLK,BaoHanh,NgaySanXuat,TinhTrang,DonViTinh,DonGia,SoLuong,HinhAnh,TrangThai) VALUES(N'"+ex.MaLK+"',N'"+ex.MaLLK+"',N'"+ex.MaNSX+"',N'"+ex.TenLK+"',N'"+ex.BaoHanh+"','"+ex.NgaySanXuat+"',N'"+ex.TinhTrang+"',"+ex.DonViTinh+","+ex.DonGia+","+ex.SoLuong+",N'"+ex.HinhAnh+"',N'"+ex.TrangThai+"')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(LinhKien ex)
        {
            KetNoi.ExecuteReader(@"");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(LinhKien ex)
        {
            KetNoi.ExecuteReader(@"");
        }
    }
}
