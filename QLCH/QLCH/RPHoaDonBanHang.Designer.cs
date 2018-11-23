namespace QLCH
{
    partial class RPHoaDonBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RPHDBHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLLKMTDataSet = new QLCH.QLLKMTDataSet();
            this.ViewDSSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewDSSPTableAdapter = new QLCH.QLLKMTDataSetTableAdapters.ViewDSSPTableAdapter();
            this.RPHDBHTableAdapter = new QLCH.QLLKMTDataSetTableAdapters.RPHDBHTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPTTHDBHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTTHDBHTableAdapter = new QLCH.QLLKMTDataSetTableAdapters.RPTTHDBHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RPHDBHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLLKMTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDSSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTTHDBHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RPHDBHBindingSource
            // 
            this.RPHDBHBindingSource.DataMember = "RPHDBH";
            this.RPHDBHBindingSource.DataSource = this.QLLKMTDataSet;
            // 
            // QLLKMTDataSet
            // 
            this.QLLKMTDataSet.DataSetName = "QLLKMTDataSet";
            this.QLLKMTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewDSSPBindingSource
            // 
            this.ViewDSSPBindingSource.DataMember = "ViewDSSP";
            this.ViewDSSPBindingSource.DataSource = this.QLLKMTDataSet;
            // 
            // ViewDSSPTableAdapter
            // 
            this.ViewDSSPTableAdapter.ClearBeforeFill = true;
            // 
            // RPHDBHTableAdapter
            // 
            this.RPHDBHTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RPHDBHBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.rPTTHDBHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCH.InHoaDonBanHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(629, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPTTHDBHBindingSource
            // 
            this.rPTTHDBHBindingSource.DataMember = "RPTTHDBH";
            this.rPTTHDBHBindingSource.DataSource = this.QLLKMTDataSet;
            // 
            // rPTTHDBHTableAdapter
            // 
            this.rPTTHDBHTableAdapter.ClearBeforeFill = true;
            // 
            // RPHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 449);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RPHoaDonBanHang";
            this.Text = "RPHoaDonBanHang";
            this.Load += new System.EventHandler(this.RPHoaDonBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPHDBHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLLKMTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDSSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTTHDBHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ViewDSSPBindingSource;
        private QLLKMTDataSet QLLKMTDataSet;
        private QLLKMTDataSetTableAdapters.ViewDSSPTableAdapter ViewDSSPTableAdapter;
        private System.Windows.Forms.BindingSource RPHDBHBindingSource;
        private QLLKMTDataSetTableAdapters.RPHDBHTableAdapter RPHDBHTableAdapter;
   
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rPTTHDBHBindingSource;
        private QLLKMTDataSetTableAdapters.RPTTHDBHTableAdapter rPTTHDBHTableAdapter;
    }
}