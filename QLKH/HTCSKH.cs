using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CSKH_SALONOTO.Class;

using System.Windows.Forms;

namespace CSKH_SALONOTO.QLKH
{
    public partial class HTCSKH : Form
    {
        Progress pro = new Progress();
        public string act = "";
       
        public HTCSKH()
        {
            InitializeComponent();
        }

        private void HTCSKH_Load(object sender, EventArgs e)
        {
            cb_timkiem.Text = "Mã";

            // tb enable
            
            tb_ten.Enabled = false;
            tb_ma.Enabled = false;
            tb_mota.Enabled = false;
            tb_timkiem.Enabled = true;
            cb_timkiem.Enabled = true;
            // bt
            bt_luu.Enabled = false;
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            //
            dgv_ht.Select();
            dgv_ht.Enabled = true;
            dgv_ht.DataSource = pro.get("Select * from Hinhthuc_CSKH order by Ma_HT ASC");
        }

        private void dgv_ht_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tb_ma.Text = dgv_ht.CurrentRow.Cells[0].Value.ToString().Trim();
                tb_ten.Text = dgv_ht.CurrentRow.Cells[1].Value.ToString().Trim();
                tb_mota.Text = dgv_ht.CurrentRow.Cells[2].Value.ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Đã sắp xếp lại");
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            string str = "Select * From Hinhthuc_CSKH Where ";

            if (cb_timkiem.Text == "Mã")
            {
                str += "Ma_HT like '%" + tb_timkiem.Text + "%'";
                
            }
            else if (cb_timkiem.Text == "Tên")
            {
                str += "Ten_HT like '%" + tb_timkiem.Text + "%'";
            }
            dgv_ht.DataSource = pro.get(str);
        }
        public bool check()
        {
            if (tb_ma.Text == "")
            { return false; }
            if (tb_ma.Text.Contains(" "))
            { return false; }
            return true;

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            //set blank
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_mota.Text = "";
            //bat tat nut
            tb_ma.Enabled = true;
            tb_ten.Enabled = true; 
            tb_mota.Enabled = true;
            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            dgv_ht.Enabled = false;
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
            if (pro.check(tb_ma.Text) == true)
            {
                if (act == "Them")
                {
                    try
                    {
                        pro.insert("INSERT INTO Hinhthuc_CSKH (Ma_HT,Ten_HT,Mota_HT) ", "'"+tb_ma.Text.Trim()+"',", "N'"+tb_ten.Text.Trim()+"',","N'"+ tb_mota.Text.Trim()+"'");
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
                        string str = "update Hinhthuc_CSKH set Ten_HT = N'" + tb_ten.Text + "',Mota_HT = N'" + tb_mota.Text + "' where Ma_HT = '" + tb_ma.Text + "';";

                        pro.update(str);
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
            HTCSKH_Load(sender, e);

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

            DialogResult msb = MessageBox.Show("Bạn có muốn xóa dữ liệu này hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msb == DialogResult.Yes)
            {
                try
                {
                    pro.delete("Delete Hinhthuc_CSKH Where Ma_HT=", tb_ma.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công lỗi: " + ex.Message);
                }
            }
            HTCSKH_Load(sender, e);
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            tb_ma.Enabled = false;
            tb_ten.Enabled = true;
            tb_mota.Enabled = true;
            tb_timkiem.Enabled = false;
            cb_timkiem.Enabled = false;
            act = "Sua";
            // button
            bt_them.Enabled = false;
            dgv_ht.Enabled = false;
            bt_xoa.Enabled = false;
            bt_luu.Enabled = true;
            bt_sua.Enabled = false;
            //select
        }
    }
}
