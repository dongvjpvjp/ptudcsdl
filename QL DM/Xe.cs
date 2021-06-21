using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using CSKH_SALONOTO.Class;
using System.Windows.Forms;

namespace CSKH_SALONOTO.QL_DM
{
    public partial class Xe : Form
    {
       Progress pro = new Progress();
        public string act = "";
        
        public Xe()
        {
            InitializeComponent();
        }

        private void Xe_Load(object sender, EventArgs e)
        { 
            cb_ma.DataSource = pro.get("Select Ma_NCC,Ten_NCC from NCC");
            cb_ma.DisplayMember = "Ten_NCC";
            cb_ma.ValueMember = "Ma_NCC";
            cb_timkiem.Text = "Nhà cung cấp";
            
            // tb enable
            cb_ma.Enabled = false;
            tb_ten.Enabled = false;
            tb_ma.Enabled = false;
            tb_mota.Enabled = false;
            tb_giatri.Enabled = false;
            tb_timkiem.Enabled = true;
            cb_timkiem.Enabled = true;
            // bt
            bt_luu.Enabled = false;
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            //
            dgv_xe.Select();
            dgv_xe.Enabled = true;
            dgv_xe.DataSource = pro.get("Select * from View_XE order by ma_Xe ASC");



        }

        private void dgv_xe_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tb_ma.Text = dgv_xe.CurrentRow.Cells[0].Value.ToString().Trim();
                tb_ten.Text = dgv_xe.CurrentRow.Cells[1].Value.ToString().Trim();
                cb_ma.Text = dgv_xe.CurrentRow.Cells[2].Value.ToString().Trim();
                tb_giatri.Text = dgv_xe.CurrentRow.Cells[3].Value.ToString().Trim();
                tb_mota.Text = dgv_xe.CurrentRow.Cells[4].Value.ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Đã sắp xếp lại");
            }
        }
        

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            string str = "Select * from View_Xe where ";
            if (cb_timkiem.Text == "Mã xe")
            {
                str += "Ma_Xe like '%" + tb_timkiem.Text + "%';";
                
            }
            if (cb_timkiem.Text == "Tên xe")
            {
                str += "Ten_XE like '%" + tb_timkiem.Text + "%';";
            }
            else if (cb_timkiem.Text == "Nhà cung cấp")
            {
                str += "Ten_NCC like '%" + tb_timkiem.Text + "%';";
            }

            dgv_xe.DataSource = pro.get(str);
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            tb_ten.Text = "";
            tb_ma.Text = "";
            tb_mota.Text = "";
            tb_giatri.Text = "";
            cb_ma.Select();
            // tb enable
            cb_ma.Enabled = true;
            tb_ten.Enabled = true;
            tb_ma.Enabled = true;
            tb_mota.Enabled = true;
            tb_giatri.Enabled = true;
            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            // bt
            bt_luu.Enabled = true;
            bt_them.Enabled = false;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            act = "Thêm";
            dgv_xe.Enabled = false;


        }

     
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (pro.check(tb_ma.Text) == true)
            {
                if (act == "Thêm")
                {
                    try
                    {
                        pro.insert("Insert into XE(Ma_Xe,Ten_XE,Ma_NCC,Giatri_XE,Mota_XE)", "'"+tb_ma.Text+"',", "N'"+tb_ten.Text.Trim()+"',","'"+cb_ma.SelectedValue.ToString()+"',", "'"+tb_giatri.Text.Trim()+"',", "N'"+tb_mota.Text.Trim()+"'");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm mới không thành công lỗi: " + ex.Message);
                    }
                }
                if (act == "Sửa")
                {
                    try
                    {
                        string str = "update XE set Ten_XE = N'" + tb_ten.Text + "',Giatri_XE = '" + tb_giatri.Text + "',Mota_XE = N'" + tb_mota.Text + "',Ma_NCC = '" + cb_ma.SelectedValue.ToString() + "' where Ma_XE = '" + tb_ma.Text + "';";

                        pro.update(str);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa không thành công lỗi: " + ex.Message);
                    }
                }
            }
            else if (pro.check(tb_ma.Text) == false)
            {
                MessageBox.Show("Bạn nhập sai cú pháp");
            }
                Xe_Load(sender, e);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            var dbr = MessageBox.Show("Bạn có muốn xóa dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dbr == DialogResult.Yes)
            {
                try
                {
                    pro.delete("Delete XE where Ma_Xe =", tb_ma.Text);
                }
                catch
                {
                    MessageBox.Show("Xóa dữ liệu không thành công");
                }
            }
            Xe_Load(sender, e);

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            // tb enable
            tb_ma.Enabled = false;
            cb_ma.Enabled = true;
            tb_ten.Enabled = true;
            tb_mota.Enabled = true;
            tb_giatri.Enabled = true;
            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            // bt
            bt_luu.Enabled = true; ;
            bt_them.Enabled = false;
            dgv_xe.Enabled = false;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            act = "Sửa";
            
        }

        private void tb_giatri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }

        private void cb_ma_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
