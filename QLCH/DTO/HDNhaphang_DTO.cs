using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class HDNhaphang_DTO
    {
      private String sMaHDN;
      public String SMaHDN
      {
          get { return sMaHDN; }
          set { sMaHDN = value; }
      }

      private String sMaNV;
      public String SMaNV
      {
          get { return sMaNV; }
          set { sMaNV = value; }
      }

      private String sMaNCC;
      public String SMaNCC
      {
          get { return sMaNCC; }
          set { sMaNCC = value; }
      }

      private DateTime dtNgayNhap;
      public DateTime DtNgayNhap
      {
          get { return dtNgayNhap; }
          set { dtNgayNhap = value; }
      }

      private float fTongTien;
      public float FTongTien
      {
          get { return fTongTien; }
          set { fTongTien = value; }
      }
    }
}
