using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace DAL
{
    public class KhachHang_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return KetNoi.GetDataTable("Select * from KhachHang" + Condition);
        }
        // THÊM DỮ LIỆU
        public void AddData(KhachHang ex)
        {
            KetNoi.ExecuteReader(@"INSERT INTO KhachHang(MaKH,TenKH,GioiTinh,Email,DienThoai,CMND,DiaChi,TrangThai)      
                                   VALUES(N'" + ex.MaKH + "',N'" + ex.TenKH + "',N'" + ex.GioiTinh +
                                    "',N'" + ex.Email + "',N'" + ex.DienThoai + "',N'"+ex.CMND+"',N'"+ex.DiaChi+"',N'"+ex.TrangThai+"')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(KhachHang ex)
        {
            KetNoi.ExecuteReader(@"UPDATE KhachHang SET TenKH =N'" + ex.TenKH + "', GioiTinh =N'" + ex.GioiTinh +
                  "',Email=N'" + ex.Email + "', DienThoai =N'" + ex.DienThoai + "',CMND =N'" + ex.CMND + "',DiaChi=N'"+ex.DiaChi+"',TrangThai=N'"+ex.TrangThai+"' Where MaKH=N'" + ex.MaKH + "'");

        }
        //  XÓA DỮ LIỆU
        public void DeleteData(KhachHang ex)
        {
            KetNoi.ExecuteReader(@"DELETE FROM KhachHang Where MaKH=N'" + ex.MaKH + "'");
        }
    }
}
