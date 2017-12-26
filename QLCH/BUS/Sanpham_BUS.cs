using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class Sanpham_BUS
    {
        //load nhan vien
        public static List<Sanpham_DTO> LoadSanpham()
        {
            return Sanpham_DAO.LoadSanPham();
        }

        public string XuLyMaSP()
        {
            string MaSPGoc = Sanpham_DAO.MaSPTutang();
            string kyTuDau = MaSPGoc.Substring(0, 2);
            int soCanTang = Convert.ToInt32(MaSPGoc.Substring(2)) + 1;

            string MaSP = "";
            if (soCanTang >= 0 && soCanTang < 10)
                MaSP = kyTuDau + "00" + soCanTang;
            if (soCanTang >= 10 && soCanTang < 100)
                MaSP = kyTuDau + "0" + soCanTang;
            if (soCanTang >= 100 && soCanTang < 1000)
                MaSP = kyTuDau + soCanTang;
            return MaSP;
        }

        /*public static List<Loaisp_DTO> LoadLSP()
        {
            return Sanpham_DAO.LoadLoaiSanPham();
        }*/
        public static DataTable GetTableLSP()
        {
            return Sanpham_DAO.GetTableLSP();
        }

        public static DataTable GetNCC()
        {
            return Sanpham_DAO.GetNCC();
        }

        public static bool Themsp(Sanpham_DTO ThemSP)
        {
            return Sanpham_DAO.ThemSP(ThemSP);
        }
        public static bool Suasp(Sanpham_DTO SuaSP)
        {
            return Sanpham_DAO.SuaSP(SuaSP);
        }
        public static bool Xoasp(Sanpham_DTO XoaSP)
        {
            return Sanpham_DAO.XoaSP(XoaSP);
        }
        public static List<Sanpham_DTO> Timkiemsp(string Tukhoa)
        {
            return Sanpham_DAO.TimkiemSP(Tukhoa);
        }

        public static List<Sanpham_DTO> Locsp(string Tukhoa)
        {
            return Sanpham_DAO.LocSP(Tukhoa);
        }
        public static List<Sanpham_DTO> Locsptt(string Tukhoa)
        {
            return Sanpham_DAO.LocSPTT(Tukhoa);
        }
    }

   
}
