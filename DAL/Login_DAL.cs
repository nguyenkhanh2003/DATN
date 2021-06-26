using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class Login_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        
        public DataTable DsLoaicV(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }
    }
}
