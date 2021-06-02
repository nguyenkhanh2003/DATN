using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ChucVu_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        // lay du lieu 
        public DataTable GetChucVu(string condition)
        {
            //return KetNoi.GetDataTable("select * from NhanVien where NhanVien.MaCV = ChucVu.MaCV" + condition);
            return KetNoi.GetDataTable("select TenCV from ChucVu" + condition);
        }
    }
}
