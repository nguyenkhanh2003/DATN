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
        KetNoiDatabase c = new KetNoiDatabase();
        KhachHang_DAL bus = new KhachHang_DAL();
        DataTable da = new DataTable();
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

        public void HienThiSearch(string a)
        {
            da = c.GetDataTable("select * from KHACHHANG where TenKH LIKE N'%" + a + "%'");
        }
    }
}
