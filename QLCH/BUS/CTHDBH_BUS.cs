using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;

namespace BUS
{
    public class CTHDBH_BUS
    {
        public static DataTable HDBANHANG_Load()
        {
            return CTHDBH_DAO.HDBANHANG_Load();
        }
        public static DataTable CTHDBANHANG_Load(string sMaHDBH)
        {
            return CTHDBH_DAO.CTHDBANHANG_Load(sMaHDBH);
        }
        public static DataTable HDBANHANG_LoadKH(string sMaKH)
        {
            return CTHDBH_DAO.HDBANHANG_LoadKH(sMaKH);
        }
        public static DataTable HDBANHANG_LoadNV(string sMaNV)
        {
            return CTHDBH_DAO.HDBANHANG_LoadNV(sMaNV);
        }
        public static DataTable HDBANHANG_Loc(DateTime dtStart, DateTime dtEnd)
        {
            return CTHDBH_DAO.HDBANHANG_Loc(dtStart, dtEnd);
        }
    }
}
