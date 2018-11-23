using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLCH
{
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();
        }

        static int StateButton = 0;

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            // load du lieu datagridview
            LoadDgvNhanvien();
            LoadCbbLoaiNV();
            LoadCbbGioitinh();
            ChangeState(false);
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LoadDgvNhanvien()
        {
            DataTable tblNhanvien = Nhanvien_BUS.LoadNhanvien();
            dgvLoadNV.DataSource = tblNhanvien;
            //rename
            dgvLoadNV.Columns["MANV"].HeaderText = "Mã nhân viên";
            dgvLoadNV.Columns["TENNV"].HeaderText = "Tên nhân viên";
            dgvLoadNV.Columns["NGSINH"].HeaderText = "Ngày sinh";
            dgvLoadNV.Columns["GIOITINH"].HeaderText = "Giới tính";
            dgvLoadNV.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgvLoadNV.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvLoadNV.Columns["TENLOAI"].HeaderText = "Chức vụ";
            dgvLoadNV.Columns["MALOAI"].Visible = false;
            //set width
            dgvLoadNV.Columns["GIOITINH"].Width = 70;
            dgvLoadNV.Columns["TENNV"].Width = 150;
            dgvLoadNV.Columns["NGSINH"].Width = 80;

        }

        private void LoadCbbLoaiNV()
        {
            DataTable tblLoaiNV = Nhanvien_BUS.LoadLoaiNV();
            cbbChucvu.DataSource = tblLoaiNV;
            cbbChucvu.DisplayMember = "TENLOAI";
            cbbChucvu.ValueMember = "MALOAI";
        }

        private void LoadCbbGioitinh()
        {
            cbbGioitinh.Items.Add("NAM");
            cbbGioitinh.Items.Add("NỮ");
            cbbGioitinh.SelectedIndex = 0;
        }

        private void dgvLoadNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StateButton = 1;
            ChangeState(true);
            Reset();
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void cbbChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private bool KiemTraSDT(string SDT)
        {
            for (int i = 0; i < SDT.Length ; i++ )
            {
                if (SDT[i] < 48 || SDT[i] > 57)
                    return false;
            }
                return true;
        }

        private string TuDongTangMaNV()
        {
            DataTable tblNhanvien = Nhanvien_BUS.LoadNhanvien();
            int DongCuoi = tblNhanvien.Rows.Count - 1;
            string sMaNV = tblNhanvien.Rows[DongCuoi][0].ToString();
            String sTemp1, sTerm2;
            sTemp1 = sMaNV.Substring(0, 2);
            sTerm2 = sMaNV.Substring(2, 3);
            sTerm2 = (int.Parse(sTerm2.ToString()) + 1).ToString();
            if(sTerm2.Length <3)
            {
                int a = sTerm2.Length;
                for (int i = 0; i < 3 - a; i++)
                    sTerm2 = "0" + sTerm2;
            }
            sMaNV = sTemp1 + sTerm2;
            return sMaNV;
        }

        private void txtMaNV_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaNV();
        }

        private void dgvLoadNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLoadNV_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            DataGridViewRow dr = dgvLoadNV.SelectedRows[0];
            txtMaNV.Text = dr.Cells["MANV"].Value.ToString();
            txtHoten.Text = dr.Cells["TENNV"].Value.ToString();
            txtSDT.Text = dr.Cells["SDT"].Value.ToString();
            txtDiachi.Text = dr.Cells["DIACHI"].Value.ToString();
            if (dr.Cells["GIOITINH"].Value.ToString() == "NAM")
                cbbGioitinh.SelectedIndex = 0;
            else
                cbbGioitinh.SelectedIndex = 1;
            cbbChucvu.SelectedValue = dr.Cells["MALOAI"].Value.ToString();
            dtpNgaysinh.Text = dr.Cells["NGSINH"].Value.ToString();
            ChangeState(false);
            btnLuu.Enabled = false;
        }

        private void Reset()
        {
            txtMaNV.ResetText();
            txtHoten.ResetText();
            txtDiachi.ResetText();
            txtSDT.ResetText();
            dtpNgaysinh.ResetText();
            cbbChucvu.SelectedIndex = 0;
            cbbGioitinh.SelectedIndex = 0;
        }

        private void ChangeState(bool bState)
        {
            txtHoten.Enabled = bState;
            txtDiachi.Enabled = bState;
            txtSDT.Enabled = bState;
            dtpNgaysinh.Enabled = bState;
            cbbGioitinh.Enabled = bState;
            cbbChucvu.Enabled = bState;
        }

        private void grbxThongtin_Enter(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            StateButton = 2;
            ChangeState(true);
            btnLuu.Enabled = true;
        }

        private void LayTTNV(Nhanvien_DTO NV)
        {
            NV.SMaNV = txtMaNV.Text;
            NV.STenNV = txtHoten.Text;
            NV.SGioitinh = "";
            if (cbbGioitinh.SelectedIndex == 0)
            {
                NV.SGioitinh = "NAM";
            }
            else
                NV.SGioitinh = "NỮ";
            NV.SDiachi = txtDiachi.Text;
            NV.SSDT = txtSDT.Text;
            NV.SMaLoai = cbbChucvu.SelectedValue.ToString();
            NV.DTNgaysinh = dtpNgaysinh.Value.Date;
        }

        private void ThemNV()
        {
            Nhanvien_DTO NV = new Nhanvien_DTO();
            txtMaNV.Text = TuDongTangMaNV();
            LayTTNV(NV);
            if (txtHoten.Text == "" || txtDiachi.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                if (DateTime.Now.Year - dtpNgaysinh.Value.Year <= 18)
                    MessageBox.Show("Nhân viên không đủ tuổi.");
                else
                {
                    if (KiemTraSDT(txtSDT.Text) == false)
                        MessageBox.Show("Số điện thoại không được chứa kí tự.");
                    else
                    {
                        try
                        {
                            Nhanvien_BUS.ThemNV(NV);
                            ChangeState(false);
                            LoadDgvNhanvien();
                            Reset();
                            btnLuu.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }

        private void CapNhatNV()
        {
            Nhanvien_DTO NV = new Nhanvien_DTO();
            DialogResult Lenh = MessageBox.Show("Bạn chắc chắn muốn cập nhật thông tin nhân viên nhân viên!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Lenh == DialogResult.Yes)
            {
                if (txtHoten.Text == "" || txtDiachi.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Mời bạn nhập đầy đủ thông tin!", "Thông báo");
                }
                else
                {
                    LayTTNV(NV);
                    if (DateTime.Now.Year - dtpNgaysinh.Value.Year <= 18)
                        MessageBox.Show("Nhân viên không đủ tuổi.");
                    else
                    {
                        if (KiemTraSDT(txtSDT.Text) == false)
                            MessageBox.Show("Số điện thoại không được chứa kí tự.");
                        else
                        {
                            try
                            {
                                Nhanvien_BUS.CapNhatNV(NV);
                                ChangeState(false);
                                LoadDgvNhanvien();
                                Reset();
                                btnCapNhat.Enabled = false;
                                btnXoa.Enabled = false;
                                btnLuu.Enabled = false;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }
            }
        }

        private void XoaNV()
        {
            DialogResult Lenh = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Lenh == DialogResult.Yes)
            {
                Nhanvien_BUS.XoaNV(txtMaNV.Text);
                Nhanvien_BUS.XoaTKNV(txtMaNV.Text);
                ChangeState(false);
                LoadDgvNhanvien();
                Reset();
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (StateButton)
            {
                case 1:
                    ThemNV();
                    break;
                case 2:
                    CapNhatNV();
                    break;
            }
        }

        private void cbbChucvu_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
