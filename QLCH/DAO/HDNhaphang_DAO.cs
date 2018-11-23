using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data.Sql;
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
                   con = DataProvider.Ketnoi();
                   DataTable dt = DataProvider.GetDataTable("HoaDonNhap_Load", con);
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
               hdn.STenNV = dt.Rows[i]["TENNV"].ToString();
               hdn.SMaNCC = dt.Rows[i]["MANCC"].ToString();
               hdn.STenNCC = dt.Rows[i]["TENNCC"].ToString();
               hdn.DtNgayNhap =dt.Rows[i]["NGAYNH"].ToString();
               hdn.FTongTien = dt.Rows[i]["TONGTIEN"].ToString();
               lsthdn.Add(hdn);
           }
           DataProvider.Dongketnoi(con);
           return lsthdn;
       }
    }
}
