﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace DAL
{
  public  class BanHang_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return KetNoi.GetDataTable("Select MaLK,TenLK from LinhKien" + Condition);
        }

         public void AddHoaDon(HoaDonBanHang ex)
        {
            KetNoi.ExecuteReader(@"INSERT INTO HoaDonBanHang(MaHDBH,MaKH,MaNV,NgayLapHDBH,TongTien,TrangThai)      
                                   VALUES(N'" + ex.MaHDBH + "',N'" + ex.MaKH + "',N'" + ex.MaNV +
                                    "',N'" + ex.NgayLapHDBH + "'," + ex.TongTien + ",N'"+ex.TrangThai+"')");
        }

        public void AddCTHD(CT_HoaDonBanHang exx)
        {
            KetNoi.ExecuteReader(@"Insert InTo CT_HoaDonBanHang(MaHDBH,MaLK,SoLuong,DonGia,KhuyenMai,ThanhTien,TrangThai) VALUES(N'"+exx.MaHDBH+"',N'"+exx.MaLK+"',"+exx.SoLuong+"',"+exx.DonGia+","+exx.KhuyenMai+","+exx.ThanhTien+",N'"+exx.TrangThai+"')");
        }
        public DataTable GetDSSP(string Condition)
        {
            return KetNoi.GetDataTable(""+Condition);
        }

        public DataTable GetNhanVien(string Condition)
        {
            return KetNoi.GetDataTable(""+Condition);
        }
        public DataTable GetDSkH(string Condition)
        {
            return KetNoi.GetDataTable(""+Condition);
        }
        public DataTable GetTimKiem(string Condition)
        {
            return KetNoi.GetDataTable(""+Condition);
        }
    }
}
