using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BUS
{
    public class ChucVu_BUS
    {
         ChucVu_DAL bus = new ChucVu_DAL();

        public DataTable GetChucVu(string condition)
        {
            return bus.GetChucVu(condition);
        }
    }
}
