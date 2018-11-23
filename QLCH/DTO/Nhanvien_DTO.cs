using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhanvien_DTO
    {
        private string sMaNV;

        public string SMaNV
        {
            get {return sMaNV;}
            set {sMaNV = value;}
        }

        private string sTenNV;

        public string STenNV
        {
            get { return sTenNV; }
            set { sTenNV = value; }
        }

        private DateTime dtNgaysinh;

        public DateTime DTNgaysinh
        {
            get { return dtNgaysinh; }
            set { dtNgaysinh = value; }
        }

        private string sGioitinh;

        public string SGioitinh
        {
            get { return sGioitinh; }
            set { sGioitinh = value; }
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

        private string sMaLoai;

        public string SMaLoai
        {
            get { return sMaLoai; }
            set { sMaLoai = value; }
        }
    }
}
