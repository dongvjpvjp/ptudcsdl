using System;
using System.Collections.Generic;
using System.ComponentModel;

using CSKH_SALONOTO.Class;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSKH_SALONOTO.QL_NV
{
    public partial class TTNV : Form
    {
        Progress temp1 = new Progress();
        string act = "";
        

        private void bt_them_Click(object sender, EventArgs e)
        {
            //set blank
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_dc.Text = "";
            tb_SDT.Text = "";
            tb_cmnd.Text = "";
            //bat tat nut
            tb_ma.Enabled = true;
            tb_ten.Enabled = true;
            tb_dc.Enabled = true;
            tb_SDT.Enabled = true;
            tb_cmnd.Enabled = true;
            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            dgv_nv.Enabled = false;
            act = "Them";
            // button
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            bt_luu.Enabled = true;
            bt_them.Enabled = false;
            //select
            tb_ma.Select();
        }

    
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (temp1.check(tb_ma.Text) == true)
            {
                if (act == "Them")
                {
                    try
                    {
                        temp1.insert("Insert into NV(Ma_NV,Ten_NV,Sdt_NV,Dc_NV,Cmnd_NV)", "'"+tb_ma.Text+"',", "N'"+tb_ten.Text+"',", "'"+tb_SDT.Text+"',", "N'"+tb_dc.Text+"',", "'"+tb_cmnd.Text+"'");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Thêm mới không thành công lỗi: " + ex.Message);
                    }
                }
                if (act == "Sua")
                {
                    try
                    {
                        string str = "update NV set Ten_NV = N'" + tb_ten.Text + "',Sdt_NV = '" + tb_SDT.Text + "',Dc_NV = N'" + tb_dc.Text + "',Cmnd_NV = '" + tb_cmnd.Text + "'"+ " where Ma_NV = '" + tb_ma.Text + "';";

                        temp1.update(str);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa không thành công lỗi 02: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập sai cú pháp");
            }
            TTNV_Load(sender, e);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có muốn xóa dữ liệu không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    temp1.delete("Delete NV where Ma_NV=", tb_ma.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xoá dữ liệu không thành công lỗi: " + ex.Message);
                }
            }
            dgv_nv.DataSource = temp1.get("select * from NV ");
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            tb_ma.Enabled = false;
            tb_ten.Enabled = true;
            tb_dc.Enabled = true;
            tb_SDT.Enabled = true;
            tb_cmnd.Enabled = true;
            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            dgv_nv.Enabled = false;
            act = "Sua";
            // button
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            bt_luu.Enabled = true;
            bt_them.Enabled = false;
            
           
            
        }

        private void tb_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }

        private void tb_cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            
            string str = "select * from NV where ";
            if (cb_timkiem.Text == "Mã")
            {
                str += "Ma_NV like '%" + tb_timkiem.Text + "%'";
                
            }
            if (cb_timkiem.Text == "Tên")
            {
                str += "Ten_NV like '%" + tb_timkiem.Text + "%'";
            }
            dgv_nv.DataSource = temp1.get(str);
        }

        public TTNV()
        {
            InitializeComponent();
        }

        private void TTNV_Load(object sender, EventArgs e)
        {
            //tb
            cb_timkiem.Text = "Mã";
            tb_ten.Enabled = false;
            tb_ma.Enabled = false;
            tb_dc.Enabled = false;
            tb_SDT.Enabled = false;
            tb_cmnd.Enabled = false;

            tb_timkiem.Enabled = true;
            cb_timkiem.Enabled = true;
            //bt
            bt_luu.Enabled = false;
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;

            // 
            dgv_nv.DataSource = temp1.get("Select * from NV Order by Ma_NV ASC");
            dgv_nv.Enabled = true;
            dgv_nv.Select();

        }

   
        private void dgv_nv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tb_ma.Text = dgv_nv.CurrentRow.Cells[0].Value.ToString().Trim();
                tb_ten.Text = dgv_nv.CurrentRow.Cells[1].Value.ToString().Trim();
                tb_SDT.Text = dgv_nv.CurrentRow.Cells[2].Value.ToString().Trim();
                tb_dc.Text = dgv_nv.CurrentRow.Cells[3].Value.ToString().Trim();
                tb_cmnd.Text = dgv_nv.CurrentRow.Cells[4].Value.ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Đã sắp xếp lại");
            }
        }

       
    }
}
