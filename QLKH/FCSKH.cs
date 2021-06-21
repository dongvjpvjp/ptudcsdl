using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSKH_SALONOTO.Class;
using CSKH_SALONOTO.QLKH;

namespace CSKH_SALONOTO.QLKH
{
    public partial class FCSKH : Form
    {
        Progress temp1 = new Progress();
        string act = "";
        public FCSKH()
        {
            InitializeComponent();
        }

        private void FCSKH_Load(object sender, EventArgs e)
        {
            // KH
            cb_kh.DataSource = temp1.get("Select Ma_KH,Ten_KH from KH");
            cb_kh.DisplayMember = "Ten_KH";
            cb_kh.ValueMember = "Ma_KH";
            cb_kh_SelectedIndexChanged(sender, e);

            cb_kh.Enabled = false;
            cb_xe.Enabled = false;
            tb_nd.Enabled = false;
            tb_ma.Enabled = false;
            dtp_ngaylap.Enabled = false;
            dtp_ngaylap.CustomFormat = "yyyy/MM/dd";
            tb_tinhtrang.Enabled = false; 
            tb_timkiem.Enabled = true;
            cb_timkiem.Text = "Mã phiếu";
            cb_timkiem.Enabled = true;
            // bt
            bt_luu.Enabled = false;
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            //
            dgv_fcskh.Select();
            dgv_fcskh.Enabled = true;
            dgv_fcskh.DataSource = temp1.get("Select * from View_FCSKH order by Ma_FCSKH ASC");


        }

        private void cb_kh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select Ma_XE,Ten_XE from View_XEKH where Ma_KH='";
            str += cb_kh.SelectedValue.ToString()+"';";
            cb_xe.DataSource = temp1.get(str);
            cb_xe.DisplayMember = "Ten_XE";
            cb_xe.ValueMember = "Ma_XE";
           
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            string str = "Select * from View_FCSKH where ";

            if (cb_timkiem.Text == "Mã phiếu")
            {
                str += "Ma_FCSKH like '%" + tb_timkiem.Text + "%';";

            }
            if (cb_timkiem.Text == "Khách hàng")
            {
                str += "Ten_KH like '%" + tb_timkiem.Text + "%';";
            }
            

            dgv_fcskh.DataSource = temp1.get(str);
        }

        private void dgv_fcskh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tb_ma.Text = dgv_fcskh.CurrentRow.Cells[0].Value.ToString().Trim();
                cb_kh.Text = dgv_fcskh.CurrentRow.Cells[1].Value.ToString().Trim();
                cb_xe.Text = dgv_fcskh.CurrentRow.Cells[2].Value.ToString().Trim();
                tb_nd.Text = dgv_fcskh.CurrentRow.Cells[3].Value.ToString().Trim();
                //mtb_ngaylap.Text = dgv_fcskh.CurrentRow.Cells[4].Value.ToString();  
                dtp_ngaylap.Text = dgv_fcskh.CurrentRow.Cells[4].Value.ToString();
                tb_tinhtrang.Text = dgv_fcskh.CurrentRow.Cells[5].Value.ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Đã sắp xếp lại");
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            //set blank
            tb_ma.Text = "";
            cb_kh.Text = "";
            cb_xe.Text = "";
            tb_nd.Text = "";
            tb_tinhtrang.Text = "";
            dtp_ngaylap.Text = "";
            //bat tat nut
            cb_kh.Enabled = true;
            cb_xe.Enabled = true;
            tb_nd.Enabled = true;
            tb_ma.Enabled = true;
            dtp_ngaylap.Enabled = true;
            tb_tinhtrang.Enabled = true;
            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            // bt
            bt_luu.Enabled = true;
            bt_them.Enabled = false;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            act = "Them";
            dgv_fcskh.Enabled = false;
            //select
            
        }

     
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (temp1.check(tb_ma.Text) == true)
            {
                if (act == "Them")
                {
                    try
                    {
                        temp1.insert("Insert into FCSKH(Ma_FCSKH,Ma_KH,Ma_XE,ND_FCSKH,Ngaylap_FCSKH,Tinhtrang_FCSKH)", "'"+tb_ma.Text+"',","'"+cb_kh.SelectedValue.ToString()+"',","'"+cb_xe.SelectedValue.ToString()+"',","N'"+tb_nd.Text+"',","'" + dtp_ngaylap.Text + "',","N'"+tb_tinhtrang.Text+"'");
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
                        string str = "update FCSKH set Ma_KH = '" + cb_kh.SelectedValue.ToString() + "',Ma_XE = '" + cb_xe.SelectedValue.ToString() + "',Nd_FCSKH = N'" + tb_nd.Text + "',Ngaylap_FCSKH = '" + dtp_ngaylap.Text + "',Tinhtrang_FCSKH = N'" + tb_tinhtrang.Text + "' where Ma_FCSKH = '" + tb_ma.Text + "';";
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
            FCSKH_Load(sender, e);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có muốn xóa dữ liệu không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    temp1.delete("Delete FCSKH where Ma_FCSKH=", tb_ma.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoá dữ liệu không thành công lỗi: " + ex.Message);
                }
            }
            dgv_fcskh.DataSource = temp1.get("select * from View_FCSKH ");
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            
            //bat tat nut
            cb_kh.Enabled = true;
            cb_xe.Enabled = true;
            tb_nd.Enabled = true;
            tb_ma.Enabled = false;
            dtp_ngaylap.Enabled = true;
            tb_tinhtrang.Enabled = true;
            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            // bt
            bt_luu.Enabled = true;
            bt_them.Enabled = false;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            act = "Sua";
            dgv_fcskh.Enabled = false;
            //
        }

        private void cb_kh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_xe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgv_fcskh_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FCSKHCT ct = new FCSKHCT();
            ct.temp_ma = tb_ma.Text;
            ct.ShowDialog();
        }
    }
}
