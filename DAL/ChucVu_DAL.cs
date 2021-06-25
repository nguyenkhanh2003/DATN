using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
   public class ChucVu_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        // lay du lieu 
        public DataTable GetChucVu(string condition)
        {
            //return KetNoi.GetDataTable("select * from NhanVien where NhanVien.MaCV = ChucVu.MaCV" + condition);
            return KetNoi.GetDataTable("select * from ChucVu" + condition);
        }

        public void AddChucVu(ChucVu ex)
        {
            KetNoi.ExecuteReader(@"Insert into ChucVu Values(N'" + ex.MaCV + "',N'" + ex.TenCV + "',N'" + ex.TrangThai + "') ");
        }
        
        public void EditChuCVu(ChucVu ex)
        {
            KetNoi.ExecuteReader(@"Update ChucVu Set TencV=N'" + ex.TenCV + "',TrangThai=N'" + ex.TrangThai + "' Where MacV=N'"+ex.MaCV+"' ");
        }

        public void DeleteChucVu(ChucVu ex)
        {
            KetNoi.ExecuteReader(@"Delete From ChucVu Where MaCV=N'" + ex.MaCV + "'");
        }
    }
}
