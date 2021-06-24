using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DoanhThu_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();

        public DataTable DoanhThuTatCa(string Condition)
        {
            return KetNoi.GetDataTable("Select SUM(TongTien) AS DoanhThu from HoaDonBanHang" + Condition);
        }

        public DataTable DoanhThuTheoNam(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }

        public DataTable DoanhThuTheoThang(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }

        public DataTable DoanhThuTheoNgay(string condiiton)
        {
             return KetNoi.GetDataTable(""+condiiton);
        }
    }
}
