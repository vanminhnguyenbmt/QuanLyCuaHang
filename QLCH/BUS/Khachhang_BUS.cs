using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class Khachhang_BUS
    {
        public static DataTable Khachhang_LoadTop1()
        {
            return Khachhang_DAO.Khachhang_LoadTop1();
        }
        public static DataTable Khachhang_LoadMaTen()
        {
            return Khachhang_DAO.Khachhang_LoadMaTen();
        }
        public static DataTable Khachhang_LoadThongtinKH(string sMaKH)
        {
            return Khachhang_DAO.Khachhang_LoadThongtinKH(sMaKH);
        }
        public static void Khachhang_Insert(Khachhang_DTO KH)
        {
            Khachhang_DAO.Khachhang_Insert(KH);
        }
        public static void Khachhang_Update(Khachhang_DTO KH)
        {
            Khachhang_DAO.Khachhang_Update(KH);
        }
    }
}
