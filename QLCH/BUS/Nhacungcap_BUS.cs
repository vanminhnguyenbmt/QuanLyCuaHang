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

        public string XuLyMaNCC()
        {
            string MaNCCGoc = Nhacungcap_DAO.MaNCCTutang();
            string kyTuDau = MaNCCGoc.Substring(0, 3);
            int soCanTang = Convert.ToInt32(MaNCCGoc.Substring(3)) + 1;

            string MaNCC = "";
            if (soCanTang >= 0 && soCanTang < 10)
                MaNCC = kyTuDau + "0" + soCanTang;
            if (soCanTang >= 10 && soCanTang < 100)
                MaNCC = kyTuDau + soCanTang;
            return MaNCC;
        }

        public static bool Themncc(Nhacungcap_DTO ThemNCC)
        {
            return Nhacungcap_DAO.ThemNCC(ThemNCC);
        }

        public static bool Suancc(Nhacungcap_DTO SuaNCC)
        {
            return Nhacungcap_DAO.SuaNCC(SuaNCC);
        }

        public static bool Xoancc(Nhacungcap_DTO XoaNCC)
        {
            return Nhacungcap_DAO.XoaNCC(XoaNCC);
        }


    }
}
