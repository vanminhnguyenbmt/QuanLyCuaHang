using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Nhanvien_BUS
    {
        //load nhan vien
        public static DataTable LoadNhanvien()
        {
            return Nhanvien_DAO.LoadNhanVien(); 
        }

        //load loai NV
        public static DataTable LoadLoaiNV()
        {
            return Nhanvien_DAO.LoadLoaiNV();
        }

        //load ten NV
        public static DataTable LoadTenNV()
        {
            return Nhanvien_DAO.LoadTenNhanVien();
        }
        //them nhan vien
        public static void ThemNV(Nhanvien_DTO NV)
        {
            Nhanvien_DAO.ThemNV(NV);
        }
        //xoa nhan vien
        public static void XoaNV(string sMaNV)
        {
            Nhanvien_DAO.XoaNV(sMaNV);
        }
        //cap nhat nhan vien
        public static void CapNhatNV(Nhanvien_DTO NV)
        {
            Nhanvien_DAO.CapNhatNV(NV);
        }
        //tim kiem nhan vien
        public static DataTable TimkiemNV(string sChuoi)
        {
            return Nhanvien_DAO.TimkiemNV(sChuoi);
        }
        //load ma nv
        public static DataTable LoadMaNV(string sTenNV)
        {
            return Nhanvien_DAO.LoadMaNV(sTenNV);
        }
        //Xoa tk nhan vien
        public static void XoaTKNV(string sMaNV)
        {
            Nhanvien_DAO.XoaTKNV(sMaNV);
        }
    }
}
