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
    public class HoadonBan_DAO
    {
        static SqlConnection con;
        //load nhan vien
        public static DataTable LoadTop1HDB()
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("HDBanHang_Load", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }
        //load ten nv
        public static DataTable LoadTenNhanVien()
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("NhanVien_SelectTenNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        //load loai NV
        public static DataTable LoadLoaiNV()
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("PLNhanVien_SelectLoaiNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        public static void ThemNV(string sMaNV, string sHoten, DateTime dtNgaysinh, string sGioitinh, string sDiachi, string sSDT, string sMaloai)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Nhanvien_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = sMaNV;
            cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = sHoten; ;
            cmd.Parameters.Add("@NGSINH", SqlDbType.SmallDateTime).Value = dtNgaysinh; ;
            cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = sGioitinh; ;
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = sDiachi; ;
            cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = sSDT; ;
            cmd.Parameters.Add("@MALOAI", SqlDbType.Char).Value = sMaloai; ;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }

        public static void XoaNV(string sMaNV)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Nhanvien_Detele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = sMaNV;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }

        public static void CapNhatNV(string sMaNV, string sHoten, DateTime dtNgaysinh, string sGioitinh, string sDiachi, string sSDT, string sMaloai)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Nhanvien_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = sMaNV;
            cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = sHoten; ;
            cmd.Parameters.Add("@NGSINH", SqlDbType.SmallDateTime).Value = dtNgaysinh; ;
            cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = sGioitinh; ;
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = sDiachi; ;
            cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = sSDT; ;
            cmd.Parameters.Add("@MALOAI", SqlDbType.Char).Value = sMaloai; ;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }

        public static DataTable TimkiemNV(string sChuoi)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("NhanVien_Search", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CHUOI", SqlDbType.Char).Value = sChuoi;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            DataProvider.Dongketnoi(con);
            return table;
        }
    }
}
