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
    public class Nhanvien_DAO
    {
        static SqlConnection con;
        //load nhan vien
        public static DataTable LoadNhanVien()
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("NhanVien_SelectAll", con);
            //string sTruyvan = "select * from NHANVIEN";
            //DataTable dt = DataProvider.LayDataTable(sTruyvan, con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            return table;
        }
    }
}
