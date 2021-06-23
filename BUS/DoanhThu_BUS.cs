using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BUS
{
    public class DoanhThu_BUS
    {
        DoanhThu_DAL bus = new DoanhThu_DAL();

        public DataTable DoanhThuTatCa(string condition)
        {
            return bus.DoanhThuTatCa(condition);
        }
    }
}
