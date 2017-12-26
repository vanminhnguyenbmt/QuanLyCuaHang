using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data;

namespace QLCH
{
    public partial class frmDMNV : Form
    {
        public frmDMNV()
        {
            InitializeComponent();
            LoadDgvLocNV();
        }

        private void LoadDgvLocNV()
        {
            DataTable tblNhanvien = Nhanvien_BUS.LoadNhanvien();
            dgvLocNV.DataSource = tblNhanvien;
            //rename
            dgvLocNV.Columns["MANV"].HeaderText = "Mã nhân viên";
            dgvLocNV.Columns["TENNV"].HeaderText = "Tên nhân viên";
            dgvLocNV.Columns["NGSINH"].HeaderText = "Ngày sinh";
            dgvLocNV.Columns["GIOITINH"].HeaderText = "Giới tính";
            dgvLocNV.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgvLocNV.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvLocNV.Columns["TENLOAI"].HeaderText = "Chức vụ";
            dgvLocNV.Columns["MALOAI"].Visible = false;
            //set width
            dgvLocNV.Columns["GIOITINH"].Width = 70;
            dgvLocNV.Columns["TENNV"].Width = 150;
            dgvLocNV.Columns["NGSINH"].Width = 80;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvLocNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDanhsach_Click(object sender, EventArgs e)
        {
            LoadDgvLocNV();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            TimkiemNV();
        }

        private void TimkiemNV()
        {
            if (txtTimkiem.Text == "")
            {
                MessageBox.Show("Mời bạn nhập nội dung tìm kiếm", "Thông báo");
            }
            else
            {
                DataTable tblNhanvien = Nhanvien_BUS.TimkiemNV(txtTimkiem.Text);
                dgvLocNV.DataSource = tblNhanvien;
                //rename
                dgvLocNV.Columns["MANV"].HeaderText = "Mã nhân viên";
                dgvLocNV.Columns["TENNV"].HeaderText = "Tên nhân viên";
                dgvLocNV.Columns["NGSINH"].HeaderText = "Ngày sinh";
                dgvLocNV.Columns["GIOITINH"].HeaderText = "Giới tính";
                dgvLocNV.Columns["DIACHI"].HeaderText = "Địa chỉ";
                dgvLocNV.Columns["SDT"].HeaderText = "Số điện thoại";
                dgvLocNV.Columns["TENLOAI"].HeaderText = "Chức vụ";
                dgvLocNV.Columns["MALOAI"].Visible = false;
                //set width
                dgvLocNV.Columns["GIOITINH"].Width = 70;
                dgvLocNV.Columns["TENNV"].Width = 150;
                dgvLocNV.Columns["NGSINH"].Width = 80;
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                LoadDgvLocNV();
            }
            else
            {
                DataTable tblNhanvien = Nhanvien_BUS.TimkiemNV(txtTimkiem.Text);
                dgvLocNV.DataSource = tblNhanvien;
                //rename
                dgvLocNV.Columns["MANV"].HeaderText = "Mã nhân viên";
                dgvLocNV.Columns["TENNV"].HeaderText = "Tên nhân viên";
                dgvLocNV.Columns["NGSINH"].HeaderText = "Ngày sinh";
                dgvLocNV.Columns["GIOITINH"].HeaderText = "Giới tính";
                dgvLocNV.Columns["DIACHI"].HeaderText = "Địa chỉ";
                dgvLocNV.Columns["SDT"].HeaderText = "Số điện thoại";
                dgvLocNV.Columns["TENLOAI"].HeaderText = "Chức vụ";
                dgvLocNV.Columns["MALOAI"].Visible = false;
                //set width
                dgvLocNV.Columns["GIOITINH"].Width = 70;
                dgvLocNV.Columns["TENNV"].Width = 150;
                dgvLocNV.Columns["NGSINH"].Width = 80;
            }
        }
    }
}
