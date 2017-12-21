using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    class DataProvider
    {
        //ket noi

        public static SqlConnection Ketnoi()
        {
            string sChuoiketnoi = @"Data Source=THIEN-PC;Initial Catalog=QLLKMT;Integrated Security=True";
            SqlConnection con = new SqlConnection(sChuoiketnoi);
            con.Open();
            return con;
        }

        // dong ket noi

        public static void Dongketnoi(SqlConnection con)
        {
            con.Close();
        }

        // lay du lieu
        public static DataTable LayDataTable(string sTruyvan, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyvan, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        //thuc thi truy van
        public static bool ThucThiTruyVanNonQuerry(string sTruyvan, SqlConnection con)
        {
            try
            {
                SqlCommand com = new SqlCommand(sTruyvan, con);
                com.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
