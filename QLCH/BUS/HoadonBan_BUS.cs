using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;

namespace BUS
{
    public class HoadonBan_BUS
    {
        public static DataTable LoadTop1HDB()
        {
            return HoadonBan_DAO.LoadTop1HDB();
        }
    }
}
