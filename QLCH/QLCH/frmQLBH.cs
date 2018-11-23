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
using DTO;


namespace QLCH
{
    public partial class frmQLBH : Form
    {
        static int StateButton;
        static AutoCompleteStringCollection DataCollectionTen = new AutoCompleteStringCollection();
        static AutoCompleteStringCollection DataCollectionMa = new AutoCompleteStringCollection();
        static AutoCompleteStringCollection DataCollectionTenKH = new AutoCompleteStringCollection();
        static AutoCompleteStringCollection DataCollectionMaKH = new AutoCompleteStringCollection();
        static AutoCompleteStringCollection DataCollectionTenSP = new AutoCompleteStringCollection();
        static AutoCompleteStringCollection DataCollectionMaSP = new AutoCompleteStringCollection();
        static int sSL;
        static string sMaCTHDBH;
        
        public frmQLBH()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            StateButton = 2;
            ChangeState(true);
        }

        private void frmQLBH_Load(object sender, EventArgs e)
        {
            txtTenNV.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenNV.AutoCompleteSource = AutoCompleteSource.CustomSource;
            getData(DataCollectionTen);
            txtTenNV.AutoCompleteCustomSource = DataCollectionTen;

            txtTenKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            getDataTenKH(DataCollectionTenKH);
            txtTenKH.AutoCompleteCustomSource = DataCollectionTenKH;
            
            ChangeState(false);
            DataTable tblSP = HoadonBan_BUS.Sanpham_Load();
            LoadCbbTenSP(tblSP);
            cbbTenSP.SelectedIndex = -1;
            txtMaSP.Text = "";
            btnLuuHD.Enabled = false;
            txtSL.Enabled = false;

        }

        private void LoadCbbTenSP(DataTable tbl)
        {
            cbbTenSP.DataSource = tbl;
            cbbTenSP.DisplayMember = "TENSP";
            cbbTenSP.ValueMember = "MASP";
        }

        private void getDataSP(AutoCompleteStringCollection dataCollection)
        {
            try
            {
                DataTable tblSP = HoadonBan_BUS.Sanpham_LoadSearch(cbbTenSP.SelectedText);
                int i = 0;
                foreach (DataRow dr in tblSP.Rows)
                {
                    dataCollection.Add(dr["TENSP"].ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        public string GetMaHDBH()
        {
            return txtMaHD.Text;
        }

        private void getData(AutoCompleteStringCollection dataCollection)
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

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
        }

        private void LoadMaNV()
        {
            try
            {
                if (txtTenNV.Text != "")
                {
                    try
                    {
                        DataTable tblTenNV = Nhanvien_BUS.LoadTenNV();
                        int j = 0;
                        foreach (DataRow dr in tblTenNV.Rows)
                        {
                            if(txtTenNV.Text == dr["TENNV"].ToString())
                            {
                                txtMaNV.Text = dr["MANV"].ToString();
                                return;
                            }
                            else
                                j++;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection ! ");
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void LoadMaKH()
        {
            try
            {
                if (txtTenKH.Text != "")
                {
                    try
                    {
                        DataTable tblTenKH = Khachhang_BUS.Khachhang_LoadMaTen();
                        int j = 0;
                        foreach (DataRow dr in tblTenKH.Rows)
                        {
                            if (txtTenKH.Text == dr["TENKH"].ToString())
                            {
                                txtMaKH.Text = dr["MAKH"].ToString();
                                return;
                            }
                            else
                                j++;
                        }
                        txtMaKH.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection ! ");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void txtTenNV_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtTenNV_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void txtTenKH_MouseClick(object sender, MouseEventArgs e)
        {
            LoadMaNV();
        }

        private void LoadThongtinKH()
        {
            DataTable tblThongtin = Khachhang_BUS.Khachhang_LoadThongtinKH(txtMaKH.Text);
            txtDiachi.Text = tblThongtin.Rows[0][0].ToString();
            txtSDT.Text = tblThongtin.Rows[0][1].ToString();
        }

        private void ChangeState(bool bState)
        {
            txtTenNV.Enabled = bState;
            txtTenKH.Enabled = bState;
            txtDiachi.Enabled = bState;
            txtSDT.Enabled = bState;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            StateButton = 1;
            ChangeState(true);
            Reset();
            DataTable tblHoadon = HoadonBan_BUS.LoadTop1HDB();
            txtMaHD.Text = TuDongTangMaNV(tblHoadon);
            //DataTable tblKhachhang = Khachhang_BUS.Khachhang_LoadTop1();
            //txtMaKH.Text = TuDongTangMaNV(tblKhachhang);
            btnLuuHD.Enabled = true;
        }
        private void Reset()
        {
            txtTenNV.ResetText();
            dtpNgayban.ResetText();
            txtTenKH.ResetText();
            txtDiachi.ResetText();
            txtSDT.ResetText();
            txtMaHD.ResetText();
            txtMaNV.ResetText();
            txtMaKH.ResetText();
        }
        private void ResetSP()
        {
            txtMaSP.ResetText();
            cbbTenSP.SelectedIndex = -1;
            txtDongia.ResetText();
            txtSL.ResetText();
        }

        private bool KiemTraSDT(string SDT)
        {
            for (int i = 0; i < SDT.Length; i++)
            {
                if (SDT[i] < 48 || SDT[i] > 57)
                    return false;
            }
            return true;
        }

        private void LayTTKH(Khachhang_DTO KH)
        {
            KH.SMaKH = txtMaKH.Text;
            KH.STenKH = txtTenKH.Text;
            KH.SSDT = txtSDT.Text;
            KH.SDiachi = txtDiachi.Text;
        }

        private void LayTTHDBH(Hoadonban_DTO HDBH)
        {
            HDBH.SMaHDB = txtMaHD.Text;
            HDBH.SMaKH = txtMaKH.Text;
            HDBH.SMaNV = txtMaNV.Text;
            HDBH.DtNgayBH = dtpNgayban.Value.Date;
            HDBH.LThanhtien = 0;
        }

        private void LayTTCTHDBH(CTHDBanhang_DTO CTHDBH)
        {
            DataTable tbl = HoadonBan_BUS.CTHDBH_LoadTop1();
            CTHDBH.SMaCTHDB = TuDongTangMaNV(tbl);
            CTHDBH.SMaHDB = txtMaHD.Text;
            CTHDBH.SMaSP = cbbTenSP.SelectedValue.ToString();
            CTHDBH.ISoLuong = int.Parse(txtSL.Text);
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            btnThemHD.Enabled = false;
            Khachhang_DTO KH = new Khachhang_DTO();
            Hoadonban_DTO HDBH = new Hoadonban_DTO();
            if(StateButton == 1)
            {
                if (txtMaKH.Text == "")
                {
                    DataTable tblHoadon = Khachhang_BUS.Khachhang_LoadTop1();
                    txtMaKH.Text = TuDongTangMaNV(tblHoadon);
                    if (txtTenNV.Text == "" || txtTenKH.Text == "" || txtMaNV.Text == "" || txtMaKH.Text == "" || txtSDT.Text == "" || txtDiachi.Text == "")
                    {
                        MessageBox.Show("Mời bạn nhập đầy đủ thông tin!", "Thông báo");
                    }
                    else
                    {
                        LayTTKH(KH);
                        LayTTHDBH(HDBH);
                        if (KiemTraSDT(txtSDT.Text) == false)
                        {
                            MessageBox.Show("Số điện thoại không được chứa kí tự.", "Thông báo");
                        }
                        else
                        {
                            try
                            {
                                Khachhang_BUS.Khachhang_Insert(KH);
                                HoadonBan_BUS.HDBanhang_Insert(HDBH);
                                cbbTenSP.Enabled = true;
                                btnThemSP.Enabled = true;
                                btnCapnhatHD.Enabled = true;
                                ChangeState(false);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }
                else
                {
                    if(txtTenNV.Text == "" || txtTenKH.Text == "" || txtMaNV.Text =="" || txtMaKH.Text == "" || txtSDT.Text =="" ||txtDiachi.Text =="")
                    {
                        MessageBox.Show("Mời bạn nhập đầy đủ thông tin!", "Thông báo");
                    }
                    else
                    {
                        LayTTHDBH(HDBH);
                        if(KiemTraSDT(txtSDT.Text)==false)
                        {
                            MessageBox.Show("Số điện thoại không được chứa kí tự.", "Thông báo");
                        }
                        else
                        {
                            try
                            {
                                HoadonBan_BUS.HDBanhang_Insert(HDBH);
                                cbbTenSP.Enabled = true;
                                btnThemSP.Enabled = true;
                                btnCapnhatHD.Enabled = true;
                                ChangeState(false);
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

        private string TuDongTangMaNV(DataTable tbl)
        {
            string sMaHDB = tbl.Rows[0][0].ToString();
            String sTemp1, sTerm2;
            sTemp1 = sMaHDB.Substring(0, 2);
            sTerm2 = sMaHDB.Substring(2, 3);
            sTerm2 = (int.Parse(sTerm2.ToString()) + 1).ToString();
            if (sTerm2.Length < 3)
            {
                int a = sTerm2.Length;
                for (int i = 0; i < 3 - a; i++)
                    sTerm2 = "0" + sTerm2;
            }
            sMaHDB = sTemp1 + sTerm2;
            return sMaHDB;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDiachi_Click(object sender, EventArgs e)
        {

        }

        private void txtTenKH_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtTenKH_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (StateButton == 1)
            {
                LoadMaKH();
                if (txtMaKH.Text != "")
                {
                    LoadThongtinKH();
                }
                if (txtMaKH.Text == "")
                {
                    txtSDT.ResetText();
                    txtDiachi.ResetText();
                }
            }
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            btnThemHD.Enabled = true;
            RPHoaDonBanHang RP = new RPHoaDonBanHang();
            RP.sMaHDBH = txtMaHD.Text;
            RP.Show();
        }

        private void cbbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenSP.SelectedIndex != -1)
            {
                txtMaSP.Text = cbbTenSP.SelectedValue.ToString();
                txtSL.Enabled = true;
            }
        }

        private void cbbTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbTenSP_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            //int a = int.Parse(txtSL.Text);
            //long b = long.Parse(txtDongia.Text-",0000");
            //txtThanhtien.Text = (a*b).ToString();
        }

        private void txtSL_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "")
            {
                DataTable tblDongia = HoadonBan_BUS.Sanpham_LoadDongia(txtMaSP.Text);
                txtDongia.Text = tblDongia.Rows[0][0].ToString();
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            CTHDBanhang_DTO CTHDBH = new CTHDBanhang_DTO();
            DataTable tblCheck = new DataTable();
            tblCheck = HoadonBan_BUS.CheckSPinHDBH(txtMaSP.Text, txtMaHD.Text);
            if (tblCheck.Rows.Count == 0)
            {
                if (txtSL.Text != "")
                {
                    LayTTCTHDBH(CTHDBH);
                    sMaCTHDBH = CTHDBH.SMaCTHDB;
                    HoadonBan_BUS.ThemCTHDBH(CTHDBH);
                    CTHDBanHang_Load(txtMaHD.Text);
                    txtTongtien.Text = TinhTongTien(txtMaHD.Text);
                    Update_Tongtien();
                    SP_CapnhatSL("-");
                    txtSL.Enabled = false;
                    ResetSP();
                }
                else
                {
                    MessageBox.Show("Mời bạn nhập số lượng cho sản phẩm!", "Thông báo");
                }
            }
            else
            {
                DialogResult Lenh = MessageBox.Show("Sản phẩm này đã được thêm, bạn có muốn thêm sản phẩm này nữa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Lenh == DialogResult.Yes)
                {
                    DataTable tblSL = HoadonBan_BUS.SP_LaySL(txtMaSP.Text);
                    int iSL = int.Parse(tblCheck.Rows[0][3].ToString())+int.Parse(txtSL.Text);
                    HoadonBan_BUS.UpdateSL_CTHDBH(tblCheck.Rows[0][0].ToString(), txtMaSP.Text, iSL);
                    CTHDBanHang_Load(txtMaHD.Text);
                    SP_CapnhatSL("-");
                }
            }
        }
        private void SP_CapnhatSL(string sChuoi)
        {
            Sanpham_DTO SP = new Sanpham_DTO();
            int iNewSL = 0;
            DataTable tblSL = HoadonBan_BUS.SP_LaySL(txtMaSP.Text);
            string sTemp = tblSL.Rows[0][0].ToString();
            switch (sChuoi)
            {
                case "-":
                    iNewSL = int.Parse(sTemp) - int.Parse(txtSL.Text);
                    break;
                case "+":
                    iNewSL = int.Parse(sTemp) + int.Parse(txtSL.Text);
                    break;
            }
            SP.SSoLuong = iNewSL;
            SP.SMaSP = txtMaSP.Text;
            HoadonBan_BUS.SP_Update_SL(SP);
        }
        private void CTHDBanHang_Load(string sMaHDBH)
        {
             DataTable tbl = HoadonBan_BUS.CTHDBanHang_Load(sMaHDBH);
             dgvCTHD.DataSource = tbl;
             dgvCTHD.Columns["MACTHDBH"].HeaderText = "Mã CTHD bán hàng";
             dgvCTHD.Columns["TENSP"].HeaderText = "Tên sản phẩm";
             dgvCTHD.Columns["MASP"].Visible = false;
             dgvCTHD.Columns["SOLUONG"].HeaderText = "Số lượng";

             dgvCTHD.Columns["TENSP"].Width = 260;
             dgvCTHD.Columns["SOLUONG"].Width = 40;
             dgvCTHD.Columns["MACTHDBH"].Width = 100;
             dgvCTHD.RowHeadersVisible = false;
        }
        private void LoadDgvCTHD()
        {
            DataGridViewRow dr = dgvCTHD.SelectedRows[0];
            txtMaSP.Text = dr.Cells["MASP"].Value.ToString();
            txtSL.Text = dr.Cells["SOLUONG"].Value.ToString();
            sSL = int.Parse(txtSL.Text);
            cbbTenSP.SelectedValue = dr.Cells["MASP"].Value.ToString();
            sMaCTHDBH = dr.Cells["MACTHDBH"].Value.ToString();
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDgvCTHD();
            btnXoaSP.Enabled = true;
            btnCapnhatSP.Enabled = true;
        }
        public string TinhTongTien(string sMaHDBH)
        {
            DataTable tbl = HoadonBan_BUS.HDBH_SumMoney(sMaHDBH);
            return tbl.Rows[0][0].ToString();
        }
        public void XoaCTHDBH()
        {
            HoadonBan_BUS.XoaCTHDBH(sMaCTHDBH);
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            XoaCTHDBH();
            CTHDBanHang_Load(txtMaHD.Text);
            SP_CapnhatSL("+");
            ResetSP();
        }
        private void Update_Tongtien()
        {
            Hoadonban_DTO HDBH = new Hoadonban_DTO();
            LayTTHDBH(HDBH);
            HDBH.LThanhtien = int.Parse(txtTongtien.Text);
            HoadonBan_BUS.Update_Tongtien(HDBH);
        }
        private void btnCapnhatSP_Click(object sender, EventArgs e)
        {
            CTHDBanhang_DTO CTHDBH = new CTHDBanhang_DTO();
            Sanpham_DTO SP = new Sanpham_DTO();
            SP.SMaSP = txtMaSP.Text;
            CTHDBH.SMaCTHDB = sMaCTHDBH;
            CTHDBH.SMaHDB = txtMaHD.Text;
            CTHDBH.SMaSP = txtMaSP.Text;
            CTHDBH.ISoLuong = int.Parse(txtSL.Text);
            HoadonBan_BUS.Update_CTHDBH(CTHDBH);
            CTHDBanHang_Load(txtMaHD.Text);
            txtTongtien.Text = TinhTongTien(txtMaHD.Text);
            Update_Tongtien();
            DataTable tblSL = HoadonBan_BUS.SP_LaySL(txtMaSP.Text);
            string sTemp = tblSL.Rows[0][0].ToString();
            int iTemp;
            if (int.Parse(txtSL.Text)>sSL)
            {
                iTemp = int.Parse(txtSL.Text)-sSL;
                SP.SSoLuong = int.Parse(sTemp) - iTemp;
                HoadonBan_BUS.SP_Update_SL(SP);
            }
            else
                if(int.Parse(txtSL.Text)<sSL)
                {
                    iTemp = sSL - int.Parse(txtSL.Text);
                    SP.SSoLuong = int.Parse(sTemp) + iTemp;
                    HoadonBan_BUS.SP_Update_SL(SP);
                }
            sSL = int.Parse(txtSL.Text);
            ResetSP();
            LoadDgvCTHD();
        }
    }
}
