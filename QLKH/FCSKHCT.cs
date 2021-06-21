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
    public partial class FCSKHCT : Form
    {
        //xảy ra khi double click content trong dgv FCSKH
        Progress temp1 = new Progress();
        string act = "";
        public string temp_ma;

        public FCSKHCT()
        {
            InitializeComponent();
        }

       

        private void FCSKHCT_Load(object sender, EventArgs e)
        {
            string str = "select Ma_FCSKHCT,Ten_NV,Ten_HT,Nd_FCSKHCT,Ngayhen_FCSKHT,StartTime_FCSKHCT,FinishTime_FCSKHCT from View_FCSKHCT where Ma_FCSKH='" + temp_ma+"';";
            // KH
            tb_ma.Text = temp_ma;

            cb_nv.DataSource = temp1.get("Select Ma_NV,Ten_NV from NV");
            cb_nv.DisplayMember = "Ten_NV";
            cb_nv.ValueMember = "Ma_NV";

            cb_ht.DataSource = temp1.get("Select Ma_HT,Ten_HT from Hinhthuc_CSKH");
            cb_ht.DisplayMember = "Ten_HT";
            cb_ht.ValueMember = "Ma_HT";

            tb_ct.Enabled = false;
            cb_ht.Enabled = false;
            cb_nv.Enabled = false;
            tb_nd.Enabled = false;
            tb_ma.Enabled = false;

            dtp_ngaylap.Enabled = false;
            dtp_ngaylap.CustomFormat = "yyyy/MM/dd";
            dtp_start.Enabled = false;
            dtp_start.CustomFormat = "yyyy/MM/dd HH:mm";
            dtp_end.Enabled = false;
            dtp_end.CustomFormat = "yyyy/MM/dd HH:mm";

            tb_timkiem.Enabled = true;
            cb_timkiem.Text = "Mã";
            cb_timkiem.Enabled = true;
            // bt
            bt_luu.Enabled = false;
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            //
            dgv_fcskhct.Select();
            dgv_fcskhct.Enabled = true;
            dgv_fcskhct.DataSource = temp1.get(str);


        }

        private void cb_xe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_ht_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgv_fcskhct_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tb_ct.Text = dgv_fcskhct.CurrentRow.Cells[0].Value.ToString().Trim();
                cb_nv.Text = dgv_fcskhct.CurrentRow.Cells[1].Value.ToString().Trim();
                cb_ht.Text = dgv_fcskhct.CurrentRow.Cells[2].Value.ToString().Trim();
                tb_nd.Text = dgv_fcskhct.CurrentRow.Cells[3].Value.ToString().Trim();
                dtp_ngaylap.Text = dgv_fcskhct.CurrentRow.Cells[4].Value.ToString();
                dtp_start.Text = dgv_fcskhct.CurrentRow.Cells[5].Value.ToString();
                dtp_end.Text = dgv_fcskhct.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Đã sắp xếp lại");
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            string str = "select Ma_FCSKHCT,Ten_NV,Ten_HT,Nd_FCSKHCT,Ngayhen_FCSKHT,StartTime_FCSKHCT,FinishTime_FCSKHCT from View_FCSKHCT where (Ma_FCSKH='" + temp_ma + "' and ";

            if (cb_timkiem.Text == "Mã")
            {
                str += "Ma_FCSKHCT like '%" + tb_timkiem.Text + "%');";

            }
            if (cb_timkiem.Text == "Hình thức")
            {
                str += "Ten_HT like '%" + tb_timkiem.Text + "%');";
            }
            if (cb_timkiem.Text == "Ngày hẹn")
            {
                str += "Ngayhen_FCSKHT like '%" + tb_timkiem.Text + "%');";
            }

            dgv_fcskhct.DataSource = temp1.get(str);
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            //set blank
            tb_ct.Text = "";
            cb_nv.Text = "";
            cb_ht.Text = "";
            tb_nd.Text = "";
            
            dtp_ngaylap.Text = "";
            dtp_start.Text = "";
            dtp_end.Text = "";
            //bat tat nut
            cb_nv.Enabled = true;
            cb_ht.Enabled = true;
            tb_nd.Enabled = true;
            tb_ct.Enabled = true;

            dtp_ngaylap.Enabled = true;
            dtp_start.Enabled = true;
            dtp_end.Enabled = true;


            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            // bt
            bt_luu.Enabled = true;
            bt_them.Enabled = false;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            act = "Them";
            dgv_fcskhct.Enabled = false;
            //select
            tb_ct.Select();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (temp1.check(tb_ct.Text) == true)
            {
                if (act == "Them")
                {
                    try
                    {
                        temp1.insert("Insert into FCSKHCT(Ma_FCSKHCT,Ma_FCSKH,Nd_FCSKHCT,Ngayhen_FCSKHT,Ma_HT,Ma_NV,StartTime_FCSKHCT,FinishTime_FCSKHCT)", "'"+tb_ct.Text+"',","'"+temp_ma+"',","N'"+tb_nd.Text+"',","'"+dtp_ngaylap.Text+"',","'"+cb_ht.SelectedValue.ToString()+"',", "'"+cb_nv.SelectedValue.ToString()+"',","'"+ dtp_start.Text+"',", "'"+dtp_end.Text+"'");
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
                        string str= "update FCSKHCT set Ma_HT = '"+cb_ht.SelectedValue.ToString()+"',Ma_NV = '"+cb_nv.SelectedValue.ToString()+"',Nd_FCSKHCT = N'"+tb_nd.Text+ "',Ngayhen_FCSKHT = '"+dtp_ngaylap.Text+"',StartTime_FCSKHCT = '"+dtp_start.Text+"',FinishTime_FCSKHCT = '"+dtp_end.Text+"' where Ma_FCSKHCT = '"+tb_ct.Text+"';";

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
            FCSKHCT_Load(sender, e);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có muốn xóa dữ liệu không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string str = "Delete FCSKHCT where Ma_FCSKH='" + temp_ma + "' and Ma_FCSKHCT=";
            if (dr == DialogResult.Yes)
            {
                try
                {
                    temp1.delete(str, tb_ct.Text+"");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoá dữ liệu không thành công lỗi: " + ex.Message);
                }
            }
            string str1 = "select Ma_FCSKHCT,Ten_NV,Ten_HT,Nd_FCSKHCT,Ngayhen_FCSKHT,StartTime_FCSKHCT,FinishTime_FCSKHCT from View_FCSKHCT where Ma_FCSKH='" + temp_ma + "';";
            dgv_fcskhct.DataSource = temp1.get(str1);
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            cb_nv.Enabled = true;
            cb_ht.Enabled = true;
            tb_nd.Enabled = true;
            tb_ct.Enabled = false;

            dtp_ngaylap.Enabled = true;
            dtp_start.Enabled = true;
            dtp_end.Enabled = true;

            dgv_fcskhct.Enabled = false;
            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            // bt
            bt_luu.Enabled = true;
            bt_them.Enabled = false;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            act = "Sua";
        }
    }
}
