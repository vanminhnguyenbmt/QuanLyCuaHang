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
                nv.STGBH = dt.Rows[i]["TGBAOHANH"].ToString();
                nv.SSoLuong = dt.Rows[i]["SOLUONG"].ToString();
                nv.STrangThai = dt.Rows[i]["TRANGTHAI"].ToString();
                nv.SDonGia = dt.Rows[i]["DONGIA"].ToString();
                nv.SMaLoai = dt.Rows[i]["MALOAI"].ToString();
                nv.SMaNCC = dt.Rows[i]["MANCC"].ToString();
                listnv.Add(nv);
            }
            return listnv;
        }
    }
}
