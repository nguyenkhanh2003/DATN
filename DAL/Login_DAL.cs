﻿using System;
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

        public DataTable DangNhap(string username,string password)
        {
            return KetNoi.GetDataTable("Select * From NhanVien Where UserName=N'" + username + "' and PassWord=N'" + password + "'");
        }

        public DataTable GetPhanQuyen(string condition)
        {
            return KetNoi.GetDataTable("select * From ChucVu Where QLNV='"+condition+"'");
        }

        public DataTable GetLogin(string username,string password)
        {
            return KetNoi.GetDataTable("Select * From NhanVien,ChucVu Where  NhanVien.UserName=N'" + username + "'and NhanVien.PassWord=N'" + password + "' and ChucVu.MaCV=NhanVien.MaCV");
        }
    }
}
