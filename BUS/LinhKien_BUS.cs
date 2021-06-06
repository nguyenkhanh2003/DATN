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
  public  class LinhKien_BUS
    {
        KetNoiDatabase c = new KetNoiDatabase();
        LinhKien_DAL bus = new LinhKien_DAL();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        // THEM DATA
        public void AddData(LinhKien ex)
        {
            bus.AddData(ex);
        }
        public void EditData(LinhKien ex)
        {
            bus.EditData(ex);
        }
        public void DeleteData(LinhKien ex)
        {
            bus.DeleteData(ex);
        }
    }
}
