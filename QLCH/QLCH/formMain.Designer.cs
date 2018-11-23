namespace QLCH
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeThong = new System.Windows.Forms.Panel();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnCNNV = new System.Windows.Forms.Button();
            this.btnCNKH = new System.Windows.Forms.Button();
            this.btnCNNCC = new System.Windows.Forms.Button();
            this.btnCNSP = new System.Windows.Forms.Button();
            this.btnCNHDNH = new System.Windows.Forms.Button();
            this.btnCNBH = new System.Windows.Forms.Button();
            this.panelDanhMuc = new System.Windows.Forms.Panel();
            this.btnDMLSP = new System.Windows.Forms.Button();
            this.btnDMKH = new System.Windows.Forms.Button();
            this.btnDMNCC = new System.Windows.Forms.Button();
            this.btnDMSP = new System.Windows.Forms.Button();
            this.btnDMHDNH = new System.Windows.Forms.Button();
            this.btnDMHDBH = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.btnGioiThieu = new System.Windows.Forms.Button();
            this.btnChucNang = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.panelHeThong.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.panelDanhMuc.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.panelHeThong);
            this.panel1.Controls.Add(this.panelChucNang);
            this.panel1.Controls.Add(this.panelDanhMuc);
            this.panel1.Controls.Add(this.btnHeThong);
            this.panel1.Controls.Add(this.btnGioiThieu);
            this.panel1.Controls.Add(this.btnChucNang);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnDanhMuc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 672);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelHeThong
            // 
            this.panelHeThong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeThong.Controls.Add(this.btnQLTaiKhoan);
            this.panelHeThong.Controls.Add(this.btnDangXuat);
            this.panelHeThong.Controls.Add(this.btnDangNhap);
            this.panelHeThong.Location = new System.Drawing.Point(34, 599);
            this.panelHeThong.Name = "panelHeThong";
            this.panelHeThong.Size = new System.Drawing.Size(162, 72);
            this.panelHeThong.TabIndex = 7;
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnQLTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(0, 46);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(162, 23);
            this.btnQLTaiKhoan.TabIndex = 2;
            this.btnQLTaiKhoan.Text = "QL Tài Khoản";
            this.btnQLTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 23);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(162, 23);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangNhap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(0, 0);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(162, 23);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // panelChucNang
            // 
            this.panelChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChucNang.Controls.Add(this.btnCNNV);
            this.panelChucNang.Controls.Add(this.btnCNKH);
            this.panelChucNang.Controls.Add(this.btnCNNCC);
            this.panelChucNang.Controls.Add(this.btnCNSP);
            this.panelChucNang.Controls.Add(this.btnCNHDNH);
            this.panelChucNang.Controls.Add(this.btnCNBH);
            this.panelChucNang.Location = new System.Drawing.Point(34, 324);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(162, 139);
            this.panelChucNang.TabIndex = 7;
            // 
            // btnCNNV
            // 
            this.btnCNNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCNNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnCNNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCNNV.ForeColor = System.Drawing.Color.White;
            this.btnCNNV.Location = new System.Drawing.Point(0, 115);
            this.btnCNNV.Name = "btnCNNV";
            this.btnCNNV.Size = new System.Drawing.Size(162, 24);
            this.btnCNNV.TabIndex = 5;
            this.btnCNNV.Text = "QL Nhân Viên";
            this.btnCNNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCNNV.UseVisualStyleBackColor = true;
            this.btnCNNV.Click += new System.EventHandler(this.btnCNNV_Click);
            // 
            // btnCNKH
            // 
            this.btnCNKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCNKH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnCNKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCNKH.ForeColor = System.Drawing.Color.White;
            this.btnCNKH.Location = new System.Drawing.Point(0, 92);
            this.btnCNKH.Name = "btnCNKH";
            this.btnCNKH.Size = new System.Drawing.Size(162, 23);
            this.btnCNKH.TabIndex = 4;
            this.btnCNKH.Text = "Thống kê";
            this.btnCNKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCNKH.UseVisualStyleBackColor = true;
            this.btnCNKH.Click += new System.EventHandler(this.btnCNKH_Click);
            // 
            // btnCNNCC
            // 
            this.btnCNNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCNNCC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnCNNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCNNCC.ForeColor = System.Drawing.Color.White;
            this.btnCNNCC.Location = new System.Drawing.Point(0, 69);
            this.btnCNNCC.Name = "btnCNNCC";
            this.btnCNNCC.Size = new System.Drawing.Size(162, 23);
            this.btnCNNCC.TabIndex = 3;
            this.btnCNNCC.Text = "QL Nhà Cung Cấp";
            this.btnCNNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCNNCC.UseVisualStyleBackColor = true;
            this.btnCNNCC.Click += new System.EventHandler(this.btnCNNCC_Click);
            // 
            // btnCNSP
            // 
            this.btnCNSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCNSP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnCNSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCNSP.ForeColor = System.Drawing.Color.White;
            this.btnCNSP.Location = new System.Drawing.Point(0, 46);
            this.btnCNSP.Name = "btnCNSP";
            this.btnCNSP.Size = new System.Drawing.Size(162, 23);
            this.btnCNSP.TabIndex = 2;
            this.btnCNSP.Text = "QL Sản Phẩm";
            this.btnCNSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCNSP.UseVisualStyleBackColor = true;
            this.btnCNSP.Click += new System.EventHandler(this.btnCNSP_Click);
            // 
            // btnCNHDNH
            // 
            this.btnCNHDNH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCNHDNH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnCNHDNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCNHDNH.ForeColor = System.Drawing.Color.White;
            this.btnCNHDNH.Location = new System.Drawing.Point(0, 23);
            this.btnCNHDNH.Name = "btnCNHDNH";
            this.btnCNHDNH.Size = new System.Drawing.Size(162, 23);
            this.btnCNHDNH.TabIndex = 1;
            this.btnCNHDNH.Text = "QL Hóa Đơn Nhập Hàng";
            this.btnCNHDNH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCNHDNH.UseVisualStyleBackColor = true;
            this.btnCNHDNH.Click += new System.EventHandler(this.btnCNHDNH_Click);
            // 
            // btnCNBH
            // 
            this.btnCNBH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCNBH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnCNBH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCNBH.ForeColor = System.Drawing.Color.White;
            this.btnCNBH.Location = new System.Drawing.Point(0, 0);
            this.btnCNBH.Name = "btnCNBH";
            this.btnCNBH.Size = new System.Drawing.Size(162, 23);
            this.btnCNBH.TabIndex = 0;
            this.btnCNBH.Text = "QL Bán Hàng";
            this.btnCNBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCNBH.UseVisualStyleBackColor = true;
            this.btnCNBH.Click += new System.EventHandler(this.btnCNBH_CLick);
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDanhMuc.Controls.Add(this.btnDMLSP);
            this.panelDanhMuc.Controls.Add(this.btnDMKH);
            this.panelDanhMuc.Controls.Add(this.btnDMNCC);
            this.panelDanhMuc.Controls.Add(this.btnDMSP);
            this.panelDanhMuc.Controls.Add(this.btnDMHDNH);
            this.panelDanhMuc.Controls.Add(this.btnDMHDBH);
            this.panelDanhMuc.Location = new System.Drawing.Point(34, 114);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(162, 139);
            this.panelDanhMuc.TabIndex = 6;
            // 
            // btnDMLSP
            // 
            this.btnDMLSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDMLSP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnDMLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMLSP.ForeColor = System.Drawing.Color.White;
            this.btnDMLSP.Location = new System.Drawing.Point(0, 115);
            this.btnDMLSP.Name = "btnDMLSP";
            this.btnDMLSP.Size = new System.Drawing.Size(162, 24);
            this.btnDMLSP.TabIndex = 5;
            this.btnDMLSP.Text = "Loại Sản Phẩm";
            this.btnDMLSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMLSP.UseVisualStyleBackColor = true;
            this.btnDMLSP.Click += new System.EventHandler(this.btnDMLSP_Click);
            // 
            // btnDMKH
            // 
            this.btnDMKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDMKH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnDMKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMKH.ForeColor = System.Drawing.Color.White;
            this.btnDMKH.Location = new System.Drawing.Point(0, 92);
            this.btnDMKH.Name = "btnDMKH";
            this.btnDMKH.Size = new System.Drawing.Size(162, 23);
            this.btnDMKH.TabIndex = 4;
            this.btnDMKH.Text = "Nhân viên";
            this.btnDMKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMKH.UseVisualStyleBackColor = true;
            this.btnDMKH.Click += new System.EventHandler(this.btnDMKH_Click);
            // 
            // btnDMNCC
            // 
            this.btnDMNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDMNCC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnDMNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMNCC.ForeColor = System.Drawing.Color.White;
            this.btnDMNCC.Location = new System.Drawing.Point(0, 69);
            this.btnDMNCC.Name = "btnDMNCC";
            this.btnDMNCC.Size = new System.Drawing.Size(162, 23);
            this.btnDMNCC.TabIndex = 3;
            this.btnDMNCC.Text = "Nhà Cung Cấp";
            this.btnDMNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMNCC.UseVisualStyleBackColor = true;
            this.btnDMNCC.Click += new System.EventHandler(this.btnDMNCC_Click);
            // 
            // btnDMSP
            // 
            this.btnDMSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDMSP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnDMSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMSP.ForeColor = System.Drawing.Color.White;
            this.btnDMSP.Location = new System.Drawing.Point(0, 46);
            this.btnDMSP.Name = "btnDMSP";
            this.btnDMSP.Size = new System.Drawing.Size(162, 23);
            this.btnDMSP.TabIndex = 2;
            this.btnDMSP.Text = "Sản Phẩm";
            this.btnDMSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMSP.UseVisualStyleBackColor = true;
            this.btnDMSP.Click += new System.EventHandler(this.btnDMSP_Click);
            // 
            // btnDMHDNH
            // 
            this.btnDMHDNH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDMHDNH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnDMHDNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMHDNH.ForeColor = System.Drawing.Color.White;
            this.btnDMHDNH.Location = new System.Drawing.Point(0, 23);
            this.btnDMHDNH.Name = "btnDMHDNH";
            this.btnDMHDNH.Size = new System.Drawing.Size(162, 23);
            this.btnDMHDNH.TabIndex = 1;
            this.btnDMHDNH.Text = "Hóa Đơn Nhập Hàng";
            this.btnDMHDNH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMHDNH.UseVisualStyleBackColor = true;
            this.btnDMHDNH.Click += new System.EventHandler(this.btnDMHDNH_Click);
            // 
            // btnDMHDBH
            // 
            this.btnDMHDBH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDMHDBH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnDMHDBH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMHDBH.ForeColor = System.Drawing.Color.White;
            this.btnDMHDBH.Location = new System.Drawing.Point(0, 0);
            this.btnDMHDBH.Name = "btnDMHDBH";
            this.btnDMHDBH.Size = new System.Drawing.Size(162, 23);
            this.btnDMHDBH.TabIndex = 0;
            this.btnDMHDBH.Text = "Hóa Đơn Bán Hàng";
            this.btnDMHDBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMHDBH.UseVisualStyleBackColor = true;
            this.btnDMHDBH.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.ForeColor = System.Drawing.Color.White;
            this.btnHeThong.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong.Image")));
            this.btnHeThong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.Location = new System.Drawing.Point(14, 534);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(182, 59);
            this.btnHeThong.TabIndex = 8;
            this.btnHeThong.Text = "Hệ Thống";
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.FlatAppearance.BorderSize = 0;
            this.btnGioiThieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioiThieu.ForeColor = System.Drawing.Color.White;
            this.btnGioiThieu.Image = ((System.Drawing.Image)(resources.GetObject("btnGioiThieu.Image")));
            this.btnGioiThieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGioiThieu.Location = new System.Drawing.Point(14, 469);
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.Size = new System.Drawing.Size(182, 59);
            this.btnGioiThieu.TabIndex = 7;
            this.btnGioiThieu.Text = "Giới Thiệu";
            this.btnGioiThieu.UseVisualStyleBackColor = true;
            this.btnGioiThieu.Click += new System.EventHandler(this.btnGioiThieu_Click);
            // 
            // btnChucNang
            // 
            this.btnChucNang.FlatAppearance.BorderSize = 0;
            this.btnChucNang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChucNang.ForeColor = System.Drawing.Color.White;
            this.btnChucNang.Image = ((System.Drawing.Image)(resources.GetObject("btnChucNang.Image")));
            this.btnChucNang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChucNang.Location = new System.Drawing.Point(15, 259);
            this.btnChucNang.Name = "btnChucNang";
            this.btnChucNang.Size = new System.Drawing.Size(182, 59);
            this.btnChucNang.TabIndex = 6;
            this.btnChucNang.Text = "Chức Năng";
            this.btnChucNang.UseVisualStyleBackColor = true;
            this.btnChucNang.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.SidePanel.Location = new System.Drawing.Point(2, 48);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 59);
            this.SidePanel.TabIndex = 5;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMuc.Image")));
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(14, 49);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(183, 59);
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "Danh Mục";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.btnMaximize);
            this.panelStatus.Controls.Add(this.btnMinimize);
            this.panelStatus.Controls.Add(this.btnExit);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(200, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(852, 38);
            this.panelStatus.TabIndex = 6;
            this.panelStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelStatus_MouseDown);
            this.panelStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelStatus_MouseMove);
            this.panelStatus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelStatus_MouseUp);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(777, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(33, 33);
            this.btnMaximize.TabIndex = 8;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(738, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 33);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(816, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(200, 38);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(852, 634);
            this.tabControl.TabIndex = 7;
            this.tabControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDoubleClick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 672);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panel1.ResumeLayout(false);
            this.panelHeThong.ResumeLayout(false);
            this.panelChucNang.ResumeLayout(false);
            this.panelDanhMuc.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Button btnGioiThieu;
        private System.Windows.Forms.Button btnChucNang;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Panel panelDanhMuc;
        private System.Windows.Forms.Button btnDMSP;
        private System.Windows.Forms.Button btnDMHDNH;
        private System.Windows.Forms.Button btnDMHDBH;
        private System.Windows.Forms.Button btnDMLSP;
        private System.Windows.Forms.Button btnDMKH;
        private System.Windows.Forms.Button btnDMNCC;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Button btnCNNV;
        private System.Windows.Forms.Button btnCNKH;
        private System.Windows.Forms.Button btnCNNCC;
        private System.Windows.Forms.Button btnCNSP;
        private System.Windows.Forms.Button btnCNHDNH;
        private System.Windows.Forms.Button btnCNBH;
        private System.Windows.Forms.Panel panelHeThong;
        private System.Windows.Forms.Button btnQLTaiKhoan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.TabControl tabControl;
    }
}