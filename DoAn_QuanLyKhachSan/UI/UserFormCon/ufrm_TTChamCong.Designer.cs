namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTChamCong
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
            this.data_TTChamCong = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTChamCong = new System.Windows.Forms.TextBox();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.dtngaylam = new System.Windows.Forms.DateTimePicker();
            this.cb_nhanvien = new System.Windows.Forms.ComboBox();
            this.txt_machamcong = new System.Windows.Forms.TextBox();
            maLoaiPhongLabel = new System.Windows.Forms.Label();
            tenLoaiPhongLabel = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            soNguoiToiDaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // maLoaiPhongLabel
            // 
            maLoaiPhongLabel.AutoSize = true;
            maLoaiPhongLabel.Location = new System.Drawing.Point(22, 209);
            maLoaiPhongLabel.Name = "maLoaiPhongLabel";
            maLoaiPhongLabel.Size = new System.Drawing.Size(111, 16);
            maLoaiPhongLabel.TabIndex = 96;
            maLoaiPhongLabel.Text = "MÃ CHẤM CÔNG";
            // 
            // tenLoaiPhongLabel
            // 
            tenLoaiPhongLabel.AutoSize = true;
            tenLoaiPhongLabel.Location = new System.Drawing.Point(22, 237);
            tenLoaiPhongLabel.Name = "tenLoaiPhongLabel";
            tenLoaiPhongLabel.Size = new System.Drawing.Size(111, 16);
            tenLoaiPhongLabel.TabIndex = 98;
            tenLoaiPhongLabel.Text = "TÊN NHÂN VIÊN";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Location = new System.Drawing.Point(22, 265);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(108, 16);
            giaLabel.TabIndex = 99;
            giaLabel.Text = "NGÀY LÀM VIỆC";
            // 
            // soNguoiToiDaLabel
            // 
            soNguoiToiDaLabel.AutoSize = true;
            soNguoiToiDaLabel.Location = new System.Drawing.Point(22, 293);
            soNguoiToiDaLabel.Name = "soNguoiToiDaLabel";
            soNguoiToiDaLabel.Size = new System.Drawing.Size(89, 16);
            soNguoiToiDaLabel.TabIndex = 100;
            soNguoiToiDaLabel.Text = "TRẠNG THÁI";
            // 
            // data_TTChamCong
            // 
            this.data_TTChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTChamCong.Location = new System.Drawing.Point(445, 206);
            this.data_TTChamCong.Name = "data_TTChamCong";
            this.data_TTChamCong.RowHeadersWidth = 51;
            this.data_TTChamCong.RowTemplate.Height = 24;
            this.data_TTChamCong.Size = new System.Drawing.Size(893, 352);
            this.data_TTChamCong.TabIndex = 65;
            this.data_TTChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTChamCong_CellClick);
            // 
            // txtTimKiemTTChamCong
            // 
            this.txtTimKiemTTChamCong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTChamCong.Location = new System.Drawing.Point(445, 170);
            this.txtTimKiemTTChamCong.Name = "txtTimKiemTTChamCong";
            this.txtTimKiemTTChamCong.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTChamCong.TabIndex = 64;
            this.txtTimKiemTTChamCong.TextChanged += new System.EventHandler(this.txtTimKiemTTChamCong_TextChanged);
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Items.AddRange(new object[] {
            "Có mặt ",
            "Vắng mặt"});
            this.cb_trangthai.Location = new System.Drawing.Point(155, 296);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(272, 24);
            this.cb_trangthai.TabIndex = 103;
            // 
            // dtngaylam
            // 
            this.dtngaylam.Location = new System.Drawing.Point(155, 268);
            this.dtngaylam.Name = "dtngaylam";
            this.dtngaylam.Size = new System.Drawing.Size(272, 22);
            this.dtngaylam.TabIndex = 102;
            // 
            // cb_nhanvien
            // 
            this.cb_nhanvien.FormattingEnabled = true;
            this.cb_nhanvien.Location = new System.Drawing.Point(155, 237);
            this.cb_nhanvien.Name = "cb_nhanvien";
            this.cb_nhanvien.Size = new System.Drawing.Size(272, 24);
            this.cb_nhanvien.TabIndex = 101;
            // 
            // txt_machamcong
            // 
            this.txt_machamcong.Enabled = false;
            this.txt_machamcong.Location = new System.Drawing.Point(155, 206);
            this.txt_machamcong.Name = "txt_machamcong";
            this.txt_machamcong.Size = new System.Drawing.Size(272, 22);
            this.txt_machamcong.TabIndex = 97;
            // 
            // ufrm_TTChamCong
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
            this.Controls.Add(this.data_TTChamCong);
            this.Controls.Add(this.txtTimKiemTTChamCong);
            this.Name = "ufrm_TTChamCong";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTChamCong;
        private System.Windows.Forms.TextBox txtTimKiemTTChamCong;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.DateTimePicker dtngaylam;
        private System.Windows.Forms.ComboBox cb_nhanvien;
        private System.Windows.Forms.TextBox txt_machamcong;
    }
}
