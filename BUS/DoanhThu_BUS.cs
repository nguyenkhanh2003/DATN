﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BUS
{
    public class DoanhThu_BUS
    {
        DoanhThu_DAL bus = new DoanhThu_DAL();

        public DataTable DoanhThuTatCa(string condition)
        {
            return bus.DoanhThuTatCa(condition);
        }

        public DataTable DoanThuTheoNam(string condition)
        {
            return bus.DoanhThuTheoNam(condition);
        }

        public DataTable DoanhThuTheoThang(string condition)
        {
            return bus.DoanhThuTheoThang(condition);
        }

        public DataTable DoanhThuTheoNgay(string condition)
        {
            return bus.DoanhThuTheoNgay(condition);
        }

        public DataTable SPBanChayTheoThang(string condition)
        {
            return bus.SPBanChayTheoThang(condition);
        }

        public DataTable Top3SanPhamBanTrongNam(string condition)
        {
            return bus.Top3SanPhamBanTrongNam(condition);
        }
        public DataTable Top3MuaMonth(string condition)
        {
            return bus.Top3SPMuaNhieuTrongThang(condition);
        }
        public DataTable Top3SPMuaYear(string condition)
        {
            return bus.Top3SPMuaNhieuTrongName(condition);
        }
        public DataTable Top3HDMuaNhieu(string condition)
        {
            return bus.Top3HDMuaNhieu(condition);
        }
        public DataTable LoadDoanhThuChart(string condition)
        {
            return bus.LoadDoanhThuLenChart(condition);
        }
        public DataTable DoanhThuThang1(string condition)
       {
           return bus.DoanhThuThang1(condition);
       }
       public DataTable DoanhThuThang2(string condition)
       {
           return bus.DoanhThuThang2(condition);
       }
       public DataTable DoanhThuThang3(string condition)
       {
           return bus.DoanhThuThang3(condition);
       }
    }
}
