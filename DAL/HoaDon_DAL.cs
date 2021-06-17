﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class HoaDon_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();

        public DataTable GetHoaDon(string Condition)
        {
            return KetNoi.GetDataTable("Select HoaDonBanHang.MaHDBH,TenKH,TennV,HoaDonBanHang.NgayLapHDBH,TongTien,HoaDonBanHang.TrangThai From HoaDonBanHang,NhanVien,KhachHang Where NhanVien.MaNV=HoaDonBanHang.MaNV and KhachHang.MaKH=HoaDonBanHang.MaKH" + Condition);
        }
        public DataTable GetCtHoaDon(string Condition)
        {
            return KetNoi.GetDataTable("select CT_HoaDonBanHang.MaHDBH,TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,KhuyenMai,ThanhTien,CT_HoaDonBanHang.TrangThai from CT_HoaDonBanHang,LinhKien,HoaDonBanHang Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH=HoaDonBanHang.MaHDBH "+Condition);

        }
        public DataTable GetNhanVien(string conditon)
        {
            return KetNoi.GetDataTable("Select MaNV,TenNV From NhanVien" + conditon);
        }

        public DataTable GetKhachHang(string conditon)
        {
            return KetNoi.GetDataTable("select MaKH,TenKH From KhachHang"+conditon);
        }

        public DataTable GetLinhKien(string condition)
        {
            return KetNoi.GetDataTable("Select MaLK,TenLK From LinhKien"+condition);
        }
    }
}