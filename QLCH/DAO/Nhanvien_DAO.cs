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
            var cmd = new SqlCommand("Nhanvien_Load", con);
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

        public static void ThemNV(Nhanvien_DTO NV)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Nhanvien_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = NV.SMaNV;
            cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = NV.STenNV; ;
            cmd.Parameters.Add("@NGSINH", SqlDbType.SmallDateTime).Value = NV.DTNgaysinh; ;
            cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = NV.SGioitinh; ;
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = NV.SDiachi; ;
            cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = NV.SSDT; ;
            cmd.Parameters.Add("@MALOAI", SqlDbType.Char).Value = NV.SMaLoai; ;
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

        public static void CapNhatNV(Nhanvien_DTO NV)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Nhanvien_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = NV.SMaNV;
            cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = NV.STenNV; ;
            cmd.Parameters.Add("@NGSINH", SqlDbType.SmallDateTime).Value = NV.DTNgaysinh; ;
            cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = NV.SGioitinh; ;
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = NV.SDiachi; ;
            cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = NV.SSDT; ;
            cmd.Parameters.Add("@MALOAI", SqlDbType.Char).Value = NV.SMaLoai; ;
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

        public static DataTable LoadMaNV(string sTenNV)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("sp_timkiem", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.Char).Value = sTenNV;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            DataProvider.Dongketnoi(con);
            return table;
        }

        public static void XoaTKNV(string sMaNV)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("TKNHANVIEN_DeleteMaNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = sMaNV;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }

    }
}
