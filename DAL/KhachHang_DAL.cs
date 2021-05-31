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
            
        }
        //  SỬA DỮ LIỆU
        public void EditData(KhachHang ex)
        {
          
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(KhachHang ex)
        {
           
        }
    }
}
