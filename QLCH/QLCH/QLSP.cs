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
using System.Data.SqlClient;
using System.Data;

namespace QLCH
{
    public partial class QLSP : Form
    {
        public QLSP()
        {
            
            InitializeComponent();
        }

        private void QLSP_Load(object sender, EventArgs e)
        {
            LoadDgvSanPham();
            try
            {
                Sanpham_BUS x = new Sanpham_BUS();
                txtmasp.Text = x.XuLyMaSP();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            cbtrangthai.SelectedIndex = 0;
         
            DataTable dt = new DataTable();
            DataTable listCombox = Sanpham_BUS.GetTableLSP();
            cbmaloai.DisplayMember = "TENLOAI";//Word là tên trường bạn muốn hiển thị trong combobox
            cbmaloai.ValueMember = "MALOAI";
            cbmaloai.DataSource = listCombox;

            DataTable dt2 = new DataTable();
            DataTable listCombox2 = Sanpham_BUS.GetNCC();
            cbmancc.DisplayMember = "TENNCC";//Word là tên trường bạn muốn hiển thị trong combobox
            cbmancc.ValueMember = "MANCC";
            cbmancc.DataSource = listCombox2;

        }
        private void LoadDgvSanPham()
        {
            List<Sanpham_DTO> lstSanpham = Sanpham_BUS.LoadSanpham();
            
            dgvdmsp.DataSource   = lstSanpham;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Sanpham_DTO spDTO = new Sanpham_DTO();
            spDTO.STenSP = txttensp.Text;
            spDTO.SSoLuong =int.Parse(txtsoluong.Text);
            spDTO.SDonGia = int.Parse(txtdongia.Text);
            spDTO.STGBH = int.Parse(cbtgbh.Text);
            spDTO.STrangThai = cbtrangthai.Text;
            spDTO.SMaSP = txtmasp.Text;
            spDTO.SMaLoai = cbmaloai.SelectedValue.ToString();
            spDTO.SMaNCC = cbmancc.SelectedValue.ToString();
            if(Sanpham_BUS.Themsp(spDTO) == true )
            {
                MessageBox.Show("Them thanh cong");
                LoadDgvSanPham();
                
            }
            else
            MessageBox.Show("Them that bai!");

            

        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Sanpham_DTO spDTO = new Sanpham_DTO();
            spDTO.SMaSP = txtmasp.Text;
            spDTO.STenSP = txttensp.Text;
            spDTO.SSoLuong = int.Parse(txtsoluong.Text);
            spDTO.SDonGia = int.Parse(txtdongia.Text);
            spDTO.STGBH = int.Parse(cbtgbh.Text);
            spDTO.STrangThai = cbtrangthai.Text;
            spDTO.SMaSP = txtmasp.Text;
            spDTO.SMaLoai = cbmaloai.SelectedValue.ToString();
            spDTO.SMaNCC = cbmancc.SelectedValue.ToString();
            if (Sanpham_BUS.Suasp(spDTO) == true)
            {
                MessageBox.Show("Sua thanh cong");
                LoadDgvSanPham();

            }
            else
                MessageBox.Show("Sua that bai!");
        }

        private void dgvdmsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvdmsp.SelectedRows[0];

            txtmasp.Text = dr.Cells["SMaSP"].Value.ToString();
            txttensp.Text = dr.Cells["STenSP"].Value.ToString();
            cbtgbh.Text = dr.Cells["STGBH"].Value.ToString();
            txtsoluong.Text = dr.Cells["SSoLuong"].Value.ToString();
            cbtrangthai.Text = dr.Cells["STrangThai"].Value.ToString();
            txtdongia.Text = dr.Cells["SDonGia"].Value.ToString();
            cbmaloai.SelectedValue = dr.Cells["SMaLoai"].Value.ToString();
            cbmancc.SelectedValue = dr.Cells["SMaNCC"].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Sanpham_DTO spDTO = new Sanpham_DTO();
            spDTO.SMaSP = txtmasp.Text;
            if (Sanpham_BUS.Xoasp(spDTO) == true)
            {
                MessageBox.Show("Xoa thanh cong");
                LoadDgvSanPham();

            }
            else
                MessageBox.Show("Xoa that bai!");
        }

      

        
        
    }
}
