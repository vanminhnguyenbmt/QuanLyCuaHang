namespace QLCH
{
    partial class frmQLHDNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txTongSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txTongTT = new System.Windows.Forms.TextBox();
            this.dgvHDNhap = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCTHDNhap = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelHDN = new System.Windows.Forms.Button();
            this.btnAddHDN = new System.Windows.Forms.Button();
            this.btnUpdateHDN = new System.Windows.Forms.Button();
            this.btnUpdateCTHDN = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HOÁ ĐƠN NHẬP HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã HĐ: ";
            // 
            // txMaHD
            // 
            this.txMaHD.Location = new System.Drawing.Point(70, 46);
            this.txMaHD.Name = "txMaHD";
            this.txMaHD.ReadOnly = true;
            this.txMaHD.Size = new System.Drawing.Size(210, 20);
            this.txMaHD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NV nhập:";
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(70, 72);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(210, 21);
            this.cbNV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày nhập:";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Location = new System.Drawing.Point(386, 75);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(200, 20);
            this.dtNgayNhap.TabIndex = 7;
            // 
            // cbNCC
            // 
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(386, 47);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(200, 21);
            this.cbNCC.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhà CC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(622, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng số lượng SP :";
            // 
            // txTongSP
            // 
            this.txTongSP.Location = new System.Drawing.Point(744, 46);
            this.txTongSP.Name = "txTongSP";
            this.txTongSP.ReadOnly = true;
            this.txTongSP.Size = new System.Drawing.Size(146, 20);
            this.txTongSP.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(622, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tổng thanh toán: ";
            // 
            // txTongTT
            // 
            this.txTongTT.Location = new System.Drawing.Point(744, 75);
            this.txTongTT.Name = "txTongTT";
            this.txTongTT.ReadOnly = true;
            this.txTongTT.Size = new System.Drawing.Size(146, 20);
            this.txTongTT.TabIndex = 13;
            // 
            // dgvHDNhap
            // 
            this.dgvHDNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.Ngay,
            this.TongTT,
            this.NhaCC,
            this.TenNV});
            this.dgvHDNhap.Location = new System.Drawing.Point(6, 19);
            this.dgvHDNhap.Name = "dgvHDNhap";
            this.dgvHDNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDNhap.Size = new System.Drawing.Size(419, 308);
            this.dgvHDNhap.TabIndex = 14;
            this.dgvHDNhap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDNhap_CellDoubleClick);
            this.dgvHDNhap.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHDNhap_CellMouseClick);
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
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "STenNV";
            this.TenNV.HeaderText = "NV Nhập";
            this.TenNV.Name = "TenNV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHDNhap);
            this.groupBox1.Location = new System.Drawing.Point(16, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 340);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách HĐ nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCTHDNhap);
            this.groupBox2.Location = new System.Drawing.Point(447, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 340);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết HĐ nhập";
            // 
            // dgvCTHDNhap
            // 
            this.dgvCTHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.SL,
            this.DG});
            this.dgvCTHDNhap.Location = new System.Drawing.Point(9, 19);
            this.dgvCTHDNhap.Name = "dgvCTHDNhap";
            this.dgvCTHDNhap.Size = new System.Drawing.Size(422, 308);
            this.dgvCTHDNhap.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "STenSP";
            this.dataGridViewTextBoxColumn2.FillWeight = 300F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên SP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 68;
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
            // 
            // btnDelHDN
            // 
            this.btnDelHDN.BackColor = System.Drawing.Color.LightPink;
            this.btnDelHDN.Location = new System.Drawing.Point(256, 456);
            this.btnDelHDN.Name = "btnDelHDN";
            this.btnDelHDN.Size = new System.Drawing.Size(75, 35);
            this.btnDelHDN.TabIndex = 15;
            this.btnDelHDN.Text = "Xoá HĐ";
            this.btnDelHDN.UseVisualStyleBackColor = false;
            this.btnDelHDN.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddHDN
            // 
            this.btnAddHDN.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddHDN.Location = new System.Drawing.Point(175, 456);
            this.btnAddHDN.Name = "btnAddHDN";
            this.btnAddHDN.Size = new System.Drawing.Size(75, 35);
            this.btnAddHDN.TabIndex = 17;
            this.btnAddHDN.Text = "Thêm HĐ";
            this.btnAddHDN.UseVisualStyleBackColor = false;
            // 
            // btnUpdateHDN
            // 
            this.btnUpdateHDN.BackColor = System.Drawing.Color.MintCream;
            this.btnUpdateHDN.Location = new System.Drawing.Point(337, 456);
            this.btnUpdateHDN.Name = "btnUpdateHDN";
            this.btnUpdateHDN.Size = new System.Drawing.Size(104, 35);
            this.btnUpdateHDN.TabIndex = 18;
            this.btnUpdateHDN.Text = "Sửa TT Hoá đơn";
            this.btnUpdateHDN.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCTHDN
            // 
            this.btnUpdateCTHDN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateCTHDN.Location = new System.Drawing.Point(700, 456);
            this.btnUpdateCTHDN.Name = "btnUpdateCTHDN";
            this.btnUpdateCTHDN.Size = new System.Drawing.Size(99, 35);
            this.btnUpdateCTHDN.TabIndex = 19;
            this.btnUpdateCTHDN.Text = "Sửa CT Hoá đơn";
            this.btnUpdateCTHDN.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(803, 456);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 35);
            this.button5.TabIndex = 20;
            this.button5.Text = "In HĐ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmQLHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 503);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnUpdateCTHDN);
            this.Controls.Add(this.btnUpdateHDN);
            this.Controls.Add(this.btnAddHDN);
            this.Controls.Add(this.btnDelHDN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txTongTT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txTongSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txMaHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQLHDNhap";
            this.Text = "frmQLHDNhap";
            this.Load += new System.EventHandler(this.frmQLHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txTongSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txTongTT;
        private System.Windows.Forms.DataGridView dgvHDNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCTHDNhap;
        private System.Windows.Forms.Button btnDelHDN;
        private System.Windows.Forms.Button btnAddHDN;
        private System.Windows.Forms.Button btnUpdateHDN;
        private System.Windows.Forms.Button btnUpdateCTHDN;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
    }
}

