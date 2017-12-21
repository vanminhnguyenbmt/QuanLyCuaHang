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
using BUS;

namespace QLCH
{
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            // load du lieu datagridview
            LoadDgvNhanvien();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LoadDgvNhanvien()
        {
            DataTable tblNhanvien = Nhanvien_BUS.LoadNhanvien();
            dgvLoadNV.DataSource = tblNhanvien;
        }
    }
}
