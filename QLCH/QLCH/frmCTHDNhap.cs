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
    public partial class frmCTHDNhap : Form
    {
        List<string> lsmasp = new List<string>();
        List<string> lscbdgv = new List<string>();
        List<string> manv = new List<string>();
        List<string> mancc = new List<string>();
        SqlConnection con;
        string state = "add"; // 0 la them 1 la cap nhat
        public frmCTHDNhap()
        {
            InitializeComponent();
        }
        public frmCTHDNhap(string Message): this()
        {
            state = Message;
        }
        private void frmCTHDNhap_Load(object sender, EventArgs e)
        {
            
            con = DataProvider.Ketnoi();
            DataTable dt1, dt3;
            AddNVToComBox(cbNV2);
            AddNCCToComBox(cbNCC2);
            dt1 = DataProvider.GetDataTable("HDN_MAHDN_TOP1", con);
            dt3 = DataProvider.GetDataTable("LOAD_SANPHAM_ELEMENT",con);
            for(int i = 0; i<dt3.Rows.Count; i++)
            {
                lscbdgv.Add(dt3.Rows[i]["TENSP"].ToString());
                lsmasp.Add(dt3.Rows[i]["MASP"].ToString());
            }
          
            colTenSP.Items.AddRange(lscbdgv.ToArray());
            if(state == "add")
            {
                btnSave.Text = "Thêm HĐ";
                txMaHD2.Text = TuDongTangMaNV(dt1);
            }
            else 
            {
                btnSave.Text = "Lưu TT";
                SqlCommand cmd2 = new SqlCommand("HDNH_WITHMAHD", con);
                cmd2.Parameters.Add("@MAHDNH", SqlDbType.Char).Value = state;
                DataTable dt = DataProvider.GetDataTableWithParam(cmd2, con);
                txMaHD2.Text= dt.Rows[0]["MAHDNH"].ToString();
                cbNV2.SelectedIndex = seachmaposition( dt.Rows[0]["MANV"].ToString(),manv);
                cbNCC2.SelectedIndex = seachmaposition(dt.Rows[0]["MANCC"].ToString(), mancc);
                dtNgayNhap2.Value = DateTime.Parse(dt.Rows[0]["NGAYNH"].ToString());
                txTongTT2.Text= dt.Rows[0]["TONGTIEN"].ToString();
                loadbang();
            }
            con.Close();
        }
        private void loadbang()
        {
            List<CTHDNhap_DTO> lstCTHDNhap = CTHDNhap_BUS.LoadCTHDNhap(txMaHD2.Text);
            dgvCTHDNhap2.DataSource = lstCTHDNhap;
            dgvCTHDNhap2.Columns["SMaCTHDN"].Visible = false;
            dgvCTHDNhap2.Columns["SMaSP"].Visible = false;
            dgvCTHDNhap2.Columns["SMaHDN"].Visible = false;
        }

        private string TuDongTangMaNV(DataTable dt)
        {
            
            string ma =dt.Rows[0][0].ToString();
            String sTemp1, sTerm2;
            sTemp1 = ma.Substring(0, 2);
            sTerm2 = ma.Substring(2, 3);
            sTerm2 = (int.Parse(sTerm2.ToString()) + 1).ToString();
            if (sTerm2.Length < 3)
            {
                int a = sTerm2.Length;
                for (int i = 0; i < 3 - a; i++)
                    sTerm2 = "0" + sTerm2;
            }
            ma = sTemp1 + sTerm2;
            return ma;
        }

        public void AddNVToComBox(ComboBox cb)
        {
            manv.Clear();
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

        private bool checkfill()
        {
            if (txTongTT2.Text != "" && cbNCC2.SelectedIndex != 0 && cbNV2.SelectedIndex != 0)
                return true;
            else return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkfill())
            {
               SqlConnection con2 = DataProvider.Ketnoi();
                InsertHDNH(txMaHD2.Text, manv[cbNV2.SelectedIndex], mancc[cbNCC2.SelectedIndex], dtNgayNhap2.Value.ToString(), txTongTT2.Text);
                for (int i = 0; i < dgvCTHDNhap2.Rows.Count-1; i++)
                {
                    DataTable dt2 = DataProvider.GetDataTable("HDN_CTHDN_TOP1", con2);
                   string masp = searchma(dgvCTHDNhap2.Rows[i].Cells[0].Value.ToString(), lsmasp,lscbdgv);
                  //  MessageBox.Show(TuDongTangMaNV(dt2) + txMaHD2.Text + masp+ dgvCTHDNhap2.Rows[i].Cells[1].Value.ToString() + dgvCTHDNhap2.Rows[i].Cells[2].Value.ToString());
                    InsertCTHDNHAP(TuDongTangMaNV(dt2),txMaHD2.Text,masp,dgvCTHDNhap2.Rows[i].Cells[1].Value.ToString(),dgvCTHDNhap2.Rows[i].Cells[2].Value.ToString());
                }
                    MessageBox.Show("THÊM THÀNH CÔNG !");
            }
            else
                MessageBox.Show("KIỂM TRA NHẬP ĐẦY ĐỦ THÔNG TIN");
        }
        public void LoadSP()
        {
            con = DataProvider.Ketnoi();
            DataTable dt = new DataTable();
            dt = DataProvider.GetDataTable("LOAD_SANPHAM_ELEMENT", con);
            con.Close();

        }
        private string searchma (string ma, List<string> mangma, List<string> mangten)
        {
            int i = 0;
            while (mangten[i] != ma)
            {
                i++;
            }
            return mangma[i];
        }
        private int seachmaposition (string ma, List<string> mangma)
        {
            int i = 0;
            while(mangma[i] != ma)
            {
                i++;
            }
            return i;
        }
        private void InsertHDNH(string mahdnh, string manv, string mancc, string ngnhap, string tongtien)
        {
            con = DataProvider.Ketnoi();
            SqlCommand cmd = new SqlCommand("HoaDonNhap_Insert", con);
            cmd.Parameters.Add("@MAHDNH", SqlDbType.Char).Value = mahdnh;
            cmd.Parameters.Add("@MANV", SqlDbType.Char).Value = manv;
            cmd.Parameters.Add("@MANCC", SqlDbType.Char).Value = mancc;
            cmd.Parameters.Add("@NGAYNH", SqlDbType.SmallDateTime).Value = ngnhap;
            cmd.Parameters.Add("@TONGTIEN", SqlDbType.Money).Value = tongtien;
           
            DataProvider.GetDataTableWithParam(cmd, con);
            con.Close();
        }
        private void InsertCTHDNHAP(string macthd, string mahdnh, string masp, string soluong, string gianhap)
        {
            con = DataProvider.Ketnoi();
            SqlCommand cmd = new SqlCommand("CTHDNhap_Insert",con);
            cmd.Parameters.Add("@MACTHDNH", SqlDbType.Char).Value = macthd;
            cmd.Parameters.Add("@MAHDNH", SqlDbType.Char).Value = mahdnh;
            cmd.Parameters.Add("@MASP", SqlDbType.Char).Value = masp;
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@GIANHAP", SqlDbType.Money).Value = gianhap;
            DataProvider.GetDataTableWithParam(cmd, con);
            con.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_CT_Click(object sender, EventArgs e)
        {
            if (dgvCTHDNhap2.Rows.Count <= 1)
            {
                MessageBox.Show("HOÁ ĐƠN PHẢI CÓ ÍT NHẤT 1 DÒNG CHI TIẾT ");
                return;
            }
                
            foreach (DataGridViewRow row in dgvCTHDNhap2.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["colInsDel"];
                if (chk.Selected == true)
                {
                    con = DataProvider.Ketnoi();
                    SqlCommand cmd3 = new SqlCommand("CTHDNhap_Delete_NOMACT", con);
                    cmd3.Parameters.Add("@MAHDNH", SqlDbType.Char).Value = txMaHD2.Text;
                    cmd3.Parameters.Add("@MASP", SqlDbType.Char).Value = searchma(row.Cells["colTenSP"].Value.ToString(), lsmasp, lscbdgv);
                    DataProvider.GetDataTableWithParam(cmd3, con);
                    MessageBox.Show("Xoá thành công !");
                    loadbang();
                }
                
            }
        }

        private void btnUpdate_CT_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1;
            foreach (DataGridViewRow row in dgvCTHDNhap2.Rows)
            {
               cmd1.Parameters.Add("")
            }
        }

        private void dgvCTHDNhap2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate_CT.Enabled = true;
        }
    }
}
