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
    public partial class frmLogin : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string loginTenLoai;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sUserName = txtUserName.Text;
            string sPassWord = txtPassWord.Text;
            DataTable dtLogin = PhanQuyen_BUS.GetUser(sUserName, sPassWord);
            if (dtLogin.Rows.Count > 0)
            {
                this.Hide();
                //formMain f = new formMain(dtLogin.Rows[0][0].ToString(), dtLogin.Rows[0][1].ToString(), dtLogin.Rows[0][2].ToString(), dtLogin.Rows[0][3].ToString(), dtLogin.Rows[0][4].ToString(), dtLogin.Rows[0][5].ToString());
                loginTenLoai = dtLogin.Rows[0][5].ToString();
                formMain f = new formMain();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tên tài khoản", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if(txtUserName.Text == "Tên đăng nhập")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.White;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if(txtUserName.Text == "")
            {
                txtUserName.Text = "Tên đăng nhập";
                txtUserName.ForeColor = Color.FromArgb(204, 206, 219);
            }
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "Mật khẩu")
            {
                txtPassWord.Text = "";
                txtPassWord.ForeColor = Color.White;
            }
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "")
            {
                txtPassWord.Text = "Mật khẩu";
                txtPassWord.ForeColor = Color.FromArgb(204, 206, 219);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
