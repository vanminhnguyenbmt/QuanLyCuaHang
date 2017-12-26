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

      private string fTongTien;
      public string FTongTien
      {
          get { return fTongTien; }
          set { fTongTien = value.Substring(0,value.Length-5);  }
      }
      private string sTenNV;
      public string STenNV
      {
          get { return sTenNV; }
          set { sTenNV = value; }
      }
      private string sTenNCC;
      public string STenNCC
      {
          get { return sTenNCC; }
          set { sTenNCC = value; }
      }
    }
}
