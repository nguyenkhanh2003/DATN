﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
   public  class HoaDon_BUS
    {
        HoaDon_DAL bus = new HoaDon_DAL();
        public DataTable GetHoaDon(string Condition)
        {
            return bus.GetHoaDon(Condition);
        } 
        public DataTable GetCtHoaDon(string Condition)
        {
            return bus.GetCtHoaDon(Condition);
        }
        public DataTable GetNhanVien(string condition)
        {
            return bus.GetNhanVien(condition);
        }
        public DataTable GetKhachHang(string condition)
        {
            return bus.GetKhachHang(condition);
        }
        public DataTable GetLinhKien(string condition)
        {
            return bus.GetLinhKien(condition);
        }
    }
}