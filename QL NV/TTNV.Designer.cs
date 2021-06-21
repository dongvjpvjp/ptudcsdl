namespace CSKH_SALONOTO.QL_NV
{
    partial class TTNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.cb_timkiem = new System.Windows.Forms.ComboBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.dgv_nv = new System.Windows.Forms.DataGridView();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.tb_cmnd = new System.Windows.Forms.TextBox();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.tb_dc = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.lb_list = new System.Windows.Forms.Label();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.lb_headline = new System.Windows.Forms.Label();
            this.lb_mota = new System.Windows.Forms.Label();
            this.lb_cmnd = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_ma = new System.Windows.Forms.Label();
            this.Ma_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dc_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmnd_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(689, 270);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 45);
            this.bt_luu.TabIndex = 52;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(487, 267);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 26);
            this.bt_sua.TabIndex = 50;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(390, 267);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 26);
            this.bt_them.TabIndex = 49;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // cb_timkiem
            // 
            this.cb_timkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timkiem.FormattingEnabled = true;
            this.cb_timkiem.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cb_timkiem.Location = new System.Drawing.Point(314, 267);
            this.cb_timkiem.Name = "cb_timkiem";
            this.cb_timkiem.Size = new System.Drawing.Size(47, 21);
            this.cb_timkiem.TabIndex = 48;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(584, 267);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 26);
            this.bt_xoa.TabIndex = 51;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // dgv_nv
            // 
            this.dgv_nv.AllowUserToAddRows = false;
            this.dgv_nv.AllowUserToDeleteRows = false;
            this.dgv_nv.AllowUserToResizeRows = false;
            this.dgv_nv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_NV,
            this.Ten_NV,
            this.Sdt_NV,
            this.Dc_NV,
            this.Cmnd_NV});
            this.dgv_nv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_nv.Location = new System.Drawing.Point(6, 321);
            this.dgv_nv.MultiSelect = false;
            this.dgv_nv.Name = "dgv_nv";
            this.dgv_nv.ReadOnly = true;
            this.dgv_nv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nv.Size = new System.Drawing.Size(768, 209);
            this.dgv_nv.TabIndex = 47;
            this.dgv_nv.SelectionChanged += new System.EventHandler(this.dgv_nv_SelectionChanged);
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(195, 267);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(110, 20);
            this.tb_timkiem.TabIndex = 46;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // tb_cmnd
            // 
            this.tb_cmnd.Location = new System.Drawing.Point(487, 121);
            this.tb_cmnd.Name = "tb_cmnd";
            this.tb_cmnd.Size = new System.Drawing.Size(208, 20);
            this.tb_cmnd.TabIndex = 45;
            this.tb_cmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cmnd_KeyPress);
            // 
            // tb_SDT
            // 
            this.tb_SDT.Location = new System.Drawing.Point(487, 75);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(208, 20);
            this.tb_SDT.TabIndex = 44;
            this.tb_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SDT_KeyPress);
            // 
            // tb_dc
            // 
            this.tb_dc.Location = new System.Drawing.Point(195, 186);
            this.tb_dc.Multiline = true;
            this.tb_dc.Name = "tb_dc";
            this.tb_dc.Size = new System.Drawing.Size(500, 75);
            this.tb_dc.TabIndex = 43;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(195, 132);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(110, 20);
            this.tb_ten.TabIndex = 42;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(195, 78);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(110, 20);
            this.tb_ma.TabIndex = 41;
            // 
            // lb_list
            // 
            this.lb_list.AutoSize = true;
            this.lb_list.Location = new System.Drawing.Point(3, 301);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(112, 13);
            this.lb_list.TabIndex = 40;
            this.lb_list.Text = "Danh sách nhân viên:";
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(110, 270);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(65, 17);
            this.lb_timkiem.TabIndex = 39;
            this.lb_timkiem.Text = "Tìm Kiếm:";
            // 
            // lb_headline
            // 
            this.lb_headline.AutoSize = true;
            this.lb_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_headline.Location = new System.Drawing.Point(189, 14);
            this.lb_headline.Name = "lb_headline";
            this.lb_headline.Size = new System.Drawing.Size(527, 33);
            this.lb_headline.TabIndex = 38;
            this.lb_headline.Text = "Quản Lý Thông Tin Nhân Viên CSKH";
            // 
            // lb_mota
            // 
            this.lb_mota.AutoSize = true;
            this.lb_mota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mota.Location = new System.Drawing.Point(110, 206);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(50, 17);
            this.lb_mota.TabIndex = 37;
            this.lb_mota.Text = "Địa chỉ:";
            // 
            // lb_cmnd
            // 
            this.lb_cmnd.AutoSize = true;
            this.lb_cmnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cmnd.Location = new System.Drawing.Point(385, 124);
            this.lb_cmnd.Name = "lb_cmnd";
            this.lb_cmnd.Size = new System.Drawing.Size(82, 17);
            this.lb_cmnd.TabIndex = 36;
            this.lb_cmnd.Text = "Số căn cước:";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.Location = new System.Drawing.Point(385, 78);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(88, 17);
            this.lb_sdt.TabIndex = 35;
            this.lb_sdt.Text = "Số điện thoại:";
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(110, 135);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(53, 17);
            this.lb_ten.TabIndex = 34;
            this.lb_ten.Text = "Tên NV:";
            // 
            // lb_ma
            // 
            this.lb_ma.AutoSize = true;
            this.lb_ma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ma.Location = new System.Drawing.Point(110, 78);
            this.lb_ma.Name = "lb_ma";
            this.lb_ma.Size = new System.Drawing.Size(52, 17);
            this.lb_ma.TabIndex = 33;
            this.lb_ma.Text = "Mã NV:";
            // 
            // Ma_NV
            // 
            this.Ma_NV.DataPropertyName = "Ma_NV";
            this.Ma_NV.HeaderText = "Mã";
            this.Ma_NV.Name = "Ma_NV";
            this.Ma_NV.ReadOnly = true;
            // 
            // Ten_NV
            // 
            this.Ten_NV.DataPropertyName = "Ten_NV";
            this.Ten_NV.HeaderText = "Tên";
            this.Ten_NV.Name = "Ten_NV";
            this.Ten_NV.ReadOnly = true;
            // 
            // Sdt_NV
            // 
            this.Sdt_NV.DataPropertyName = "Sdt_NV";
            this.Sdt_NV.HeaderText = "Số điện thoại";
            this.Sdt_NV.Name = "Sdt_NV";
            this.Sdt_NV.ReadOnly = true;
            // 
            // Dc_NV
            // 
            this.Dc_NV.DataPropertyName = "Dc_NV";
            this.Dc_NV.HeaderText = "Địa chỉ";
            this.Dc_NV.Name = "Dc_NV";
            this.Dc_NV.ReadOnly = true;
            // 
            // Cmnd_NV
            // 
            this.Cmnd_NV.DataPropertyName = "Cmnd_NV";
            this.Cmnd_NV.HeaderText = "Số căn cước";
            this.Cmnd_NV.Name = "Cmnd_NV";
            this.Cmnd_NV.ReadOnly = true;
            // 
            // TTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 544);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.cb_timkiem);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.dgv_nv);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.tb_cmnd);
            this.Controls.Add(this.tb_SDT);
            this.Controls.Add(this.tb_dc);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.lb_list);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.lb_headline);
            this.Controls.Add(this.lb_mota);
            this.Controls.Add(this.lb_cmnd);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.lb_ten);
            this.Controls.Add(this.lb_ma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TTNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QLTTNV";
            this.Load += new System.EventHandler(this.TTNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.ComboBox cb_timkiem;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.DataGridView dgv_nv;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.TextBox tb_cmnd;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.TextBox tb_dc;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Label lb_list;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.Label lb_headline;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.Label lb_cmnd;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dc_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmnd_NV;
    }
}