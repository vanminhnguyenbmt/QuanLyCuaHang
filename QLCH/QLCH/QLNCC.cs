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
    public partial class QLNCC : Form
    {
        public QLNCC()
        {
            InitializeComponent();
        }

        private void QLNCC_Load(object sender, EventArgs e)
        {
            txttenncc.Enabled = false;
            txtdiachi.Enabled = false;
            txtsdt.Enabled = false;
            txtmancc.Enabled = false;
            LoadDgvNhacungcap();
            try
            {
                Nhacungcap_BUS x = new Nhacungcap_BUS();
                txtmancc.Text = x.XuLyMaNCC();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadDgvNhacungcap()
        {
            List<Nhacungcap_DTO> lstncc = Nhacungcap_BUS.LoadNhacungcap();

            dgvncc.DataSource = lstncc;

            dgvncc.Columns["SMancc"].HeaderText = "Mã NCC";
            dgvncc.Columns["STencc"].HeaderText = "Tên NCC";
            dgvncc.Columns["SSodienthoaincc"].HeaderText = "SĐT";
            dgvncc.Columns["SDiachincc"].HeaderText = "Địa chỉ";


            dgvncc.Columns["SMancc"].Width = 50;
            dgvncc.Columns["SDiachincc"].Width = 300;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public bool IsNumber(string kytu)
        {
            foreach (Char c in kytu)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            
            if (txttenncc.Text == "" || txtsdt.Text == "" || txtdiachi.Text == ""|| IsNumber(txtsdt.Text) == false)
                MessageBox.Show("Thông tin chưa đầy đủ hoặc sai định dạng, vui lòng kiểm tra lại!");
            else   
            {

                Nhacungcap_DTO nccDTO = new Nhacungcap_DTO();
                nccDTO.SMancc = txtmancc.Text;
                nccDTO.STencc = txttenncc.Text;
                nccDTO.SSodienthoaincc = txtsdt.Text;
                nccDTO.SDiachincc = txtdiachi.Text;

                if (Nhacungcap_BUS.Themncc(nccDTO) == true)
                {
                    MessageBox.Show("Lưu thành công");
                    LoadDgvNhacungcap();

                }
                else
                    MessageBox.Show("Thất bại!");
            }
        }

        //private void dgvncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewRow dr1 = dgvncc.SelectedRows[0];

        //    txtmancc.Text = dr1.Cells["SMancc"].Value.ToString();
        //    txttenncc.Text = dr1.Cells["STencc"].Value.ToString();
        //    txtsdt.Text = dr1.Cells["SSodienthoaincc"].Value.ToString();
        //    txtdiachi.Text = dr1.Cells["SDiachincc"].Value.ToString();

        //}

        private void dtsua_Click(object sender, EventArgs e)
        {
            

            Nhacungcap_DTO nccDTO = new Nhacungcap_DTO();
            nccDTO.SMancc = txtmancc.Text;
            nccDTO.STencc = txttenncc.Text;
            nccDTO.SSodienthoaincc = txtsdt.Text;
            nccDTO.SDiachincc = txtdiachi.Text;

            if (Nhacungcap_BUS.Suancc(nccDTO) == true)
            {
                MessageBox.Show("Cập nhật thành công");
                LoadDgvNhacungcap();

            }
            else
                MessageBox.Show("Thất bại!");
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            Nhacungcap_DTO nccDTO = new Nhacungcap_DTO();
            nccDTO.SMancc = txtmancc.Text;
            if (Nhacungcap_BUS.Xoancc(nccDTO) == true)
            {
                MessageBox.Show("Đã xóa");
                LoadDgvNhacungcap();

            }
            else
                MessageBox.Show("Thất bại!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr1 = dgvncc.SelectedRows[0];

            txtmancc.Text = dr1.Cells["SMancc"].Value.ToString();
            txttenncc.Text = dr1.Cells["STencc"].Value.ToString();
            txtsdt.Text = dr1.Cells["SSodienthoaincc"].Value.ToString();
            txtdiachi.Text = dr1.Cells["SDiachincc"].Value.ToString();

            btsua.Enabled = true;
            txttenncc.Enabled = true;
            txtsdt.Enabled = true;
            txtdiachi.Enabled = true;
        }

        private void btthem_Click_1(object sender, EventArgs e)
        {
            btsua.Enabled = false;
            txttenncc.Enabled = true;
            txtdiachi.Enabled = true;
            txtsdt.Enabled = true;

            txttenncc.ResetText();
            txtsdt.ResetText();
            txtdiachi.ResetText();
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
