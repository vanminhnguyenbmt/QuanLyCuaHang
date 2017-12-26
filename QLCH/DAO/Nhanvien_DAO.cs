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
        public static List<Nhanvien_DTO> LoadNhanVien()
        {
            string sTruyvan = "select * from NHANVIEN";
            con = DataProvider.Ketnoi();
            DataTable dt = DataProvider.LayDataTable(sTruyvan, con);
            if(dt.Rows.Count==0)
            {
                return null;
            }
            List<Nhanvien_DTO> listnv = new List<Nhanvien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nhanvien_DTO nv = new Nhanvien_DTO();
                nv.SMaNV = dt.Rows[i]["MANV"].ToString();
                nv.STenNV = dt.Rows[i]["TENNV"].ToString();
                nv.DTNgaysinh = DateTime.Parse(dt.Rows[i]["NGSINH"].ToString());
                nv.IGioitinh = Int32.Parse(dt.Rows[i]["GIOITINH"].ToString());
                nv.SDiachi = dt.Rows[i]["DIACHI"].ToString();
                nv.SSDT = dt.Rows[i]["SDT"].ToString();
                nv.SMaLoai = dt.Rows[i]["MALOAI"].ToString();
                listnv.Add(nv);
            }
            return listnv;
        }
    }
}
