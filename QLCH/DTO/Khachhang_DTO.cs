using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khachhang_DTO
    {
        private string sMaKH;

        public string SMaKH
        {
            get { return sMaKH; }
            set { sMaKH = value; }
        }

        private string sTenKH;

        public string STenKH
        {
            get { return sTenKH; }
            set { sTenKH = value; }
        }

        private string sDiachi;

        public string SDiachi
        {
            get { return sDiachi; }
            set { sDiachi = value; }
        }

        private string sSDT;

        public string SSDT
        {
            get { return sSDT; }
            set { sSDT = value; }
        }
    }
}
