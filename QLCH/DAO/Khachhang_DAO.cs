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
    public class Khachhang_DAO
    {
        static SqlConnection con;
        //load top 1 ma khach hang
        public static DataTable Khachhang_LoadTop1()
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Khachhang_LoadTop1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }
        //Load TENKH va MAKH 
        public static DataTable Khachhang_LoadMaTen()
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Khachhang_LoadMaTen", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        //Load DIACHI va SDT 
        public static DataTable Khachhang_LoadThongtinKH(string sMaKH)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Khachhang_LoadThongtinKH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAKH", SqlDbType.Char).Value = sMaKH;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        //Insert KH
        public static void Khachhang_Insert(Khachhang_DTO KH)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Khachhang_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAKH", SqlDbType.Char).Value = KH.SMaKH;
            cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = KH.STenKH; 
            cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = KH.SSDT;
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = KH.SDiachi; 
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }

        //Update Khach hang
        public static void Khachhang_Update(Khachhang_DTO KH)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Khachhang_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAKH", SqlDbType.Char).Value = KH.SMaKH;
            cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = KH.STenKH;
            cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = KH.SSDT;
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = KH.SDiachi;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }
    }
}
