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
    public class HoadonBan_BUS
    {
        public static DataTable LoadTop1HDB()
        {
            return HoadonBan_DAO.LoadTop1HDB();
        }
        public static void HDBanhang_Insert(Hoadonban_DTO HDBH)
        {
            HoadonBan_DAO.HDBanhang_Insert(HDBH);
        }
        public static DataTable Sanpham_Load()
        {
            return HoadonBan_DAO.Sanpham_Load();
        }
        public static DataTable Sanpham_LoadSearch(string sChuoi)
        {
            return HoadonBan_DAO.Sanpham_LoadSearch(sChuoi);
        }
        public static DataTable Sanpham_LoadDongia(string sMaSP)
        {
            return HoadonBan_DAO.Sanpham_LoadDongia(sMaSP);
        }
        public static DataTable CTHDBH_LoadTop1()
        {
            return HoadonBan_DAO.CTHDBH_LoadTop1();
        }
        public static void ThemCTHDBH(CTHDBanhang_DTO CTHDBH)
        {
            HoadonBan_DAO.ThemCTHDBH(CTHDBH);
        }
        public static DataTable CTHDBanHang_Load(string sMaHDBH)
        {
            return HoadonBan_DAO.CTHDBanHang_Load(sMaHDBH);
        }
        public static DataTable HDBH_SumMoney(string sMaHDBH)
        {
            return HoadonBan_DAO.HDBH_SumMoney(sMaHDBH);
        }
        public static void XoaCTHDBH(string sMaCTHDBH)
        {
            HoadonBan_DAO.XoaCTHDBH(sMaCTHDBH);
        }
        public static void Update_Tongtien(Hoadonban_DTO HDBH)
        {
            HoadonBan_DAO.Update_Tongtien(HDBH);
        }
        public static void Update_CTHDBH(CTHDBanhang_DTO CTHDBH)
        {
            HoadonBan_DAO.Update_CTHDBH(CTHDBH);
        }
        public static void UpdateSL_CTHDBH(string sMaCTHDBH, string sMaSP, int iSL)
        {
            HoadonBan_DAO.UpdateSL_CTHDBH(sMaCTHDBH,sMaSP,iSL);
        }
        public static void SP_Update_SL(Sanpham_DTO SP)
        {
            HoadonBan_DAO.SP_Update_SL(SP);
        }
        public static DataTable SP_LaySL(string sMaSP)
        {
            return HoadonBan_DAO.SP_LaySL(sMaSP);
        }
        public static DataTable CheckSPinHDBH(string sMaSP, string sMaHDBH)
        {
            return HoadonBan_DAO.CheckSPinHDBH(sMaSP, sMaHDBH);
        }
    }
}
