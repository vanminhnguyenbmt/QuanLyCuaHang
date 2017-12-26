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
    public class Sanpham_DAO
    {
        static SqlConnection con;
        //load san pham
        public static List<Sanpham_DTO> LoadSanPham()
        {
            string sTruyvan = "select * from SANPHAM";
            con = DataProvider.Ketnoi();
            DataTable dt = DataProvider.LayDataTable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Sanpham_DTO> listnv = new List<Sanpham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Sanpham_DTO nv = new Sanpham_DTO();
                nv.SMaSP = dt.Rows[i]["MASP"].ToString();
                nv.STenSP = dt.Rows[i]["TENSP"].ToString();
                nv.STGBH = int.Parse(dt.Rows[i]["TGBAOHANH"].ToString());
                nv.SSoLuong = int.Parse(dt.Rows[i]["SOLUONG"].ToString());
                nv.STrangThai = dt.Rows[i]["TRANGTHAI"].ToString();
                nv.SDonGia = int.Parse(dt.Rows[i]["DONGIA"].ToString());
                nv.SMaLoai = dt.Rows[i]["MALOAI"].ToString();
                nv.SMaNCC = dt.Rows[i]["MANCC"].ToString();
                listnv.Add(nv);
            }
            return listnv;
        }

        public static String MaSPTutang()
        {
         
            Sanpham_DTO TGBH = new Sanpham_DTO();
            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("SanPham_MASP_TOP1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            string sMaSP = table.Rows[0]["MASP"].ToString(); 
            DataProvider.Dongketnoi(con);
            return sMaSP;
        }


        public static DataTable GetTableLSP()
        {

            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("LoaiSanPham_SelectAll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;

        }

        public static DataTable GetNCC()
        {

            con = DataProvider.Ketnoi();
            var cmd = new SqlCommand("NCC_SelectAll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            var Adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            Adapter.Fill(table);
            DataProvider.Dongketnoi(con);
            return table;

        }

        public static bool ThemSP(Sanpham_DTO ThemSP)
        {
            string sTruyvan = string.Format(@"insert into SANPHAM (MASP,TENSP, TGBAOHANH, SOLUONG, TRANGTHAI, DONGIA, MALOAI, MANCC) values ('{0}','{1}','{2}','{3}',N'{4}','{5}','{6}','{7}') ", ThemSP.SMaSP, ThemSP.STenSP, ThemSP.STGBH, ThemSP.SSoLuong, ThemSP.STrangThai, ThemSP.SDonGia, ThemSP.SMaLoai, ThemSP.SMaNCC);
            //string sTruyvan = "insert into khoa values('" + txtMASP+ "',N'" + txtTENSP.Text + "')";

            con = DataProvider.Ketnoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuerry(sTruyvan, con);
                DataProvider.Dongketnoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.Dongketnoi(con);
                return false;
            }
        }

        public static bool SuaSP(Sanpham_DTO SuaSP)
        {
            string sTruyvan = string.Format(" Update SANPHAM set TENSP='{0}',TGBAOHANH='{1}',TRANGTHAI='{2}',DONGIA='{3}',MALOAI='{4}',MANCC='{5}' WHERE MASP='{5}'", SuaSP.STenSP, SuaSP.STGBH, SuaSP.STrangThai, SuaSP.SDonGia, SuaSP.SMaLoai, SuaSP.SMaNCC, SuaSP.SMaSP);
            //string sTruyvan = "insert into khoa values('" + txtMASP+ "',N'" + txtTENSP.Text + "')";

            con = DataProvider.Ketnoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuerry(sTruyvan, con);
                DataProvider.Dongketnoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.Dongketnoi(con);
                return false;
            }
        }
        public static bool XoaSP(Sanpham_DTO XoaSP)
        {
            string sTruyvan = string.Format(" DELETE FROM SANPHAM WHERE  MASP='{0}'", XoaSP.SMaSP);
            //string sTruyvan = "insert into khoa values('" + txtMASP+ "',N'" + txtTENSP.Text + "')";

            con = DataProvider.Ketnoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuerry(sTruyvan, con);
                DataProvider.Dongketnoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.Dongketnoi(con);
                return false;
            }
        }

        public static List<Sanpham_DTO> TimkiemSP(string txtTukhoa)
        {
            string sTruyvan = "select * from SANPHAM where TENSP like '%"+ txtTukhoa +"%' ";
            con = DataProvider.Ketnoi();
            DataTable dt = DataProvider.LayDataTable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Sanpham_DTO> listnv = new List<Sanpham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Sanpham_DTO nv = new Sanpham_DTO();
                nv.SMaSP = dt.Rows[i]["MASP"].ToString();
                nv.STenSP = dt.Rows[i]["TENSP"].ToString();
                nv.STGBH = int.Parse(dt.Rows[i]["TGBAOHANH"].ToString());
                nv.SSoLuong = int.Parse(dt.Rows[i]["SOLUONG"].ToString());
                nv.STrangThai = dt.Rows[i]["TRANGTHAI"].ToString();
                nv.SDonGia = int.Parse(dt.Rows[i]["DONGIA"].ToString());
                nv.SMaLoai = dt.Rows[i]["MALOAI"].ToString();
                nv.SMaNCC = dt.Rows[i]["MANCC"].ToString();
                listnv.Add(nv);
            }
            return listnv;
        }

        public static List<Sanpham_DTO> LocSP(string txtTukhoa)
        {
            string sTruyvan = "select * from SANPHAM where MALOAI like '%"+ txtTukhoa +"%' ";
            con = DataProvider.Ketnoi();
            DataTable dt = DataProvider.LayDataTable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Sanpham_DTO> listnv = new List<Sanpham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Sanpham_DTO nv = new Sanpham_DTO();
                nv.SMaSP = dt.Rows[i]["MASP"].ToString();
                nv.STenSP = dt.Rows[i]["TENSP"].ToString();
                nv.STGBH = int.Parse(dt.Rows[i]["TGBAOHANH"].ToString());
                nv.SSoLuong = int.Parse(dt.Rows[i]["SOLUONG"].ToString());
                nv.STrangThai = dt.Rows[i]["TRANGTHAI"].ToString();
                nv.SDonGia = int.Parse(dt.Rows[i]["DONGIA"].ToString());
                nv.SMaLoai = dt.Rows[i]["MALOAI"].ToString();
                nv.SMaNCC = dt.Rows[i]["MANCC"].ToString();
                listnv.Add(nv);
            }
            return listnv;
        }

        public static List<Sanpham_DTO> LocSPTT(string txtTukhoa)
        {
            string sTruyvan = "select * from SANPHAM where TRANGTHAI LIKE '%" + txtTukhoa + "%' ";
            con = DataProvider.Ketnoi();
            DataTable dt = DataProvider.LayDataTable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Sanpham_DTO> listnv = new List<Sanpham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Sanpham_DTO nv = new Sanpham_DTO();
                nv.SMaSP = dt.Rows[i]["MASP"].ToString();
                nv.STenSP = dt.Rows[i]["TENSP"].ToString();
                nv.STGBH = int.Parse(dt.Rows[i]["TGBAOHANH"].ToString());
                nv.SSoLuong = int.Parse(dt.Rows[i]["SOLUONG"].ToString());
                nv.STrangThai = dt.Rows[i]["TRANGTHAI"].ToString();
                nv.SDonGia = int.Parse(dt.Rows[i]["DONGIA"].ToString());
                nv.SMaLoai = dt.Rows[i]["MALOAI"].ToString();
                nv.SMaNCC = dt.Rows[i]["MANCC"].ToString();
                listnv.Add(nv);
            }
            return listnv;
        }
        

        
    }
}
