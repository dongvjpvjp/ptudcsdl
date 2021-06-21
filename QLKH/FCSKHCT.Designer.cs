namespace CSKH_SALONOTO.QLKH
{
    partial class FCSKHCT
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
            this.cb_nv = new System.Windows.Forms.ComboBox();
            this.lb_XE = new System.Windows.Forms.Label();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.cb_timkiem = new System.Windows.Forms.ComboBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.dgv_fcskhct = new System.Windows.Forms.DataGridView();
            this.Ma_FCSKHCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nd_FCSKHCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayhen_FCSKHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime_FCSKHCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishTime_FCSKHCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.tb_nd = new System.Windows.Forms.TextBox();
            this.tb_ct = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.lb_list = new System.Windows.Forms.Label();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.lb_headline = new System.Windows.Forms.Label();
            this.lb_mota = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_ma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ht = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fcskhct)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_nv
            // 
            this.cb_nv.FormattingEnabled = true;
            this.cb_nv.Location = new System.Drawing.Point(195, 144);
            this.cb_nv.Name = "cb_nv";
            this.cb_nv.Size = new System.Drawing.Size(110, 21);
            this.cb_nv.TabIndex = 118;
            this.cb_nv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_xe_KeyPress);
            // 
            // lb_XE
            // 
            this.lb_XE.AutoSize = true;
            this.lb_XE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_XE.Location = new System.Drawing.Point(109, 144);
            this.lb_XE.Name = "lb_XE";
            this.lb_XE.Size = new System.Drawing.Size(71, 17);
            this.lb_XE.TabIndex = 117;
            this.lb_XE.Text = "Nhân Viên:";
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(690, 288);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 45);
            this.bt_luu.TabIndex = 116;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(488, 285);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 26);
            this.bt_sua.TabIndex = 114;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(391, 285);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 26);
            this.bt_them.TabIndex = 113;
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
            "Hình thức",
            "Ngày hẹn"});
            this.cb_timkiem.Location = new System.Drawing.Point(315, 285);
            this.cb_timkiem.Name = "cb_timkiem";
            this.cb_timkiem.Size = new System.Drawing.Size(54, 21);
            this.cb_timkiem.TabIndex = 112;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(585, 285);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 26);
            this.bt_xoa.TabIndex = 115;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // dgv_fcskhct
            // 
            this.dgv_fcskhct.AllowUserToAddRows = false;
            this.dgv_fcskhct.AllowUserToDeleteRows = false;
            this.dgv_fcskhct.AllowUserToResizeRows = false;
            this.dgv_fcskhct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_fcskhct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fcskhct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_FCSKHCT,
            this.Ten_NV,
            this.Ten_HT,
            this.Nd_FCSKHCT,
            this.Ngayhen_FCSKHT,
            this.StartTime_FCSKHCT,
            this.FinishTime_FCSKHCT});
            this.dgv_fcskhct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_fcskhct.Location = new System.Drawing.Point(6, 345);
            this.dgv_fcskhct.MultiSelect = false;
            this.dgv_fcskhct.Name = "dgv_fcskhct";
            this.dgv_fcskhct.ReadOnly = true;
            this.dgv_fcskhct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fcskhct.Size = new System.Drawing.Size(768, 183);
            this.dgv_fcskhct.TabIndex = 111;
            this.dgv_fcskhct.SelectionChanged += new System.EventHandler(this.dgv_fcskhct_SelectionChanged);
            // 
            // Ma_FCSKHCT
            // 
            this.Ma_FCSKHCT.DataPropertyName = "Ma_FCSKHCT";
            this.Ma_FCSKHCT.HeaderText = "Mã";
            this.Ma_FCSKHCT.Name = "Ma_FCSKHCT";
            this.Ma_FCSKHCT.ReadOnly = true;
            // 
            // Ten_NV
            // 
            this.Ten_NV.DataPropertyName = "Ten_NV";
            this.Ten_NV.HeaderText = "Nhân Viên";
            this.Ten_NV.Name = "Ten_NV";
            this.Ten_NV.ReadOnly = true;
            // 
            // Ten_HT
            // 
            this.Ten_HT.DataPropertyName = "Ten_HT";
            this.Ten_HT.HeaderText = "Hình thức";
            this.Ten_HT.Name = "Ten_HT";
            this.Ten_HT.ReadOnly = true;
            // 
            // Nd_FCSKHCT
            // 
            this.Nd_FCSKHCT.DataPropertyName = "Nd_FCSKHCT";
            this.Nd_FCSKHCT.HeaderText = "Nội dung";
            this.Nd_FCSKHCT.Name = "Nd_FCSKHCT";
            this.Nd_FCSKHCT.ReadOnly = true;
            // 
            // Ngayhen_FCSKHT
            // 
            this.Ngayhen_FCSKHT.DataPropertyName = "Ngayhen_FCSKHT";
            this.Ngayhen_FCSKHT.HeaderText = "Ngày hẹn";
            this.Ngayhen_FCSKHT.Name = "Ngayhen_FCSKHT";
            this.Ngayhen_FCSKHT.ReadOnly = true;
            // 
            // StartTime_FCSKHCT
            // 
            this.StartTime_FCSKHCT.DataPropertyName = "StartTime_FCSKHCT";
            this.StartTime_FCSKHCT.HeaderText = "Thời gian bắt đầu";
            this.StartTime_FCSKHCT.Name = "StartTime_FCSKHCT";
            this.StartTime_FCSKHCT.ReadOnly = true;
            // 
            // FinishTime_FCSKHCT
            // 
            this.FinishTime_FCSKHCT.DataPropertyName = "FinishTime_FCSKHCT";
            this.FinishTime_FCSKHCT.HeaderText = "Thời gian kết thúc";
            this.FinishTime_FCSKHCT.Name = "FinishTime_FCSKHCT";
            this.FinishTime_FCSKHCT.ReadOnly = true;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(196, 285);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(110, 20);
            this.tb_timkiem.TabIndex = 110;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // tb_nd
            // 
            this.tb_nd.Location = new System.Drawing.Point(195, 214);
            this.tb_nd.Multiline = true;
            this.tb_nd.Name = "tb_nd";
            this.tb_nd.Size = new System.Drawing.Size(500, 65);
            this.tb_nd.TabIndex = 108;
            // 
            // tb_ct
            // 
            this.tb_ct.Location = new System.Drawing.Point(195, 110);
            this.tb_ct.Name = "tb_ct";
            this.tb_ct.Size = new System.Drawing.Size(110, 20);
            this.tb_ct.TabIndex = 107;
            // 
            // tb_ma
            // 
            this.tb_ma.Enabled = false;
            this.tb_ma.Location = new System.Drawing.Point(195, 76);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(110, 20);
            this.tb_ma.TabIndex = 106;
            // 
            // lb_list
            // 
            this.lb_list.AutoSize = true;
            this.lb_list.Location = new System.Drawing.Point(3, 319);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(125, 13);
            this.lb_list.TabIndex = 105;
            this.lb_list.Text = "Danh sách phiếu chi tiết:";
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(109, 288);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(65, 17);
            this.lb_timkiem.TabIndex = 104;
            this.lb_timkiem.Text = "Tìm Kiếm:";
            // 
            // lb_headline
            // 
            this.lb_headline.AutoSize = true;
            this.lb_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_headline.Location = new System.Drawing.Point(57, 20);
            this.lb_headline.Name = "lb_headline";
            this.lb_headline.Size = new System.Drawing.Size(669, 33);
            this.lb_headline.TabIndex = 103;
            this.lb_headline.Text = "Quản Lý Phiếu Chăm Sóc Khách Hàng Chi Tiết";
            // 
            // lb_mota
            // 
            this.lb_mota.AutoSize = true;
            this.lb_mota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mota.Location = new System.Drawing.Point(109, 212);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(66, 17);
            this.lb_mota.TabIndex = 102;
            this.lb_mota.Text = "Nội dụng:";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.Location = new System.Drawing.Point(377, 76);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(67, 17);
            this.lb_sdt.TabIndex = 100;
            this.lb_sdt.Text = "Ngày hẹn:";
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(109, 110);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(74, 17);
            this.lb_ten.TabIndex = 99;
            this.lb_ten.Text = "Mã Chi tiết:";
            // 
            // lb_ma
            // 
            this.lb_ma.AutoSize = true;
            this.lb_ma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ma.Location = new System.Drawing.Point(109, 76);
            this.lb_ma.Name = "lb_ma";
            this.lb_ma.Size = new System.Drawing.Size(55, 17);
            this.lb_ma.TabIndex = 98;
            this.lb_ma.Text = "Mã FCS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 122;
            this.label2.Text = "Thời gian bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 124;
            this.label3.Text = "Thời gian kết thúc:";
            // 
            // cb_ht
            // 
            this.cb_ht.FormattingEnabled = true;
            this.cb_ht.Location = new System.Drawing.Point(195, 179);
            this.cb_ht.Name = "cb_ht";
            this.cb_ht.Size = new System.Drawing.Size(110, 21);
            this.cb_ht.TabIndex = 127;
            this.cb_ht.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_ht_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 126;
            this.label1.Text = "Hình thức:";
            // 
            // dtp_ngaylap
            // 
            this.dtp_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaylap.Location = new System.Drawing.Point(497, 76);
            this.dtp_ngaylap.Name = "dtp_ngaylap";
            this.dtp_ngaylap.Size = new System.Drawing.Size(105, 20);
            this.dtp_ngaylap.TabIndex = 131;
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start.Location = new System.Drawing.Point(497, 113);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(133, 20);
            this.dtp_start.TabIndex = 132;
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end.Location = new System.Drawing.Point(497, 148);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(133, 20);
            this.dtp_end.TabIndex = 133;
            // 
            // FCSKHCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 544);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.dtp_ngaylap);
            this.Controls.Add(this.cb_ht);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_nv);
            this.Controls.Add(this.lb_XE);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.cb_timkiem);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.dgv_fcskhct);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.tb_nd);
            this.Controls.Add(this.tb_ct);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.lb_list);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.lb_headline);
            this.Controls.Add(this.lb_mota);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.lb_ten);
            this.Controls.Add(this.lb_ma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FCSKHCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FCSKHCT";
            this.Load += new System.EventHandler(this.FCSKHCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fcskhct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_nv;
        private System.Windows.Forms.Label lb_XE;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.ComboBox cb_timkiem;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.DataGridView dgv_fcskhct;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.TextBox tb_nd;
        private System.Windows.Forms.TextBox tb_ct;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Label lb_list;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.Label lb_headline;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_FCSKHCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nd_FCSKHCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayhen_FCSKHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime_FCSKHCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishTime_FCSKHCT;
        private System.Windows.Forms.DateTimePicker dtp_ngaylap;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
    }
}