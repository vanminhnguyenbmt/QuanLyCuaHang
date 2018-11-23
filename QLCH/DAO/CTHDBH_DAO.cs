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
    public class CTHDBH_DAO
    {
        static SqlConnection con;

        //Load Hoa don ban hang
        public static DataTable HDBANHANG_Load()
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("HDBANHANG_Load", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        //Load Chi tiet hoa don ban hang
        public static DataTable CTHDBANHANG_Load(string sMaHDBH)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("CTHDBanHang_Load", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAHDBH", SqlDbType.Char).Value = sMaHDBH;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        //Load Hoa don ban hang thoe khach hang
        public static DataTable HDBANHANG_LoadKH(string sMaKH)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("HDBANHANG_LoadKH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAKH", SqlDbType.Char).Value = sMaKH;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        //Load Hoa don ban hang theo nhan vien
        public static DataTable HDBANHANG_LoadNV(string sMaNV)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("HDBANHANG_LoadNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = sMaNV;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        //Loc hoa don theo ngay
        public static DataTable HDBANHANG_Loc(DateTime dtStart, DateTime dtEnd)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("HDBANHANG_Loc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@START", SqlDbType.SmallDateTime).Value = dtStart;
            cmd.Parameters.Add("@END", SqlDbType.SmallDateTime).Value = dtEnd;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }
    }
}
