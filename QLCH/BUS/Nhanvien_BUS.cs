using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Nhanvien_BUS
    {
        //load nhan vien
        public static DataTable LoadNhanvien()
        {
            return Nhanvien_DAO.LoadNhanVien(); 
        }
    }
}
