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
        List<int> lstUpdate = new List<int>();
        DataTable dt1, dt3;
        List<CTHDNhap_DTO> lstCTHDNhap;
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
                groupBox1.Visible = false;
                btnDel_CT.Text = "Xoá dòng";
                dgvCTHDNhap_CT.Columns["colInsDel"].Visible = false;
        
                
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
                cbSPAdd.Items.AddRange(lscbdgv.ToArray());
                cbNCC2.Enabled = false;
                cbNV2.Enabled = false;
                txTongTT2.Enabled = false;
                dtNgayNhap2.Enabled = false;
                btnSave.Text = "Cập nhật HĐ";
            }
            con.Close();
        }
        private void loadbang()
        {
            lstCTHDNhap = CTHDNhap_BUS.LoadCTHDNhap(txMaHD2.Text);
            dgvCTHDNhap_CT.DataSource = lstCTHDNhap;
            dgvCTHDNhap_CT.Columns["SMaCTHDN"].Visible = false;
            dgvCTHDNhap_CT.Columns["SMaSP"].Visible = false;
            dgvCTHDNhap_CT.Columns["SMaHDN"].Visible = false;
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
            if (cbNCC2.SelectedText.ToString() != null && cbNV2.SelectedText.ToString() !=null)
                return true;
            else return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(state=="add")
            {
               
                if(checkfill()&&tinhtongthanhtien(dgvCTHDNhap_CT) != 0)
                {
                     if (MessageBox.Show("Bạn có muốn thêm hoá đơn có mã " + txMaHD2.Text + " với tổng thanh toán là " + tinhtongthanhtien(dgvCTHDNhap_CT).ToString() + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                   
                                SqlConnection con2 = DataProvider.Ketnoi();
                                InsertHDNH(txMaHD2.Text, manv[cbNV2.SelectedIndex], mancc[cbNCC2.SelectedIndex], dtNgayNhap2.Value.ToString(), tinhtongthanhtien(dgvCTHDNhap_CT).ToString());
                                for (int i = 0; i < dgvCTHDNhap_CT.Rows.Count - 1; i++)
                                {
                                    DataTable dt2 = DataProvider.GetDataTable("HDN_CTHDN_TOP1", con2);
                                    string masp = searchma(dgvCTHDNhap_CT.Rows[i].Cells[0].Value.ToString(), lsmasp, lscbdgv);
                                    InsertCTHDNHAP(TuDongTangMaNV(dt2), txMaHD2.Text, masp, dgvCTHDNhap_CT.Rows[i].Cells[1].Value.ToString(), dgvCTHDNhap_CT.Rows[i].Cells[2].Value.ToString());
                                }
                                MessageBox.Show("Thêm hoá đơn " + txMaHD2.Text + " thành công !", "Thông báo");
                                this.Close();
                   
                        }
                }
                    else
                        MessageBox.Show("Bạn cần nhập đầy đủ thông tin và kiểm tra lại thông tin cho đúng", "Lỗi");
               
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn cập nhật lại hoá đơn " + txMaHD2.Text + " với tổng thanh toán mới là " + tinhtongthanhtien(dgvCTHDNhap_CT).ToString() + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvCTHDNhap_CT.Rows)
                    {

                            UpdateCTHDNHAP(row.Cells["SMaCTHDN"].Value.ToString(), row.Cells["SMaSP"].Value.ToString(), row.Cells["SL"].Value.ToString(), row.Cells["DG"].Value.ToString());
                    }
                    MessageBox.Show("Cập nhật hoá đơn thành công!", "Thông báo");
                    UpdateTongThanhTienHDN(txMaHD2.Text, tinhtongthanhtien(dgvCTHDNhap_CT));
                    this.Close();

                }
                else return;
            }
           
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
        private void UpdateCTHDNHAP(string macthd, string masp, string soluong, string gianhap)
        {
            con = DataProvider.Ketnoi();
            SqlCommand cmd1 = new SqlCommand("CTHD_Update", con);
            cmd1.Parameters.Add("@MACTHDN", SqlDbType.Char).Value = macthd;
            cmd1.Parameters.Add("@MASP", SqlDbType.Char).Value = masp;
            cmd1.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = soluong;
            cmd1.Parameters.Add("@GIANHAP", SqlDbType.Money).Value = gianhap;
            DataProvider.RunSQuerryWithParam(cmd1, con);
            con.Close();
        }
        private void InsertHDNH(string mahdnh, string manv, string mancc, string ngnhap, string tongtien)
        {

            if (KiemTraSo(tongtien) == false)
            {
                MessageBox.Show("Không thêm được! Kiểm tra lại dữ liệu bạn nhập vào: " + tongtien, "Lỗi");
                return;
            }
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

            if (KiemTraSo(soluong) == false || KiemTraSo(gianhap) == false)
            {
                MessageBox.Show("Không thêm được mã CTHD "+macthd+"! Kiểm tra lại dữ liệu bạn nhập vào", "Lỗi");
                return;
            }
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
            if(state == "add")
            {
                if (this.dgvCTHDNhap_CT.SelectedRows.Count > 0 && dgvCTHDNhap_CT.SelectedRows[0].Index < dgvCTHDNhap_CT.Rows.Count-1)
                {
                    dgvCTHDNhap_CT.Rows.RemoveAt(this.dgvCTHDNhap_CT.SelectedRows[0].Index);
                }
                else MessageBox.Show("Không thể xoá dòng cuối cùng!", "Lỗi");
            }
            else
            {
                if (dgvCTHDNhap_CT.Rows.Count <= 1)
                {
                    MessageBox.Show("Hoá đơn phải có ít nhất 1 chi tiết","Lỗi");
                    return;
                }

                foreach (DataGridViewRow row in dgvCTHDNhap_CT.Rows)
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
                        
                    }

                }
                loadbang();
                con.Close();
                
            }
           
        }


        private bool KiemTraSo(string SDT)
        {
            for (int i = 0; i < SDT.Length; i++)
            {
                if (SDT[i] < 48 || SDT[i] > 57)
                    return false;
            }
            return true;
        }
      
        

        private void btnAdd_Row_Click(object sender, EventArgs e)
        {
            if(KiemTraSo(txtSoluong.Text) == true && KiemTraSo(txtGianhap.Text) == true)
            {
                InsertCTHDNHAP(TuDongTangMaNV(DataProvider.GetDataTable("HDN_CTHDN_TOP1",con)), txMaHD2.Text,lsmasp[cbSPAdd.SelectedIndex], txtSoluong.Text,txtGianhap.Text);
            }
            else
            {
                MessageBox.Show("Kiểm tra lại dữ liệu nhập vào", "Thông báo");
            }
            loadbang();
        }


        private void dgvCTHDNhap2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDel_CT.Enabled = true;
            if(state != "add")
            {
                btnSave.Enabled = true;
            }
        }
        private int tinhtongthanhtien(DataGridView dvg)
        {
            Int32 sl, dg, s;
            s = 0;
            int i = 0;
            foreach (DataGridViewRow row in dvg.Rows)
            {
                if(state!="add" || i<dvg.Rows.Count-1)
                {
                    try
                    {
                        sl = int.Parse(row.Cells["SL"].Value.ToString());
                        dg = int.Parse(row.Cells["DG"].Value.ToString());
                        s += sl * dg;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bạn vui lòng kiểm tra lại dữ liệu nhập vào \nChi tiết lỗi: "+ex + "", "Lỗi");
                        return 0;
                    }
                }
                i++;
            }
            return s;
        }
       private void UpdateTongThanhTienHDN(string mahd, int tongtt)
        {
            con = DataProvider.Ketnoi();

            SqlCommand cmd3 = new SqlCommand("UP_HDNH_THANHTOAN", con);
            cmd3.Parameters.Add("@MAHDNH", SqlDbType.Char).Value = mahd;
            cmd3.Parameters.Add("@TONGTIEN", SqlDbType.Int).Value = tongtt.ToString();
            DataProvider.GetDataTableWithParam(cmd3, con);
            con.Close();
        }

       private void dgvCTHDNhap_CT_DataError(object sender, DataGridViewDataErrorEventArgs e)
       {
           if( MessageBox.Show("Bạn nhập dữ liệu không đúng ! Vui lòng sửa lại trước khi thực hiện thao tác khác \n Chi tiết lỗi: " + e + "", "Lỗi",MessageBoxButtons.OK)== DialogResult.OK)
           {
               e.Cancel = true;
           }
       }
    }
}

