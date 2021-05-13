using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
   public class NhaCungCap_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return KetNoi.GetDataTable("Select * from NhaCungCap" + Condition);
        }
        // THÊM DỮ LIỆU
        public void AddData(NhaCungCap ex)
        {
            KetNoi.ExecuteReader(@"INSERT INTO NhaCungCap(MaNCC, TenNCC, DiaChi, DienThoai, Email, TrangThai)      
                                   VALUES(N'" + ex.MaNCC + "',N'" + ex.TenNCC + "',N'" + ex.DiaChi +
                                   "',N'" + ex.DienThoai + "',N'" + ex.Email + "',N'" + ex.TrangThai + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(NhaCungCap ex)
        {
            KetNoi.ExecuteReader(@"UPDATE NhaCungCap SET TenNCC =N'" + ex.TenNCC + "', DiaChi =N'" + ex.DiaChi +
                "', DienThoai =N'" + ex.DienThoai + "',Email =N'"+ex.Email+"' Where MaNCC=N'" + ex.MaNCC + "'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(NhaCungCap ex)
        {
            KetNoi.ExecuteReader(@"DELETE FROM NhaCungCap Where MaNCC=N'" + ex.MaNCC + "'");
        }

    }
}
