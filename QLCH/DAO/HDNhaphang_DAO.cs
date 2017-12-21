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
   public class HDNhaphang_DAO
    {
       //Khoi tao bien ket noi
       static SqlConnection con;
       public static List<HDNhaphang_DTO> LoadHDNhap()
       {
        //Khai bao truy cap SQL
           string sTruyvan = "select * from HDNHAPHANG";
           con = DataProvider.Ketnoi();
           DataTable dt = DataProvider.LayDataTable(sTruyvan, con);
           if(dt.Rows.Count == 0)
           {
               return null;
           }
        //Tao list HDNhap_DTP
           List<HDNhaphang_DTO> lsthdn = new List<HDNhaphang_DTO>();
           for(int i = 0; i<dt.Rows.Count;i++)
           {
               HDNhaphang_DTO hdn = new HDNhaphang_DTO();
               hdn.SMaHDN = dt.Rows[i]["MAHDNH"].ToString();
               hdn.SMaNV = dt.Rows[i]["MANV"].ToString();
               hdn.SMaNCC = dt.Rows[i]["MANCC"].ToString();
               hdn.DtNgayNhap = DateTime.Parse(dt.Rows[i]["NGAYNH"].ToString());
               hdn.FTongTien = float.Parse(dt.Rows[i]["TONGTIEN"].ToString());
               lsthdn.Add(hdn);
           }
           return lsthdn;
       }
    }
}
