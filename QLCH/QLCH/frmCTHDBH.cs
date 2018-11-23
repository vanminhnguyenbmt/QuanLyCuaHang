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

namespace QLCH
{
    public partial class frmCTHDBH : Form
    {
        static AutoCompleteStringCollection DataCollectionTenKH = new AutoCompleteStringCollection();
        static AutoCompleteStringCollection DataCollectionTenNV = new AutoCompleteStringCollection();

        public frmCTHDBH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCTHDBH_Load(object sender, EventArgs e)
        {
            //Load du lieu
            DataTable tblHDBANHANG = new DataTable();
            tblHDBANHANG = CTHDBH_BUS.HDBANHANG_Load();
            LoadDuLieu(tblHDBANHANG);

            //Rename
            dgvHDBH.Columns["MAHDBH"].HeaderText = "Mã HD";
            dgvHDBH.Columns["TENNV"].HeaderText = "Nhân viên bán hàng";
            dgvHDBH.Columns["TENKH"].HeaderText = "Khách hàng";
            dgvHDBH.Columns["NGAYBH"].HeaderText = "Ngày bán";
            dgvHDBH.Columns["THANHTIEN"].HeaderText = "Tổng tiền";

            //Set width
            dgvHDBH.Columns["TENNV"].Width = 140;
            dgvHDBH.Columns["MAHDBH"].Width = 70;
            dgvHDBH.Columns["TENKH"].Width = 120;
            dgvHDBH.Columns["NGAYBH"].Width = 80;
            dgvHDBH.Columns["THANHTIEN"].Width = 80;
            dgvHDBH.RowHeadersVisible = false;

            //Tạo suggest tên
            txtTenNV.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenNV.AutoCompleteSource = AutoCompleteSource.CustomSource;
            getDataNV(DataCollectionTenNV);
            txtTenNV.AutoCompleteCustomSource = DataCollectionTenNV;

            txtTenKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            getDataTenKH(DataCollectionTenKH);
            txtTenKH.AutoCompleteCustomSource = DataCollectionTenKH;

        }

        private void LoadDuLieu(DataTable tbl)
        {
            dgvHDBH.DataSource = tbl;
        }

        private void getDataNV(AutoCompleteStringCollection dataCollection)
        {
            try
            {
                DataTable tblTenNV = Nhanvien_BUS.LoadTenNV();
                int i = 0;
                foreach (DataRow dr in tblTenNV.Rows)
                {
                    dataCollection.Add(dr["TENNV"].ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void getDataTenKH(AutoCompleteStringCollection dataCollection)
        {
            try
            {
                DataTable tblTenKH = Khachhang_BUS.Khachhang_LoadMaTen();
                int i = 0;
                foreach (DataRow dr in tblTenKH.Rows)
                {
                    dataCollection.Add(dr["TENKH"].ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            if (txtTenKH.Text == "" && txtTenNV.Text == "")
                MessageBox.Show("Mời bạn nhập nội dung cần tìm kiếm", "Thông báo");
            else
                if (txtTenKH.Text != "" && txtTenNV.Text != "")
                    MessageBox.Show("Bạn chỉ được nhập 1 trong 2 thông tin", "Thông báo");
                else
                    if (txtTenKH.Text != "" && txtTenNV.Text == "")
                    {
                        tbl = CTHDBH_BUS.HDBANHANG_LoadKH(LoadMaKH());
                        LoadDuLieu(tbl);
                    }
                    else
                    {
                        tbl = CTHDBH_BUS.HDBANHANG_LoadNV(LoadMaNV());
                        LoadDuLieu(tbl);
                    }
        }

        private string LoadMaNV()
        {
            DataTable tblTenNV = Nhanvien_BUS.LoadTenNV();
            int j = 0;
            foreach (DataRow dr in tblTenNV.Rows)
            {
                if (txtTenNV.Text == dr["TENNV"].ToString())
                    return dr["MANV"].ToString();
                else
                    j++;
            }
            return "";
        }

        private string LoadMaKH()
        {
            DataTable tblTenKH = Khachhang_BUS.Khachhang_LoadMaTen();
            int j = 0;
            foreach (DataRow dr in tblTenKH.Rows)
            {
                if (txtTenKH.Text == dr["TENKH"].ToString())
                    return dr["MAKH"].ToString();
                else
                    j++;
            }
            return "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvHDBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDgvCTHDBH();  
        }

        private void LoadDgvCTHDBH()
        {
            DataGridViewRow dr = dgvHDBH.SelectedRows[0];
            DataTable tbl = new DataTable();
            tbl = CTHDBH_BUS.CTHDBANHANG_Load(dr.Cells["MAHDBH"].Value.ToString());
            dgvCTHDBH.DataSource = tbl;

            //Rename
            dgvCTHDBH.Columns["TENSP"].HeaderText = "Tên sản phẩm";
            dgvCTHDBH.Columns["MASP"].Visible = false;
            dgvCTHDBH.Columns["SOLUONG"].HeaderText = "Số lượng";
            dgvCTHDBH.Columns["MACTHDBH"].HeaderText = "Mã CTHD";

            //Set width
            dgvCTHDBH.Columns["TENSP"].Width = 240;
            dgvCTHDBH.Columns["SOLUONG"].Width = 40;
            dgvCTHDBH.Columns["MACTHDBH"].Width = 50;
            dgvCTHDBH.RowHeadersVisible = false;
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLoadDL_Click(object sender, EventArgs e)
        {
            //Load du lieu
            DataTable tblHDBANHANG = new DataTable();
            tblHDBANHANG = CTHDBH_BUS.HDBANHANG_Load();
            LoadDuLieu(tblHDBANHANG);
            txtTenKH.ResetText();
            txtTenNV.ResetText();
            dgvCTHDBH.DataSource = "";
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            
            DateTime dtStart = new DateTime();
            DateTime dtEnd = new DateTime();
            dtStart = dtpStart.Value.Date;
            dtEnd = dtpEnd.Value.Date;
            if (dtStart > dtEnd)
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc","Thông báo");
            else
            {
                DataTable tbl = new DataTable();
                tbl = CTHDBH_BUS.HDBANHANG_Loc(dtStart, dtEnd);
                dgvHDBH.DataSource = tbl;
            }
        }
    }
}
