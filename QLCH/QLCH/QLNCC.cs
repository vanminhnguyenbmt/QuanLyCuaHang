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
        }

        private void LoadDgvNhacungcap()
        {
            List<Nhacungcap_DTO> lstncc = Nhacungcap_BUS.LoadNhacungcap();

            dgvncc.DataSource = lstncc;
        }
    }
}
