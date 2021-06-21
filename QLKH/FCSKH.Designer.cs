namespace CSKH_SALONOTO.QLKH
{
    partial class FCSKH
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
            this.lb_XE = new System.Windows.Forms.Label();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.cb_timkiem = new System.Windows.Forms.ComboBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.dgv_fcskh = new System.Windows.Forms.DataGridView();
            this.Ma_FCSKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_XE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nd_FCSKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaylap_FCSKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinhtrang_FCSKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.tb_tinhtrang = new System.Windows.Forms.TextBox();
            this.tb_nd = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.lb_list = new System.Windows.Forms.Label();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.lb_headline = new System.Windows.Forms.Label();
            this.lb_mota = new System.Windows.Forms.Label();
            this.lb_cmnd = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_ma = new System.Windows.Forms.Label();
            this.cb_kh = new System.Windows.Forms.ComboBox();
            this.cb_xe = new System.Windows.Forms.ComboBox();
            this.dtp_ngaylap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fcskh)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_XE
            // 
            this.lb_XE.AutoSize = true;
            this.lb_XE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_XE.Location = new System.Drawing.Point(110, 148);
            this.lb_XE.Name = "lb_XE";
            this.lb_XE.Size = new System.Drawing.Size(47, 17);
            this.lb_XE.TabIndex = 95;
            this.lb_XE.Text = "Xe KH:";
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(689, 270);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 45);
            this.bt_luu.TabIndex = 94;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(487, 267);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 26);
            this.bt_sua.TabIndex = 92;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(390, 267);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 26);
            this.bt_them.TabIndex = 91;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // cb_timkiem
            // 
            this.cb_timkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timkiem.FormattingEnabled = true;
            this.cb_timkiem.Items.AddRange(new object[] {
            "Mã phiếu",
            "Khách hàng"});
            this.cb_timkiem.Location = new System.Drawing.Point(314, 267);
            this.cb_timkiem.Name = "cb_timkiem";
            this.cb_timkiem.Size = new System.Drawing.Size(47, 21);
            this.cb_timkiem.TabIndex = 90;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(584, 267);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 26);
            this.bt_xoa.TabIndex = 93;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // dgv_fcskh
            // 
            this.dgv_fcskh.AllowUserToAddRows = false;
            this.dgv_fcskh.AllowUserToDeleteRows = false;
            this.dgv_fcskh.AllowUserToResizeRows = false;
            this.dgv_fcskh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_fcskh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fcskh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_FCSKH,
            this.Ten_KH,
            this.Ten_XE,
            this.Nd_FCSKH,
            this.Ngaylap_FCSKH,
            this.Tinhtrang_FCSKH});
            this.dgv_fcskh.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_fcskh.Location = new System.Drawing.Point(6, 321);
            this.dgv_fcskh.MultiSelect = false;
            this.dgv_fcskh.Name = "dgv_fcskh";
            this.dgv_fcskh.ReadOnly = true;
            this.dgv_fcskh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fcskh.Size = new System.Drawing.Size(768, 209);
            this.dgv_fcskh.TabIndex = 89;
            this.dgv_fcskh.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_fcskh_CellContentDoubleClick);
            this.dgv_fcskh.SelectionChanged += new System.EventHandler(this.dgv_fcskh_SelectionChanged);
            // 
            // Ma_FCSKH
            // 
            this.Ma_FCSKH.DataPropertyName = "Ma_FCSKH";
            this.Ma_FCSKH.HeaderText = "Mã";
            this.Ma_FCSKH.Name = "Ma_FCSKH";
            this.Ma_FCSKH.ReadOnly = true;
            // 
            // Ten_KH
            // 
            this.Ten_KH.DataPropertyName = "Ten_KH";
            this.Ten_KH.HeaderText = "Khách hàng";
            this.Ten_KH.Name = "Ten_KH";
            this.Ten_KH.ReadOnly = true;
            // 
            // Ten_XE
            // 
            this.Ten_XE.DataPropertyName = "Ten_XE";
            this.Ten_XE.HeaderText = "Xe";
            this.Ten_XE.Name = "Ten_XE";
            this.Ten_XE.ReadOnly = true;
            // 
            // Nd_FCSKH
            // 
            this.Nd_FCSKH.DataPropertyName = "Nd_FCSKH";
            this.Nd_FCSKH.HeaderText = "Nội dung";
            this.Nd_FCSKH.Name = "Nd_FCSKH";
            this.Nd_FCSKH.ReadOnly = true;
            // 
            // Ngaylap_FCSKH
            // 
            this.Ngaylap_FCSKH.DataPropertyName = "Ngaylap_FCSKH";
            this.Ngaylap_FCSKH.HeaderText = "Ngày lập";
            this.Ngaylap_FCSKH.Name = "Ngaylap_FCSKH";
            this.Ngaylap_FCSKH.ReadOnly = true;
            // 
            // Tinhtrang_FCSKH
            // 
            this.Tinhtrang_FCSKH.DataPropertyName = "Tinhtrang_FCSKH";
            this.Tinhtrang_FCSKH.HeaderText = "Tình trạng";
            this.Tinhtrang_FCSKH.Name = "Tinhtrang_FCSKH";
            this.Tinhtrang_FCSKH.ReadOnly = true;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(195, 267);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(110, 20);
            this.tb_timkiem.TabIndex = 88;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // tb_tinhtrang
            // 
            this.tb_tinhtrang.Location = new System.Drawing.Point(487, 116);
            this.tb_tinhtrang.Name = "tb_tinhtrang";
            this.tb_tinhtrang.Size = new System.Drawing.Size(85, 20);
            this.tb_tinhtrang.TabIndex = 87;
            // 
            // tb_nd
            // 
            this.tb_nd.Location = new System.Drawing.Point(195, 184);
            this.tb_nd.Multiline = true;
            this.tb_nd.Name = "tb_nd";
            this.tb_nd.Size = new System.Drawing.Size(500, 75);
            this.tb_nd.TabIndex = 85;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(195, 78);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(110, 20);
            this.tb_ma.TabIndex = 83;
            // 
            // lb_list
            // 
            this.lb_list.AutoSize = true;
            this.lb_list.Location = new System.Drawing.Point(3, 301);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(91, 13);
            this.lb_list.TabIndex = 82;
            this.lb_list.Text = "Danh sách phiếu:";
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(110, 270);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(65, 17);
            this.lb_timkiem.TabIndex = 81;
            this.lb_timkiem.Text = "Tìm Kiếm:";
            // 
            // lb_headline
            // 
            this.lb_headline.AutoSize = true;
            this.lb_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_headline.Location = new System.Drawing.Point(108, 18);
            this.lb_headline.Name = "lb_headline";
            this.lb_headline.Size = new System.Drawing.Size(551, 33);
            this.lb_headline.TabIndex = 80;
            this.lb_headline.Text = "Quản Lý Phiếu Chăm Sóc Khách Hàng";
            // 
            // lb_mota
            // 
            this.lb_mota.AutoSize = true;
            this.lb_mota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mota.Location = new System.Drawing.Point(110, 206);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(66, 17);
            this.lb_mota.TabIndex = 79;
            this.lb_mota.Text = "Nội dụng:";
            // 
            // lb_cmnd
            // 
            this.lb_cmnd.AutoSize = true;
            this.lb_cmnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cmnd.Location = new System.Drawing.Point(387, 116);
            this.lb_cmnd.Name = "lb_cmnd";
            this.lb_cmnd.Size = new System.Drawing.Size(70, 17);
            this.lb_cmnd.TabIndex = 78;
            this.lb_cmnd.Text = "Tình trạng:";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.Location = new System.Drawing.Point(385, 78);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(64, 17);
            this.lb_sdt.TabIndex = 77;
            this.lb_sdt.Text = "Ngày lập:";
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(110, 113);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(79, 17);
            this.lb_ten.TabIndex = 76;
            this.lb_ten.Text = "Khách hàng:";
            // 
            // lb_ma
            // 
            this.lb_ma.AutoSize = true;
            this.lb_ma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ma.Location = new System.Drawing.Point(110, 78);
            this.lb_ma.Name = "lb_ma";
            this.lb_ma.Size = new System.Drawing.Size(65, 17);
            this.lb_ma.TabIndex = 75;
            this.lb_ma.Text = "Mã Phiếu:";
            // 
            // cb_kh
            // 
            this.cb_kh.FormattingEnabled = true;
            this.cb_kh.Location = new System.Drawing.Point(195, 112);
            this.cb_kh.Name = "cb_kh";
            this.cb_kh.Size = new System.Drawing.Size(110, 21);
            this.cb_kh.TabIndex = 98;
            this.cb_kh.SelectedIndexChanged += new System.EventHandler(this.cb_kh_SelectedIndexChanged);
            this.cb_kh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_kh_KeyPress);
            // 
            // cb_xe
            // 
            this.cb_xe.FormattingEnabled = true;
            this.cb_xe.Location = new System.Drawing.Point(195, 148);
            this.cb_xe.Name = "cb_xe";
            this.cb_xe.Size = new System.Drawing.Size(110, 21);
            this.cb_xe.TabIndex = 99;
            this.cb_xe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_xe_KeyPress);
            // 
            // dtp_ngaylap
            // 
            this.dtp_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaylap.Location = new System.Drawing.Point(487, 78);
            this.dtp_ngaylap.Name = "dtp_ngaylap";
            this.dtp_ngaylap.Size = new System.Drawing.Size(85, 20);
            this.dtp_ngaylap.TabIndex = 130;
            this.dtp_ngaylap.Value = new System.DateTime(2019, 12, 24, 0, 0, 0, 0);
            // 
            // FCSKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 544);
            this.Controls.Add(this.dtp_ngaylap);
            this.Controls.Add(this.cb_xe);
            this.Controls.Add(this.cb_kh);
            this.Controls.Add(this.lb_XE);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.cb_timkiem);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.dgv_fcskh);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.tb_tinhtrang);
            this.Controls.Add(this.tb_nd);
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
            this.Name = "FCSKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu Chăm Sóc Khách Hàng";
            this.Load += new System.EventHandler(this.FCSKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fcskh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_XE;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.ComboBox cb_timkiem;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.DataGridView dgv_fcskh;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.TextBox tb_tinhtrang;
        private System.Windows.Forms.TextBox tb_nd;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Label lb_list;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.Label lb_headline;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.Label lb_cmnd;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_FCSKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_XE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nd_FCSKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaylap_FCSKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinhtrang_FCSKH;
        private System.Windows.Forms.ComboBox cb_kh;
        private System.Windows.Forms.ComboBox cb_xe;
        private System.Windows.Forms.DateTimePicker dtp_ngaylap;
    }
}