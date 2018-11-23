namespace QLCH
{
    partial class frmDMHDNH
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
            this.dgvHDNhap_DM = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNV_DMHDN = new System.Windows.Forms.ComboBox();
            this.cbNV2 = new System.Windows.Forms.Label();
            this.cbNCC_DMHDN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocDate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdShowAll = new System.Windows.Forms.RadioButton();
            this.rdFillter = new System.Windows.Forms.RadioButton();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCTHDNhap = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNhap_DM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHDNhap_DM
            // 
            this.dgvHDNhap_DM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHDNhap_DM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDNhap_DM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.Ngay,
            this.TongTT,
            this.NhaCC,
            this.TenNV});
            this.dgvHDNhap_DM.Location = new System.Drawing.Point(12, 154);
            this.dgvHDNhap_DM.Name = "dgvHDNhap_DM";
            this.dgvHDNhap_DM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDNhap_DM.Size = new System.Drawing.Size(811, 203);
            this.dgvHDNhap_DM.TabIndex = 15;
            this.dgvHDNhap_DM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDNhap_DM_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNV_DMHDN);
            this.groupBox1.Controls.Add(this.cbNV2);
            this.groupBox1.Controls.Add(this.cbNCC_DMHDN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 98);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc theo: ";
            // 
            // cbNV_DMHDN
            // 
            this.cbNV_DMHDN.FormattingEnabled = true;
            this.cbNV_DMHDN.Location = new System.Drawing.Point(116, 63);
            this.cbNV_DMHDN.Name = "cbNV_DMHDN";
            this.cbNV_DMHDN.Size = new System.Drawing.Size(267, 21);
            this.cbNV_DMHDN.TabIndex = 19;
            this.cbNV_DMHDN.SelectedIndexChanged += new System.EventHandler(this.cbNV_DMHDN_SelectedIndexChanged);
            // 
            // cbNV2
            // 
            this.cbNV2.AutoSize = true;
            this.cbNV2.Location = new System.Drawing.Point(19, 67);
            this.cbNV2.Name = "cbNV2";
            this.cbNV2.Size = new System.Drawing.Size(92, 13);
            this.cbNV2.TabIndex = 20;
            this.cbNV2.Text = "Nhân viên nhập : ";
            // 
            // cbNCC_DMHDN
            // 
            this.cbNCC_DMHDN.FormattingEnabled = true;
            this.cbNCC_DMHDN.Location = new System.Drawing.Point(116, 30);
            this.cbNCC_DMHDN.Name = "cbNCC_DMHDN";
            this.cbNCC_DMHDN.Size = new System.Drawing.Size(267, 21);
            this.cbNCC_DMHDN.TabIndex = 17;
            this.cbNCC_DMHDN.SelectedIndexChanged += new System.EventHandler(this.cbNCC_DMHDN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nhà cung cấp :";
            // 
            // btnLocDate
            // 
            this.btnLocDate.Location = new System.Drawing.Point(320, 26);
            this.btnLocDate.Name = "btnLocDate";
            this.btnLocDate.Size = new System.Drawing.Size(64, 53);
            this.btnLocDate.TabIndex = 21;
            this.btnLocDate.Text = "Lọc";
            this.btnLocDate.UseVisualStyleBackColor = true;
            this.btnLocDate.Click += new System.EventHandler(this.btnLocDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Đến ngày :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Từ ngày :";
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(105, 26);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(200, 20);
            this.dtpBegin.TabIndex = 27;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(105, 59);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLocDate);
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpBegin);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(425, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 98);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc các hoá đơn theo ngày : ";
            // 
            // rdShowAll
            // 
            this.rdShowAll.AutoSize = true;
            this.rdShowAll.Checked = true;
            this.rdShowAll.Location = new System.Drawing.Point(12, 27);
            this.rdShowAll.Name = "rdShowAll";
            this.rdShowAll.Size = new System.Drawing.Size(77, 17);
            this.rdShowAll.TabIndex = 30;
            this.rdShowAll.TabStop = true;
            this.rdShowAll.Text = "Hiện tất cả";
            this.rdShowAll.UseVisualStyleBackColor = true;
            this.rdShowAll.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdFillter
            // 
            this.rdFillter.AutoSize = true;
            this.rdFillter.Location = new System.Drawing.Point(118, 27);
            this.rdFillter.Name = "rdFillter";
            this.rdFillter.Size = new System.Drawing.Size(158, 17);
            this.rdFillter.TabIndex = 31;
            this.rdFillter.Text = "Lọc theo điều kiện bên dưới";
            this.rdFillter.UseVisualStyleBackColor = true;
            this.rdFillter.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "SMaHDN";
            this.MaHD.HeaderText = "Mã HĐ";
            this.MaHD.Name = "MaHD";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "DtNgayNhap";
            this.Ngay.HeaderText = "Ngày nhập";
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 150;
            // 
            // TongTT
            // 
            this.TongTT.DataPropertyName = "FTongTien";
            this.TongTT.HeaderText = "Tổng TT";
            this.TongTT.Name = "TongTT";
            // 
            // NhaCC
            // 
            this.NhaCC.DataPropertyName = "STenNCC";
            this.NhaCC.HeaderText = "Nhà CC";
            this.NhaCC.Name = "NhaCC";
            this.NhaCC.Width = 150;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "STenNV";
            this.TenNV.HeaderText = "NV Nhập";
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 200;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCTHDNhap);
            this.groupBox3.Location = new System.Drawing.Point(12, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(814, 202);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết HĐ nhập";
            // 
            // dgvCTHDNhap
            // 
            this.dgvCTHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.SL,
            this.DG});
            this.dgvCTHDNhap.Location = new System.Drawing.Point(6, 19);
            this.dgvCTHDNhap.Name = "dgvCTHDNhap";
            this.dgvCTHDNhap.Size = new System.Drawing.Size(798, 177);
            this.dgvCTHDNhap.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "STenSP";
            this.dataGridViewTextBoxColumn2.FillWeight = 300F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên SP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "ISoLuong";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // DG
            // 
            this.DG.DataPropertyName = "FGiaNhap";
            this.DG.HeaderText = "Giá nhập";
            this.DG.Name = "DG";
            this.DG.Width = 200;
            // 
            // frmDMHDNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 556);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rdFillter);
            this.Controls.Add(this.rdShowAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHDNhap_DM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDMHDNH";
            this.Text = "t";
            this.Load += new System.EventHandler(this.frmDMHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNhap_DM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHDNhap_DM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNV_DMHDN;
        private System.Windows.Forms.Label cbNV2;
        private System.Windows.Forms.ComboBox cbNCC_DMHDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLocDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdShowAll;
        private System.Windows.Forms.RadioButton rdFillter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCTHDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
    }
}