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
using System.Data.Sql;
using System.Data.SqlClient;
using BUS;
using DAO;

namespace QLCH
{
    public partial class frmDMHDNH : Form
    {
        List<string> manv = new List<string>();
        List<string> mancc = new List<string>();

        public frmDMHDNH()
        {
            InitializeComponent();
            
        }

        private void frmDMHDNhap_Load(object sender, EventArgs e)
        {
            LoaddgvHDNhap();
        }
        private void LoaddgvHDNhap()
        {
            List<HDNhaphang_DTO> lstHDNhap = HDNhaphang_BUS.LoadHDNhap();
            dgvHDNhap_DM.DataSource = lstHDNhap;
            dgvHDNhap_DM.Columns["SMaNV"].Visible = false;
            dgvHDNhap_DM.Columns["SMaNCC"].Visible = false;
            AddNVToComBox(cbNV_DMHDN);
            AddNCCToComBox(cbNCC_DMHDN);
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }
        public void AddNVToComBox(ComboBox cb)
        {
            manv.Clear();
            cbNV_DMHDN.Items.Add("--không--");
            SqlConnection con = new SqlConnection();
            con = DataProvider.Ketnoi();
            var dt = new DataTable();
            dt = DataProvider.GetDataTable("NhanVien_Select_Element", con);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(dt.Rows[i]["TENNV"].ToString());
                manv.Add(dt.Rows[i]["MANV"].ToString());
            }
            DataProvider.Dongketnoi(con);
            cbNV_DMHDN.SelectedIndex = 0;

        }
        public void AddNCCToComBox(ComboBox cb)
        {

            mancc.Clear();
            cbNCC_DMHDN.Items.Add("--không--");
            SqlConnection con1 = new SqlConnection();
            con1 = DataProvider.Ketnoi();
            var dt = new DataTable();
            dt = DataProvider.GetDataTable("NhaCungCap_Select_Element", con1);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(dt.Rows[i]["TENNCC"].ToString());
                mancc.Add(dt.Rows[i]["MANCC"].ToString());
            }
            DataProvider.Dongketnoi(con1);
            cbNCC_DMHDN.SelectedIndex = 0;
        }

        private void cbNCC_DMHDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbNCC_DMHDN.SelectedIndex !=0)
            {
                SqlConnection con = new SqlConnection();
                con = DataProvider.Ketnoi();
                SqlCommand cmd = new SqlCommand("HDNH_WITHMANCC", con);
                cmd.Parameters.Add("@MANCC", SqlDbType.Char).Value = mancc[cbNCC_DMHDN.SelectedIndex-1];
                dgvHDNhap_DM.DataSource = DataProvider.GetDataTableWithParam(cmd, con);
                dgvHDNhap_DM.Columns["MANV"].Visible = false;
                dgvHDNhap_DM.Columns["MANCC"].Visible = false;
                DataProvider.Dongketnoi(con);
                cbNV_DMHDN.SelectedIndex = 0;
            }
           
           
        }

     
        private void cbNV_DMHDN_SelectedIndexChanged(object sender, EventArgs e)
        {

             if(cbNV_DMHDN.SelectedIndex !=0)
            {
                SqlConnection con = new SqlConnection();
                con = DataProvider.Ketnoi();
                SqlCommand cmd = new SqlCommand("HDNH_WITHMANV", con);
                cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = manv[cbNV_DMHDN.SelectedIndex-1];
                dgvHDNhap_DM.DataSource = DataProvider.GetDataTableWithParam(cmd, con);
                dgvHDNhap_DM.Columns["MANV"].Visible = false;
                dgvHDNhap_DM.Columns["MANCC"].Visible = false;
                DataProvider.Dongketnoi(con);
                cbNCC_DMHDN.SelectedIndex = 0;
            }
        }

        private void btnLocDate_Click(object sender, EventArgs e)
        {
            //dgvHDNhap2.Rows.Clear();
            cbNCC_DMHDN.SelectedIndex = 0;
            cbNV_DMHDN.SelectedIndex = 0;
            if(DateTime.Compare(dtpBegin.Value,dtpEnd.Value)>0)
            {
                MessageBox.Show("Ngày bắt đầu không thể trễ hơn ngày kết thúc !","Lỗi");
            }
            else
            {
                SqlConnection con11 = new SqlConnection();
                con11 = DataProvider.Ketnoi();
                SqlCommand cmd = new SqlCommand("HDNhapHang_Load_Day", con11);
                cmd.Parameters.Add("@DAYBEGIN", SqlDbType.SmallDateTime).Value = dtpBegin.Value.ToShortDateString();
                cmd.Parameters.Add("@DAYEND", SqlDbType.SmallDateTime).Value = dtpEnd.Value.ToShortDateString();
                
                dgvHDNhap_DM.DataSource = DataProvider.GetDataTableWithParam(cmd, con11);
                dgvHDNhap_DM.Columns["MANV"].Visible = false;
                dgvHDNhap_DM.Columns["MANCC"].Visible = false;
    
                DataProvider.Dongketnoi(con11);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (rdShowAll.Checked == true)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                List<HDNhaphang_DTO> lstHDNhap = HDNhaphang_BUS.LoadHDNhap();
                dgvHDNhap_DM.DataSource = lstHDNhap;
                dgvHDNhap_DM.Columns["SMaNV"].Visible = false;
                dgvHDNhap_DM.Columns["SMaNCC"].Visible = false;
            }
            else
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           if(rdFillter.Checked == true)
           {
               groupBox1.Enabled = true;
               groupBox2.Enabled = true;
           }
          
        }

        private void dgvHDNhap_DM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(rdFillter.Checked && e.RowIndex == dgvHDNhap_DM.Rows.Count-1)
           {
               MessageBox.Show("Dòng này không có dữ liệu");
               return;
           }
            string str = dgvHDNhap_DM[0, e.RowIndex].Value.ToString();
            List<CTHDNhap_DTO> lstCTHDNhap = CTHDNhap_BUS.LoadCTHDNhap(str);

            dgvCTHDNhap.DataSource = lstCTHDNhap;
            dgvCTHDNhap.Columns["SMaCTHDN"].Visible = false;
            dgvCTHDNhap.Columns["SMaSP"].Visible = false;
            dgvCTHDNhap.Columns["SMaHDN"].Visible = false;
            int count = 0;
            for (int i = 0; i < dgvCTHDNhap.Rows.Count; i++)
            {
                count += int.Parse(dgvCTHDNhap[4, i].Value.ToString());
            }
     
        }

    }

}
