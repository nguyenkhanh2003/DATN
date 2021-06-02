using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVien_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        // lay du lieu 
        public DataTable GetData(string condition)
        {
            //return KetNoi.GetDataTable("select * from NhanVien where NhanVien.MaCV = ChucVu.MaCV" + condition);
            return KetNoi.GetDataTable("select * from NhanVien" + condition);
        }


        // THÊM DỮ LIỆU
        public void AddData(NhanVien ex)
        {
            KetNoi.ExecuteReader(@"INSERT INTO NhanVien(MaNV,MaCV,TenNV,GioiTinh,Email,DienThoai,CMND,DiaChi,HinhAnh,UserName,PassWord,TrangThai)      
                                   VALUES(N'" + ex.MaNV + "',N'" + ex.MaCV + "',N'" + ex.TenNV +
                                    "',N'" + ex.GioiTinh + "',N'" + ex.Email + "',N'" + ex.DienThoai + "',N'" + ex.CMND + "',N'" + ex.DiaChi + "',N'"+ex.HinhAnh+"',N'"+ex.UserName+"',N'"+ex.PassWord+"',N'"+ex.TrangThai+"')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(NhanVien ex)
        {
         

        }
        //  XÓA DỮ LIỆU
        public void DeleteData(NhanVien ex)
        {
            
        }
    }
}
