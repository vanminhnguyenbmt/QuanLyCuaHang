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
    public partial class frmQLHDNhap : Form
    {

     
        List<string> manv = new List<string>();
        List<string> mancc = new List<string>();
        public frmQLHDNhap()
        {
            InitializeComponent();
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmQLHDNhap_Load(object sender, EventArgs e)
        {
            LoaddgvHDNhap();
        }
        private void LoaddgvHDNhap ()
        {
            List<HDNhaphang_DTO> lstHDNhap = HDNhaphang_BUS.LoadHDNhap();
          
            dgvHDNhap.DataSource = lstHDNhap;
            dgvHDNhap.Columns["SMaNV"].Visible = false;
            dgvHDNhap.Columns["SMaNCC"].Visible = false;
            AddNCCToComBox(cbNCC);
            AddNVToComBox(cbNV);
        }

       
        public void AddNVToComBox (ComboBox cb)
        {
            manv.Clear();
            SqlConnection con = new SqlConnection();
            con = DataProvider.Ketnoi();
            var dt = new DataTable();
            dt = DataProvider.GetDataTable("NhanVien_Select_Element", con);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add (dt.Rows[i]["TENNV"].ToString());
                manv.Add(dt.Rows[i]["MANV"].ToString());
            }
            DataProvider.Dongketnoi(con);
            
        }
        public void AddNCCToComBox(ComboBox cb)
        {
            mancc.Clear();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txMaHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một dòng trước đã !");
                return;
            }
           
            SqlConnection con;
            con = DataProvider.Ketnoi();
            List<string> MaXoa = new List<string>();
            int i = 0;
            
            foreach (DataGridViewRow row in dgvHDNhap.SelectedRows)
            {

                if (MessageBox.Show("Bạn có thật sự muốn xoá hoá đơn " + row.Cells[0].Value.ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("HoaDonNhap_Delete", con);
                    cmd.Parameters.Add("@MAHDNH", SqlDbType.Char).Value = row.Cells[0].Value.ToString();
                    DataProvider.GetDataTableWithParam(cmd, con);
                    MessageBox.Show("Xoá dòng có MaHDN=" + row.Cells[0].Value.ToString() + " thành công!");
                    LoaddgvHDNhap();
                }
                else
                {
                    DataProvider.Dongketnoi(con);
                    break;
                }
                    
            }
            DataProvider.Dongketnoi(con);
                
        }

        private void dgvHDNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cbNCC.Items.Clear();
            cbNV.Items.Clear();
            AddNVToComBox(cbNV);
            AddNCCToComBox(cbNCC);
             string str = dgvHDNhap[0, e.RowIndex].Value.ToString();
             txMaHD.Text = str;
               
            string nv = dgvHDNhap[5, e.RowIndex].Value.ToString();
            string ncc = dgvHDNhap[6, e.RowIndex].Value.ToString();
            int i = 0;
            while (cbNV.Items[i].ToString() != nv)
            {
                i++;
            }
            cbNV.SelectedIndex = i;
            i = 0;
            while (cbNCC.Items[i].ToString() != ncc)
            {
                i++;
            }
            cbNCC.SelectedIndex = i;
            string ngay = dgvHDNhap[3, e.RowIndex].Value.ToString();
            DateTime dt = DateTime.Parse(ngay);
            dtpNgayNhap.Value = new DateTime(dt.Year, dt.Month, dt.Day);
            string t = dgvHDNhap[4, e.RowIndex].Value.ToString();
            txTongTT.Text = t;
            List<CTHDNhap_DTO> lstCTHDNhap = CTHDNhap_BUS.LoadCTHDNhap(str);
            dgvCTHDNhap.DataSource = lstCTHDNhap;
            dgvCTHDNhap.Columns["SMaCTHDN"].Visible = false;
            dgvCTHDNhap.Columns["SMaSP"].Visible = false;
            dgvCTHDNhap.Columns["SMaHDN"].Visible = false;
            int count = 0;
            for (i = 0; i < dgvCTHDNhap.Rows.Count; i++)
            {
                count += int.Parse(dgvCTHDNhap[4, i].Value.ToString());
            }
            txTongSP.Text = count.ToString();
        }

        private void btnUpdateHDN_Click(object sender, EventArgs e)
        {
            if (txMaHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một dòng trước đã !");
                return;
            }
            SqlConnection con;
            con = DataProvider.Ketnoi();
            SqlCommand cmd = new SqlCommand("HDNhapHang_Update", con);
                    cmd.Parameters.Add("@MAHDNH", SqlDbType.Char).Value = txMaHD.Text;
                    cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = manv[cbNV.SelectedIndex];
                    cmd.Parameters.Add("@MANCC", SqlDbType.Char).Value = mancc[cbNCC.SelectedIndex];
            
                    cmd.Parameters.Add("@TONGTT", SqlDbType.Money).Value = txTongTT.Text;
                    cmd.Parameters.Add("@NGAYNHAP", SqlDbType.SmallDateTime).Value = dtpNgayNhap.Value.ToString();
                    DataProvider.GetDataTableWithParam(cmd, con);
                    MessageBox.Show("Sửa thông tin hoá đơn có MaHDN=" + txMaHD.Text+ " thành công!","Thông báo");
                    LoaddgvHDNhap();
            DataProvider.Dongketnoi(con);
        }

        private void btnUpdateCTHDN_Click(object sender, EventArgs e)
        {
            if (txMaHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một dòng trước đã !");
                return;
            }
            frmCTHDNhap frm2 = new frmCTHDNhap(txMaHD.Text);
            frm2.Activate();
            frm2.Show();
        }

        private void btnAddHDN_Click(object sender, EventArgs e)
        {
            frmCTHDNhap frm2 = new frmCTHDNhap("add");
            frm2.Activate();
            frm2.Show();
        }

        private void btnSumTotal_Click(object sender, EventArgs e)
        {
            LoaddgvHDNhap();
        }
    }
}
