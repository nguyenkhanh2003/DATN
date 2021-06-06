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
            return KetNoi.GetDataTable("Select * from NhaCungCap" + Condition);
        }
        // THÊM DỮ LIỆU
        public void AddData(LinhKien ex)
        {
            KetNoi.ExecuteReader(@"");
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
