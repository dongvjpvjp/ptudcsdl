using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSKH_SALONOTO.Class;

namespace CSKH_SALONOTO.QLKH
{
    public partial class TTKH : Form
    {
        Progress temp1 = new Progress();
        public string act = "";
        
        public TTKH()
        {
            InitializeComponent();
        }

        private void TTKH_Load(object sender, EventArgs e)
        {
            cb_xe.DataSource = temp1.get("Select Ma_Xe,Ten_XE from XE");
            cb_xe.DisplayMember = "Ten_XE";
            cb_xe.ValueMember = "Ma_Xe";
            cb_timkiem.Text = "Xe";

            // tb enable
            cb_xe.Enabled = false;
            tb_ten.Enabled = false;
            tb_ma.Enabled = false;
            tb_dc.Enabled = false;
            tb_SDT.Enabled = false;
            tb_cmnd.Enabled = false;
            tb_timkiem.Enabled = true;
            cb_timkiem.Enabled = true;
            // bt
            bt_luu.Enabled = false;
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            //
            dgv_kh.Select();
            dgv_kh.Enabled = true;
            dgv_kh.DataSource = temp1.get("Select * from View_KH order by Ma_KH ASC");

        }

        private void dgv_kh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tb_ma.Text = dgv_kh.CurrentRow.Cells[0].Value.ToString().Trim();
                tb_ten.Text = dgv_kh.CurrentRow.Cells[1].Value.ToString().Trim();
                cb_xe.Text = dgv_kh.CurrentRow.Cells[2].Value.ToString().Trim();
                tb_SDT.Text = dgv_kh.CurrentRow.Cells[3].Value.ToString().Trim();
                tb_dc.Text = dgv_kh.CurrentRow.Cells[4].Value.ToString().Trim();
                tb_cmnd.Text = dgv_kh.CurrentRow.Cells[5].Value.ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Đã sắp xếp lại");
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            string str = "Select * from View_KH where ";

            if (cb_timkiem.Text == "Mã")
            {
                str += "Ma_KH like '%" + tb_timkiem.Text + "%';";

            }
            if (cb_timkiem.Text == "Tên")
            {
                str += "Ten_KH like '%" + tb_timkiem.Text + "%';";
            }
            else if (cb_timkiem.Text == "Xe")
            {
                str += "Ten_xE like '%" + tb_timkiem.Text + "%';";
            }

            dgv_kh.DataSource = temp1.get(str);
        }

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
            cb_xe.Enabled = true;
            tb_SDT.Enabled = true;
            tb_cmnd.Enabled = true;
            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            dgv_kh.Enabled = false;
            act = "Them";
            // button
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            bt_luu.Enabled = true;
            bt_them.Enabled = false;
            //select
            tb_ma.Select();
        }

        private void tb_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }

        private void cb_xe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }

     

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (temp1.check(tb_ma.Text) == true)
            {
                if (act == "Them")
                {
                    try
                    {
                        temp1.insert("Insert into KH(Ma_KH,Ten_KH,Dt_KH,Dc_KH,Cmnd_KH,Ma_XE)", "'"+tb_ma.Text+"',", "N'"+tb_ten.Text+"',", "'"+tb_SDT.Text+"',", "N'"+tb_dc.Text+"',", "'"+tb_cmnd.Text+"',","'"+cb_xe.SelectedValue.ToString()+"'");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm mới không thành công lỗi: " + ex.Message);
                    }
                }
                if (act == "Sua")
                {
                    try
                    {
                        string str = "update KH set Ten_KH = N'" + tb_ten.Text + "',Dt_KH = '" + tb_SDT.Text + "',Dc_KH = N'" + tb_dc.Text + "',Cmnd_KH = '" + tb_cmnd.Text + "',Ma_XE = '" + cb_xe.SelectedValue.ToString() + "' where Ma_KH = '" + tb_ma.Text + "';";
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
            TTKH_Load(sender, e);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có muốn xóa dữ liệu không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    temp1.delete("Delete KH where Ma_KH=", tb_ma.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoá dữ liệu không thành công lỗi: " + ex.Message);
                }
            }
            dgv_kh.DataSource = temp1.get("select * from View_KH ");
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            tb_ma.Enabled = false;
            tb_ten.Enabled = true;
            tb_dc.Enabled = true;
            tb_SDT.Enabled = true;
            cb_xe.Enabled = true;
            tb_cmnd.Enabled = true;
            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            dgv_kh.Enabled = false;
            act = "Sua";
            // button
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            bt_luu.Enabled = true;
            bt_them.Enabled = false;
            //select
          
        }
    }
}
