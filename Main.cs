using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CSKH_SALONOTO.QL_DM;
using CSKH_SALONOTO.QL_NV;
using CSKH_SALONOTO.QLKH;
using System.Windows.Forms;

namespace CSKH_SALONOTO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýTàiKhoảnNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cầuHìnhHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saoLưuDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NCC ncc = new NCC();
            ncc.ShowDialog();
        }

        private void danhMụcXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xe xe = new Xe();
            xe.ShowDialog();

        }

        private void quảnLýThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTNV nv = new TTNV();
            nv.ShowDialog();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTKH kh = new TTKH();
            kh.ShowDialog();
        }

        private void phiếuChămSócKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCSKH f = new FCSKH();
            f.ShowDialog();
        }

        private void hìnhThứcChămSócKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HTCSKH ht = new HTCSKH();
            ht.ShowDialog();
        }
    }
}

        

    
       


        
    
