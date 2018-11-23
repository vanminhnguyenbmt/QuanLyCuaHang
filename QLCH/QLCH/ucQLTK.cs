using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLCH
{
    public partial class ucQLTK : UserControl
    {
        public ucQLTK()
        {
            InitializeComponent();
        }

        static int StateButton = 0;

        private void DgvLoad_TKNhanVien_NhanVien()
        {
            DataTable tblTKNV = PhanQuyen_BUS.TKNhanVien_Load();
            dgvNhanVien.DataSource = tblTKNV;
            //rename
            dgvNhanVien.Columns["MATK"].HeaderText = "Mã tài khoản";
            dgvNhanVien.Columns["MANV"].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns["TENNV"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["TENDANGNHAP"].HeaderText = "Tên đăng nhập";
            dgvNhanVien.Columns["MATKHAU"].HeaderText = "Mật khẩu";
            dgvNhanVien.Columns["TENLOAI"].HeaderText = "Tên loại";  
        }

        private void LayTTTK(TaikhoanNV_DTO TK)
        {
            TK.SMaNV = txtMaNV.Text;
            TK.SMaTK = txtMaTK.Text;
            TK.STenDangNhap = txtUserName.Text;
            TK.SMatKhau = txtPassWord.Text;
        }

        private string TuDongTangMaTK()
        {
            DataTable tblNhanvien = PhanQuyen_BUS.TKNhanVien_Top1();
            int DongCuoi = tblNhanvien.Rows.Count - 1;
            string sMaTK = tblNhanvien.Rows[DongCuoi][0].ToString();
            String sTemp1, sTerm2;
            sTemp1 = sMaTK.Substring(0, 2);
            sTerm2 = sMaTK.Substring(2, 3);
            sTerm2 = (int.Parse(sTerm2.ToString()) + 1).ToString();
            if (sTerm2.Length < 3)
            {
                int a = sTerm2.Length;
                for (int i = 0; i < 3 - a; i++)
                    sTerm2 = "0" + sTerm2;
            }
            sMaTK = sTemp1 + sTerm2;
            return sMaTK;
        }

        private void ThemTK(object sender, EventArgs e)
        {
            TaikhoanNV_DTO TK = new TaikhoanNV_DTO();
            txtMaTK.Text = TuDongTangMaTK();
            if (txtUserName.Text == "" || txtPassWord.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                LayTTTK(TK);
                try
                {
                    PhanQuyen_BUS.ThemTK(TK);
                    ucQLTK_Load(sender, e);
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void CapNhapTK(object sender, EventArgs e)
        {
            TaikhoanNV_DTO TK = new TaikhoanNV_DTO();
            DialogResult Lenh = MessageBox.Show("Xác nhận thay đổi!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Lenh == DialogResult.Yes)
            {
                if (txtUserName.Text == "" || txtPassWord.Text == "")
                {
                    MessageBox.Show("Mời bạn nhập đầy đủ thông tin!", "Thông báo");
                }
                else
                {
                    LayTTTK(TK);
                    try
                    {
                        PhanQuyen_BUS.CapNhapTK(TK);
                        ucQLTK_Load(sender, e);
                        Reset();
                        btnCapNhapTK.Enabled = false;
                        btnXoaTK.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        private void XoaTK(object sender, EventArgs e)
        {
            DialogResult Lenh = MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Lenh == DialogResult.Yes)
            {
                PhanQuyen_BUS.XoaTK(txtMaTK.Text);
                ucQLTK_Load(sender, e);
                Reset();
                btnCapNhapTK.Enabled = false;
                btnXoaTK.Enabled = false;
            }
        }
        private void Reset()
        {
            txtMaTK.ResetText();
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtUserName.ResetText();
            txtPassWord.ResetText();
        }

        private void ChangeState(bool bState)
        {
            txtMaTK.Enabled = false;
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtUserName.Enabled = bState;
            txtPassWord.Enabled = bState;
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            StateButton = 1;
            ChangeState(true);
            btnCapNhapTK.Enabled = false;
            btnXoaTK.Enabled = false;
            btnLuuTK.Enabled = true;
        }


        private void ucQLTK_Load(object sender, EventArgs e)
        {
            DgvLoad_TKNhanVien_NhanVien();
            ChangeState(false);
            btnCapNhapTK.Enabled = false;
            btnXoaTK.Enabled = false;
            btnLuuTK.Enabled = false;
        }

        private void btnLuuTK_Click(object sender, EventArgs e)
        {
            switch(StateButton)
            {
                case 1:
                    ThemTK(sender, e);
                    break;
                case 2:
                    CapNhapTK(sender, e);
                    break;
            }
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            btnThemTK.Enabled = true;
            btnCapNhapTK.Enabled = true;
            btnXoaTK.Enabled = true;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvNhanVien.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if(cell != null)
            {
                DataGridViewRow dgv = cell.OwningRow;
                txtMaTK.Text = dgv.Cells["MATK"].Value.ToString();
                txtMaNV.Text = dgv.Cells["MANV"].Value.ToString();
                txtTenNV.Text = dgv.Cells["TENNV"].Value.ToString();
                txtUserName.Text = dgv.Cells["TENDANGNHAP"].Value.ToString();
                txtPassWord.Text = dgv.Cells["MATKHAU"].Value.ToString();
            }       
            ChangeState(false);
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            XoaTK(sender, e);
        }

        private void btnCapNhapTK_Click(object sender, EventArgs e)
        {
            StateButton = 2;
            ChangeState(true);
            btnThemTK.Enabled = false;
            btnCapNhapTK.Enabled = false;
            btnXoaTK.Enabled = false;
            btnLuuTK.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
