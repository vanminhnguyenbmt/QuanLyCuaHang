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
    public partial class QLSP : Form
    {
        public QLSP()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void QLSP_Load(object sender, EventArgs e)
        {
            LoadDgvSanPham();
        }
        private void LoadDgvSanPham()
        {
            List<Sanpham_DTO> lstSanpham = Sanpham_BUS.LoadSanpham();
            
            dgvdmsp.DataSource   = lstSanpham;
        }

       
    }
}
