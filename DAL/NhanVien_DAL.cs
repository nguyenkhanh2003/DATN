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
            return KetNoi.GetDataTable("select MaNV,ChucVu.TenCV,TenNV,GioiTinh,Email,NgaySinh,DienThoai,CMND,DiaChi,HinhAnh,UserName,PassWord,NhanVien.TrangThai From NhanVien,ChucVu where NhanVien.MaCV=ChucVu.MaCV" + condition);
        }

       //Hien Thị Tìm Kiếm
        public DataTable GetTimKiem(string Condition)
        {
            return KetNoi.GetDataTable(""+Condition);
        }

        // THÊM DỮ LIỆU
        public void AddData(NhanVien ex)
        {
            KetNoi.ExecuteReader(@"INSERT INTO NhanVien(MaNV,MaCV,TenNV,GioiTinh,Email,NgaySinh,DienThoai,CMND,DiaChi,HinhAnh,UserName,PassWord,TrangThai)      
                                   VALUES(N'" + ex.MaNV + "',N'" + ex.MaCV + "',N'" + ex.TenNV +
                                    "',N'" + ex.GioiTinh + "',N'" + ex.Email + "',N'"+ex.NgaySinh+"',N'" + ex.DienThoai + "',N'" + ex.CMND + "',N'" + ex.DiaChi + "',N'"+ex.HinhAnh+"',N'"+ex.UserName+"',N'"+ex.PassWord+"',N'"+ex.TrangThai+"')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(NhanVien ex)
        {
            KetNoi.ExecuteReader(@"UPDATE NhanVien SET MaCV=N'" + ex.MaCV + "',TenNV=N'" + ex.TenNV + "',GioiTinh=N'" + ex.GioiTinh + "',Email=N'" + ex.Email + "',NgaySinh=" + ex.NgaySinh + ",DienThoai=N'" + ex.DienThoai + "',CMND=N'" + ex.CMND + "',DiaChi=N'" + ex.DiaChi + "',HinhAnh=N'" + ex.HinhAnh + "',UserName=N'" + ex.UserName + "',PassWord=N'" + ex.PassWord + "',TrangThai=N'" + ex.TrangThai + "' Where MaNV='" + ex.MaNV + "' ");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(NhanVien ex)
        {
            KetNoi.ExecuteReader(@"Delete From NhanVien Where MaNV='" + ex.MaNV + "'");
        }
    }
}
