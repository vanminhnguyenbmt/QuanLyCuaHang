using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLCH
{
    public partial class RPHoaDonBanHang : Form
    {
        public RPHoaDonBanHang()
        {
            InitializeComponent();
        }

        private void SetParameter()
        {
            ReportParameter rp = new ReportParameter("MaHoaDonBanHang");
            rp.Values.Add(sMaHDBH);
            reportViewer1.LocalReport.SetParameters(rp);
        }
        public string sMaHDBH { set; get; }
        private void RPHoaDonBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLLKMTDataSet.RPTTHDBH' table. You can move, or remove it, as needed.
            this.rPTTHDBHTableAdapter.Fill(this.QLLKMTDataSet.RPTTHDBH, sMaHDBH);
            // TODO: This line of code loads data into the 'QLLKMTDataSet.RPHDBH' table. You can move, or remove it, as needed.
            this.RPHDBHTableAdapter.Fill(this.QLLKMTDataSet.RPHDBH, sMaHDBH);

            
            // TODO: This line of code loads data into the 'QLLKMTDataSet.ViewDSSP' table. You can move, or remove it, as needed.
            //this.ViewDSSPTableAdapter.Fill(this.QLLKMTDataSet.ViewDSSP);

            this.reportViewer1.RefreshReport();
            SetParameter();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            
        }
    }
}
