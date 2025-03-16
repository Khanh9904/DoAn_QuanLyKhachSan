namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTThongTinKhachHang
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
            System.Windows.Forms.Label maKhachHangLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label cCCDLabel;
            this.data_TTTTKH = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTTTKH = new System.Windows.Forms.TextBox();
            this.gioiTinhTextBox = new System.Windows.Forms.ComboBox();
            this.maKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.cCCDTextBox = new System.Windows.Forms.TextBox();
            maKhachHangLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            cCCDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTTTKH)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTTTKH
            // 
            this.data_TTTTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTTTKH.Location = new System.Drawing.Point(471, 140);
            this.data_TTTTKH.Name = "data_TTTTKH";
            this.data_TTTTKH.RowHeadersWidth = 51;
            this.data_TTTTKH.RowTemplate.Height = 24;
            this.data_TTTTKH.Size = new System.Drawing.Size(893, 352);
            this.data_TTTTKH.TabIndex = 67;
            this.data_TTTTKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTTTKH_CellClick);
            // 
            // txtTimKiemTTTTKH
            // 
            this.txtTimKiemTTTTKH.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTTTKH.Location = new System.Drawing.Point(471, 104);
            this.txtTimKiemTTTTKH.Name = "txtTimKiemTTTTKH";
            this.txtTimKiemTTTTKH.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTTTKH.TabIndex = 66;
            this.txtTimKiemTTTTKH.TextChanged += new System.EventHandler(this.txtTimKiemTTTTKH_TextChanged);
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.FormattingEnabled = true;
            this.gioiTinhTextBox.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.gioiTinhTextBox.Location = new System.Drawing.Point(213, 220);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(200, 24);
            this.gioiTinhTextBox.TabIndex = 103;
            // 
            // maKhachHangLabel
            // 
            maKhachHangLabel.AutoSize = true;
            maKhachHangLabel.Location = new System.Drawing.Point(82, 140);
            maKhachHangLabel.Name = "maKhachHangLabel";
            maKhachHangLabel.Size = new System.Drawing.Size(118, 16);
            maKhachHangLabel.TabIndex = 90;
            maKhachHangLabel.Text = "MÃ KHÁCH HÀNG";
            // 
            // maKhachHangTextBox
            // 
            this.maKhachHangTextBox.Enabled = false;
            this.maKhachHangTextBox.Location = new System.Drawing.Point(213, 137);
            this.maKhachHangTextBox.Name = "maKhachHangTextBox";
            this.maKhachHangTextBox.Size = new System.Drawing.Size(200, 22);
            this.maKhachHangTextBox.TabIndex = 91;
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(82, 168);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(58, 16);
            hoTenLabel.TabIndex = 92;
            hoTenLabel.Text = "HỌ TÊN";
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.Location = new System.Drawing.Point(213, 165);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(200, 22);
            this.hoTenTextBox.TabIndex = 93;
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(82, 197);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(80, 16);
            ngaySinhLabel.TabIndex = 94;
            ngaySinhLabel.Text = "NGÀY SINH";
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(213, 193);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngaySinhDateTimePicker.TabIndex = 95;
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(82, 229);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(68, 16);
            gioiTinhLabel.TabIndex = 96;
            gioiTinhLabel.Text = "GIỚI TÍNH";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(82, 257);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(104, 16);
            sDTLabel.TabIndex = 97;
            sDTLabel.Text = "SỐ ĐIỆN THOẠI";
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.Location = new System.Drawing.Point(213, 254);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(200, 22);
            this.sDTTextBox.TabIndex = 98;
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(82, 285);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(53, 16);
            diaChiLabel.TabIndex = 99;
            diaChiLabel.Text = "ĐỊA CHỈ";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.Location = new System.Drawing.Point(213, 282);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(200, 22);
            this.diaChiTextBox.TabIndex = 100;
            // 
            // cCCDLabel
            // 
            cCCDLabel.AutoSize = true;
            cCCDLabel.Location = new System.Drawing.Point(82, 313);
            cCCDLabel.Name = "cCCDLabel";
            cCCDLabel.Size = new System.Drawing.Size(44, 16);
            cCCDLabel.TabIndex = 101;
            cCCDLabel.Text = "CCCD";
            // 
            // cCCDTextBox
            // 
            this.cCCDTextBox.Location = new System.Drawing.Point(213, 310);
            this.cCCDTextBox.Name = "cCCDTextBox";
            this.cCCDTextBox.Size = new System.Drawing.Size(200, 22);
            this.cCCDTextBox.TabIndex = 102;
            // 
            // ufrm_TTThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gioiTinhTextBox);
            this.Controls.Add(maKhachHangLabel);
            this.Controls.Add(this.maKhachHangTextBox);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.hoTenTextBox);
            this.Controls.Add(ngaySinhLabel);
            this.Controls.Add(this.ngaySinhDateTimePicker);
            this.Controls.Add(gioiTinhLabel);
            this.Controls.Add(sDTLabel);
            this.Controls.Add(this.sDTTextBox);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(cCCDLabel);
            this.Controls.Add(this.cCCDTextBox);
            this.Controls.Add(this.data_TTTTKH);
            this.Controls.Add(this.txtTimKiemTTTTKH);
            this.Name = "ufrm_TTThongTinKhachHang";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTTTKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTTTKH;
        private System.Windows.Forms.TextBox txtTimKiemTTTTKH;
        private System.Windows.Forms.ComboBox gioiTinhTextBox;
        private System.Windows.Forms.TextBox maKhachHangTextBox;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox cCCDTextBox;
    }
}
