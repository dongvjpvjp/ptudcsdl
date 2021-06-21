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
    public partial class NCC : Form
    {
        public string act = "";
        Progress temp = new Progress();
        
        public NCC()
        {
            InitializeComponent();
        }

        private void NCC_Load(object sender, EventArgs e)
        {
            
            cb_timkiem.Text = "Mã";
            dgv_ncc.DataSource = temp.get("Select * From NCC Order by Ma_NCC ASC");
            tb_ma.Enabled = false;
            tb_ten.Enabled = false;
            tb_DC.Enabled = false;
            tb_SDT.Enabled = false;
            tb_mota.Enabled = false;
            tb_timkiem.Enabled = true;
            cb_timkiem.Enabled = true;
            dgv_ncc.Enabled = true;
            //button
            bt_luu.Enabled = false;
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            //
            dgv_ncc.Select();
            dgv_ncc.Enabled = true;
           
        }

       
   
        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            string str = "Select * From NCC Where ";
            
            if (cb_timkiem.Text == "Mã")
            {
                str += "Ma_NCC like '%" + tb_timkiem.Text + "%'";
                dgv_ncc.DataSource = temp.get(str);
            }
            else if (cb_timkiem.Text == "Tên")
            {
                str += "Ten_NCC like '%" + tb_timkiem.Text + "%'";
                dgv_ncc.DataSource = temp.get(str);
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {   
            //set blank
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_DC.Text = "";
            tb_SDT.Text = "";
            tb_mota.Text = "";
            //bat tat nut
            tb_ma.Enabled = true;
            tb_ten.Enabled = true;
            tb_DC.Enabled = true;
            tb_SDT.Enabled = true;
            tb_mota.Enabled = true;
            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            dgv_ncc.Enabled = false;
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
            

            if (temp.check(tb_ma.Text) == true)
            {
                if (act == "Them")
                {
                    try
                    {
                        temp.insert("INSERT INTO NCC(Ma_NCC,Ten_NCC,Dc_NCC,Sdt_NCC,Mota_NCC ) ", "'"+tb_ma.Text+"',", "N'"+tb_ten.Text+"',", "N'"+tb_DC.Text.Trim()+ "',", "'"+tb_SDT.Text+"',", "N'"+tb_mota.Text+"'");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm mới không thành công lỗi: " + ex.Message);
                    }


                }
                else if (act == "Sua")
                {
                    try
                    {
                        string str = "update NCC set Ten_NCC = N'" + tb_ten.Text + "',Dc_NCC = N'" + tb_DC.Text + "',Mota_NCC = N'" + tb_mota.Text + "',Sdt_NCC = '" + tb_SDT.Text + "' where Ma_NCC = '" + tb_ma.Text + "';";

                        temp.update(str);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa dữ liệu không thành công lỗi 01:" + ex.Message);
                    }
                }
            }

            else
            {
                MessageBox.Show("Bạn đã nhập sai cú pháp");
            }
            NCC_Load(sender, e);
        
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            
            DialogResult msb = MessageBox.Show("Bạn có muốn xóa dữ liệu này hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msb == DialogResult.Yes)
            {
                try
                {
                    temp.delete("Delete NCC Where Ma_NCC=", tb_ma.Text);
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xóa không thành công lỗi: " + ex.Message);
                }
            }
            NCC_Load(sender, e);

        }

      

        private void dgv_ncc_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tb_ma.Text = dgv_ncc.CurrentRow.Cells[0].Value.ToString().Trim();
                tb_ten.Text = dgv_ncc.CurrentRow.Cells[1].Value.ToString().Trim();
                tb_DC.Text = dgv_ncc.CurrentRow.Cells[2].Value.ToString().Trim();
                tb_SDT.Text = dgv_ncc.CurrentRow.Cells[3].Value.ToString().Trim();
                tb_mota.Text = dgv_ncc.CurrentRow.Cells[4].Value.ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Đã sắp xếp lại");
            }
            
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
                tb_ma.Enabled = false;
                tb_ten.Enabled = true;
                tb_DC.Enabled = true;
                tb_SDT.Enabled = true;
                tb_mota.Enabled = true;
                tb_timkiem.Enabled = false;
                cb_timkiem.Enabled = false;
                act = "Sua";
                // button
                bt_them.Enabled = false;
                dgv_ncc.Enabled = false;
                bt_xoa.Enabled = false;
                bt_luu.Enabled = true;
                bt_sua.Enabled = false;
                //select
                tb_ma.Select();
                //sửa = xóa + thêm
            }

        private void tb_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }
    }

        
    }

    

