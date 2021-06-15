using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
   public class BanHang_BUS
    {
        BanHang_DAL bus = new BanHang_DAL();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }

        public DataTable GetDSSP(string Condition)
        {
            return bus.GetDSSP(Condition);
        }

        public DataTable GetTimKiem(string Condition)
        {
            return bus.GetTimKiem(Condition);
        }
    }
}
