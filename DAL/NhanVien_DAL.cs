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
            return KetNoi.GetDataTable("select MaNV,ChucVu.TenCV,TenNV,GioiTinh,NgaySinh,Email,DienThoai,CMND,DiaChi,HinhAnh,TrangThai,TenTK,MatKhau from NhanVien,ChucVu where NhanVien.MaCV = ChucVu.MaCV" + condition);
        }
    }
}
