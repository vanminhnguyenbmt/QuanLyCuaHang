using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class CTHDNhap_DTO
    {
        private String sMaCTHDN;
        public String SMaCTHDN
        {
            get { return sMaCTHDN; }
            set { sMaCTHDN = value; }
        }

        private String sMaHDN;
        public String SMaHDN
        {
            get { return sMaHDN; }
            set { sMaHDN = value; }
        }
        private String sMaSP;
        public String SMaSP
        {
            get { return sMaSP; }
            set { sMaSP = value; }
        }
        private String sTenSP;
        public String STenSP
        {
            get { return sTenSP; }
            set { sTenSP = value; }
        }
        private int iSoLuong;
        public int ISoLuong
        {
            get { return iSoLuong; }
            set { iSoLuong = value; }
        }
        private float fGiaNhap;
        public float FGiaNhap
        {
            get { return fGiaNhap; }
            set { fGiaNhap = value; }
        }
    }
}
