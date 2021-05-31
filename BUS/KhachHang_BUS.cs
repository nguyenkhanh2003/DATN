using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
   public class KhachHang_BUS
    {
        KhachHang_DAL bus = new KhachHang_DAL();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        // THEM DATA
        public void AddData(KhachHang ex)
        {
            bus.AddData(ex);
        }
        public void EditData(KhachHang ex)
        {
            bus.EditData(ex);
        }
        public void DeleteData(KhachHang ex)
        {
            bus.DeleteData(ex);
        }
        public void SearchData(KhachHang ex)
        {
            bus.SearchData(ex);
        }
    }
}
