using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
   public class CTHDNhap_BUS
    {
        public static List<CTHDNhap_DTO> LoadCTHDNhap(String s)
        {
            return CTHDNhap_DAO.LoadCTHDNhap(s);
        }
       
    }
}
