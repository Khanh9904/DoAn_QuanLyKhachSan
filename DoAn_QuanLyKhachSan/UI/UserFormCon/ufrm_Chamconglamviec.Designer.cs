namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_Chamconglamviec
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label maLoaiPhongLabel;
            System.Windows.Forms.Label tenLoaiPhongLabel;
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label soNguoiToiDaLabel;
            this.txt_machamcong = new System.Windows.Forms.TextBox();
            this.txtTimKiemCong = new System.Windows.Forms.TextBox();
            this.btnClearCong = new System.Windows.Forms.Button();
            this.btnXoaCong = new System.Windows.Forms.Button();
            this.btnSuaCong = new System.Windows.Forms.Button();
            this.btnThemCong = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.dgv_chamcong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_nhanvien = new System.Windows.Forms.ComboBox();
            this.dtngaylam = new System.Windows.Forms.DateTimePicker();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            maLoaiPhongLabel = new System.Windows.Forms.Label();
            tenLoaiPhongLabel = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            soNguoiToiDaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chamcong)).BeginInit();
            this.SuspendLayout();
            // 
            // maLoaiPhongLabel
            // 
            maLoaiPhongLabel.AutoSize = true;
            maLoaiPhongLabel.Location = new System.Drawing.Point(77, 199);
            maLoaiPhongLabel.Name = "maLoaiPhongLabel";
            maLoaiPhongLabel.Size = new System.Drawing.Size(98, 16);
            maLoaiPhongLabel.TabIndex = 85;
            maLoaiPhongLabel.Text = "Mã chấm công:";
            // 
            // tenLoaiPhongLabel
            // 
            tenLoaiPhongLabel.AutoSize = true;
            tenLoaiPhongLabel.Location = new System.Drawing.Point(77, 227);
            tenLoaiPhongLabel.Name = "tenLoaiPhongLabel";
            tenLoaiPhongLabel.Size = new System.Drawing.Size(94, 16);
            tenLoaiPhongLabel.TabIndex = 87;
            tenLoaiPhongLabel.Text = "Tên nhân viên:";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Location = new System.Drawing.Point(77, 255);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(99, 16);
            giaLabel.TabIndex = 89;
            giaLabel.Text = "Ngày làm việc :";
            // 
            // soNguoiToiDaLabel
            // 
            soNguoiToiDaLabel.AutoSize = true;
            soNguoiToiDaLabel.Location = new System.Drawing.Point(77, 283);
            soNguoiToiDaLabel.Name = "soNguoiToiDaLabel";
            soNguoiToiDaLabel.Size = new System.Drawing.Size(70, 16);
            soNguoiToiDaLabel.TabIndex = 91;
            soNguoiToiDaLabel.Text = "Trạng thái:";
            // 
            // txt_machamcong
            // 
            this.txt_machamcong.Enabled = false;
            this.txt_machamcong.Location = new System.Drawing.Point(193, 196);
            this.txt_machamcong.Name = "txt_machamcong";
            this.txt_machamcong.Size = new System.Drawing.Size(272, 22);
            this.txt_machamcong.TabIndex = 86;
            // 
            // txtTimKiemCong
            // 
            this.txtTimKiemCong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemCong.Location = new System.Drawing.Point(572, 161);
            this.txtTimKiemCong.Name = "txtTimKiemCong";
            this.txtTimKiemCong.Size = new System.Drawing.Size(675, 22);
            this.txtTimKiemCong.TabIndex = 84;
            this.txtTimKiemCong.TextChanged += new System.EventHandler(this.txtTimKiemCong_TextChanged);
            // 
            // btnClearCong
            // 
            this.btnClearCong.Location = new System.Drawing.Point(732, 633);
            this.btnClearCong.Name = "btnClearCong";
            this.btnClearCong.Size = new System.Drawing.Size(116, 49);
            this.btnClearCong.TabIndex = 83;
            this.btnClearCong.Text = "Xóa Dữ Liệu";
            this.btnClearCong.UseVisualStyleBackColor = true;
            this.btnClearCong.Click += new System.EventHandler(this.btnClearCong_Click);
            // 
            // btnXoaCong
            // 
            this.btnXoaCong.Location = new System.Drawing.Point(581, 633);
            this.btnXoaCong.Name = "btnXoaCong";
            this.btnXoaCong.Size = new System.Drawing.Size(99, 49);
            this.btnXoaCong.TabIndex = 82;
            this.btnXoaCong.Text = "Xóa";
            this.btnXoaCong.UseVisualStyleBackColor = true;
            this.btnXoaCong.Click += new System.EventHandler(this.btnXoaCong_Click);
            // 
            // btnSuaCong
            // 
            this.btnSuaCong.Location = new System.Drawing.Point(420, 633);
            this.btnSuaCong.Name = "btnSuaCong";
            this.btnSuaCong.Size = new System.Drawing.Size(99, 49);
            this.btnSuaCong.TabIndex = 81;
            this.btnSuaCong.Text = "Sửa";
            this.btnSuaCong.UseVisualStyleBackColor = true;
            this.btnSuaCong.Click += new System.EventHandler(this.btnSuaCong_Click);
            // 
            // btnThemCong
            // 
            this.btnThemCong.Location = new System.Drawing.Point(271, 633);
            this.btnThemCong.Name = "btnThemCong";
            this.btnThemCong.Size = new System.Drawing.Size(99, 49);
            this.btnThemCong.TabIndex = 80;
            this.btnThemCong.Text = "Thêm";
            this.btnThemCong.UseVisualStyleBackColor = true;
            this.btnThemCong.Click += new System.EventHandler(this.btnThemCong_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(80, 91);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 79;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // dgv_chamcong
            // 
            this.dgv_chamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chamcong.Location = new System.Drawing.Point(572, 189);
            this.dgv_chamcong.Name = "dgv_chamcong";
            this.dgv_chamcong.RowHeadersWidth = 51;
            this.dgv_chamcong.RowTemplate.Height = 24;
            this.dgv_chamcong.Size = new System.Drawing.Size(675, 393);
            this.dgv_chamcong.TabIndex = 78;
            this.dgv_chamcong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chamcong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "QUẢN LÝ CHẤM CÔNG LÀM VIỆC";
            // 
            // cb_nhanvien
            // 
            this.cb_nhanvien.FormattingEnabled = true;
            this.cb_nhanvien.Location = new System.Drawing.Point(193, 227);
            this.cb_nhanvien.Name = "cb_nhanvien";
            this.cb_nhanvien.Size = new System.Drawing.Size(272, 24);
            this.cb_nhanvien.TabIndex = 93;
            // 
            // dtngaylam
            // 
            this.dtngaylam.Location = new System.Drawing.Point(193, 258);
            this.dtngaylam.Name = "dtngaylam";
            this.dtngaylam.Size = new System.Drawing.Size(272, 22);
            this.dtngaylam.TabIndex = 94;
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Items.AddRange(new object[] {
            "Có mặt ",
            "Vắng mặt"});
            this.cb_trangthai.Location = new System.Drawing.Point(193, 286);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(272, 24);
            this.cb_trangthai.TabIndex = 95;
            // 
            // ufrm_Chamconglamviec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_trangthai);
            this.Controls.Add(this.dtngaylam);
            this.Controls.Add(this.cb_nhanvien);
            this.Controls.Add(maLoaiPhongLabel);
            this.Controls.Add(this.txt_machamcong);
            this.Controls.Add(tenLoaiPhongLabel);
            this.Controls.Add(giaLabel);
            this.Controls.Add(soNguoiToiDaLabel);
            this.Controls.Add(this.txtTimKiemCong);
            this.Controls.Add(this.btnClearCong);
            this.Controls.Add(this.btnXoaCong);
            this.Controls.Add(this.btnSuaCong);
            this.Controls.Add(this.btnThemCong);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.dgv_chamcong);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_Chamconglamviec";
            this.Size = new System.Drawing.Size(1250, 830);
            this.Load += new System.EventHandler(this.ufrm_Chamconglamviec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chamcong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_machamcong;
        private System.Windows.Forms.TextBox txtTimKiemCong;
        private System.Windows.Forms.Button btnClearCong;
        private System.Windows.Forms.Button btnXoaCong;
        private System.Windows.Forms.Button btnSuaCong;
        private System.Windows.Forms.Button btnThemCong;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.DataGridView dgv_chamcong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_nhanvien;
        private System.Windows.Forms.DateTimePicker dtngaylam;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
