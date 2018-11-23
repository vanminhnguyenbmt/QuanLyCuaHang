using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHDBanhang_DTO
    {
        private string sMaCTHDB;

        public string SMaCTHDB
        {
            get { return sMaCTHDB; }
            set { sMaCTHDB = value; }
        }

        private string sMaHDB;

        public string SMaHDB
        {
            get { return sMaHDB; }
            set { sMaHDB = value; }
        }

        private string sMaSP;

        public string SMaSP
        {
            get { return sMaSP; }
            set { sMaSP = value; }
        }

        private int iSoLuong;

        public int ISoLuong
        {
            get { return iSoLuong; }
            set { iSoLuong = value; }
        }
    }
}
