using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Sanpham_BUS
    {
        //load nhan vien
        public static List<Sanpham_DTO> LoadSanpham()
        {
            return Sanpham_DAO.LoadSanPham();
        }
    }
}
