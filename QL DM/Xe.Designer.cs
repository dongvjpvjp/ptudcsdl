namespace CSKH_SALONOTO.QL_DM
{
    partial class Xe
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
            this.dgv_xe = new System.Windows.Forms.DataGridView();
            this.Ma_Xe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_XE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giatri_XE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota_XE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.tb_giatri = new System.Windows.Forms.TextBox();
            this.lb_list = new System.Windows.Forms.Label();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.lb_headline = new System.Windows.Forms.Label();
            this.lb_mota = new System.Windows.Forms.Label();
            this.lb_dc = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_ma = new System.Windows.Forms.Label();
            this.cb_ma = new System.Windows.Forms.ComboBox();
            this.lb_maxe = new System.Windows.Forms.Label();
            this.tb_ma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xe)).BeginInit();
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
            "Mã xe",
            "Tên xe",
            "Nhà cung cấp"});
            this.cb_timkiem.Location = new System.Drawing.Point(314, 267);
            this.cb_timkiem.Name = "cb_timkiem";
            this.cb_timkiem.Size = new System.Drawing.Size(70, 21);
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
            // dgv_xe
            // 
            this.dgv_xe.AllowUserToAddRows = false;
            this.dgv_xe.AllowUserToDeleteRows = false;
            this.dgv_xe.AllowUserToResizeRows = false;
            this.dgv_xe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Xe,
            this.Ten_XE,
            this.Ten_NCC,
            this.Giatri_XE,
            this.Mota_XE});
            this.dgv_xe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_xe.Location = new System.Drawing.Point(6, 321);
            this.dgv_xe.MultiSelect = false;
            this.dgv_xe.Name = "dgv_xe";
            this.dgv_xe.ReadOnly = true;
            this.dgv_xe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_xe.Size = new System.Drawing.Size(768, 209);
            this.dgv_xe.TabIndex = 47;
            this.dgv_xe.SelectionChanged += new System.EventHandler(this.dgv_xe_SelectionChanged);
            // 
            // Ma_Xe
            // 
            this.Ma_Xe.DataPropertyName = "Ma_Xe";
            this.Ma_Xe.HeaderText = "Mã Xe";
            this.Ma_Xe.Name = "Ma_Xe";
            this.Ma_Xe.ReadOnly = true;
            // 
            // Ten_XE
            // 
            this.Ten_XE.DataPropertyName = "Ten_XE";
            this.Ten_XE.HeaderText = "Tên Xe";
            this.Ten_XE.Name = "Ten_XE";
            this.Ten_XE.ReadOnly = true;
            // 
            // Ten_NCC
            // 
            this.Ten_NCC.DataPropertyName = "Ten_NCC";
            this.Ten_NCC.HeaderText = "Tên nhà cung cấp";
            this.Ten_NCC.Name = "Ten_NCC";
            this.Ten_NCC.ReadOnly = true;
            // 
            // Giatri_XE
            // 
            this.Giatri_XE.DataPropertyName = "Giatri_XE";
            this.Giatri_XE.HeaderText = "Giá trị";
            this.Giatri_XE.Name = "Giatri_XE";
            this.Giatri_XE.ReadOnly = true;
            // 
            // Mota_XE
            // 
            this.Mota_XE.DataPropertyName = "Mota_XE";
            this.Mota_XE.HeaderText = "Mô tả";
            this.Mota_XE.Name = "Mota_XE";
            this.Mota_XE.ReadOnly = true;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(195, 267);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(110, 20);
            this.tb_timkiem.TabIndex = 46;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(487, 75);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(110, 20);
            this.tb_ten.TabIndex = 44;
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(195, 152);
            this.tb_mota.Multiline = true;
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(500, 98);
            this.tb_mota.TabIndex = 43;
            // 
            // tb_giatri
            // 
            this.tb_giatri.Location = new System.Drawing.Point(487, 109);
            this.tb_giatri.Name = "tb_giatri";
            this.tb_giatri.Size = new System.Drawing.Size(110, 20);
            this.tb_giatri.TabIndex = 42;
            this.tb_giatri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_giatri_KeyPress);
            // 
            // lb_list
            // 
            this.lb_list.AutoSize = true;
            this.lb_list.Location = new System.Drawing.Point(3, 301);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(76, 13);
            this.lb_list.TabIndex = 40;
            this.lb_list.Text = "Danh sách xe:";
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
            this.lb_headline.Location = new System.Drawing.Point(299, 9);
            this.lb_headline.Name = "lb_headline";
            this.lb_headline.Size = new System.Drawing.Size(187, 33);
            this.lb_headline.TabIndex = 38;
            this.lb_headline.Text = "Quản Lý Xe ";
            // 
            // lb_mota
            // 
            this.lb_mota.AutoSize = true;
            this.lb_mota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mota.Location = new System.Drawing.Point(97, 151);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(76, 17);
            this.lb_mota.TabIndex = 37;
            this.lb_mota.Text = "Mô tả khác:";
            // 
            // lb_dc
            // 
            this.lb_dc.AutoSize = true;
            this.lb_dc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dc.Location = new System.Drawing.Point(406, 107);
            this.lb_dc.Name = "lb_dc";
            this.lb_dc.Size = new System.Drawing.Size(46, 17);
            this.lb_dc.TabIndex = 35;
            this.lb_dc.Text = "Giá trị:";
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(406, 75);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(50, 17);
            this.lb_ten.TabIndex = 34;
            this.lb_ten.Text = "Tên Xe:";
            // 
            // lb_ma
            // 
            this.lb_ma.AutoSize = true;
            this.lb_ma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ma.Location = new System.Drawing.Point(97, 75);
            this.lb_ma.Name = "lb_ma";
            this.lb_ma.Size = new System.Drawing.Size(92, 17);
            this.lb_ma.TabIndex = 33;
            this.lb_ma.Text = "Nhà cung cấp:";
            // 
            // cb_ma
            // 
            this.cb_ma.FormattingEnabled = true;
            this.cb_ma.Location = new System.Drawing.Point(195, 78);
            this.cb_ma.Name = "cb_ma";
            this.cb_ma.Size = new System.Drawing.Size(110, 21);
            this.cb_ma.TabIndex = 53;
            this.cb_ma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_ma_KeyPress);
            // 
            // lb_maxe
            // 
            this.lb_maxe.AutoSize = true;
            this.lb_maxe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maxe.Location = new System.Drawing.Point(97, 113);
            this.lb_maxe.Name = "lb_maxe";
            this.lb_maxe.Size = new System.Drawing.Size(49, 17);
            this.lb_maxe.TabIndex = 54;
            this.lb_maxe.Text = "Mã Xe:";
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(195, 113);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(110, 20);
            this.tb_ma.TabIndex = 55;
            // 
            // Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 544);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.lb_maxe);
            this.Controls.Add(this.cb_ma);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.cb_timkiem);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.dgv_xe);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_mota);
            this.Controls.Add(this.tb_giatri);
            this.Controls.Add(this.lb_list);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.lb_headline);
            this.Controls.Add(this.lb_mota);
            this.Controls.Add(this.lb_dc);
            this.Controls.Add(this.lb_ten);
            this.Controls.Add(this.lb_ma);
            this.Name = "Xe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xe";
            this.Load += new System.EventHandler(this.Xe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.ComboBox cb_timkiem;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.DataGridView dgv_xe;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.TextBox tb_giatri;
        private System.Windows.Forms.Label lb_list;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.Label lb_headline;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.Label lb_dc;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_ma;
        private System.Windows.Forms.ComboBox cb_ma;
        private System.Windows.Forms.Label lb_maxe;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Xe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_XE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giatri_XE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota_XE;
    }
}