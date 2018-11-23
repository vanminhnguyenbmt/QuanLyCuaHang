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
   public class CTHDNhap_DAO
    {
       static SqlConnection con;
       public static List<CTHDNhap_DTO> LoadCTHDNhap(String s)
       {
           con = DataProvider.Ketnoi();
           var cmd = new SqlCommand("CTHDNhap_Load",con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@MAHDNH",SqlDbType.Char).Value = s;
           var dap = new SqlDataAdapter(cmd);
           var dt = new DataTable();
           dap.Fill(dt);
           if (dt.Rows.Count == 0)
           {
               return null;
           }
           //Tao list HDNhap_DTP
           List<CTHDNhap_DTO> lstcthdn = new List<CTHDNhap_DTO>();
           for (int i = 0; i < dt.Rows.Count; i++)
           {
               CTHDNhap_DTO cthdn = new CTHDNhap_DTO();
               cthdn.SMaCTHDN = dt.Rows[i]["MACTHDNH"].ToString();
               cthdn.SMaHDN = dt.Rows[i]["MAHDNH"].ToString();
               cthdn.SMaSP = dt.Rows[i]["MASP"].ToString();
               cthdn.STenSP = dt.Rows[i]["TENSP"].ToString();
               cthdn.FGiaNhap = float.Parse(dt.Rows[i]["GIANHAP"].ToString());
               cthdn.ISoLuong = int.Parse(dt.Rows[i]["SOLUONG"].ToString());
               lstcthdn.Add(cthdn);
           }
           DataProvider.Dongketnoi(con);
           return lstcthdn;
       }
    }
}
