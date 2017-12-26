using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class Nhacungcap_BUS
    {
        public static List<Nhacungcap_DTO> LoadNhacungcap()
        {
            return Nhacungcap_DAO.LoadNhaCungCap();
        }
    }
}
