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
    public partial class rpHDBH : Form
    {
        public rpHDBH()
        {
            InitializeComponent();
        }

        private void SetParameter(DateTime fromDate, DateTime toDate)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("FromDate");
            rp[1] = new ReportParameter("ToDate");
            rp[0].Values.Add(fromDate.ToString());
            rp[1].Values.Add(toDate.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
            //ReportParameter rp1 = new ReportParameter();
            //rp1 = new ReportParameter("FromDate");
            //rp1.Values.Add(dtpFromDate.Value.Date.ToString());
            //ReportParameter rp2 = new ReportParameter();
            //rp2 = new ReportParameter("ToDate");      
            //rp2.Values.Add(dtpToDate.Value.Date.ToString());
            //reportViewer1.LocalReport.SetParameters(rp1);
            //reportViewer1.LocalReport.SetParameters(rp2);
        }

        private void rpHDBH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLLKMTDataSet.TEST' table. You can move, or remove it, as needed.
            this.tESTTableAdapter.Fill(this.QLLKMTDataSet.TEST);
            // TODO: This line of code loads data into the 'QLLKMTDataSet.FILTER_HDBH' table. You can move, or remove it, as needed.
            this.FILTER_HDBHTableAdapter.Fill(this.QLLKMTDataSet.FILTER_HDBH,dtpFromDate.Value,dtpToDate.Value);
            SetParameter(dtpFromDate.Value, dtpToDate.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetParameter(dtpFromDate.Value, dtpToDate.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
