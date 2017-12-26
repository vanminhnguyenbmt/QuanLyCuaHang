namespace QLCH
{
    partial class DMSP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvdanhmucsp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.bntimkiem = new System.Windows.Forms.Button();
            this.cblsp = new System.Windows.Forms.ComboBox();
            this.btlsp = new System.Windows.Forms.Button();
            this.cblsptinhtrang = new System.Windows.Forms.ComboBox();
            this.btlsptinhtrang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhmucsp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btlsptinhtrang);
            this.groupBox1.Controls.Add(this.cblsptinhtrang);
            this.groupBox1.Controls.Add(this.btlsp);
            this.groupBox1.Controls.Add(this.cblsp);
            this.groupBox1.Controls.Add(this.bntimkiem);
            this.groupBox1.Controls.Add(this.txttukhoa);
            this.groupBox1.Location = new System.Drawing.Point(2, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvdanhmucsp);
            this.groupBox2.Location = new System.Drawing.Point(2, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục sản phẩm";
            // 
            // dgvdanhmucsp
            // 
            this.dgvdanhmucsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhmucsp.Location = new System.Drawing.Point(0, 23);
            this.dgvdanhmucsp.Name = "dgvdanhmucsp";
            this.dgvdanhmucsp.Size = new System.Drawing.Size(683, 150);
            this.dgvdanhmucsp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // txttukhoa
            // 
            this.txttukhoa.Location = new System.Drawing.Point(80, 33);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(100, 20);
            this.txttukhoa.TabIndex = 0;
            // 
            // bntimkiem
            // 
            this.bntimkiem.Location = new System.Drawing.Point(214, 33);
            this.bntimkiem.Name = "bntimkiem";
            this.bntimkiem.Size = new System.Drawing.Size(114, 23);
            this.bntimkiem.TabIndex = 1;
            this.bntimkiem.Text = "Tìm kiếm";
            this.bntimkiem.UseVisualStyleBackColor = true;
            this.bntimkiem.Click += new System.EventHandler(this.bntimkiem_Click);
            // 
            // cblsp
            // 
            this.cblsp.FormattingEnabled = true;
            this.cblsp.Location = new System.Drawing.Point(80, 60);
            this.cblsp.Name = "cblsp";
            this.cblsp.Size = new System.Drawing.Size(100, 21);
            this.cblsp.TabIndex = 2;
            // 
            // btlsp
            // 
            this.btlsp.Location = new System.Drawing.Point(214, 60);
            this.btlsp.Name = "btlsp";
            this.btlsp.Size = new System.Drawing.Size(114, 23);
            this.btlsp.TabIndex = 3;
            this.btlsp.Text = "Lọc theo loại SP";
            this.btlsp.UseVisualStyleBackColor = true;
            this.btlsp.Click += new System.EventHandler(this.btlsp_Click);
            // 
            // cblsptinhtrang
            // 
            this.cblsptinhtrang.FormattingEnabled = true;
            this.cblsptinhtrang.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng",
            "Ngừng kinh doanh"});
            this.cblsptinhtrang.Location = new System.Drawing.Point(405, 34);
            this.cblsptinhtrang.Name = "cblsptinhtrang";
            this.cblsptinhtrang.Size = new System.Drawing.Size(121, 21);
            this.cblsptinhtrang.TabIndex = 4;
            // 
            // btlsptinhtrang
            // 
            this.btlsptinhtrang.Location = new System.Drawing.Point(563, 33);
            this.btlsptinhtrang.Name = "btlsptinhtrang";
            this.btlsptinhtrang.Size = new System.Drawing.Size(75, 23);
            this.btlsptinhtrang.TabIndex = 5;
            this.btlsptinhtrang.Text = "Lọc theo trạng thái";
            this.btlsptinhtrang.UseVisualStyleBackColor = true;
            this.btlsptinhtrang.Click += new System.EventHandler(this.btlsptinhtrang_Click);
            // 
            // DMSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DMSP";
            this.Text = "Danh mục sản phẩm";
            this.Load += new System.EventHandler(this.DMSP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhmucsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvdanhmucsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntimkiem;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Button btlsp;
        private System.Windows.Forms.ComboBox cblsp;
        private System.Windows.Forms.Button btlsptinhtrang;
        private System.Windows.Forms.ComboBox cblsptinhtrang;
    }
}