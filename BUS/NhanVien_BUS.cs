﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
   public class NhanVien_BUS
    {
        NhanVien_DAL bus = new NhanVien_DAL();

        public DataTable GetData(string condition)
        {
            return bus.GetData(condition);
        } 
    }
}
