using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class Login
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        public DataTable GetLogin(string username,string password)
        {
            return KetNoi.GetDataTable("Select * From NhanVien Where UserName=N'" + username + "' and PassWord=N'"+password+"'");
        }
    }
}
