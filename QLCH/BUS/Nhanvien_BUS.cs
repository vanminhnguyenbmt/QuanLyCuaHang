using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Nhanvien_BUS
    {
        //load nhan vien
        public static List<Nhanvien_DTO> LoadNhanvien()
        {
            return Nhanvien_DAO.LoadNhanVien(); 
        }
    }
}
