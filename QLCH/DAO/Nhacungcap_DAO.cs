using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class Nhacungcap_DAO
    {
        static SqlConnection con;
        //load san pham
        public static List<Nhacungcap_DTO> LoadNhaCungCap()
        {
            string sTruyvan = "select * from NHACUNGCAP";
            con = DataProvider.Ketnoi();
            DataTable dt = DataProvider.LayDataTable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Nhacungcap_DTO> listncc = new List<Nhacungcap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nhacungcap_DTO ncc = new Nhacungcap_DTO();
                ncc.SMancc = dt.Rows[i]["MANCC"].ToString();
                ncc.STencc = dt.Rows[i]["TENNCC"].ToString();
                ncc.SSodienthoaincc = dt.Rows[i]["SDT"].ToString();
                ncc.SDiachincc = dt.Rows[i]["DIACHI"].ToString();
                
                listncc.Add(ncc);
            }
            return listncc;
        }

        public static String MaNCCTutang()
        {

            Nhacungcap_DTO TGBH = new Nhacungcap_DTO();
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("NhaCungCap_TOP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            string sMaNCC = table.Rows[0]["MANCC"].ToString();
            DataProvider.Dongketnoi(con);
            return sMaNCC;
        }


        public static bool ThemNCC(Nhacungcap_DTO ThemNCC)
        {
            string sTruyvan = string.Format(@"insert into NHACUNGCAP (MANCC,TENNCC,SDT, DIACHI) values ('{0}',N'{1}',N'{2}',N'{3}') ", ThemNCC.SMancc, ThemNCC.STencc,ThemNCC.SSodienthoaincc,ThemNCC.SDiachincc);
            //string sTruyvan = "insert into khoa values('" + txtMASP+ "',N'" + txtTENSP.Text + "')";

            con = DataProvider.Ketnoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuerry(sTruyvan, con);
                DataProvider.Dongketnoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.Dongketnoi(con);
                return false;
            }
        }
        public static bool SuaNCC(Nhacungcap_DTO SuaNCC)
        {
            string sTruyvan = string.Format(" Update NHACUNGCAP set TENNCC=N'{0}',SDT=N'{1}',DIACHI=N'{2}' WHERE MANCC='{3}' ", SuaNCC.STencc,SuaNCC.SSodienthoaincc,SuaNCC.SDiachincc,SuaNCC.SMancc);
            //string sTruyvan = "insert into khoa values('" + txtMASP+ "',N'" + txtTENSP.Text + "')";

            con = DataProvider.Ketnoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuerry(sTruyvan, con);
                DataProvider.Dongketnoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.Dongketnoi(con);
                return false;
            }
        }

        public static bool XoaNCC(Nhacungcap_DTO XoaNCC)
        {
            string sTruyvan = string.Format(" DELETE FROM NHACUNGCAP WHERE  MANCC='{0}'", XoaNCC.SMancc);
            //string sTruyvan = "insert into khoa values('" + txtMASP+ "',N'" + txtTENSP.Text + "')";

            con = DataProvider.Ketnoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuerry(sTruyvan, con);
                DataProvider.Dongketnoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.Dongketnoi(con);
                return false;
            }
        }
    }
}
