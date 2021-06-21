namespace CSKH_SALONOTO.QLKH
{
    partial class HTCSKH
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
            this.lb_headline = new System.Windows.Forms.Label();
            this.cb_timkiem = new System.Windows.Forms.ComboBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ht = new System.Windows.Forms.DataGridView();
            this.Ma_HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota_HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_luu = new System.Windows.Forms.Button();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.lb_mota = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_ma = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ht)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_headline
            // 
            this.lb_headline.AutoSize = true;
            this.lb_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_headline.Location = new System.Drawing.Point(74, 29);
            this.lb_headline.Name = "lb_headline";
            this.lb_headline.Size = new System.Drawing.Size(603, 33);
            this.lb_headline.TabIndex = 39;
            this.lb_headline.Text = "Danh Mục hình thức chăm sóc khách hàng";
            // 
            // cb_timkiem
            // 
            this.cb_timkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timkiem.FormattingEnabled = true;
            this.cb_timkiem.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cb_timkiem.Location = new System.Drawing.Point(271, 86);
            this.cb_timkiem.Name = "cb_timkiem";
            this.cb_timkiem.Size = new System.Drawing.Size(47, 21);
            this.cb_timkiem.TabIndex = 48;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(97, 86);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(158, 20);
            this.tb_timkiem.TabIndex = 47;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(12, 86);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(65, 17);
            this.lb_timkiem.TabIndex = 46;
            this.lb_timkiem.Text = "Tìm Kiếm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ht);
            this.groupBox1.Location = new System.Drawing.Point(9, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 335);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hình thức";
            // 
            // dgv_ht
            // 
            this.dgv_ht.AllowUserToAddRows = false;
            this.dgv_ht.AllowUserToDeleteRows = false;
            this.dgv_ht.AllowUserToResizeRows = false;
            this.dgv_ht.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_ht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ht.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_HT,
            this.Ten_HT,
            this.Mota_HT});
            this.dgv_ht.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_ht.Location = new System.Drawing.Point(6, 19);
            this.dgv_ht.MultiSelect = false;
            this.dgv_ht.Name = "dgv_ht";
            this.dgv_ht.ReadOnly = true;
            this.dgv_ht.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ht.Size = new System.Drawing.Size(303, 310);
            this.dgv_ht.TabIndex = 54;
            this.dgv_ht.SelectionChanged += new System.EventHandler(this.dgv_ht_SelectionChanged);
            // 
            // Ma_HT
            // 
            this.Ma_HT.DataPropertyName = "Ma_HT";
            this.Ma_HT.HeaderText = "Mã hình thức";
            this.Ma_HT.Name = "Ma_HT";
            this.Ma_HT.ReadOnly = true;
            // 
            // Ten_HT
            // 
            this.Ten_HT.DataPropertyName = "Ten_HT";
            this.Ten_HT.HeaderText = "Tên hình thức";
            this.Ten_HT.Name = "Ten_HT";
            this.Ten_HT.ReadOnly = true;
            // 
            // Mota_HT
            // 
            this.Mota_HT.DataPropertyName = "Mota_HT";
            this.Mota_HT.HeaderText = "Mô tả";
            this.Mota_HT.Name = "Mota_HT";
            this.Mota_HT.ReadOnly = true;
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(440, 337);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(183, 45);
            this.bt_luu.TabIndex = 63;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(440, 197);
            this.tb_mota.Multiline = true;
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(183, 101);
            this.tb_mota.TabIndex = 59;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(440, 142);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(183, 20);
            this.tb_ten.TabIndex = 58;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(440, 87);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(183, 20);
            this.tb_ma.TabIndex = 57;
            // 
            // lb_mota
            // 
            this.lb_mota.AutoSize = true;
            this.lb_mota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mota.Location = new System.Drawing.Point(355, 215);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(76, 17);
            this.lb_mota.TabIndex = 56;
            this.lb_mota.Text = "Mô tả khác:";
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(355, 144);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(51, 17);
            this.lb_ten.TabIndex = 55;
            this.lb_ten.Text = "Tên HT:";
            // 
            // lb_ma
            // 
            this.lb_ma.AutoSize = true;
            this.lb_ma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ma.Location = new System.Drawing.Point(355, 87);
            this.lb_ma.Name = "lb_ma";
            this.lb_ma.Size = new System.Drawing.Size(50, 17);
            this.lb_ma.TabIndex = 54;
            this.lb_ma.Text = "Mã HT:";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(638, 264);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(59, 27);
            this.bt_xoa.TabIndex = 69;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(638, 203);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(59, 27);
            this.bt_sua.TabIndex = 68;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(638, 142);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(59, 27);
            this.bt_them.TabIndex = 67;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // HTCSKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 445);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.tb_mota);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.lb_mota);
            this.Controls.Add(this.lb_ten);
            this.Controls.Add(this.lb_ma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_timkiem);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.lb_headline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HTCSKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HTCSKH";
            this.Load += new System.EventHandler(this.HTCSKH_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_headline;
        private System.Windows.Forms.ComboBox cb_timkiem;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ht;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_ma;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota_HT;
    }
}