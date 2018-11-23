using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public partial class formMain : Form
    {
        //string sMaTK = "", sMaNV = "", sTenNV = "", sUserName = "", sPassWord = "", sTenLoai = "";
        private bool dragging = false;
        private bool isNormal = false;
        private bool isChucNang = false;
        private bool isHeThong = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void btnChucNang_Click(object sender, EventArgs e)
        {
            if(isChucNang == false)
            {
                panelChucNang.Visible = true;
                panelDanhMuc.Visible = false;
                panelHeThong.Visible = false;
                btnChucNang.Top = btnDanhMuc.Bottom;
                SidePanel.Top = btnChucNang.Top;
                SidePanel.Height = btnChucNang.Height;
                panelChucNang.Top = btnChucNang.Bottom;
                panelChucNang.Left = btnChucNang.Left;
                btnGioiThieu.Top = panelChucNang.Bottom;
                btnHeThong.Top = btnGioiThieu.Bottom;
                isChucNang = true;
            }
            else
            {
                panelChucNang.Visible = false;
                panelDanhMuc.Visible = false;
                panelHeThong.Visible = false;
                btnChucNang.Top = btnDanhMuc.Bottom;
                SidePanel.Top = btnChucNang.Top;
                SidePanel.Height = btnChucNang.Height;
                panelChucNang.Top = btnChucNang.Bottom;
                panelChucNang.Left = btnChucNang.Left;
                btnGioiThieu.Top = btnChucNang.Bottom;
                btnHeThong.Top = btnGioiThieu.Bottom;
                isChucNang = false;
            }
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnGioiThieu.Height;
            SidePanel.Top = btnGioiThieu.Top;
            panelDanhMuc.Visible = false;
            panelChucNang.Visible = false;
            panelHeThong.Visible = false;
            btnChucNang.Top = btnDanhMuc.Bottom;
            btnGioiThieu.Top = btnChucNang.Bottom;
            SidePanel.Height = btnGioiThieu.Height;
            SidePanel.Top = btnGioiThieu.Top;
            btnHeThong.Top = btnGioiThieu.Bottom;
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            if(isHeThong == false)
            {
                SidePanel.Height = btnHeThong.Height;
                SidePanel.Top = btnHeThong.Top;
                panelHeThong.Visible = true;
                panelDanhMuc.Visible = false;
                panelChucNang.Visible = false;
                btnChucNang.Top = btnDanhMuc.Bottom;
                btnGioiThieu.Top = btnChucNang.Bottom;
                btnHeThong.Top = btnGioiThieu.Bottom;
                SidePanel.Height = btnHeThong.Height;
                SidePanel.Top = btnHeThong.Top;
                panelHeThong.Left = btnHeThong.Left;
                panelHeThong.Top = btnHeThong.Bottom;
                isHeThong = true;
            }
            else
            {
                SidePanel.Height = btnHeThong.Height;
                SidePanel.Top = btnHeThong.Top;
                panelHeThong.Visible = false;
                panelDanhMuc.Visible = false;
                panelChucNang.Visible = false;
                btnChucNang.Top = btnDanhMuc.Bottom;
                btnGioiThieu.Top = btnChucNang.Bottom;
                btnHeThong.Top = btnGioiThieu.Bottom;
                SidePanel.Height = btnHeThong.Height;
                SidePanel.Top = btnHeThong.Top;
                panelHeThong.Left = btnHeThong.Left;
                panelHeThong.Top = btnHeThong.Bottom;
                isHeThong = false;
            }
        }
        public bool isDMHDBH = false;
        TabPage tabDMHDBH = new TabPage();
        private void button1_Click(object sender, EventArgs e)
        {
            btnDMHDBH.FlatAppearance.BorderColor = Color.FromArgb(254, 215, 0);
            btnDMHDNH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMNCC.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMKH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMLSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);

            if(isDMHDBH)
            {
                tabControl.SelectedTab = tabDMHDBH;
            }
            else
            {
                frmCTHDBH frmCTHDBH = new frmCTHDBH();
                frmCTHDBH.BringToFront();
                frmCTHDBH.TopLevel = false;
                frmCTHDBH.Visible = true;
                frmCTHDBH.Dock = DockStyle.Fill;
                //TabPage tabDMHDBH = new TabPage();
                tabDMHDBH.Controls.Add(frmCTHDBH);
                tabDMHDBH.Text = "DMHD bán hàng";
                tabControl.TabPages.Add(tabDMHDBH);
                tabControl.SelectedTab = tabDMHDBH;
                isDMHDBH = true;
            }     
        }

        public bool isDMHDNH = false;
        TabPage tabDMHDNH = new TabPage();
        private void btnDMHDNH_Click(object sender, EventArgs e)
        {
            btnDMHDBH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMHDNH.FlatAppearance.BorderColor = Color.FromArgb(254, 215, 0);
            btnDMSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMNCC.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMKH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMLSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);

            if(isDMHDNH)
            {
                tabControl.SelectedTab = tabDMHDNH;
            }
            else
            {
                frmDMHDNH frmDMHDNH = new frmDMHDNH();
                frmDMHDNH.BringToFront();
                frmDMHDNH.TopLevel = false;
                frmDMHDNH.Visible = true;
                frmDMHDNH.Dock = DockStyle.Fill;

                tabDMHDNH.Controls.Add(frmDMHDNH);
                tabDMHDNH.Text = "DMHD nhập hàng";
                tabControl.TabPages.Add(tabDMHDNH);
                tabControl.SelectedTab = tabDMHDNH;
                isDMHDNH = true;
            }            
        }

        public bool isDMSP = false;
        TabPage tabDMSP = new TabPage();
        private void btnDMSP_Click(object sender, EventArgs e)
        {
            btnDMHDBH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMHDNH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMSP.FlatAppearance.BorderColor = Color.FromArgb(254, 215, 0);
            btnDMNCC.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMKH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMLSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);

            if(isDMSP)
            {
                tabControl.SelectedTab = tabDMSP;
            }
            else
            {
                DMSP frmDMSP = new DMSP();
                frmDMSP.BringToFront();
                frmDMSP.TopLevel = false;
                frmDMSP.Visible = true;
                frmDMSP.Dock = DockStyle.Fill;

                tabDMSP.Controls.Add(frmDMSP);
                tabDMSP.Text = "Danh mục sản phẩm";
                tabControl.TabPages.Add(tabDMSP);
                tabControl.SelectedTab = tabDMSP;
                isDMSP = true;
            }
            
        }

        private void btnDMNCC_Click(object sender, EventArgs e)
        {
            btnDMHDBH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMHDNH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41); 
            btnDMNCC.FlatAppearance.BorderColor = Color.FromArgb(254, 215, 0);
            btnDMKH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMLSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
        }

        public bool isDMNV = false;
        TabPage tabDMNV = new TabPage();
        private void btnDMKH_Click(object sender, EventArgs e)
        {
            btnDMHDBH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMHDNH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMNCC.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMKH.FlatAppearance.BorderColor = Color.FromArgb(254, 215, 0);
            btnDMLSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);

            if(isDMNV)
            {
                tabControl.SelectedTab = tabDMNV;
            }
            else
            {
                frmDMNV frmDMNV = new frmDMNV();
                frmDMNV.BringToFront();
                frmDMNV.TopLevel = false;
                frmDMNV.Visible = true;
                frmDMNV.Dock = DockStyle.Fill;

                tabDMNV.Controls.Add(frmDMNV);
                tabDMNV.Text = "Danh mục nhân viên";
                tabControl.TabPages.Add(tabDMNV);
                tabControl.SelectedTab = tabDMNV;
                isDMNV = true;
            }     
        }

        private void btnDMLSP_Click(object sender, EventArgs e)
        {
            btnDMHDBH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMHDNH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMNCC.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMKH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnDMLSP.FlatAppearance.BorderColor = Color.FromArgb(254, 215, 0);
        }

        public bool isCNBH = false;
        TabPage tabQLBH = new TabPage();
        private void btnCNBH_CLick(object sender, EventArgs e)
        {
            btnCNBH.FlatAppearance.BorderColor = Color.FromArgb(254, 215, 0);
            btnCNHDNH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNNCC.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNKH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNNV.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);

            if(isCNBH)
            {
                tabControl.SelectedTab = tabQLBH;
            }
            else
            {
                frmQLBH frmQLBH = new frmQLBH();
                frmQLBH.BringToFront();
                frmQLBH.TopLevel = false;
                frmQLBH.Visible = true;
                frmQLBH.Dock = DockStyle.Fill;

                tabQLBH.Controls.Add(frmQLBH);
                tabQLBH.Text = "Quản lý bán hàng";
                tabControl.TabPages.Add(tabQLBH);
                tabControl.SelectedTab = tabQLBH;
                isCNBH = true;
            }       
        }

        public bool isCNHDNH = false;
        TabPage tabQLHDNH = new TabPage();
        private void btnCNHDNH_Click(object sender, EventArgs e)
        {
            btnCNBH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNHDNH.FlatAppearance.BorderColor = Color.FromArgb(254, 215, 0);
            btnCNSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNNCC.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNKH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNNV.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);

            if(isCNHDNH)
            {
                tabControl.SelectedTab = tabQLHDNH;
            }
            else
            {
                frmQLHDNhap frmQLHDNhap = new frmQLHDNhap();
                frmQLHDNhap.BringToFront();
                frmQLHDNhap.TopLevel = false;
                frmQLHDNhap.Visible = true;
                frmQLHDNhap.Dock = DockStyle.Fill;

                tabQLHDNH.Controls.Add(frmQLHDNhap);
                tabQLHDNH.Text = "QLHD Nhập hàng";
                tabControl.TabPages.Add(tabQLHDNH);
                tabControl.SelectedTab = tabQLHDNH;
                isCNHDNH = true;
            }
        }

        public bool isCNSP = false;
        TabPage tabQLSP = new TabPage();
        private void btnCNSP_Click(object sender, EventArgs e)
        {
            btnCNBH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNHDNH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNSP.FlatAppearance.BorderColor = Color.FromArgb(254, 215, 0);
            btnCNNCC.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNKH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNNV.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);

            if(isCNSP)
            {
                tabControl.SelectedTab = tabQLSP;
            }
            else
            {
                QLSP frmQLSP = new QLSP();
                frmQLSP.BringToFront();
                frmQLSP.TopLevel = false;
                frmQLSP.Visible = true;
                frmQLSP.Dock = DockStyle.Fill;

                tabQLSP.Controls.Add(frmQLSP);
                tabQLSP.Text = "Quản lý sản phẩm";
                tabControl.TabPages.Add(tabQLSP);
                tabControl.SelectedTab = tabQLSP;
                isCNSP = true;
            } 
        }

        public bool isCNNCC = false;
        TabPage tabQLNCC = new TabPage();
        private void btnCNNCC_Click(object sender, EventArgs e)
        {
            btnCNBH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNHDNH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNNCC.FlatAppearance.BorderColor = Color.FromArgb(254, 215, 0);
            btnCNKH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNNV.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);

            if (isCNNCC)
            {
                tabControl.SelectedTab = tabQLNCC;
            }
            else
            {
                QLNCC frmQLNCC = new QLNCC();
                frmQLNCC.BringToFront();
                frmQLNCC.TopLevel = false;
                frmQLNCC.Visible = true;
                frmQLNCC.Dock = DockStyle.Fill;

                tabQLNCC.Controls.Add(frmQLNCC);
                tabQLNCC.Text = "Quản lý nhà cung cấp";
                tabControl.TabPages.Add(tabQLNCC);
                tabControl.SelectedTab = tabQLNCC;
                isCNNCC = true;
            }
        }
        TabPage tabTK = new TabPage();
        private void btnCNKH_Click(object sender, EventArgs e)
        {
            btnCNBH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNHDNH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNNCC.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNKH.FlatAppearance.BorderColor = Color.FromArgb(254, 215, 0);
            btnCNNV.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);

            rpHDBH rp = new rpHDBH();
            rp.BringToFront();
            rp.TopLevel = false;
            rp.Visible = true;
            rp.Dock = DockStyle.Fill;

            tabTK.Controls.Add(rp);
            tabTK.Text = "Thống kê";
            tabControl.TabPages.Add(tabTK);
            tabControl.SelectedTab = tabTK;
        }

        public bool isCNNV = false;
        TabPage tabQLNV = new TabPage();
        private void btnCNNV_Click(object sender, EventArgs e)
        {
            btnCNBH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNHDNH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNSP.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNNCC.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNKH.FlatAppearance.BorderColor = Color.FromArgb(42, 39, 41);
            btnCNNV.FlatAppearance.BorderColor = Color.FromArgb(254, 215, 0);

            if(isCNNV)
            {
                tabControl.SelectedTab = tabQLNV;
            }
            else
            {
                frmQLNV frmQLNV = new frmQLNV();
                frmQLNV.BringToFront();
                frmQLNV.TopLevel = false;
                frmQLNV.Visible = true;
                frmQLNV.Dock = DockStyle.Fill;

                tabQLNV.Controls.Add(frmQLNV);
                tabQLNV.Text = "Quản lý nhân viên";
                tabControl.TabPages.Add(tabQLNV);
                tabControl.SelectedTab = tabQLNV;
                isCNNV = true;
            }     
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelStatus_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panelStatus_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panelStatus_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(isNormal == false)
            {
                this.WindowState = FormWindowState.Maximized;
                isNormal = true;
            }  
            else
            {
                this.WindowState = FormWindowState.Normal;
                isNormal = false;
            }    
        }

        public bool isQLTK = false;
        TabPage tabQLTK = new TabPage();
        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            if(isQLTK)
            {
                tabControl.SelectedTab = tabQLTK;
            }
            else
            {
                UserControl ucQLTK = new ucQLTK();
                ucQLTK.Dock = DockStyle.Fill;

                tabQLTK.Controls.Add(ucQLTK);
                tabQLTK.Text = "Quản lý tài khoản";
                tabControl.TabPages.Add(tabQLTK);
                tabControl.SelectedTab = tabQLTK;
                isQLTK = true;
            } 
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            switch(frmLogin.loginTenLoai)
            {
                case "Quản Lý":
                {
                    btnDangNhap.Enabled = false;
                    btnQLTaiKhoan.Enabled = false;
                    break;
                }
                case "KINH DOANH":
                {
                    btnDangNhap.Enabled = false;
                    btnQLTaiKhoan.Enabled = false;
                    btnCNHDNH.Enabled = false;
                    btnCNSP.Enabled = true;
                    btnCNNCC.Enabled = false;
                    btnCNKH.Enabled = false;
                    btnCNNV.Enabled = false;
                    break;
                }
                case "KHO":
                {
                    btnDangNhap.Enabled = false;
                    btnQLTaiKhoan.Enabled = false;
                    btnCNBH.Enabled = false;
                    btnCNNCC.Enabled = false;
                    btnCNKH.Enabled = false;
                    btnCNNV.Enabled = false;
                    break;
                }
                default:
                {
                    btnDangNhap.Enabled = false;
                    break;
                }
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if(isNormal == false)
            {
                panelDanhMuc.Visible = true;
                panelHeThong.Visible = false;
                panelChucNang.Visible = false;
                SidePanel.Height = btnDanhMuc.Height;
                SidePanel.Top = btnDanhMuc.Top;
                panelDanhMuc.Top = btnDanhMuc.Bottom;
                panelDanhMuc.Left = btnDanhMuc.Left;
                btnChucNang.Top = panelDanhMuc.Bottom;
                btnGioiThieu.Top = btnChucNang.Bottom;
                btnHeThong.Top = btnGioiThieu.Bottom;
                isNormal = true;
            }
            else
            {
                panelDanhMuc.Visible = false;
                panelHeThong.Visible = false;
                panelChucNang.Visible = false;
                SidePanel.Height = btnDanhMuc.Height;
                SidePanel.Top = btnDanhMuc.Top;
                panelDanhMuc.Top = btnDanhMuc.Bottom;
                panelDanhMuc.Left = btnDanhMuc.Left;
                btnChucNang.Top = btnDanhMuc.Bottom;
                btnGioiThieu.Top = btnChucNang.Bottom;
                btnHeThong.Top = btnGioiThieu.Bottom;
                isNormal = false;
            }
        }

        public formMain()
        {
            InitializeComponent();
            panelDanhMuc.Visible = false;
            panelChucNang.Visible = false;
            panelHeThong.Visible = false;
            btnChucNang.Top = btnDanhMuc.Bottom;
            btnGioiThieu.Top = btnChucNang.Bottom;
            btnHeThong.Top = btnGioiThieu.Bottom;
        }

        private void tabControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TabPage current_tab = tabControl.SelectedTab;
            tabControl.TabPages.Remove(current_tab);
        }

        //public formMain(string sMaTK, string sMaNV, string sTenNV, string sUserName, string sPassWord, string sTenLoai)
        //{
        //    InitializeComponent();
        //    this.sMaTK = sMaTK;
        //    this.sMaNV = sMaNV;
        //    this.sTenNV = sTenNV;
        //    this.sUserName = sUserName;
        //    this.sPassWord = sPassWord;
        //    this.sTenLoai = sTenLoai;
        //}
    }
}
