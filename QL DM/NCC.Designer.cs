namespace CSKH_SALONOTO.QL_DM
{
    partial class NCC
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
            this.lb_ma = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_dc = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_mota = new System.Windows.Forms.Label();
            this.lb_headline = new System.Windows.Forms.Label();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.lb_list = new System.Windows.Forms.Label();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.tb_DC = new System.Windows.Forms.TextBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.dgv_ncc = new System.Windows.Forms.DataGridView();
            this.Ma_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dc_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_timkiem = new System.Windows.Forms.ComboBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_ma
            // 
            this.lb_ma.AutoSize = true;
            this.lb_ma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ma.Location = new System.Drawing.Point(108, 90);
            this.lb_ma.Name = "lb_ma";
            this.lb_ma.Size = new System.Drawing.Size(60, 17);
            this.lb_ma.TabIndex = 0;
            this.lb_ma.Text = "Mã NCC:";
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(108, 147);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(61, 17);
            this.lb_ten.TabIndex = 1;
            this.lb_ten.Text = "Tên NCC:";
            // 
            // lb_dc
            // 
            this.lb_dc.AutoSize = true;
            this.lb_dc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dc.Location = new System.Drawing.Point(383, 90);
            this.lb_dc.Name = "lb_dc";
            this.lb_dc.Size = new System.Drawing.Size(88, 17);
            this.lb_dc.TabIndex = 2;
            this.lb_dc.Text = "Số điện thoại:";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.Location = new System.Drawing.Point(383, 136);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(50, 17);
            this.lb_sdt.TabIndex = 3;
            this.lb_sdt.Text = "Địa chỉ:";
            // 
            // lb_mota
            // 
            this.lb_mota.AutoSize = true;
            this.lb_mota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mota.Location = new System.Drawing.Point(108, 218);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(76, 17);
            this.lb_mota.TabIndex = 4;
            this.lb_mota.Text = "Mô tả khác:";
            // 
            // lb_headline
            // 
            this.lb_headline.AutoSize = true;
            this.lb_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_headline.Location = new System.Drawing.Point(187, 26);
            this.lb_headline.Name = "lb_headline";
            this.lb_headline.Size = new System.Drawing.Size(353, 33);
            this.lb_headline.TabIndex = 18;
            this.lb_headline.Text = "Quản Lý Nhà Cung Cấp ";
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(108, 282);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(65, 17);
            this.lb_timkiem.TabIndex = 19;
            this.lb_timkiem.Text = "Tìm Kiếm:";
            // 
            // lb_list
            // 
            this.lb_list.AutoSize = true;
            this.lb_list.Location = new System.Drawing.Point(1, 313);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(153, 17);
            this.lb_list.TabIndex = 20;
            this.lb_list.Text = "Danh sách nhà cung cấp:";
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(193, 90);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(110, 25);
            this.tb_ma.TabIndex = 21;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(193, 144);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(110, 25);
            this.tb_ten.TabIndex = 22;
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(193, 198);
            this.tb_mota.Multiline = true;
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(500, 75);
            this.tb_mota.TabIndex = 23;
            // 
            // tb_SDT
            // 
            this.tb_SDT.Location = new System.Drawing.Point(485, 87);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(208, 25);
            this.tb_SDT.TabIndex = 24;
            this.tb_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SDT_KeyPress);
            // 
            // tb_DC
            // 
            this.tb_DC.Location = new System.Drawing.Point(485, 128);
            this.tb_DC.Multiline = true;
            this.tb_DC.Name = "tb_DC";
            this.tb_DC.Size = new System.Drawing.Size(208, 53);
            this.tb_DC.TabIndex = 25;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(193, 279);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(110, 25);
            this.tb_timkiem.TabIndex = 26;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // dgv_ncc
            // 
            this.dgv_ncc.AllowUserToAddRows = false;
            this.dgv_ncc.AllowUserToDeleteRows = false;
            this.dgv_ncc.AllowUserToResizeRows = false;
            this.dgv_ncc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_ncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_NCC,
            this.Ten_NCC,
            this.Dc_NCC,
            this.Sdt_NCC,
            this.Mota_NCC});
            this.dgv_ncc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_ncc.Location = new System.Drawing.Point(4, 333);
            this.dgv_ncc.MultiSelect = false;
            this.dgv_ncc.Name = "dgv_ncc";
            this.dgv_ncc.ReadOnly = true;
            this.dgv_ncc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ncc.Size = new System.Drawing.Size(768, 210);
            this.dgv_ncc.TabIndex = 27;
            this.dgv_ncc.SelectionChanged += new System.EventHandler(this.dgv_ncc_SelectionChanged);
            // 
            // Ma_NCC
            // 
            this.Ma_NCC.DataPropertyName = "Ma_NCC";
            this.Ma_NCC.HeaderText = "Mã";
            this.Ma_NCC.Name = "Ma_NCC";
            this.Ma_NCC.ReadOnly = true;
            // 
            // Ten_NCC
            // 
            this.Ten_NCC.DataPropertyName = "Ten_NCC";
            this.Ten_NCC.HeaderText = "Tên Nhà Cung Cấp";
            this.Ten_NCC.Name = "Ten_NCC";
            this.Ten_NCC.ReadOnly = true;
            // 
            // Dc_NCC
            // 
            this.Dc_NCC.DataPropertyName = "Dc_NCC";
            this.Dc_NCC.HeaderText = "Địa chỉ";
            this.Dc_NCC.Name = "Dc_NCC";
            this.Dc_NCC.ReadOnly = true;
            // 
            // Sdt_NCC
            // 
            this.Sdt_NCC.DataPropertyName = "Sdt_NCC";
            this.Sdt_NCC.HeaderText = "Số điện thoại";
            this.Sdt_NCC.Name = "Sdt_NCC";
            this.Sdt_NCC.ReadOnly = true;
            // 
            // Mota_NCC
            // 
            this.Mota_NCC.DataPropertyName = "Mota_NCC";
            this.Mota_NCC.HeaderText = "Mô tả";
            this.Mota_NCC.Name = "Mota_NCC";
            this.Mota_NCC.ReadOnly = true;
            // 
            // cb_timkiem
            // 
            this.cb_timkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timkiem.FormattingEnabled = true;
            this.cb_timkiem.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cb_timkiem.Location = new System.Drawing.Point(312, 279);
            this.cb_timkiem.Name = "cb_timkiem";
            this.cb_timkiem.Size = new System.Drawing.Size(47, 25);
            this.cb_timkiem.TabIndex = 28;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(388, 279);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 26);
            this.bt_them.TabIndex = 29;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(485, 279);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 26);
            this.bt_sua.TabIndex = 30;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(582, 279);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 26);
            this.bt_xoa.TabIndex = 31;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(687, 282);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 45);
            this.bt_luu.TabIndex = 32;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 544);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.cb_timkiem);
            this.Controls.Add(this.dgv_ncc);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.tb_DC);
            this.Controls.Add(this.tb_SDT);
            this.Controls.Add(this.tb_mota);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.lb_list);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.lb_headline);
            this.Controls.Add(this.lb_mota);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.lb_dc);
            this.Controls.Add(this.lb_ten);
            this.Controls.Add(this.lb_ma);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ma;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_dc;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.Label lb_headline;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.Label lb_list;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.TextBox tb_DC;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.DataGridView dgv_ncc;
        private System.Windows.Forms.ComboBox cb_timkiem;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dc_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota_NCC;
    }
}