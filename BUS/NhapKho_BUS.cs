using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class NhapKho_BUS
    {
        NhapKho_DAL bus = new NhapKho_DAL();

        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }

        public void AddHoaDon(HoaDonNhapHang ex)
        {
            bus.AddHoaDon(ex);
        }
        public void AddCTHD(CT_HoaDonNhapHang exx)
        {
            bus.AddCTHD(exx);
        }

        public DataTable GetNhanVien(string Condition)
        {
            return bus.GetNhanVien(Condition);
        }

        public DataTable GetNCC(string condition)
        {
            return bus.GetNCC(condition);
        }

        public DataTable HienThiHDN(string condition)
        {
            return bus.HienThiHDN(condition);
        }
    }
}
