namespace QLCH
{
    partial class frmQLNV
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
            this.grbxThongtin = new System.Windows.Forms.GroupBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbxLuong = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtBacluong = new System.Windows.Forms.TextBox();
            this.btnTinhluong = new System.Windows.Forms.Button();
            this.txtLuong = new System.Windows.Forms.Label();
            this.txtPhucap = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvLoadNV = new System.Windows.Forms.DataGridView();
            this.grbxThongtin.SuspendLayout();
            this.grbxLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // grbxThongtin
            // 
            this.grbxThongtin.Controls.Add(this.dtpNgaysinh);
            this.grbxThongtin.Controls.Add(this.label6);
            this.grbxThongtin.Controls.Add(this.txtSDT);
            this.grbxThongtin.Controls.Add(this.txtDiachi);
            this.grbxThongtin.Controls.Add(this.txtMaNV);
            this.grbxThongtin.Controls.Add(this.txtHoten);
            this.grbxThongtin.Controls.Add(this.label5);
            this.grbxThongtin.Controls.Add(this.label4);
            this.grbxThongtin.Controls.Add(this.label3);
            this.grbxThongtin.Controls.Add(this.label2);
            this.grbxThongtin.Location = new System.Drawing.Point(22, 92);
            this.grbxThongtin.Name = "grbxThongtin";
            this.grbxThongtin.Size = new System.Drawing.Size(750, 158);
            this.grbxThongtin.TabIndex = 1;
            this.grbxThongtin.TabStop = false;
            this.grbxThongtin.Text = "Thông tin";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Location = new System.Drawing.Point(507, 31);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaysinh.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(154, 118);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(201, 20);
            this.txtSDT.TabIndex = 8;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(507, 76);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(200, 20);
            this.txtDiachi.TabIndex = 7;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(154, 31);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(201, 20);
            this.txtMaNV.TabIndex = 5;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(154, 76);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(201, 20);
            this.txtHoten.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã NV:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // grbxLuong
            // 
            this.grbxLuong.Controls.Add(this.textBox3);
            this.grbxLuong.Controls.Add(this.textBox2);
            this.grbxLuong.Controls.Add(this.txtBacluong);
            this.grbxLuong.Controls.Add(this.btnTinhluong);
            this.grbxLuong.Controls.Add(this.txtLuong);
            this.grbxLuong.Controls.Add(this.txtPhucap);
            this.grbxLuong.Controls.Add(this.label7);
            this.grbxLuong.Location = new System.Drawing.Point(22, 267);
            this.grbxLuong.Name = "grbxLuong";
            this.grbxLuong.Size = new System.Drawing.Size(750, 100);
            this.grbxLuong.TabIndex = 2;
            this.grbxLuong.TabStop = false;
            this.grbxLuong.Text = "Lương";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(468, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 5;
            // 
            // txtBacluong
            // 
            this.txtBacluong.Location = new System.Drawing.Point(40, 63);
            this.txtBacluong.Name = "txtBacluong";
            this.txtBacluong.Size = new System.Drawing.Size(150, 20);
            this.txtBacluong.TabIndex = 4;
            // 
            // btnTinhluong
            // 
            this.btnTinhluong.Location = new System.Drawing.Point(658, 60);
            this.btnTinhluong.Name = "btnTinhluong";
            this.btnTinhluong.Size = new System.Drawing.Size(75, 23);
            this.btnTinhluong.TabIndex = 3;
            this.btnTinhluong.Text = "Tính lương";
            this.btnTinhluong.UseVisualStyleBackColor = true;
            // 
            // txtLuong
            // 
            this.txtLuong.AutoSize = true;
            this.txtLuong.Location = new System.Drawing.Point(531, 31);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(37, 13);
            this.txtLuong.TabIndex = 2;
            this.txtLuong.Text = "Lương";
            // 
            // txtPhucap
            // 
            this.txtPhucap.AutoSize = true;
            this.txtPhucap.Location = new System.Drawing.Point(305, 31);
            this.txtPhucap.Name = "txtPhucap";
            this.txtPhucap.Size = new System.Drawing.Size(47, 13);
            this.txtPhucap.TabIndex = 1;
            this.txtPhucap.Text = "Phụ cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bậc lương";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(428, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvLoadNV
            // 
            this.dgvLoadNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadNV.Location = new System.Drawing.Point(22, 437);
            this.dgvLoadNV.Name = "dgvLoadNV";
            this.dgvLoadNV.Size = new System.Drawing.Size(750, 212);
            this.dgvLoadNV.TabIndex = 7;
            // 
            // frmQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.dgvLoadNV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbxLuong);
            this.Controls.Add(this.grbxThongtin);
            this.Controls.Add(this.label1);
            this.Name = "frmQLNV";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQLNV_Load);
            this.grbxThongtin.ResumeLayout(false);
            this.grbxThongtin.PerformLayout();
            this.grbxLuong.ResumeLayout(false);
            this.grbxLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbxThongtin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.GroupBox grbxLuong;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtBacluong;
        private System.Windows.Forms.Button btnTinhluong;
        private System.Windows.Forms.Label txtLuong;
        private System.Windows.Forms.Label txtPhucap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvLoadNV;
    }
}

