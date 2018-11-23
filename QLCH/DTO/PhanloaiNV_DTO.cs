using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanloaiNV_DTO
    {
        private string sMaloaiNV;

        public string SMaloaiNV
        {
            get { return sMaloaiNV; }
            set { sMaloaiNV = value; }
        }
        private string sTenloaiMV;

        public string STenloaiNV
        {
            get { return sTenloaiMV; }
            set { sTenloaiMV = value; }
        }
    }
}
