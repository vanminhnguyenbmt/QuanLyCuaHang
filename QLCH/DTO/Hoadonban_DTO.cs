using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hoadonban_DTO
    {
        private string sMaHDB;

        public string SMaHDB
        {
            get { return sMaHDB; }
            set { sMaHDB = value; }
        }

        private string sMaNV;

        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }

        private string sMaKH;

        public string SMaKH
        {
            get { return sMaKH; }
            set { sMaKH = value; }
        }

        private DateTime dtNgayBH;

        public DateTime DtNgayBH
        {
            get { return dtNgayBH; }
            set { dtNgayBH = value; }
        }

        private long lThanhtien;

        public long LThanhtien
        {
            get { return lThanhtien; }
            set { lThanhtien = value; }
        }
    }
}
