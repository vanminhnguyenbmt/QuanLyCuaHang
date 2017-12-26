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
    public partial class frmQLBH : Form
    {
        static AutoCompleteStringCollection DataCollectionTen = new AutoCompleteStringCollection();
        static AutoCompleteStringCollection DataCollectionMa = new AutoCompleteStringCollection();
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
            ChangeState(true);
        }

        private void frmQLBH_Load(object sender, EventArgs e)
        {
            txtTenNV.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenNV.AutoCompleteSource = AutoCompleteSource.CustomSource;
            getData(DataCollectionTen);
            txtTenNV.AutoCompleteCustomSource = DataCollectionTen;
            ChangeState(false);
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

        private string[] GetKeyWord(string sText)
        {
            DataTable tblTenNV = Nhanvien_BUS.LoadTenNV();
            string[] items = new string[tblTenNV.Rows.Count];
            int i = 0;
            foreach (DataRow dr in tblTenNV.Rows)
            {
                items.SetValue(dr["TENNV"].ToString(), i);
                i++;
            }
            return items;
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

        private void ChangeState(bool bState)
        {
            txtTenNV.Enabled = bState;
            dtpNgayban.Enabled = bState;
            txtTenKH.Enabled = bState;
            txtDiachi.Enabled = bState;
            txtSDT.Enabled = bState;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            ChangeState(true);
            Reset();
            txtMaHD.Text = TuDongTangMaNV();
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

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            ChangeState(false);
        }

        private string TuDongTangMaNV()
        {
            DataTable tblHoadon = HoadonBan_BUS.LoadTop1HDB();
            string sMaHDB = tblHoadon.Rows[0][0].ToString();
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
    }
}
