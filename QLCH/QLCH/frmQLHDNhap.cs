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
        }

        private void dgvHDNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void AddNVToComBox ()
        {
            SqlConnection con = new SqlConnection();
            con = DataProvider.Ketnoi();
            var dt = new DataTable();
            dt = DataProvider.GetDataTable("NhanVien_Select_Element", con);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbNV.Items.Add (dt.Rows[i]["TENNV"].ToString());
            }
            DataProvider.Dongketnoi(con);
            
        }
        public void AddNCCToComBox()
        {
            SqlConnection con1 = new SqlConnection();
            con1 = DataProvider.Ketnoi();
            var dt = new DataTable();
            dt = DataProvider.GetDataTable("NhaCungCap_Select_Element", con1);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbNCC.Items.Add(dt.Rows[i]["TENNCC"].ToString());
            }
            DataProvider.Dongketnoi(con1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = DataProvider.Ketnoi();
            List<string> MaXoa = new List<string>();
            int i = 0;
            foreach (DataGridViewRow row in dgvHDNhap.SelectedRows)
            {
                
                    SqlCommand cmd = new SqlCommand("HoaDonNhap_Delete", con);
                    cmd.Parameters.Add("@MAHDNH", SqlDbType.Char).Value = row.Cells[0].Value.ToString();
                    DataProvider.GetDataTableWithParam(cmd, con);
                    MessageBox.Show("Xoá dòng có MaHDN="+row.Cells[0].Value.ToString()+" thành công!");
                    LoaddgvHDNhap();
            }
            DataProvider.Dongketnoi(con);
                
        }

        private void dgvHDNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cbNCC.Items.Clear();
            cbNV.Items.Clear();
            AddNVToComBox();
            AddNCCToComBox();
            String s = dgvHDNhap[0, e.RowIndex].Value.ToString();
            txMaHD.Text = s;
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
            dtNgayNhap.Value = new DateTime(dt.Year, dt.Month, dt.Day);
            string t = dgvHDNhap[4, e.RowIndex].Value.ToString();
            txTongTT.Text = t;
            List<CTHDNhap_DTO> lstCTHDNhap = CTHDNhap_BUS.LoadCTHDNhap(s);
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
    }
}
