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




namespace QLCH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void button12_Click(object sender, EventArgs e)
        {
            QLSP f = new QLSP();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DMSP dmsp = new DMSP();
            dmsp.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            QLNCC qlncc = new QLNCC();
            qlncc.Show();
=======
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmQLNV frm = new frmQLNV();
            frm.Show();
>>>>>>> Thien_conflict
        }
    }
}
