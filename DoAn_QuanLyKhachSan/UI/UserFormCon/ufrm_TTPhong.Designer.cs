namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTPhong
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
            System.Windows.Forms.Label maPhongLabel;
            System.Windows.Forms.Label tenPhongLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            System.Windows.Forms.Label maLoaiPhongLabel;
            System.Windows.Forms.Label maThietBiLabel;
            this.data_TTPhong = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTPhong = new System.Windows.Forms.TextBox();
            this.tinhTrangTextBox = new System.Windows.Forms.ComboBox();
            this.cbTang = new System.Windows.Forms.ComboBox();
            this.cbMaLoaiPhong = new System.Windows.Forms.ComboBox();
            this.maPhongTextBox = new System.Windows.Forms.TextBox();
            this.tenPhongTextBox = new System.Windows.Forms.TextBox();
            maPhongLabel = new System.Windows.Forms.Label();
            tenPhongLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            maLoaiPhongLabel = new System.Windows.Forms.Label();
            maThietBiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // maPhongLabel
            // 
            maPhongLabel.AutoSize = true;
            maPhongLabel.Location = new System.Drawing.Point(21, 169);
            maPhongLabel.Name = "maPhongLabel";
            maPhongLabel.Size = new System.Drawing.Size(79, 16);
            maPhongLabel.TabIndex = 66;
            maPhongLabel.Text = "MÃ PHÒNG";
            // 
            // tenPhongLabel
            // 
            tenPhongLabel.AutoSize = true;
            tenPhongLabel.Location = new System.Drawing.Point(21, 197);
            tenPhongLabel.Name = "tenPhongLabel";
            tenPhongLabel.Size = new System.Drawing.Size(87, 16);
            tenPhongLabel.TabIndex = 68;
            tenPhongLabel.Text = "TÊN PHÒNG";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(21, 225);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(90, 16);
            tinhTrangLabel.TabIndex = 70;
            tinhTrangLabel.Text = "TINH TRANG";
            // 
            // maLoaiPhongLabel
            // 
            maLoaiPhongLabel.AutoSize = true;
            maLoaiPhongLabel.Location = new System.Drawing.Point(21, 253);
            maLoaiPhongLabel.Name = "maLoaiPhongLabel";
            maLoaiPhongLabel.Size = new System.Drawing.Size(111, 16);
            maLoaiPhongLabel.TabIndex = 71;
            maLoaiPhongLabel.Text = "MÃ LOẠI PHÒNG";
            // 
            // maThietBiLabel
            // 
            maThietBiLabel.AutoSize = true;
            maThietBiLabel.Location = new System.Drawing.Point(21, 281);
            maThietBiLabel.Name = "maThietBiLabel";
            maThietBiLabel.Size = new System.Drawing.Size(68, 16);
            maThietBiLabel.TabIndex = 72;
            maThietBiLabel.Text = "MÃ TẦNG";
            // 
            // data_TTPhong
            // 
            this.data_TTPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTPhong.Location = new System.Drawing.Point(411, 163);
            this.data_TTPhong.Name = "data_TTPhong";
            this.data_TTPhong.RowHeadersWidth = 51;
            this.data_TTPhong.RowTemplate.Height = 24;
            this.data_TTPhong.Size = new System.Drawing.Size(893, 352);
            this.data_TTPhong.TabIndex = 65;
            this.data_TTPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTPhong_CellClick);
            this.data_TTPhong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_TTPhong_CellFormatting);
            // 
            // txtTimKiemTTPhong
            // 
            this.txtTimKiemTTPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTPhong.Location = new System.Drawing.Point(411, 127);
            this.txtTimKiemTTPhong.Name = "txtTimKiemTTPhong";
            this.txtTimKiemTTPhong.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTPhong.TabIndex = 64;
            this.txtTimKiemTTPhong.TextChanged += new System.EventHandler(this.txtTimKiemTTPhong_TextChanged);
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.FormattingEnabled = true;
            this.tinhTrangTextBox.Items.AddRange(new object[] {
            "Đang sử dụng",
            "Trống"});
            this.tinhTrangTextBox.Location = new System.Drawing.Point(158, 222);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(237, 24);
            this.tinhTrangTextBox.TabIndex = 75;
            // 
            // cbTang
            // 
            this.cbTang.FormattingEnabled = true;
            this.cbTang.Location = new System.Drawing.Point(158, 280);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(237, 24);
            this.cbTang.TabIndex = 74;
            // 
            // cbMaLoaiPhong
            // 
            this.cbMaLoaiPhong.FormattingEnabled = true;
            this.cbMaLoaiPhong.Location = new System.Drawing.Point(158, 250);
            this.cbMaLoaiPhong.Name = "cbMaLoaiPhong";
            this.cbMaLoaiPhong.Size = new System.Drawing.Size(237, 24);
            this.cbMaLoaiPhong.TabIndex = 73;
            // 
            // maPhongTextBox
            // 
            this.maPhongTextBox.Enabled = false;
            this.maPhongTextBox.Location = new System.Drawing.Point(158, 163);
            this.maPhongTextBox.Name = "maPhongTextBox";
            this.maPhongTextBox.Size = new System.Drawing.Size(237, 22);
            this.maPhongTextBox.TabIndex = 67;
            // 
            // tenPhongTextBox
            // 
            this.tenPhongTextBox.Location = new System.Drawing.Point(158, 191);
            this.tenPhongTextBox.Name = "tenPhongTextBox";
            this.tenPhongTextBox.Size = new System.Drawing.Size(237, 22);
            this.tenPhongTextBox.TabIndex = 69;
            // 
            // ufrm_TTPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tinhTrangTextBox);
            this.Controls.Add(this.cbTang);
            this.Controls.Add(this.cbMaLoaiPhong);
            this.Controls.Add(maPhongLabel);
            this.Controls.Add(this.maPhongTextBox);
            this.Controls.Add(tenPhongLabel);
            this.Controls.Add(this.tenPhongTextBox);
            this.Controls.Add(tinhTrangLabel);
            this.Controls.Add(maLoaiPhongLabel);
            this.Controls.Add(maThietBiLabel);
            this.Controls.Add(this.data_TTPhong);
            this.Controls.Add(this.txtTimKiemTTPhong);
            this.Name = "ufrm_TTPhong";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTPhong;
        private System.Windows.Forms.TextBox txtTimKiemTTPhong;
        private System.Windows.Forms.ComboBox tinhTrangTextBox;
        private System.Windows.Forms.ComboBox cbTang;
        private System.Windows.Forms.ComboBox cbMaLoaiPhong;
        private System.Windows.Forms.TextBox maPhongTextBox;
        private System.Windows.Forms.TextBox tenPhongTextBox;
    }
}
