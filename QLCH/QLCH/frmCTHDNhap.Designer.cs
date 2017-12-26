namespace QLCH
{
    partial class frmCTHDNhap
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
            this.txTongTT2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNCC2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayNhap2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNV2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txMaHD2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCTHDNhap2 = new System.Windows.Forms.DataGridView();
            this.colTenSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDel_CT = new System.Windows.Forms.Button();
            this.btnUpdate_CT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDNhap2)).BeginInit();
            this.SuspendLayout();
            // 
            // txTongTT2
            // 
            this.txTongTT2.Location = new System.Drawing.Point(738, 13);
            this.txTongTT2.Name = "txTongTT2";
            this.txTongTT2.Size = new System.Drawing.Size(146, 20);
            this.txTongTT2.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(616, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tổng thanh toán: ";
            // 
            // cbNCC2
            // 
            this.cbNCC2.FormattingEnabled = true;
            this.cbNCC2.Location = new System.Drawing.Point(382, 12);
            this.cbNCC2.Name = "cbNCC2";
            this.cbNCC2.Size = new System.Drawing.Size(200, 21);
            this.cbNCC2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nhà CC:";
            // 
            // dtNgayNhap2
            // 
            this.dtNgayNhap2.Location = new System.Drawing.Point(382, 40);
            this.dtNgayNhap2.Name = "dtNgayNhap2";
            this.dtNgayNhap2.Size = new System.Drawing.Size(200, 20);
            this.dtNgayNhap2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày nhập:";
            // 
            // cbNV2
            // 
            this.cbNV2.FormattingEnabled = true;
            this.cbNV2.Location = new System.Drawing.Point(66, 37);
            this.cbNV2.Name = "cbNV2";
            this.cbNV2.Size = new System.Drawing.Size(210, 21);
            this.cbNV2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "NV nhập:";
            // 
            // txMaHD2
            // 
            this.txMaHD2.Location = new System.Drawing.Point(66, 11);
            this.txMaHD2.Name = "txMaHD2";
            this.txMaHD2.ReadOnly = true;
            this.txMaHD2.Size = new System.Drawing.Size(210, 20);
            this.txMaHD2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã HĐ: ";
            // 
            // dgvCTHDNhap2
            // 
            this.dgvCTHDNhap2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDNhap2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSP,
            this.SL,
            this.DG,
            this.colInsDel});
            this.dgvCTHDNhap2.Location = new System.Drawing.Point(12, 81);
            this.dgvCTHDNhap2.Name = "dgvCTHDNhap2";
            this.dgvCTHDNhap2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCTHDNhap2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHDNhap2.Size = new System.Drawing.Size(874, 359);
            this.dgvCTHDNhap2.TabIndex = 26;
            this.dgvCTHDNhap2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHDNhap2_CellEndEdit);
            // 
            // colTenSP
            // 
            this.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTenSP.DataPropertyName = "STenSP";
            this.colTenSP.FillWeight = 300F;
            this.colTenSP.HeaderText = "Tên SP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenSP.Width = 300;
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
            this.DG.Width = 150;
            // 
            // colInsDel
            // 
            this.colInsDel.HeaderText = "Xoá";
            this.colInsDel.Name = "colInsDel";
            this.colInsDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInsDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(728, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(809, 456);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDel_CT
            // 
            this.btnDel_CT.Location = new System.Drawing.Point(647, 456);
            this.btnDel_CT.Name = "btnDel_CT";
            this.btnDel_CT.Size = new System.Drawing.Size(75, 35);
            this.btnDel_CT.TabIndex = 29;
            this.btnDel_CT.Text = "Xoá các lựa chọn";
            this.btnDel_CT.UseVisualStyleBackColor = true;
            this.btnDel_CT.Click += new System.EventHandler(this.btnDel_CT_Click);
            // 
            // btnUpdate_CT
            // 
            this.btnUpdate_CT.Enabled = false;
            this.btnUpdate_CT.Location = new System.Drawing.Point(563, 456);
            this.btnUpdate_CT.Name = "btnUpdate_CT";
            this.btnUpdate_CT.Size = new System.Drawing.Size(78, 35);
            this.btnUpdate_CT.TabIndex = 30;
            this.btnUpdate_CT.Text = "Cập nhật";
            this.btnUpdate_CT.UseVisualStyleBackColor = true;
            this.btnUpdate_CT.Click += new System.EventHandler(this.btnUpdate_CT_Click);
            // 
            // frmCTHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 503);
            this.Controls.Add(this.btnUpdate_CT);
            this.Controls.Add(this.btnDel_CT);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvCTHDNhap2);
            this.Controls.Add(this.txTongTT2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbNCC2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtNgayNhap2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNV2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txMaHD2);
            this.Controls.Add(this.label2);
            this.Name = "frmCTHDNhap";
            this.Text = "frmCTHDNhap";
            this.Load += new System.EventHandler(this.frmCTHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDNhap2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txTongTT2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbNCC2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayNhap2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNV2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txMaHD2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCTHDNhap2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colInsDel;
        private System.Windows.Forms.Button btnDel_CT;
        private System.Windows.Forms.Button btnUpdate_CT;
    }
}