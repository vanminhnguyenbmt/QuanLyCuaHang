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
                ncc.SDiachincc = dt.Rows[i]["SDT"].ToString();
                ncc.SSodienthoaincc = dt.Rows[i]["DIACHI"].ToString();
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
    }
}
