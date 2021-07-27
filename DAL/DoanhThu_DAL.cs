﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DoanhThu_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();

        public DataTable DoanhThuTatCa(string Condition)
        {
            return KetNoi.GetDataTable("Select SUM(TongTien) AS DoanhThu from HoaDonBanHang" + Condition);
        }

        public DataTable DoanhThuTheoNam(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }

        public DataTable DoanhThuTheoThang(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }

        public DataTable DoanhThuTheoNgay(string condiiton)
        {
             return KetNoi.GetDataTable(""+condiiton);
        }

        public DataTable SPBanChayTheoThang(string condiiton)
        {
            return KetNoi.GetDataTable(""+condiiton);
        }

        public DataTable Top3SanPhamBanTrongNam(string condiiton)
        {
            return KetNoi.GetDataTable(""+condiiton);
        }
        public DataTable Top3SPMuaNhieuTrongThang(string condition)
        {
            return KetNoi.GetDataTable(""+condition);
        }
        public DataTable Top3SPMuaNhieuTrongName(string condition)
        {
            return KetNoi.GetDataTable(""+condition);
        }
        public DataTable Top3HDMuaNhieu(string condition)
        {
            return KetNoi.GetDataTable(""+condition);
        }
        public DataTable LoadDoanhThuLenChart( string condition)
        {
            return KetNoi.GetDataTable("select MONTH(NgayLapHDBH) AS Thang, Sum(TongTien)From HoaDonBanHang Group by MONTH(NgayLapHDBH)" + condition);
        }

        public DataTable DoanhThuThang1(string condition)
        {
            return KetNoi.GetDataTable(""+condition);
        }
        public DataTable DoanhThuThang2(string condition)
        {
            return KetNoi.GetDataTable(""+condition);
        }
        public DataTable DoanhThuThang3(string condition)
        {
            return KetNoi.GetDataTable(""+condition);
        }
    }
}
