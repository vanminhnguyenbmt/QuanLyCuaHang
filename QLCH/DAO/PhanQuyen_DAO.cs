using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class PhanQuyen_DAO
    {
        static SqlConnection con;
        public static DataTable GetUser(string sUserName, string sPassWord)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("TKNhanVien_Check", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = sUserName;
            cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = sPassWord;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        public static DataTable TKNhanVien_Load()
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("TKNhanVien_NhanVien_Load", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        public static DataTable TKNhanVien_Top1()
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("TKNhanVien_Top1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        public static void ThemTK(TaikhoanNV_DTO TK)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("TKNhanVien_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MATK", SqlDbType.Char).Value = TK.SMaTK;
            cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = TK.SMaNV;
            cmd.Parameters.Add("@USERNAME", SqlDbType.Char).Value = TK.STenDangNhap;
            cmd.Parameters.Add("@PASSWORD", SqlDbType.Char).Value = TK.SMatKhau;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }

        public static void XoaTK(string sMaTK)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("TKNhanVien_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MATK", SqlDbType.Char).Value = sMaTK;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }

        public static void CapNhapTK(TaikhoanNV_DTO TK)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("TKNhanVien_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MATK", SqlDbType.Char).Value = TK.SMaTK;
            cmd.Parameters.Add("@USERNAME", SqlDbType.Char).Value = TK.STenDangNhap;
            cmd.Parameters.Add("@PASSWORD", SqlDbType.Char).Value = TK.SMatKhau;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }
    }
}
