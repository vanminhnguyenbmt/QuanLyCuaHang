using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public partial class frmMain : Form
    {
        string sMaLoai = "", sTenLoai = "", sUserName = "", sPassWord = "";
        public frmMain()
        {
            InitializeComponent();
            
        }
        public frmMain(string sMaLoai, string sTenLoai, string sUserName, string sPassWord)
        {
            InitializeComponent();
            this.sMaLoai = sMaLoai;
            this.sTenLoai = sTenLoai;
            this.sUserName = sUserName;
            this.sPassWord = sPassWord;
            if(sTenLoai == "KINH DOANH")
            {
                btnQLNCC.Enabled = false;
                btnQLNV.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmQLBH frmQLHDB = new frmQLBH();
            frmQLHDB.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Activate();
            frmLogin.Show();
            this.Enabled = false;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmQLNV frm = new frmQLNV();
            frm.Show();
        }
    }
}
