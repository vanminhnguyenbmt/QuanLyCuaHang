using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class PhanQuyen_BUS
    {
        public static DataTable GetUser(string sUserName, string sPassWord)
        {
            return PhanQuyen_DAO.GetUser(sUserName, sPassWord);
        }

        public static DataTable TKNhanVien_Load()
        {
            return PhanQuyen_DAO.TKNhanVien_Load();
        }

        public static DataTable TKNhanVien_Top1()
        {
            return PhanQuyen_DAO.TKNhanVien_Top1();
        }

        public static void ThemTK(TaikhoanNV_DTO TK)
        {
            PhanQuyen_DAO.ThemTK(TK);
        }

        public static void XoaTK(string sMaTK)
        {
            PhanQuyen_DAO.XoaTK(sMaTK);
        }

        public static void CapNhapTK(TaikhoanNV_DTO TK)
        {
            PhanQuyen_DAO.CapNhapTK(TK);
        }
    }
}
