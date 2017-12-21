using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class HDNhaphang_BUS
    {
    // Load Hoadon nhap
        public static List<HDNhaphang_DTO> LoadHDNhap()
        {

            return HDNhaphang_DAO.LoadHDNhap();
        }
    }
}
