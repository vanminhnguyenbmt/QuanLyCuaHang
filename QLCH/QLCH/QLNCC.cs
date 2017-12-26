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
using System.Data.SqlClient;
using System.Data;

namespace QLCH
{
    public partial class QLNCC : Form
    {
        public QLNCC()
        {
            InitializeComponent();
        }

        private void QLNCC_Load(object sender, EventArgs e)
        {
            LoadDgvNhacungcap();
            try
            {
                Nhacungcap_BUS x = new Nhacungcap_BUS();
                txtmancc.Text = x.XuLyMaNCC();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadDgvNhacungcap()
        {
            List<Nhacungcap_DTO> lstncc = Nhacungcap_BUS.LoadNhacungcap();

            dgvncc.DataSource = lstncc;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
