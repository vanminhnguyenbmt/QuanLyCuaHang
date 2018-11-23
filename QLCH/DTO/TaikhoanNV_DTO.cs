using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaikhoanNV_DTO
    {
        private string sMaTK;

        public string SMaTK
        {
            get { return sMaTK; }
            set { sMaTK = value; }
        }
        private string sMaMV;

        public string SMaNV
        {
            get { return sMaMV; }
            set { sMaMV = value; }
        }

        private string sTenDangNhap;

        public string STenDangNhap
        {
            get { return sTenDangNhap; }
            set { sTenDangNhap = value; }
        }
        private string sMatKhau;

        public string SMatKhau
        {
            get { return sMatKhau; }
            set { sMatKhau = value; }
        }
    }
}
