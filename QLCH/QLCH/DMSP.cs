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
using System.Data;


namespace QLCH
{
    public partial class DMSP : Form
    {
        public DMSP()
        {
            InitializeComponent();
        }

        private void DMSP_Load(object sender, EventArgs e)
        {
            LoadDgvSanPham();
            DataTable dt1 = new DataTable();
            DataTable listCombox = Sanpham_BUS.GetTableLSP();
            cblsp.DisplayMember = "TENLOAI";//Word là tên trường bạn muốn hiển thị trong combobox
            cblsp.ValueMember = "MALOAI";
            cblsp.DataSource = listCombox;
        }
        private void LoadDgvSanPham()
        {
            List<Sanpham_DTO> lstSanpham = Sanpham_BUS.LoadSanpham();

            dgvdanhmucsp.DataSource = lstSanpham;
        }

        private void bntimkiem_Click(object sender, EventArgs e)
        {
            string sTukhoa = txttukhoa.Text;
            List<Sanpham_DTO> lstkqsp = Sanpham_BUS.Timkiemsp(sTukhoa);
            if(lstkqsp.Count == 0)
            {
                MessageBox.Show("Khong co san pham can tim!");

            }
            else
                dgvdanhmucsp.DataSource = lstkqsp;

        }

        private void btlsp_Click(object sender, EventArgs e)
        {
            string sTukhoa = cblsp.SelectedValue.ToString();
            List<Sanpham_DTO> lstkqsp = Sanpham_BUS.Locsp(sTukhoa);
            if (lstkqsp.Count == 0)
            {
                MessageBox.Show("Khong co san pham can tim!");

            }
            else
                dgvdanhmucsp.DataSource = lstkqsp;
        }

        private void btlsptinhtrang_Click(object sender, EventArgs e)
        {
            string sTukhoa = cblsptinhtrang.Text;
            MessageBox.Show(sTukhoa);
            List<Sanpham_DTO> lstkqsp = Sanpham_BUS.Locsptt(sTukhoa);
            try
            {
               
                    dgvdanhmucsp.DataSource = lstkqsp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong co san pham can tim!");
            }
            
        }
    }
}
