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
   public  class Login_BUS
    {
        Login_DAL bus = new Login_DAL();
       
        public DataTable HienThiDScV(string condition)
        {
            return bus.DsLoaicV(condition);
        }
    }
}
