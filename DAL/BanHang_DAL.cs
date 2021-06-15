using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace DAL
{
  public  class BanHang_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return KetNoi.GetDataTable("Select TenLK from LinhKien" + Condition);
        }

        public DataTable GetDSSP(string Condition)
        {
            return KetNoi.GetDataTable(""+Condition);
        }
        public DataTable GetTimKiem(string Condition)
        {
            return KetNoi.GetDataTable(""+Condition);
        }
    }
}
