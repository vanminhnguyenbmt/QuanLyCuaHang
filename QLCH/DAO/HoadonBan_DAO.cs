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
        //load top 1 ma nhan vien
        public static DataTable LoadTop1HDB()
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("HDBanHang_LoadTop1", con);
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

        public static void XoaNV(string sMaNV)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Nhanvien_Detele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = sMaNV;
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

        public static void HDBanhang_Insert(Hoadonban_DTO HDBH)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("HDBanHang_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAHDBH", SqlDbType.Char).Value = HDBH.SMaHDB;
            cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = HDBH.SMaNV; 
            cmd.Parameters.Add("@MAKH", SqlDbType.Char).Value = HDBH.SMaKH; 
            cmd.Parameters.Add("@NGAYBH", SqlDbType.SmallDateTime).Value = HDBH.DtNgayBH;
            cmd.Parameters.Add("@THANHTIEN", SqlDbType.Money).Value = 0;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }
        public static DataTable Sanpham_Load()
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Sanpham_Load", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        public static DataTable Sanpham_LoadSearch(string sChuoi)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("SP_LoadSearch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CHUOI", SqlDbType.Char).Value = sChuoi;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        public static DataTable Sanpham_LoadDongia(string sMaSP)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("Sanpham_LoadDongia", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MASP", SqlDbType.Char).Value = sMaSP;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        public static DataTable CTHDBH_LoadTop1()
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("CTHDBH_LoadTop1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }
        public static void ThemCTHDBH(CTHDBanhang_DTO CTHDBH)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("CTHDBanHang_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MACTHDBH", SqlDbType.Char).Value = CTHDBH.SMaCTHDB;
            cmd.Parameters.Add("@MAHDBH", SqlDbType.Char).Value = CTHDBH.SMaHDB;
            cmd.Parameters.Add("@MASP", SqlDbType.Char).Value = CTHDBH.SMaSP;
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = CTHDBH.ISoLuong;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }
        public static DataTable CTHDBanHang_Load(string sMaHDBH)
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
        public static DataTable HDBH_SumMoney(string sMaHD)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("HDBH_SumMoney", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAHDBH", SqlDbType.Char).Value = sMaHD;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }
        public static void XoaCTHDBH(string sMaCTHDBH)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("CTHDBanHang_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MACTHDBH", SqlDbType.Char).Value = sMaCTHDBH;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }
        public static void Update_Tongtien(Hoadonban_DTO HDBH)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("HDBANHANG_Update_ThanhTien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAHDBH", SqlDbType.Char).Value = HDBH.SMaHDB;
            cmd.Parameters.Add("@THANHTIEN", SqlDbType.Int).Value = HDBH.LThanhtien;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }
        public static void Update_CTHDBH(CTHDBanhang_DTO CTHDBH)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("CTHDBanHang_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MACTHDBH", SqlDbType.Char).Value = CTHDBH.SMaCTHDB;
            cmd.Parameters.Add("@MAHDBH", SqlDbType.Char).Value = CTHDBH.SMaHDB;
            cmd.Parameters.Add("@MASP", SqlDbType.Char).Value = CTHDBH.SMaSP;
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = CTHDBH.ISoLuong;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }
        public static void UpdateSL_CTHDBH(string sMaCTHDBH, string sMaSP, int iSL)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("CTHDBanHang_UpdateSL", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MACTHDBH", SqlDbType.Char).Value = sMaCTHDBH;
            cmd.Parameters.Add("@MASP", SqlDbType.Char).Value = sMaSP;
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = iSL;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }
        public static void SP_Update_SL(Sanpham_DTO SP)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("SANPHAM_CapnhatSL", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MASP", SqlDbType.Char).Value = SP.SMaSP;
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = SP.SSoLuong;
            cmd.ExecuteNonQuery();
            DataProvider.Dongketnoi(con);
        }
        public static DataTable SP_LaySL(string sMaSP)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("SANPHAM_LaySL", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MASP", SqlDbType.Char).Value = sMaSP;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }

        public static DataTable CheckSPinHDBH(string sMaSP, string sMaHDBH)
        {
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("CheckSPinHDBH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MASP", SqlDbType.Char).Value = sMaSP;
            cmd.Parameters.Add("@MAHDBH", SqlDbType.Char).Value = sMaHDBH;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;
        }
    }
}
